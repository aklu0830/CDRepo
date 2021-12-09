using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsORM.Models;


namespace SportsORM.Controllers
{
    public class HomeController : Controller
    {

        private static Context _context;

        public HomeController(Context DBContext)
        {
            _context = DBContext;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.BaseballLeagues = _context.Leagues
                .Where(l => l.Sport.Contains("Baseball"))
                .ToList();
            
            return View();
        }

        [HttpGet("level_1")]
        public IActionResult Level1() {
            ViewBag.Women = _context.Leagues
                .Where(l => l.Name.Contains("Women"))
                .ToList();
            ViewBag.Hockey = _context.Leagues.Where(l => l.Sport.Contains("Hockey"));
            ViewBag.NoFootball = _context.Leagues.Where(l => !l.Sport.Contains("Football"));
            ViewBag.Conferences = _context.Leagues.Where(l => l.Name.Contains("Conference"));
            ViewBag.Atlantic = _context.Leagues.Where(l => l.Name.Contains("Atlantic"));
            ViewBag.Dallas = _context.Teams.Where(t => t.Location.Contains("Dallas"));
            ViewBag.Raptors = _context.Teams.Where(t => t.TeamName.Contains("Raptors"));
            ViewBag.LocationCity = _context.Teams.Where(t => t.Location.Contains("City"));
            ViewBag.BeginsWithT = _context.Teams.Where(t => t.TeamName.StartsWith("t"));
            ViewBag.OrderedByLocation = _context.Teams.OrderBy(t => t.Location);
            ViewBag.RevByAlOrder = _context.Teams.OrderByDescending(t => t.TeamName);
            ViewBag.LastNameCooper = _context.Players.Where(p => p.LastName.Contains("Cooper"));
            ViewBag.FirstNameJoshua = _context.Players.Where(p => p.FirstName.Contains("Joshua"));
            ViewBag.LastNameCooperNoJoshua = _context.Players.Where(p => p.LastName.Contains("Cooper") && !p.FirstName.Contains("Joshua"));
            ViewBag.FirstNameAlexanderOrWyatt = _context.Players.Where(p => p.FirstName.Contains("Alexander") || p.FirstName.Contains("Wyatt"));
            
            return View();
        }

        [HttpGet("level_2")]
        public IActionResult Level2()
        {
            return View();
        }

        [HttpGet("level_3")]
        public IActionResult Level3()
        {
            return View();
        }

    }
}