using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TempleTours.Models;

namespace TempleTours.Controllers
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

        public IActionResult SignUp()
        {
            return View(new TimeslotModel { });
        }

        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        ////uncomment after inserting the variable into the Form()
        //[HttpPost]
        //public IActionResult Form(Group formResponse)
        //{
        //    //Debug.WriteLine(formResponse.GroupName);

        //    return View("Submissions");
        //}

        public IActionResult ViewAppts()
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
