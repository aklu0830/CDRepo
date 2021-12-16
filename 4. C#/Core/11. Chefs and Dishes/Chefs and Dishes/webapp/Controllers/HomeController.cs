using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            List<Chef> chefs = _context.Chefs.Include(d=>d.CreatedDishes).ToList();
            ViewBag.Chefs = chefs;
            return View();
        }

        [HttpGet("/newChef")]
        public IActionResult NewChef() {
            return View();
        }

        [HttpGet("/newDish")]
        public IActionResult NewDish() {
            ViewBag.Chefs = _context.Chefs.ToList();
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
                return View("NewChef");
            }
        }

        [HttpPost("mkNewDish")]
        public IActionResult MakeNewDish(Dish dish) {
            if (ModelState.IsValid) {
                Console.WriteLine("Chef ID " + dish.ChefId);
                _context.Dishes.Add(dish);
                _context.SaveChanges();
                return RedirectToAction("Index");
            } else {
                return View("NewDish");
            }
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
