using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using JokesWebApp.Models;



namespace JokesWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Redirect to the Jokes CRUD list
            return RedirectToAction("Index", "Jokes");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Error()
        {
            var model = new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };
            return View(model);
        }
    }
}