using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int clock = DateTime.Now.Hour;

            ViewBag.greet = clock > 12 ? "İyi Günler" : "Günaydın";
            ViewBag.userName = "Erdem";
            return View();
        }
    }
}