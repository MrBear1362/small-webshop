using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ObligatoriskOpgave2.Models
{
    public partial class Music : Product
    {
        [Required(ErrorMessage = "Please enter the artists name")]
        public string Artist { get; set; }
        [Required(ErrorMessage = "Please enter the genre")]
        public string Genre { get; set; }
        public string Info { get; set; }
    }
}