using Microsoft.AspNetCore.Mvc;

namespace EAD_Project.Controllers
{
    public class CommonController : Controller
    {
        [HttpGet]
        public IActionResult PrivacyPolicy()
        {
            return View();
        }

        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult FAQ()
        {
            return View();
        }
        public IActionResult GrabandGO()
        {
            return View();
        }
        public IActionResult PickupLocation()
        {
            return View();
        }
    }
}
