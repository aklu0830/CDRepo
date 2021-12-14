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
using Microsoft.AspNetCore.Http;

namespace webappR.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;
        private Context _context;
        private bool isLoggedIn = false;
        private int? UserID = 0;
        

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

        [HttpGet("/register")]
        public IActionResult Registration() {
            return View();
        }

        [HttpGet("login")]
        public IActionResult Login() {
            return View();
        }

        [HttpPost("/processlogin")]
        public IActionResult ProcessLogin(LoginUser submission) {
            if (ModelState.IsValid) {
                var userInDB = _context.Users.FirstOrDefault(u => u.Email == submission.Email);

                if (userInDB == null) {
                    ModelState.AddModelError("Email", "Invalid Email/Password");
                    return View("Login");
                }

                var hasher = new PasswordHasher<LoginUser>();

                var result = hasher.VerifyHashedPassword(submission, userInDB.Password, submission.Password);

                if (result == 0) {
                    ModelState.AddModelError("Email", "Invalid Email/Password");
                    return View("Login");
                } else {
                    HttpContext.Session.SetInt32("UserID", userInDB.UserId);
                    UserID = HttpContext.Session.GetInt32("UserID");
                    Console.WriteLine("BL " + UserID);
                    


                    return Redirect("success");
                }
                
            }
            else {
                return View("Login");
            }
            
            
        }
        

        [HttpPost("/createusr")]
        public IActionResult Register(User user) {
            
            if (ModelState.IsValid) {
                if (_context.Users.Any(u => u.Email == user.Email)) {
                    ModelState.AddModelError("Email", "This email already exists in the database");
                    return View("Registration");
                } else {
                    PasswordHasher<User> hasher = new PasswordHasher<User>();
                    user.Password = hasher.HashPassword(user, user.Password);
                    _context.Add(user);
                    _context.SaveChanges();
                    return Redirect("/");
                }
            } else {
                return View("Registration");
            }

            return Redirect("/");
        }

        [HttpGet("/success")]
        public IActionResult Success() {
            Console.WriteLine("UserID:  "+HttpContext.Session.GetInt32("UserID"));
            if (HttpContext.Session.GetInt32("UserID") > 0) {
                ViewBag.ID = HttpContext.Session.GetInt32("UserID");
                return View();
            } else {

                return Redirect("login");
            }
            

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}