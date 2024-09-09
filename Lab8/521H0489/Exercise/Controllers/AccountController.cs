using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Exercise.Controllers;
using Exercise.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Lab7MVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [OnlyUnauthenticated]
        public async Task<IActionResult> Login(Account account)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var hashedPassword = HashPassword(account.Password);

            var user = await _context.Accounts
                .Include(a => a.UserRoles)
                .FirstOrDefaultAsync(u => u.Email == account.Email && u.Password == hashedPassword);

            if (user != null)
            {
                await saveLogin(user);
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Invalid login credentials.");
                return View();
            }
        }

        private async Task saveLogin(Account account)
        {
            var roles = account.UserRoles.Select(ur => ur.RoleName).ToList();

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Email, account.Email),
                new Claim(ClaimTypes.Name, account.FullName),
            };

            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
        }

        public async Task<IActionResult> LogoutAsync()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index");
        }

        [OnlyUnauthenticated]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [OnlyUnauthenticated]
        public async Task<IActionResult> Register(Account account)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            account.Password = HashPassword(account.Password);

            _context.Accounts.Add(account);
            await _context.SaveChangesAsync();

            foreach (var userRole in account.UserRoles)
            {
                var role = await _context.UserRoles.FirstOrDefaultAsync(r => r.RoleName == userRole.RoleName);

                if (role != null)
                {
                    var newUserRole = new UserRole
                    {
                        UserId = account.Id,
                        RoleName = role.RoleName
                    };

                    _context.UserRoles.Add(newUserRole);
                }
            }

            await _context.SaveChangesAsync();
            await saveLogin(account);
            return RedirectToAction("Index");
        }

        public IActionResult Forbidden()
        {
            return View();
        }

        [Authorize]
        public IActionResult Profile()
        {
            return View();
        }

        private string HashPassword(string password)
        {
            var salt = new byte[16];
            var hashed = KeyDerivation.Pbkdf2(password, salt, KeyDerivationPrf.HMACSHA256, 10000, 16);
            return Convert.ToBase64String(hashed);
        }
    }
}
