using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ObligatoriskOpgave2.Models
{
    public partial class Book : Product
    {
        [Required(ErrorMessage = "Please enter the authors name")]
        public string Author { get; set; }
        [Required(ErrorMessage = "Please enter the publishers name")]
        public string Publisher { get; set; }
        [Required(ErrorMessage = "Please enter number of pages")]
        public int Pages { get; set; }
    }
}