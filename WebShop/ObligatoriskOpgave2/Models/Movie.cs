using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ObligatoriskOpgave2.Models
{
    public partial class Movie : Product
    {
        [Required(ErrorMessage = "Please enter the Directors name")]
        public string Director { get; set; }
        
        public System.DateTime ReleaseDate { get; set; }
    }
}