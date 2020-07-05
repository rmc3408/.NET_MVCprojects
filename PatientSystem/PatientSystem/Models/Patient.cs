using System;

namespace PatientSystem.Models
{
    public class Patient
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Occupation { get; set; }
        public bool? Insurance { get; set; }
        public bool? Operation { get; set; }
        public int Marital { get; set; }
        public DateTime Clock { get; set; }
    }
}