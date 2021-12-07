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
            TempData["Name"] = student.Name;
            TempData["House"] = student.House;
            TempData["CurrentYear"] = student.CurrentYear;

            return Redirect("results");
        }

        [HttpGet("/results")]
        public IActionResult Results() {
            ViewBag.Name = TempData["Name"];
            ViewBag.House = TempData["House"];
            ViewBag.Year = TempData["CurrentYear"];
            return View();
        }
    }
}