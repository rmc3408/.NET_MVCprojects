using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; } = "";
        public long Price { get; set; } = 0;
        public string PictureUrl { get; set; } = default!;
        public string Type { get; set; } = default!;
        public string Brand { get; set; } = default!;
        public int Quantity { get; set; } = default!;
    }
}