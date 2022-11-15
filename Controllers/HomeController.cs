using FirstCoreMVCWebApplication.Models;
using FirstCoreMVCWebApplication.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreMVCWebApplication.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ViewResult DetailsByViewData()
        {
            // Storing string Data
            ViewData["Title"] = "Student Details Page";
            ViewData["Header"] = "Student Details";

            // Create Student Data
            Student student = new Student()
            {
                StudentId = "STD101",
                Name = "James",
                Branch = "CSE",
                Section = "A",
                Gender = "Male"
            };
            // Storing Student Data
            ViewData["Student"] = student;

            return View();
        }

        public ViewResult DetailsByViewBag()
        {
            // Storing string Data
            ViewBag.Title = "Student Details Page";
            ViewBag.Header = "Student Details";

            // Create Student Data
            Student student = new Student()
            {
                StudentId = "STD101",
                Name = "James",
                Branch = "CSE",
                Section = "A",
                Gender = "Male"
            };
            // Storing Student Data
            ViewBag.Student = student;
            return View();
        }

        public ViewResult DetailsByStronglyTypedModel()
        {
            ViewBag.Title = "Student Details Page";
            ViewBag.Header = "Student Details";
            // Create Student Data
            Student student = new Student()
            {
                StudentId = "STD101",
                Name = "James",
                Branch = "CSE",
                Section = "A",
                Gender = "Male"
            };
            return View();
        }
        public ViewResult DetailsByViewModel()
        {
            //Student Basic Details
            Student student = new Student()
            {
                StudentId = "STD102",
                Name = "Dillip",
                Branch = "CSE",
                Section = "A",
                Gender = "Male"
            };
            //Student Address
            Address address = new Address()
            {
                StudentId = "STD102",
                City = "Mumbai",
                State = "Maharashtra",
                Country = "India",
                Pin = "400097"
            };
            //Creating the View model
            StudentDetailsViewModel studentDetailsViewModel = new StudentDetailsViewModel()
            {
                Student = student,
                Address = address,
                Title = "Student Details Page",
                Header = "Student Details",
            };
            return View(studentDetailsViewModel);
        }
    }
}
