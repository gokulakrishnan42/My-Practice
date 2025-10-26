using Microsoft.AspNetCore.Mvc;

namespace ShoppingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<ShoppingApp.Models.User> ousers = new List<ShoppingApp.Models.User>()
        {

        new ShoppingApp.Models.User() {Name = "Gojo",ImagePath = "Images/Gojo.jpg",Desc = "Welcome to my Page" },
        new ShoppingApp.Models.User() {Name = "Employee",ImagePath = "Images/images.jpg",Desc = "Welcome to my Page" }


        };
            ViewData["Name"] = "Gokul";
            ViewData["listofusers"] = ousers;
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }

    }
}
