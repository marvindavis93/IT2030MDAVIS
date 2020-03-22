using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class Student : IValidatableObject
    {
       
       [Display(Name = "Student Id")]
        public virtual int StudentID { get; set; }
        
        [Display( Name = "Last Name") ]
        [Required]
        [StringLength(50)]

        public virtual string StudentLastname { get; set; }

        [Display(Name ="First Name")]
        [Required ]
        [StringLength(50 )]
        public virtual string StudentFirstName {get; set;}




        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public string State { get; set; }


        


       
        public     IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            // Validation 1 : Zip code has to be between 
            if (Address2 == Address1) 
            {
                yield return (new ValidationResult("Address2 cannot be same as Address 1"));
            }
            if (State !=  null && State.Split (' ').Length >2 )
            {
                yield return (new ValidationResult("Enter 2 digit State code "));
            }
            if (Zipcode !=  null && Zipcode.Split(' ').Length <5)
            {
            }
            else
            {
                yield return (new ValidationResult("Enter a 5 digit Zipcode"));
            }

            //throw new NotImplementedException();

        }
    }
}