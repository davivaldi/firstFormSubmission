using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using validatingFormSub.Models;

namespace validatingFormSub.Controllers
{
    public class HomeController : Controller
    {


        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        
        [HttpPost("user/create")]
        public IActionResult Create(User user)
        {
            if(ModelState.IsValid)
            {
                Console.WriteLine("everthing is right your welcome!");
                User newUser = new User();
                return RedirectToAction("Success");
            }
            else
            {
                Console.WriteLine("brah get your life");
                return View("Index");
            }
        }

        [HttpGet("Success")]
        public IActionResult Success()
        {
            return View();
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
    }
}
