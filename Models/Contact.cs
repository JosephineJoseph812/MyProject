using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Models
{
    public class Contact
    {
        [Key]
       public int ContactId { get; set; } 
       [Required]
        [MaxLength(100)]
       public string Name { get; set; }
       public string email { get; set; }
       public string Message { get; set; }
       [ForeignKey("UserId")]
        public int UserId { get; set;}
        public UserAccount UserAccount{ get; set; }

    }
}