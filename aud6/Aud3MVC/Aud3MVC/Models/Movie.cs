using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aud3MVC.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [Required] public string Name { get; set; }

        [Required]
        [Range(0, 10, ErrorMessage = "Rating must be between 0-10")]
        public decimal Rating { get; set; }

        [Required]
        [Display(Name = "Download URL")]
        public string DownloadURL { get; set; }

        [Required]
        [Display(Name = "Image URL")]
        public string ImageURL { get; set; }
    }
}