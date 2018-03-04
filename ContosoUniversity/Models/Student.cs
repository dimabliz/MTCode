using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Student : Person
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }

        public double CreditsEarned { get; set; }

        [Range(0.7, 4, ErrorMessage = "Invalid GPA")]
        public double Gpa { get; set; }

        public string GpaFormatted { get; set; }

        public void setGpaFormat() {
            double rounded = Math.Round(Gpa, 2);
            GpaFormatted = rounded.ToString("F");
        }
    }
}
