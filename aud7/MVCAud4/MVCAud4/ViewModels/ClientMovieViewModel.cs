using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCAud4.Models;

namespace MVCAud4.ViewModels
{
    public class ClientMovieViewModel
    {
        public Movie Movie { get; set; }
        public IEnumerable<Client> Clients { get; set; }
        public int MovieId { get; set; }
        public int SelectedClientId { get; set; }
    }
}