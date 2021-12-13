using Microsoft.AspNetCore.Mvc;

namespace webapp.Controllers {
    public class HomeController : Controller {
        [HttpGet("/")]
        public IActionResult Index() {
            
            return View();
        }
        
    }
}