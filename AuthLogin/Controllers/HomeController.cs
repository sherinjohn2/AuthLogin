using AuthLogin.Models;
using AuthLogin.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;

using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AuthLogin.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogin _logger;

        public HomeController(ILogin logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string username, string password)
        {
            var issuccess = _logger.AuthenticateUser( username, password);


            if (issuccess.Result != null)
            {
                ViewBag.username = string.Format("Successfully logged-in", username);
                //return View();
                //   TempData["username"] = "sherin";
                return RedirectToAction("Home", "Home");
            }
            else
            {
                ViewBag.username = string.Format("Login Failed ", username);
                return View();
            }
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Home()
        {
            return View();
        }
    }
}