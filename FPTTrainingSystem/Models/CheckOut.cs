using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FPTTrainingSystem.Models
{
    public class CheckOut
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        [StringLength(200)]
        public string Address { get; set; }

        [Required]
        public string EmailAddress { get; set; }
        public double PhoneNumber { get; set; }
    }
}