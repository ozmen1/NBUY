using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShoppingApp.Core;
using ShoppingApp.Entity.Concrete.Identity;
using ShoppingApp.Web.Areas.Admin.Models.Dtos;
using ShoppingApp.Web.EmailServices.Abstract;
using ShoppingApp.Web.Models.Dtos;

namespace ShoppingApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class UserController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;

        public UserController(UserManager<User> userManager, RoleManager<Role> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            //bütün userları çekeceğiz userdto barındıran bir liste yaratacağız
            List<UserDto> users = _userManager.Users.Select(u => new UserDto
            {
                Id = u.Id,
                FirstName = u.FirstName,
                LastName = u.LastName,
                UserName = u.UserName,
                Email = u.Email,
                EmailConfirmed = u.EmailConfirmed
            }).ToList();
            ViewBag.SelectedMenu = "User";
            ViewBag.Title = "Kullanıcılar";
            return View(users);
        }
        //kendi denemem
        //public IActionResult Create()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public async Task<IActionResult> Create(UserDto userDto)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var user = new User
        //        {
        //            FirstName = userDto.FirstName,
        //            LastName = userDto.LastName,
        //            UserName = userDto.UserName,
        //            Email = userDto.Email,
        //            EmailConfirmed = userDto.EmailConfirmed
        //        };
        //        var result = await _userManager.CreateAsync(user, "Qwe123.");

        //        if (result.Succeeded)
        //        {
        //            return RedirectToAction("Index", "User");
        //        }
        //    }
        //    ModelState.AddModelError("", "Bilinmeyen bir hata oluştu, lütfen tekrar deneyiniz.");
        //    return View(userDto);
        //}
        //kendi denemem
        public IActionResult Create()
        {
            UserAddDto userAddDto = new UserAddDto
            {
                Roles = _roleManager.Roles.Select(r => new RoleDto
                {
                    Id = r.Id,
                    Name = r.Name,
                    Description = r.Description
                }).ToList(),
                SelectedRoles = new List<string>()
                //Aslında buraya selectedRoles de konulabilir, hatta konulursa işimizi çok rahatlatacak. Daha sonra buraya döneceğiz.
            };
            ViewBag.Title = "Kullanıcı Oluştur";
            return View(userAddDto);
        }

        [HttpPost]
        public async Task<IActionResult> Create(UserAddDto userAddDto)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    FirstName = userAddDto.UserDto.FirstName,
                    LastName = userAddDto.UserDto.LastName,
                    UserName = userAddDto.UserDto.UserName,
                    Email = userAddDto.UserDto.Email,
                    EmailConfirmed = userAddDto.UserDto.EmailConfirmed
                };
                var result = await _userManager.CreateAsync(user, "Qwe123.");
                if (result.Succeeded) 
                {
                    var result2 = await _userManager.AddToRolesAsync(user, userAddDto.SelectedRoles);
                    if (result2.Succeeded)
                    {
                        TempData["Message"] = Jobs.CreateMessage("Başarılı", $"{user.UserName} kullanıcısı başarıyla oluşturuldu.", "success");
                        return RedirectToAction("Index", "User");
                    }

                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            userAddDto.Roles = _roleManager.Roles.Select(r => new RoleDto
            {
                Id = r.Id,
                Name = r.Name,
                Description = r.Description
            }).ToList();
            userAddDto.SelectedRoles = userAddDto.SelectedRoles ?? new List<string>();
            return View(userAddDto);
        }
        public async Task<IActionResult> Edit(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            UserAddDto userUpdateDto = new UserAddDto
            {
                UserDto = new UserDto
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    EmailConfirmed = user.EmailConfirmed,
                    UserName = user.UserName
                },
                SelectedRoles = await _userManager.GetRolesAsync(user),
                Roles = _roleManager.Roles.Select(r => new RoleDto
                {
                    Id = r.Id,
                    Name = r.Name,
                    Description = r.Description
                }).ToList()
        };
            return View(userUpdateDto);
        }
    }
}
