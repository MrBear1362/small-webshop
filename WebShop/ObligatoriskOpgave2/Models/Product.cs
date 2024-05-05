using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ObligatoriskOpgave2.CustomValidation;

namespace ObligatoriskOpgave2.Models
{
    public enum Type
    {
        Book, Music, Movie
    }
    public abstract partial class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Please enter the title")]
        public string Title { get; set; }
        public bool StockStatus { get; set; }
        [Required]
        public int Quantity { get; set; }
        public Type Type { get; set; }
        [Required(ErrorMessage = "Please enter product variation(Example: DVD or Bluray?)")]
        public string TypeVariation { get; set; }
        [Required(ErrorMessage = "Please enter image-url")]
        public string Pic { get; set; }
        [Required(ErrorMessage = "Please enter the price")]
        public double Price { get; set; }
    }
}