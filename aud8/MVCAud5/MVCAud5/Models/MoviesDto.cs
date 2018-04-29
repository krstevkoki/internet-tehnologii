using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAud5.Models
{
    public class MoviesDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Rating { get; set; }
        public string DownloadURL { get; set; }
        public string ImageUrl { get; set; }
    }
}