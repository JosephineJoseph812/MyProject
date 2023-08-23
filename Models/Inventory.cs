using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Models
{
    public class Inventory
    {
        [Key]
        public int InventoryId { get; set; }
        [Required]
        [MaxLength(100)]
        public int stock { get; set;}

    }
}