using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Models
{
    public class Order
    {
        [Key]
        public int OrdersId { get; set; }
        [Required]
        [MaxLength(200)]
        public string CustomerName { get; set;}
        public string status { get; set;}
        public decimal total { get; set; }
        public int quantities { get; set; }
        public string ItemsPurchased { get; set; }
        public string ShippingAddress { get; set; }
        public int date { get; set; }
        [ForeignKey("UserId")]
        public int UserId { get; set;}
        public UserAccount UserAccount{ get; set; }
       
    }
}