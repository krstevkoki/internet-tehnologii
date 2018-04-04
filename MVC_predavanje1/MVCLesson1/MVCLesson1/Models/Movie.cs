using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCLesson1.Models
{
    public class Movie
    {
        public string Name { get; set; }
        public decimal Rating { get; set; }
        public string DownloadURL { get; set; }
        public string ImageURL { get; set; }

        public Movie()
        {
        }

        public override string ToString()
        {
            return $"{Name} - {Rating}";
        }
    }
}