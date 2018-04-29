using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAud5.Models
{
    public class ClientDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string MemberCard { get; set; }
        public string Telephone { get; set; }
        public bool IsSubscribed { get; set; }
    }
}