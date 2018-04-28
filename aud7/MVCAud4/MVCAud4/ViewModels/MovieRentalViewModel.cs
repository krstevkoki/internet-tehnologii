using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCAud4.Models;

namespace MVCAud4.ViewModels
{
    public class MovieRentalViewModel
    {
        public Movie Movie { get; set; }
        public List<Client> Clients { get; set; }

        public MovieRentalViewModel()
        {
            Movie = new Movie();
            Clients = new List<Client>();
        }

        public MovieRentalViewModel(Movie movie, List<Client> clients)
        {
            Movie = movie;
            Clients = clients;
        }
    }
}