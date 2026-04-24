using Microsoft.AspNetCore.Mvc;
using Zentrix.Web.ViewModels;

namespace Zentrix.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult About() => View();

        [HttpGet]
        public IActionResult Contact() => View();

        [HttpPost]
        public IActionResult Contact(ContactViewModel model)
        {
            ViewBag.Message = "Thanks! We will contact you.";
            return View();
        }
    }
}