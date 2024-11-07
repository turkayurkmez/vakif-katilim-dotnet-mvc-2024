using eshop.Application;
using eshop.MVC.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace eshop.MVC.Controllers
{
    public class UsersController(IUserService userService) : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(string? gidilecekUrl)
        {
            UserLoginViewModel model = new UserLoginViewModel() { ReturnUrl = gidilecekUrl };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserLoginViewModel model, string? gidilecekUrl)
        {
            if (ModelState.IsValid)
            {
                var user = userService.ValidateUser(model.UserName, model.Password);
                if (user != null)
                {

                    var claims = new Claim[]
                    {
                        new Claim(ClaimTypes.Name,user.Name),
                        new Claim(ClaimTypes.GivenName,user.UserName),
                        new Claim(ClaimTypes.Role,user.Role),
                        new Claim("AyakNo","36")
                    };
                    ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                    await HttpContext.SignInAsync(claimsPrincipal);

                    if (!string.IsNullOrEmpty(gidilecekUrl)&& Url.IsLocalUrl(gidilecekUrl))
                    {
                        return Redirect(gidilecekUrl);
                    }
                    return Redirect("/");
                }
                ModelState.AddModelError("login", "Kullanıcı adı veya şifre yanlış!");
            }

            model.ReturnUrl = gidilecekUrl;
            return View(model);

        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }

        public IActionResult AccessDenied() => View();
    }
}
