using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class MeetingController : Controller
    {

        public IActionResult Apply()
        {
            return View();
        }

        public IActionResult List()
        {
            List<UserInfo> users = Repository.Users;
            return View(users);
        }

        [HttpPost]
        public IActionResult Apply(UserInfo model)
        {

            Repository.CreateUser(model);
            ViewBag.UserCount = Repository.Users.Where(info => info.WillAttend == true).Count();
            return View("Thanks", model);
        }

        public IActionResult Details(int id)
        {
            UserInfo? user = Repository.GetById(id);
            return View(user);
        }
    }
}