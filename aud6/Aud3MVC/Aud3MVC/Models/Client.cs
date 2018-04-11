using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aud3MVC.Models
{
    public class Client
    {
        [Required] public string Name { get; set; }
        [Required] public string Address { get; set; }

        [Required]
        [Range(1, Int32.MaxValue, ErrorMessage = "Age must be a positive number (> 0)")]
        public int Age { get; set; }

        [Required]
        [Display(Name = "Member card")]
        public string MemberCard { get; set; }

        [Required] public string Telephone { get; set; }
        public bool IsSubscribed { get; set; }
    }
}