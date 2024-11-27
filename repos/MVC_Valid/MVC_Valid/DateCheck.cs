using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_Valid
{
    public class DateCheck : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value,ValidationContext validationContext)
        {
            if (value != null)
            {
                DateTime date = Convert.ToDateTime(value);
                var year =date.Year;
                if(year<2024)
                {
                    return ValidationResult.Success;
                }

            }
            ErrorMessage = ErrorMassage == null ? "Please Check Date" :ErrorMessage:
            return new ValidationResult(ErrorMessage);
        }


    }
}