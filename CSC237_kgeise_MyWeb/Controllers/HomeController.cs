//NO MODELS
//using CSC237_kgeise_MyWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic; //Dictionary class is here
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CSC237_kgeise_MyWeb.Controllers
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

        public IActionResult Contact()
        {
            /*
            ** See dictionary discussion in textbook Chapter 8 ViewData and ViewBag
            ** This is a C# class called Dictionary
            */
            var contacts = new Dictionary<string, string> {
                { "Phone", "555-123-4567" },
                { "Email", "me@mywebsite.com" },
                { "Facebook", "facebook.com/mywebsite" }
            };
            return View(contacts);
        }
    }
}
