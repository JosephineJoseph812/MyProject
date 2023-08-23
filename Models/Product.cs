using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [MaxLength(200)]
        public string specs { get; set; }
        public int Name { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public int image { get; set; }
        public string inventory { get; set; }
        public int size { get; set; }
        public string color { get; set; }
        public string brand { get; set; }
        public string category { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set;}
        public UserAccount UserAccount{ get; set; }

        [ForeignKey("   InventoryId")]
        public int    InventoryId { get; set;}
        public          Inventory       Inventory{ get; set; }
        [ForeignKey("CategoriesId")]
        public int CategoriesId { get; set;}
        public Category Category{ get; set; }

    }
}