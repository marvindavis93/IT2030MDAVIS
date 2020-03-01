using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class Student
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
    }
}