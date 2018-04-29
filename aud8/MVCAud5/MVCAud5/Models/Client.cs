using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCAud5.Models
{
    public class Client
    {
        [Key] public int Id { get; set; }
        [Required] public string Name { get; set; }
        public string Address { get; set; }

        [Range(1, Int32.MaxValue, ErrorMessage = "Age must be a positive number (> 0)")]
        public int Age { get; set; }

        [Display(Name = "Member card")] public string MemberCard { get; set; }
        public string Telephone { get; set; }
        public bool IsSubscribed { get; set; }
        public virtual ICollection<Movie> Movies { get; set; } // used for database communication for Client & Model

        public Client()
        {
            Movies = new List<Movie>();
        }
    }
}