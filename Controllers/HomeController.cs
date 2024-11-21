using System.Diagnostics;
using AspNetWithJquery.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetWithJquery.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public int Add(int num1,int num2)
        //{
        //    return num1+num2;
        //}

        [HttpPost]
        public Calculation calculate(int num1, int num2)
        {
            Calculation calculation = new Calculation();
            calculation.Add = num1+num2;
            calculation.Susbtract = num1 - num2;
            calculation.Multiply = num1 * num2;
            calculation.Division = num1 / num2;

            return calculation;
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
