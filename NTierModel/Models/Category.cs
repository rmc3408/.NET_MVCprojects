﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace bhrugen_patel.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(4)]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; } = "";

        [DisplayName("Display Order")]
        [Range(1,100, ErrorMessage = "Out of range from 1 to 100")]
        public int DisplayOrder { get; set; }
    }
}
