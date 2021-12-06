using System;
using Microsoft.AspNetCore.Mvc;

namespace webapp.Controllers {
    public class FormController : Controller {
        
        [HttpGet("")]
        public IActionResult Form() {
            return View();
        }

        [HttpPost]
        [Route("process")]
        public IActionResult Process(string Name, string Location, string Language, string Comments) {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Location: " + Location);
            Console.WriteLine("Language: " + Language);
            Console.WriteLine("Comments: " + Comments);
            TempData["Name"] = Name;
            TempData["Location"] = Location;
            TempData["Language"] = Language;
            TempData["Comments"] = Comments;
            
            return Redirect("/results");
        }

        [HttpGet]
        [Route("results")]
        public IActionResult Results() {
            ViewBag.Name = TempData["Name"];
            ViewBag.Location = TempData["Location"];
            ViewBag.Language = TempData["Language"];
            ViewBag.Comments = TempData["Comments"];

            return View();
        }
    }
}