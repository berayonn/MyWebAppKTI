using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyWebApp.Models;
using MyWebApp.Repositories;

namespace MyWebApp.Controllers
{
    [Authorize]
    public class StudentsController : Controller
    {
        private readonly ILogger<StudentsController> _logger;

        private readonly IStudentRepository _studentRepository;
        public StudentsController(ILogger<StudentsController> logger,
        IStudentRepository studentRepository)
        {
            _logger = logger;
            _studentRepository = studentRepository;
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "Students List";
            var models = _studentRepository.GetAll();
            return View(models);
            //Students student = new Students()
            //{
                //StudentId = 1,
                //Name = "Jhon Doe",
                //Email = "jhon@gmail.com",
                //BirthDate = new DateOnly(1999, 2, 20)
            //};

            //ViewData["Message"]= "Hello from StudentsController";
            //ViewData["Date"]= DateTime.Now;
            //ViewBag.Pesan = "Hello from  View Bag !";
            //return View(student);
        }
        public IActionResult Description()
        {
            return View();
        }

        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}