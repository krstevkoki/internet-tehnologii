using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCAud4.Models
{
    public class Movie
    {
        [Key] public int Id { get; set; }
        [Required] public string Name { get; set; }

        [Range(0, 10, ErrorMessage = "Rating must be between 0-10")]
        public decimal Rating { get; set; }

        [Display(Name = "Download URL")] public string DownloadURL { get; set; }

        [Display(Name = "Image URL")] public string ImageUrl { get; set; }

        public virtual ICollection<Client> Clients { get; set; } // used for database communication for Client & Model

        public Movie()
        {
            Clients = new List<Client>();
        }
    }
}