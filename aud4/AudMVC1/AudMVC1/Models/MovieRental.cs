using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AudMVC1.Models
{
    public class MovieRental
    {
        public Movie Movie { get; set; }
        public List<Client> Clients { get; set; }

        public MovieRental()
        {
            Movie = new Movie();
            Clients = new List<Client>();
        }

        public MovieRental(Movie movie, List<Client> clients)
        {
            Movie = movie;
            Clients = clients;
        }
    }
}