using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ObligatoriskOpgave2.CustomValidation
{
    public class CustomPrice : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            Double price = Convert.ToDouble(value);
            return Double.TryParse(price.ToString(), out price); ;
        }
    }
}