using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab4MVC.Models
{
    public class Friend
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Range(0, 200, ErrorMessage = "FriendId must be between 0-200")]
        [Display(Name = "Friend Id")]

        public int FriendId { get; set; }

        [Required] public string Name { get; set; }
        [Required] public string Hometown { get; set; }
    }
}