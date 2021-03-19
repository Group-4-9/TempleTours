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

        [HttpGet]
        public IActionResult SignUp()
        {
            return View(new TimeslotModel());
        }

        [HttpPost]
        public IActionResult SignUp(TimeslotModel timeslotModel)
        {
            return View("Form", timeslotModel);
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
            Debug.WriteLine(group.GroupName);

            // add the group, update the DB
            if (ModelState.IsValid)
            {
                // update the data
                _context.Groups.Add(group);
                _context.SaveChanges();
            }

            return View();
        }
        //Need to pass the database stuff into the view
        // _context is where the data of the databse is stored. "Groups" is the name of the field/table
        // of the databse that has the data we want to display
        public IActionResult ViewAppts()
        {
            return View(_context.Groups);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
