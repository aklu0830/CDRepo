using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DbConnection;
using Microsoft.AspNetCore.Routing;
using webapp.Models;
using System.Linq;

namespace webapp.Controllers {
    public class UsersController : Controller {
        [HttpGet]
        [Route("/us")]
        public IActionResult Index() {
            List<Dictionary<string, object >> AUsers = DbConnector.Query("SELECT * FROM USERS");
            var SortedShit = AUsers.OrderByDescending(p => p["FirstName"]);
            
            foreach (var x in SortedShit) {
                Console.WriteLine(x["FirstName"]);
                
            }


            ViewBag.Users = SortedShit;
            return View();
        }

        [HttpGet]
        [Route("/usr/{id}")]
        public IActionResult UsrInfo(int id) {
            List<Dictionary<string, object >> OneUSR = DbConnector.Query($"SELECT * FROM USERS WHERE id = {id}");

            ViewBag.User = OneUSR;
            return View();
        }

        [HttpGet]
        [Route("/crup")]
        public IActionResult CreateUsrPage() {
            return View();
        }

        [HttpPost]
        [Route("/create")]
        public IActionResult CreateUSR(User user) {
            string query = $"insert into users(FirstName, LastName) values ('{user.FirstName}', '{user.LastName}')";
            DbConnector.Execute(query);
            return Redirect("/us");
        }
    }
}