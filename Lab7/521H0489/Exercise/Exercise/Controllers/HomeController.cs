using Exercise.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Exercise.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Route("/Error/{code:int}")]
        public IActionResult Error(int code)
        {
            ViewBag.Message = "Error: " + code; 
            return View();
        }

    }
}