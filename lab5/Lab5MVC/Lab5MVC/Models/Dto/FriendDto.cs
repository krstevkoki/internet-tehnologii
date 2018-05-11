using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab5MVC.Models.Dto
{
    public class FriendDto
    {
        public int Id { get; set; }
        public int FriendId { get; set; }
        public string Name { get; set; }
        public string Hometown { get; set; }
    }
}