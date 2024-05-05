using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ObligatoriskOpgave2.Models
{
    public class Customer
    {
        [Key]
        public int PersonId { get; set; }
        public string Name { get; set; }

        public Customer()
        {
            this.Products = new HashSet<Product>();
        }
       
        

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
    }
}