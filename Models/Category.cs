using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Models
{
    public class Category
    {
        [Key]
        public int CategoriesId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set;}
        
    }
}