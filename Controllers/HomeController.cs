using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TempleTours.Models;
using TempleTours.Models.ViewModels;

namespace TempleTours.Controllers
{
    public class HomeController : Controller
    {
        private TempleTourContext _context { get; set; }

        // set the private variable
        public HomeController (TempleTourContext con)
        {
            _context = con;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View(new TimeslotModel());
        }

        [HttpGet]
        public IActionResult Form(string time)
        {
            return View("Form", new FormViewModel 
            { 
               Time = time
            });
        }

        [HttpPost]
        public IActionResult Form(Group group)
        {
            // add the group, update the DB
            if (ModelState.IsValid)
            {
                // update the data
                _context.Groups.Add(group);
                _context.SaveChanges();
            }

            return View();
        }

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
