using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentSystem.Models;

namespace StudentSystem.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            Student studName = new Student()
            {
                Firstname = "Raphael",
                LastName = "Molinaro",
                Gpa = 4.44,
                FullTime = true,
                CourseCode = "Soft Eng",
                Email = "rmc@proton.com",
                StudentID = 301098080

            };
            return View(studName);
        }


        public IActionResult LStudents()
        {
            List<Student> studPack = new List<Student>()
            {
                new Student()
                {
                Firstname = "Raphael",
                LastName = "Molinaro",
                Gpa = 1.44,
                FullTime = true,
                CourseCode = "COMP100",
                Email = "rmc@proton.com",
                StudentID = 301098080
                },
                new Student()
                {
                Firstname = "Luana",
                LastName = "Cesar",
                Gpa = 2.4,
                FullTime = true,
                CourseCode = "COMP229",
                Email = "lcesar@proton.com",
                StudentID = 301098011
                },
                new Student()
                {
                Firstname = "Clara",
                LastName = "CCCC",
                Gpa = 4.44,
                FullTime = true,
                CourseCode = "COMP229",
                Email = "rmc@proton.com",
                StudentID = 301090000
                },
                new Student()
                {
                Firstname = "Jennifer",
                LastName = "Cesar",
                Gpa = 3.4,
                FullTime = true,
                CourseCode = "COMP123",
                Email = "lcesar@proton.com",
                StudentID = 301098011
                }
        };
            
            return View(studPack);
        }

    }
}
