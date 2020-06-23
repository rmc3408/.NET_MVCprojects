using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    public class Student
    {
        public string CourseCode { get; set; }
        public string Email { get; set; }
        public string Firstname { get; set; }
        public bool FullTime { get; set; }
        public double Gpa { get; set; }
        public string LastName { get; set; }
        public int StudentID { get; set; }


    }
}
