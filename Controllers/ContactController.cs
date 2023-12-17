using Microsoft.AspNetCore.Mvc;
using EddiesHikingStore.Models;

namespace EddiesHikingStore.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            // Initialize ViewData to not show the message by default
            ViewData["ShowThankYouMessage"] = false;
            return View();
        }

        [HttpPost]
        public IActionResult Index(ContactModel model)
        {
            if (ModelState.IsValid)
            {
                // Handle form submission here (e.g., send an email, save to database).

                // Set ViewData to show the thank you message
                ViewData["ShowThankYouMessage"] = true;

                // You can optionally clear the model to reset the form fields
                // model = new ContactModel();

                // Redirect to the view to display the thank you message
                return View(model);
            }

            // If ModelState is not valid, return the view with validation errors
            return View(model);
        }
    }
}
