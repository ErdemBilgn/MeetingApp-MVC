using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int clock = DateTime.Now.Hour;

            ViewBag.greet = clock > 12 ? "İyi Günler" : "Günaydın";
            int userCount = Repository.Users.Where(info => info.WillAttend == true).Count();


            MeetingInfo meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "İstanbul, ABC Kongre Merkezi",
                Date = new DateTime(2024, 01, 20, 20, 0, 0),
                NumberOfPeople = userCount
            };


            return View(meetingInfo);
        }
    }
}