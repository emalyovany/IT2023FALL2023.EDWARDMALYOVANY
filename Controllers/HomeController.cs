using EddiesHikingStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace EddiesHikingStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult FAQ()
        {
            return View();
        }

        public IActionResult Events()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        // GET: Home/Tools
        // Display the tools view with session data
        public IActionResult Tools()
        {
            // Only set initial session variables if they are not already set
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("FirstName")))
            {
                HttpContext.Session.SetString("FirstName", "Edward");
                HttpContext.Session.SetString("LastName", "Malyovany");
                HttpContext.Session.SetString("Course", "IT2030");
                HttpContext.Session.SetInt32("FavNum", 1);
            }

            // Prepare the model from current session values
            MySession model = new MySession
            {
                FirstName = HttpContext.Session.GetString("FirstName"),
                LastName = HttpContext.Session.GetString("LastName"),
                Course = HttpContext.Session.GetString("Course"),
                FavNum = HttpContext.Session.GetInt32("FavNum") ?? 0 // Default to 0 if not set
            };
            return View(model);
        }

        // POST: Home/DisplaySessionVariables
        [HttpPost]
        public IActionResult DisplaySessionVariables()
        {
            // Redirect to the Tools view, which will display current session data
            return RedirectToAction("Tools");
        }

        // POST: Home/ClearSessionVariables
        [HttpPost]
        public IActionResult ClearSessionVariables()
        {
            // Clear all session data
            HttpContext.Session.Clear();

            // Redirect to the Tools action, which will now display empty fields
            return RedirectToAction("Tools");
        }
    }
}
