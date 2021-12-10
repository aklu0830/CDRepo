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

        [HttpGet]
        [Route("/edit/{id}")]
        public IActionResult EditDish(int id) {
            List<Dishes> dish = _context.Dishes.Where(dish => dish.DishId == id).ToList();
            if (dish.Count < 1) {
                return Redirect("/");
            } else {
                ViewBag.Dish = dish;
                return View();
            }
            
        }

        [HttpGet]
        [Route("update/{id}")]
        public IActionResult UpdateDish(int id, string Chef,
            string Name, int Calories,
            int Tastiness,
            string Description) {
            Console.WriteLine("Name is: "+Name);
            Dishes dish = _context.Dishes.FirstOrDefault(dish => dish.DishId == id);
            
            
            
            dish.Name = Name;
            dish.Calories = Calories;
            dish.Tastiness = Tastiness;
            dish.Description = Description;
            dish.Chef = Chef;
            dish.UpdatedAt = DateTime.Now;

            _context.SaveChanges();
            
            return Redirect($"/view/{id}");
        }

        [HttpGet]
        [Route("/delete/{id}")]
        public IActionResult DeleteDish(int id) {

            Dishes dish = _context.Dishes.SingleOrDefault(dish => dish.DishId == id);

            _context.Dishes.Remove(dish);

            _context.SaveChanges();
            
            
            return Redirect("/");
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