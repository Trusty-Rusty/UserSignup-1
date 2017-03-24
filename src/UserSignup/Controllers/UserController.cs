using Microsoft.AspNetCore.Mvc;
using UserSignup.Models;

namespace UserSignup.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(User user, string verify)
        {
            if (user.Password == null || !user.Password.Equals(verify))
            {
                ViewBag.username = user.Username;
                ViewBag.email = user.Email;
                ViewBag.message = "Passwords do not match";

                return View();
            }

            ViewBag.username = user.Username;

            return View("Index");
        }
    }
}
