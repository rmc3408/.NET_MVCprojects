using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRepair301098080.Models
{
    public class Car
    {
        public string LicensePlate { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Make { get; set; }
        public string Model { get; set; }
        public bool Door { get; set; }
        public bool Gas { get; set; }
        public bool Wheel { get; set; }
        public DateTime CurrentDateAndTime { get; set; }

    }
}
