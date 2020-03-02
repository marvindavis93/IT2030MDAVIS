using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace EnrollmentApplication.Models
{
    public class InvalidChars : ValidationAttribute
    {
        readonly string invalidChars;
        public InvalidChars(string invalidChars) : base("{0} contains unacceptable characters!")
        {
            this.invalidChars = invalidChars;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                if (((string)value).Contains(invalidChars))
                {
                    var errormessage = FormatErrorMessage(validationContext.DisplayName);
                    return new ValidationResult(errormessage);
                }
            }
            return ValidationResult.Success;
        }
    }
}