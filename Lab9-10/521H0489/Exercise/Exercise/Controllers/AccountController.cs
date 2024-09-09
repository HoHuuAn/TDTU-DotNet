using Exercise.DTO;
using Exercise.Models;
using Exercise.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Exercise.Controllers
{
    [ApiController]
    [Route("/api/account")]
    public class AccountController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("login")]
        public IActionResult Login(AccountDto account)
        {
            var user = _context.Accounts.FirstOrDefault(u => u.Email == account.Email);

            if (user != null && BCrypt.Net.BCrypt.Verify(account.Password, user.Password))
            {
                var roles = user.Roles;
                var token = TokenService.GenerateToken(user.Email, 120, roles);
                return Ok(new
                {
                    Token = token,
                    Data = user
                });
            }
            else
            {
                return Unauthorized(new
                {
                    Message = "Invalid email or password",
                });
            }
        }

        [HttpPost("register")]
        public IActionResult Register(Account account)
        {
            var existingUser = _context.Accounts.FirstOrDefault(u => u.Email == account.Email);

            if (existingUser != null)
            {
                return Conflict(new
                {
                    Message = "Email already exists",
                });
            }
            account.Password = BCrypt.Net.BCrypt.HashPassword(account.Password);

            _context.Accounts.Add(account);
            _context.SaveChanges();

            return CreatedAtAction(nameof(Login), new { email = account.Email }, account);
        }
    }
}
