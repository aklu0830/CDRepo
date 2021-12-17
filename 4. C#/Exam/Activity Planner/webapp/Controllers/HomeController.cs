using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using webapp.Models;
using Activity = webapp.Models.Activity;

namespace webapp.Controllers {
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

        [HttpGet("/register")]
        public IActionResult Registration() {
            return View();
        }

        [HttpGet("login")]
        public IActionResult Login() {
            if (HttpContext.Session.GetInt32("UserID").HasValue) {
                return RedirectToAction("Dashboard");
            }
            else {
                return View();
            }
        }

        [HttpGet("/dashboard")]
        public IActionResult Dashboard() {
            if (HttpContext.Session.GetInt32("UserID") == null) {
                return RedirectToAction("Login");
            }

            ViewBag.LoggedInUser =
                _context.Users.FirstOrDefault(d => d.UserId == HttpContext.Session.GetInt32("UserID"));
            ViewBag.Activities =
                _context.Activities.Include(g => g.Guests).Include(f => f.Poster).ToList();

            return View();
        }

        [HttpGet("/newActivity")]
        public IActionResult newActivity() {
            if (HttpContext.Session.GetInt32("UserID") == null) {
                return RedirectToAction("Login");
            }

            return View();
        }

        [HttpPost("/mkActivity")]
        public IActionResult makeActivity(Activity activity) {
            
            if (HttpContext.Session.GetInt32("UserID") == null) {
                return RedirectToAction("Login");
            }
            
            if (ModelState.IsValid) {
                activity.UserId = (int) HttpContext.Session.GetInt32("UserID");
                _context.Add(activity);
                _context.SaveChanges();
                return RedirectToAction("Dashboard");
            }
            else {
                return View("newActivity");
            }
            
            
        }

        [HttpPost("/processlogin")]
        public IActionResult ProcessLogin(LogUser submission) {
            if (ModelState.IsValid) {
                var userInDB = _context.Users.FirstOrDefault(u => u.Email == submission.Email);

                if (userInDB == null) {
                    ModelState.AddModelError("Email", "Invalid Email/Password");
                    return View("Login");
                }

                var hasher = new PasswordHasher<LogUser>();

                var result = hasher.VerifyHashedPassword(submission, userInDB.Password, submission.Password);

                if (result == 0) {
                    ModelState.AddModelError("Email", "Invalid Email/Password");
                    return View("Login");
                }
                else {
                    HttpContext.Session.SetInt32("UserID", userInDB.UserId);
                    Console.WriteLine("Logged In UserID: " + HttpContext.Session.GetInt32("UserID"));


                    return Redirect("/dashboard");
                }
            }
            else {
                return View("Login");
            }
        }

        [HttpGet("/delete/{aid}")]
        public IActionResult Delete(int aid) {
            Activity toDelete = _context.Activities.SingleOrDefault(f => f.ActivityId == aid);

            _context.Activities.Remove(toDelete);
            _context.SaveChanges();

            return RedirectToAction("Dashboard");
        }

        [HttpGet("/rsvp/{wid}/{uid}")]
        public IActionResult RSVP(int wid, int uid) {
            RSVP rsvp = new RSVP();
            rsvp.ActivityId = wid;
            rsvp.UserId = uid;
            _context.Add(rsvp);
            _context.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpGet("/unrsvp/{wid}/{uid}")]
        public IActionResult unRSVP(int wid, int uid) {
            RSVP rsvp = _context.RSVPs.FirstOrDefault(d => d.ActivityId == wid && d.UserId == uid);

            _context.RSVPs.Remove(rsvp);
            _context.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpGet("/activity/{aid}")]
        public IActionResult ViewActivity(int aid) {
            ViewBag.LoggedInUser =
                _context.Users.FirstOrDefault(d => d.UserId == HttpContext.Session.GetInt32("UserID"));
            ViewBag.Activity = _context.Activities.FirstOrDefault(a => a.ActivityId == aid);

            return View();
        }


        [HttpPost("/createusr")]
        public IActionResult Register(User user) {
            if (ModelState.IsValid) {
                if (_context.Users.Any(u => u.Email == user.Email)) {
                    ModelState.AddModelError("Email", "This email already exists in the database");
                    return View("Registration");
                }
                else {
                    PasswordHasher<User> hasher = new PasswordHasher<User>();
                    user.Password = hasher.HashPassword(user, user.Password);
                    _context.Add(user);
                    _context.SaveChanges();
                    return Redirect("/");
                }
            }
            else {
                return View("Registration");
            }

            return Redirect("/");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel
                {RequestId = System.Diagnostics.Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}