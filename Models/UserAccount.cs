using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Models
{
    public class UserAccount
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string address { get; set; }
        public string Name { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public int PhoneNumber { get; set; }
    }
}