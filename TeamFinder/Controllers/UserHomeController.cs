using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TeamFinder.Models;

namespace TeamFinder.Controllers
{
    public class UserHomeController : Controller
    {
        private readonly ILogger<UserHomeController> _logger;

        public UserHomeController(ILogger<UserHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Mentor()
        {
            return View();
        }

        public IActionResult TeamFind()
        {
            return View();
        }
        public IActionResult TeamCreate()
        {
            return View();
        }
        public IActionResult Profil()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}