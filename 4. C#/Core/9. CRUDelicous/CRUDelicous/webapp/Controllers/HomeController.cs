using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using webapp.Models;

namespace webapp.Controllers {
    public class HomeController : Controller {
        private Context _context;

        public HomeController(Context context) {
            _context = context;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index() {
            List<Dishes> AllDishes = _context.Dishes.OrderByDescending(d=>d.CreatedAt).ToList();
            ViewBag.Dishes = AllDishes;
            return View();
        }

        [HttpGet]
        [Route("/view/{id}")]
        public IActionResult ViewDish(int id) {
            List<Dishes> Dish = _context.Dishes.Where(dish => dish.DishId == id).ToList();
            if (Dish.Count < 1) {
                return Redirect("/");
            } else {
                ViewBag.Dish = Dish;
                return View(); 
            }
                
        }

        [HttpGet]
        [Route("/create")]
        public IActionResult CreateDish() {

            
            
            return View();
        }

        [HttpPost]
        [Route("/makedish")]
        public IActionResult CreateDishPost(Dishes dish) {

            _context.Dishes.Add(dish);
            _context.SaveChanges();
            
            return Redirect("/");
        }
    }
}