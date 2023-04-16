using CoreLayer.DTOs.Users;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MedicalAppointmentApp.Controllers
{
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;

        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(UserLoginDto userLoginDto)
        {
            if (!ModelState.IsValid)
            {
                var user = await userManager.FindByNameAsync(userLoginDto.userName);
                if (user != null)
                {
                    var result = await signInManager.CheckPasswordSignInAsync(user, userLoginDto.password, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction(""); //todo: Yol bilinmediği için adres tanımlanamadı.
                    }
                    else
                    {
                        ModelState.AddModelError("", "Kullanıcı Adı veya Şifre Hatalı ! ");
                        return View();
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Kullanıcı Adı veya Şifre Hatalı ! ");
                    return View();
                }
            }
            else
            {
                return View();
            }
        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction(""); //todo: Nereye çıkış yaptıracaksak oraya yönlendir
        }
    }
}
