using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class Course
    {
        [Display(Name = "Course ID")]
        public virtual int CourseId { get; set; }

        [Required]
        [StringLength(150)]

        [Display(Name = "Course Title")]
        public virtual string Title { get; set; }


        [Display(Name = "Description")]

        public virtual string CourseDescription { get; set; }

        [Required]
        [Range(1,4)]
         [Display(Name = "Number of Credits")]
        [RegularExpression("^[1-4]{1}$", ErrorMessage = "Enter value either 1,2 or 3,4")]
        public virtual int CourseCredits { get; set; }
    }
}