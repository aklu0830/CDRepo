using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using webappR.Models;

namespace webappR.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;
        private Context _context;

        public HomeController(ILogger<HomeController> logger, Context context) {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index() {
            return View();
        }

        public IActionResult Privacy() {
            return View();
        }

        [HttpGet("/login")]
        public IActionResult Login() {
            return View();
        }

        [HttpPost("/register")]
        public IActionResult Register(User user) {
            
            if (ModelState.IsValid) {
                if (_context.Users.Any(u => u.Email == user.Email)) {
                    ModelState.AddModelError("Email", "This email already exists in the database");
                    return View("login");
                } else {
                    PasswordHasher<User> hasher = new PasswordHasher<User>();
                    user.Password = hasher.HashPassword(user, user.Password);
                    _context.Add(user);
                    _context.SaveChanges();
                    return Redirect("/");
                }
            } else {
                return View("login");
            }

            return Redirect("/");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}