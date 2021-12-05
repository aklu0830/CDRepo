using Microsoft.AspNetCore.Mvc;
namespace webapp.Controllers {
    public class HomeController : Controller {
        [HttpGet]
        [Route("")]
        public ViewResult Page() {
            return View();
        }
    }
}