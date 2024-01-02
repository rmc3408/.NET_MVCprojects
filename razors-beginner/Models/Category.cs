﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace razors_beginner.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Category Name")]
        public string Name { get; set; }

        [DisplayName("Display Order")]
        [Range(1, 100)]
        public int DisplayOrder { get; set; }
    }
}
