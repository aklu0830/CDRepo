using System;
using Microsoft.AspNetCore.Mvc;
using webapp.Models;

namespace webapp.Controllers {
    public class PasscodeController : Controller {
        [HttpGet("")]
        public IActionResult Index() {
            string genpasscode = "";
            Random r = new Random();
            string[] possibleNums = new string[] {
                "1","2","3","4","5","6","7","8","9","0",
                "A","B","C","D","E","F","G","H","I","J","K","L",
                "M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"
            };
            for (int i = 0; i < 14; i++) {
                int index = r.Next(0,possibleNums.Length-1);
                genpasscode += possibleNums[index];
            }

            Passcode pc = new Passcode() {
                passcode = genpasscode
            };
            
            return View(pc);
        }

        [HttpPost("")]
        public IActionResult Process() {
            return Redirect("/");
        }
    }
}