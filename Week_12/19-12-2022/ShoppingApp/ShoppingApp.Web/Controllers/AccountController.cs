using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShoppingApp.Core;
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

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
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
                var user = await _userManager.FindByEmailAsync(loginDto.Email);
                if (user == null)
                {
                    ModelState.AddModelError("", "Böyle bir kullanıcı bulunamadı!"); //"" = formda hata mesajına All özelliği verdiğimiz için
                    return View(loginDto);
                }
                //bu noktada email onayı yapılıp yapılmadığını kontrol edeceğiz, eğer email onayli ise login yaptıracağız değise hatırlatacağız.
                if (!await _userManager.IsEmailConfirmedAsync(user))
                {
                    TempData["Message"] = Jobs.CreateMessage("Bilgi", "Hesabınız onaylanmamış, lütfen mailinize gelen onay linkine tıklayarak hesanınız onaylayınız.", "warning");
                    return View(loginDto);

                    //ÖDEV: Eğer hesap onaylı değilse burada kullanıcıya "onaynlinki gönder" şeklinde bir buton görünsün ve bu butona basıldığında tekrar onay linki gönderilsin. login view'ine koşula bağlı bir buton koy. butona tıklayınca form açılsın onaylama linkini göndermek istediğiniz maili yazınız şeklinde....bir tane url  oluşturup. _emailsender.SenEmailAsync kullanacağız. 
                }
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
                    await _emailSender.SendEmailAsync(user.Email, "ShoppingApp Hesap Onaylama", $"<h1>Merhaba</h1<br><p>Lütfen hesabınızı onaylamak için aşağıdaki linke tıklayınız<p><a href='http://localhost:5134{url}'>Onay Linki</a>" );
                    //ViewBag.Message = "Kayıt işleminizi tamamlamak için mailinize gönderilen onaylama linkine tıklayınız.";
                    TempData["Message"] = Jobs.CreateMessage("Bilgi", "Lütfen mail hesabınızı kontrol edin. Gelen linki tıklayarak hesabınızı onaylayın.", "warning");
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
                TempData["Message"] = Jobs.CreateMessage("Hata", "Geçersiz Token ya da User bilgisi", "danger"); ;
                return View();
            }
            var user = await _userManager.FindByIdAsync(userId);
            if (user != null) 
            {
                //veritabanında ilgili satırı 0'dan 1'e döndüren şey bu ConfirmEmailAsync'tir.
                var result = await _userManager.ConfirmEmailAsync(user, token); 
                if (result.Succeeded)
                {
                    TempData["Message"] = Jobs.CreateMessage("Başarılı", "Hesabınız başarıyla onaylandı, giriş yapabilirsiniz.", "success");
                    return RedirectToAction("Login", "Account");

                }

            }
            TempData["Message"] = Jobs.CreateMessage("Hata", "Bir sorun oluştu ve hesabınız onaylanmadı. Lütfen Admin ile iletişime geçiniz.", "danger"); ;

            return View();
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string email)
        {
            if (String.IsNullOrEmpty(email)) //isnullorempty = null veya ""
            {
                TempData["Message"] = Jobs.CreateMessage("Hata", "Lütfen mail adresinizi eksiksiz bir şekilde giriniz", "danger");
                return View();
            }
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null) 
            {
                TempData["Message"] = Jobs.CreateMessage("Hata", "Böyle kayıtlı bir mail adresi bulunamadı. Lütfen kontrol ederek tekrar deneyiniz.", "danger");
                return View();
            }
            var tokenCode = await _userManager.GeneratePasswordResetTokenAsync(user); //tokencode'u oluşturuyoruz.
            var url = Url.Action("ResetPassword", "Account", new
            {
                userId = user.Id,
                token = tokenCode
            });
            await _emailSender.SendEmailAsync(
                email,
                "ShoppingApp Şifre Sıfırlama Linki",
                $"Lütfen parolanızı yenilemek için <a href='http://localhost:5134{url}'>Tıklayınız</a>"
                );
            TempData["Message"] = Jobs.CreateMessage("Bilgi", "Şifre sıfırlama linkiniz, mail adresinize gönderilmiştir. Lütfen mail adresinizi kontrol ediniz.", "info");
            return RedirectToAction("Login", "Account");
        }
        public IActionResult ResetPassword(string userId, string token)
        {
            if (userId == null || token == null)
            {
                TempData["Message"] = Jobs.CreateMessage("Hata", "Bir sorun oluştu, lütfen daha sonra tekrar deneyiniz.", "danger");
                return RedirectToAction("Index", "Home");
            }
            var resetPasswordDto = new ResetPasswordDto
            {
                Token = token
            };
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordDto resetPasswordDto)
        {
            if(!ModelState.IsValid)
            {
                return View(resetPasswordDto);
            }
            var user = await _userManager.FindByEmailAsync(resetPasswordDto.Email);
            if (user == null)
            {
                TempData["Message"] = Jobs.CreateMessage("Hata", "Böyle bir kullanıcı bulunamadı", "danger");
                return View(resetPasswordDto);
            }
            var result = await _userManager.ResetPasswordAsync(user, resetPasswordDto.Token, resetPasswordDto.Password); //şifreyi değiştiririm ama bana şu 3 bilgi vermen lazım diyor.
            if (result.Succeeded)
            {
                TempData["Message"] = Jobs.CreateMessage("Başarılı", "Başarılı bir şekilde değiştirilmiştir. Giriş yapmayı deneyiniz.", "success");
                return RedirectToAction("Login", "Account");
            }
            TempData["Message"] = Jobs.CreateMessage("Hata", "Bir hata oluştu, admin ile iletişime geçiniz.", "danger");
            return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> Manage(string id)
        {
            var name = id;
            if (String.IsNullOrEmpty(name))
            {
                return NotFound();
            }
            var user = await _userManager.FindByNameAsync(name);
            if (user==null)
            {
                return NotFound();
            }
            List<SelectListItem> genderList = new List<SelectListItem>();
            genderList.Add(new SelectListItem
            {
                Text = "Kadın",
                Value = "Kadın",
                Selected = user.Gender == "Kadın" ? true : false
            });
            genderList.Add(new SelectListItem
            {
                Text = "Erkek",
                Value = "Erkek",
                Selected = user.Gender == "Erkek" ? true : false
            });
            UserManageDto userManageDto = new UserManageDto
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Gender = user.Gender,
                DateOfBirth = user.DateOfBirth,
                UserName = user.UserName,
                Email = user.Email,
                GenderSelectList = genderList
            };
            return View(userManageDto);
        }
        [HttpPost]
        public async Task<IActionResult> Manage(UserManageDto userManageDto)
        {
            if (userManageDto == null) { return NotFound(); }
            var user = await _userManager.FindByIdAsync(userManageDto.Id);
            if (user == null) { return NotFound(); }

            user.FirstName = userManageDto.FirstName;
            user.LastName = userManageDto.LastName;
            user.UserName = userManageDto.UserName;
            user.Gender = userManageDto.Gender;
            user.Email = userManageDto.Email;
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                TempData["Message"] = Jobs.CreateMessage("Başarılı!", "Profiliniz başarıyla kaydedilmiştir.", "success");

            }

            List<SelectListItem> genderList = new List<SelectListItem>();
            genderList.Add(new SelectListItem
            {
                Text = "Kadın",
                Value = "Kadın",
                Selected = user.Gender == "Kadın" ? true : false
            });
            genderList.Add(new SelectListItem
            {
                Text = "Erkek",
                Value = "Erkek",
                Selected = user.Gender == "Erkek" ? true : false
            });
            userManageDto.GenderSelectList = genderList;
            return View(userManageDto);
            //ÖDEV: Eğer kullanıcı adı değiştirilmişse sağ üst köşedeki username bölümünün güncellenmesini JavaScript kodları yazarak sağlayınız.
            //Veya "Benim aklmıma başka çözüm geldi" diyen varsa, kabülümüzdür :)
        }
    }
}
