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

builder.Services.AddDbContext<IdentityContext>(options=>options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection"))); //buraya g�venlik gere�i connection stringi direkt yaz�lmaz.

builder.Services.AddDbContext<ShopAppContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection"))); //connection string burda yarat�ld�, shopappcontext'te constructor olarak kullan�ld�.

builder.Services.AddIdentity<User, /*IdentityRole*/ Role>()
    .AddEntityFrameworkStores<IdentityContext>() //bunu kullanarak efcore ile ba�lant�s�n� sa�layacak
    //cookie bazl�, token bazl� identification.... cookie bazl�: taray�c� i�erisinde saklanan ge�ici bilgiler, sayfalar aras�nda gezerken login misin de�il misin kontrol eder...token bazl�: uzun string ile kontrol eder.... biz cookie bazl� kullanaca��z....jwt=javascript token'lar�
    .AddDefaultTokenProviders();
//mail do�rulama token'� kullanaca��z.

builder.Services.Configure<IdentityOptions>(options =>
{
    #region PasswordSettings
    options.Password.RequireDigit = true; //�ifre i�inde mutlaka rakam bulunsun demi� olduk
    options.Password.RequireLowercase = true; //�ifre i�inde k���k harf olsun
    options.Password.RequireUppercase = true;
    options.Password.RequiredLength = 6; //�ifre en az 6 karakter olsun.
    options.Password.RequireNonAlphanumeric= true; //�ifre i�inde alfan�merik katakterler (nokta, virg�l, slash, y�ld�z, parantez, at gibi) bulunmas� zorunlu olsun

    #endregion
    #region LoginSettings
    options.Lockout.MaxFailedAccessAttempts = 5; //ba�ar�s�z eri�im denemesi sonucu k�s�t verir...en fazla 5 deneme...
    options.Lockout.DefaultLockoutTimeSpan= TimeSpan.FromMinutes(5);

    #endregion
    #region UserSettings
    options.User.RequireUniqueEmail = true; //benzersiz email adresi ile kay�t olunabilir.

    #endregion
    #region SignInSettings
    options.SignIn.RequireConfirmedEmail = false; //true ise email onay� aktiftir.
    options.SignIn.RequireConfirmedPhoneNumber= false; //true ise telefon numaras� onay� aktiftir. (sms onay)
    #endregion
});

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/account/login"; //e�er a��labilmesi i�in login olman�n zorunlu oldu�u bir istekte bulunulursa, kullan�c�n�n  y�nlendirilece�i sayfa buras� olacak. (account controller�ndaki login action metodu)
    options.LogoutPath = "/account/logout"; //kullan�c� ��k�� yapt���nda y�nlendirilecek sayfa
    options.AccessDeniedPath = "/account/accessdenied"; //yetkisiz giri� s�ras�nda y�nlendirilecek sayfa
    options.SlidingExpiration = true; //varsay�lan cookie ya�am s�resinin(20dk) ya da ayarlanan ya�am s�resinin her yeni istek s�ras�nda s�f�rlanarak yeniden ba�lamas�n� sa�lar. e-okul sisteminde bu false'dur (sert bir g�venlik �nlemi)
    options.ExpireTimeSpan = TimeSpan.FromDays(10); //ya�am s�resini ayarlar.
    options.Cookie = new CookieBuilder
    {
        HttpOnly = true, //ftp, smtp gibi protokoller ile ula��lmas�n� engeller.
        Name = ".ShoppingApp.Security.Cookie", //bu isimde bir cookie yarat�r
        SameSite = SameSiteMode.Strict //benzer siteden gelecek isteklerin kar��lanmas�, kapat�lmas�. kopya site sald�r�lar�ndan koruyacak.
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
//id buradaki bir de�i�ken ismidir category ve product id de�il....

app.Run();
