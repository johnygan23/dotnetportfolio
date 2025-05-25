using Microsoft.AspNetCore.Mvc;

namespace WebAppExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]        // Maps to URL: /
        public IActionResult Index()
        {
            return View();  // Renders Views/Home/Index.cshtml
        }

        [Route("about")]   // Maps to URL: /about
        public IActionResult About()
        {
            return View();  // Renders Views/Home/About.cshtml
        }

        [Route("projects")]   // Maps to URL: /projects
        public IActionResult Projects()
        {
            return View();  // Renders Views/Home/Projects.cshtml
        }

        [Route("contact")]
        public IActionResult Contact()
        {
            return View(); // Renders Views/Home/Contact.cshtml
        }
    }
}