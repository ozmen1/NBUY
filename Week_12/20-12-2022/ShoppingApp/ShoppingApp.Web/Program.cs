using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShoppingApp.Business.Abstract;
using ShoppingApp.Business.Concrete;
using ShoppingApp.Data.Abstract;
using ShoppingApp.Data.Concrete;
using ShoppingApp.Data.Concrete.EfCore.Contexts;
using ShoppingApp.Entity.Concrete.Identity;
using ShoppingApp.Web.EmailServices.Abstract;
using ShoppingApp.Web.EmailServices.Concrete;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<IdentityContext>(options=>options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection"))); //buraya güvenlik gereði connection stringi direkt yazýlmaz.

builder.Services.AddDbContext<ShopAppContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection"))); //connection string burda yaratýldý, shopappcontext'te constructor olarak kullanýldý.

builder.Services.AddIdentity<User, /*IdentityRole*/ Role>()
    .AddEntityFrameworkStores<IdentityContext>() //bunu kullanarak efcore ile baðlantýsýný saðlayacak
    //cookie bazlý, token bazlý identification.... cookie bazlý: tarayýcý içerisinde saklanan geçici bilgiler, sayfalar arasýnda gezerken login misin deðil misin kontrol eder...token bazlý: uzun string ile kontrol eder.... biz cookie bazlý kullanacaðýz....jwt=javascript token'larý
    .AddDefaultTokenProviders();
//mail doðrulama token'ý kullanacaðýz.

builder.Services.Configure<IdentityOptions>(options =>
{
    #region PasswordSettings
    options.Password.RequireDigit = true; //þifre içinde mutlaka rakam bulunsun demiþ olduk
    options.Password.RequireLowercase = true; //þifre içinde küçük harf olsun
    options.Password.RequireUppercase = true;
    options.Password.RequiredLength = 6; //þifre en az 6 karakter olsun.
    options.Password.RequireNonAlphanumeric= true; //þifre içinde alfanümerik katakterler (nokta, virgül, slash, yýldýz, parantez, at gibi) bulunmasý zorunlu olsun

    #endregion
    #region LoginSettings
    options.Lockout.MaxFailedAccessAttempts = 5; //baþarýsýz eriþim denemesi sonucu kýsýt verir...en fazla 5 deneme...
    options.Lockout.DefaultLockoutTimeSpan= TimeSpan.FromMinutes(5);

    #endregion
    #region UserSettings
    options.User.RequireUniqueEmail = true; //benzersiz email adresi ile kayýt olunabilir.

    #endregion
    #region SignInSettings
    options.SignIn.RequireConfirmedEmail = false; //true ise email onayý aktiftir.
    options.SignIn.RequireConfirmedPhoneNumber= false; //true ise telefon numarasý onayý aktiftir. (sms onay)
    #endregion
});

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/account/login"; //eðer açýlabilmesi için login olmanýn zorunlu olduðu bir istekte bulunulursa, kullanýcýnýn  yönlendirileceði sayfa burasý olacak. (account controllerýndaki login action metodu)
    options.LogoutPath = "/account/logout"; //kullanýcý çýkýþ yaptýðýnda yönlendirilecek sayfa
    options.AccessDeniedPath = "/account/accessdenied"; //yetkisiz giriþ sýrasýnda yönlendirilecek sayfa
    options.SlidingExpiration = true; //varsayýlan cookie yaþam süresinin(20dk) ya da ayarlanan yaþam süresinin her yeni istek sýrasýnda sýfýrlanarak yeniden baþlamasýný saðlar. e-okul sisteminde bu false'dur (sert bir güvenlik önlemi)
    options.ExpireTimeSpan = TimeSpan.FromDays(10); //yaþam süresini ayarlar.
    options.Cookie = new CookieBuilder
    {
        HttpOnly = true, //ftp, smtp gibi protokoller ile ulaþýlmasýný engeller.
        Name = ".ShoppingApp.Security.Cookie", //bu isimde bir cookie yaratýr
        SameSite = SameSiteMode.Strict //benzer siteden gelecek isteklerin karþýlanmasý, kapatýlmasý. kopya site saldýrýlarýndan koruyacak.
    };

});

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<IProductService, ProductManager>();

builder.Services.AddScoped<IEmailSender, SmtpEmailSender>(x => new SmtpEmailSender(
    builder.Configuration["EmailSender:Host"],
    builder.Configuration.GetValue<int>("EmailSender:Port"),
    builder.Configuration.GetValue<bool>("EmailSender:EnableSSL"),
    builder.Configuration["EmailSender:UserName"],
    builder.Configuration["EmailSender:Password"]
    ));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseAuthentication();

app.UseRouting();

app.UseAuthorization();

//app.MapControllerRoute(
//    name: "productsdetails",
//    pattern: "{url?}",
//    defaults: new { controller = "Shop", action = "ProductDetails" }
//    );

//app.MapControllerRoute(
//    name: "products",
//    pattern: "{category?}",
//    defaults: new {controller="Shop", action="ProductList"}
//    );

app.MapControllerRoute(
    name: "products",
    pattern: "kategori/{categoryurl}",
    defaults: new { controller = "Shop", action = "ProductList" }
    );

app.MapControllerRoute(
    name:"productdetails",
    pattern:"urunler/{producturl}",
    defaults:new {controller="Shop", action="ProductDetails"}
    );

app.MapAreaControllerRoute(
    name: "admin",
    areaName: "Admin",
    pattern: "Admin/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"); //home controller'a gidiyor, index view'a gidiyor.
//id buradaki bir deðiþken ismidir category ve product id deðil....

app.Run();
