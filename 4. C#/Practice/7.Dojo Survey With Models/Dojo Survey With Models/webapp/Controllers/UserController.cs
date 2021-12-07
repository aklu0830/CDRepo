using System;
using Microsoft.AspNetCore.Mvc;
using webapp.Models;

namespace webapp.Controllers {
    public class UserController : Controller {
        [HttpGet]
        [Route("")]
        public IActionResult Index() {
            return View();
        }


        [HttpPost("register")]
        public IActionResult RegisterWizard(HogwartsStudent student) {
            if (ModelState.IsValid) {
                TempData["Name"] = student.Name;
                TempData["Location"] = student.Location;
                TempData["Language"] = student.Language;
                TempData["Comments"] = student.Comments;

                return Redirect("results");
            } else {
               return View("Index");
            }
        }


        [HttpGet("/results")]
        public IActionResult Results() {
            ViewBag.Name = TempData["Name"];
            ViewBag.House = TempData["Location"];
            ViewBag.Year = TempData["Language"];
            ViewBag.Comments = TempData["Comments"];
            return View();
        }
    }
}