using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace University.Models
{   
    public class Attendance
    {
        public int Id { get; set; }
        public int Hours { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date")]
        public DateTime Date_Attendance { get; set; }
        public int StatusID { get; set; }
        public int SubjectID { get; set; }
        public int StudentID { get; set; }
        public Status Status { get; set; }
        public Student Student { get; set; }
        public Subject Subject { get; set; }
    }
}
