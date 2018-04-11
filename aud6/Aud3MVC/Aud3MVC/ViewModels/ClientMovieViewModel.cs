using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Aud3MVC.Models;

namespace Aud3MVC.ViewModels
{
    public class ClientMovieViewModel
    {
        public Movie Movie { get; set; }
        public IEnumerable<Client> Clients { get; set; }
        public int MovieId { get; set; }
        public int SelectedClientId { get; set; }
    }
}