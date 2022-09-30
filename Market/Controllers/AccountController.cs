using Market.Models;
using Market.Models.ViewModels;
using Market.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Market.Controllers
{
    public class AccountController : Controller
    {
        private MarketContext db;
        public AccountController(MarketContext context)
        {
            db = context;
        }
        [HttpGet]
        public IActionResult Login()
        {     
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await db.Users.FirstOrDefaultAsync(u => u.Email == model.Email);
                if (user != null && BCrypt.Net.BCrypt.Verify(model.Password, user.Password))
                {
                    await Authenticate(model.Email); // аутентификация
                    
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await db.Users.FirstOrDefaultAsync(u => u.Email == model.Email);
                if (user == null)
                {
                    Password p = new Password();
                    if (p.isCorrect(model.Password))
                    {
                        model.Password = BCrypt.Net.BCrypt.HashPassword(model.Password);
                        db.Users.Add(new User { Name = model.Name, City = model.City, Phone = model.Phone, Email = model.Email, Password = model.Password });
                        await db.SaveChangesAsync();
                        await Authenticate(model.Email);
                        string email = model.Email;
                        return RedirectToAction("EmailVerification", new { email });
                    }
                    else
                        ModelState.AddModelError("", "Пароль должен содержать только латинские буквы и цифры");
                }
                else
                    ModelState.AddModelError("", "Данный Email уже занят");
            }
            return View(model);
        }
        public async Task<IActionResult> EmailVerification(string email)
        {
            Random rnd = new Random();
            int code = rnd.Next(100000, 999999);
            EmailCode emailCode = new EmailCode { Email = User.Identity.Name, Code = code };
            db.EmailCodes.Add(emailCode);
            await db.SaveChangesAsync();
            EmailService emailService = new EmailService();
            await emailService.SendEmailAsync(email, "Код Подтверждения", code.ToString());
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> EmailVerification(int code)
        {
            EmailCode emailCode = await db.EmailCodes.FirstOrDefaultAsync(u => u.Email == User.Identity.Name);
            if (code == emailCode.Code)
            {
                User user = await db.Users.FirstOrDefaultAsync(u => u.Email == User.Identity.Name);
                user.IsEmailVefi = true;
                db.Users.Update(user);
                await db.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Logout");
               
            }
            
        }
        public string Code(int code)
        {
            return code.ToString();
        }
        private async Task Authenticate(string userName)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userName)
            };
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }
    }
}
