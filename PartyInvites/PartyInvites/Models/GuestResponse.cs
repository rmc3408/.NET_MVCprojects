using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Enter proper name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter proper Email")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Enter phone")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "choose yes or no")]
        public bool? WillAttend { get; set; }
    }
}
