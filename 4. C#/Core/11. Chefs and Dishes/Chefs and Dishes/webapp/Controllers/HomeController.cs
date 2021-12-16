using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using webapp.Models;

namespace webapp.Controllers
{
    public class HomeController : Controller
    {
        

        private Context _context;


        public HomeController(Context context) {
            _context = context;
        }


        public IActionResult Index() {
            return View();
        }

        [HttpGet("/newChef")]
        public IActionResult NewShef() {
            return View();
        }

        [HttpPost("mkNewChef")]
        public IActionResult MakeNewChef(Chef chef) {

            if (ModelState.IsValid) {
                Console.WriteLine("DATEOFBIRTH" + chef.Dob);
                _context.Chefs.Add(chef);
                _context.SaveChanges();
                return RedirectToAction("Index");
            } else {
                return View("NewShef");
            }
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
