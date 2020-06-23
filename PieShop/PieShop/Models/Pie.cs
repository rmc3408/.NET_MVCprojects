using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Models
{
    public class Pie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal price { get; set; }
        public string ImagePieUrl { get; set; }
        public string ImageThumbsnailPieUrl { get; set; }
        public bool IsPieOfWeek { get; set; }





    }
}
