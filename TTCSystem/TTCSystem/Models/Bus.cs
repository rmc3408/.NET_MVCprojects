using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TTCSystem.Models
{
    public class Bus
    {
        [Key]
        public int BusNumber { get; set; }

        [Required(ErrorMessage = "Please enter the Route Name")]
        [Display(Name = "Route Name", Prompt = "Enter the Route Name")]
        public string RouteName { get; set; }

        [Required(ErrorMessage = "Please enter the Plate Number")]
        [Display(Name = "Plate Number", Prompt = "Enter the Plate Number")]
        public string PlateNumber { get; set; }

        [Display(Name = "Bus Is In Operation?")]
        public bool InOperation { get; set; }
    }
}
