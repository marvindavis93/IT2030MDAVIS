using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class Enrollment
    {

        [Display(Name = "Enrollment Id")] 

        public virtual int EnrollmentID {get; set;}

        [Display(Name = "Student Id")]
        public virtual int StudentId { get; set; }


        [Display(Name = "Course Id")]
        public virtual int CourseId { get; set; }
        [Display(Name = "Grade")]
        [Required ]
        [RegularExpression("^[A-F]{1}$", ErrorMessage = "Enter value A , B, C, D, E, F")]
        public virtual string Grade { get; set; }
        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }

        public virtual  bool IsActive { get; set; }

        [Required]
        [Display(Name = "Assigned Campus")]

        public virtual string AssignedCampus { get; set; }


    [Required]
        [Display(Name = "Enrolled in Semester")]
        public virtual string EnrollmentSemester { get; set; }


        [Required]
        [Range(2018, int.MaxValue, ErrorMessage ="Enter value not less than 2018" )]

        public virtual int EnrollmentYear { get; set; }

        //InvalidChars
        [Display(Name = "Notes")]
       
        [InvalidChars(" !, @, $, *,", ErrorMessage = "Notes contains unacceptable characters!")]
        public virtual string Notes { get; set; }



    }
}