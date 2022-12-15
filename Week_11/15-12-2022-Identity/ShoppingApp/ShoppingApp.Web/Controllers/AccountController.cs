using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShoppingApp.Entity.Concrete.Identity;
using ShoppingApp.Web.EmailServices.Abstract;
using ShoppingApp.Web.Models.Dtos;

namespace ShoppingApp.Web.Controllers
{
    [AutoValidateAntiforgeryToken] //ilgili postların hepsine bu özelliği vermek için
    public class AccountController : Controller
    {
        //öncelikle field'larımızı tanımlıyoruz.
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IEmailSender _emailSender;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Login(string returnUrl = null)
        {
            return View(new LoginDto { ReturnUrl = returnUrl});
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(loginDto.UserName);
                if (user == null)
                {
                    ModelState.AddModelError("", "Böyle bir kullanıcı bulunamadı!"); //"" = formda hata mesajına All özelliği verdiğimiz için
                    return View(loginDto);
                }
                //bu noktada email onayı yapılıp yapılmadığını kontrol edeceğiz, eğer email onayli ise login yaptıracağız değise hatırlatacağız.
                var result = await _signInManager.PasswordSignInAsync(user, loginDto.Password, true, true); //password logindtodan geldi
                if (result.Succeeded)
                {
                    return Redirect(loginDto.ReturnUrl ?? "~/"); //RETURNURL
                }
                ModelState.AddModelError("", "Email adresi ya da parola hatalı!");
            }
            return View(loginDto);
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        // [ValidateAntiForgeryToken] //cookie sadece ait olduğu tarayıcı tarafından gönderilmesi halinde geçerli. sadece benim bilgisayarımdan gelen cookie bilgisini kabul etsin. cookie çalınmasından korunmak için ayrıca bir araç hazırlanmış.
        public async Task<IActionResult> Register(RegisterDto registerDto)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    FirstName = registerDto.FirstName,
                    LastName = registerDto.LastName,
                    UserName = registerDto.UserName,
                    Email = registerDto.Email
                };
                var result = await _userManager.CreateAsync(user, registerDto.Password); //bu komut kullanıcının girdiği şifreyi hashler ve user bilgilerini kullanarak kullanıcıyı yaratır.
                if (result.Succeeded)
                {
                    //generate token(mail onayı için)
                    var tokenCode = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var url = Url.Action("ConfirmEmail", "Account", new
                    {
                        userId = user.Id,   
                        token = tokenCode
                    });
                    Console.WriteLine(url);
                    //mailin gönderilme, onaylanma işlemleri vs.
                    await _emailSender.SendEmailAsync(user.Email, "ShoppingApp Hesap Onaylama", $"<h1>Merhaba</h1>" +
                        $"<br>" +
                        $"<p>Lütfen hesabınızı onaylamak için aşağıdaki linke tıklayınız<p>" +
                        $"<a href='https://localhost:5134{url}'></a>" );
                    ViewBag.Message = "Kayıt işleminizi tamamlamak için mailinize gönderilen onaylama linkine tıklayınız.";
                    return RedirectToAction("Login", "Account");
                }
            }
            ModelState.AddModelError("", "Bilinmeyen bir hata oluştu, lütfen tekrar deneyiniz.");
            return View(registerDto);
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if (userId ==null || token == null)
            {
                ViewBag.Message("Geçersiz token ya da user bilgisi");
                return View();
            }
            var user = await _userManager.FindByIdAsync(userId);
            if (user != null) 
            {
                var result = await _userManager.ConfirmEmailAsync(user, token);
                if (result.Succeeded)
                {
                    ViewBag.Message("Hesabınız başarıyla onaylandı");
                    return View();
                }
            }
            ViewBag.Message("Bir sorun oluştu ve hesabınız onatlanmadı, tekrar deneyiniz.");
            return View();
        }
    }
}
