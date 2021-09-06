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
        [Required(ErrorMessage = "Не заполнено")]
        [Display(Name = "Часы")]
        public int Hours { get; set; }
        [Required(ErrorMessage = "Незаполнено")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Дата занятия")]
        public DateTime Date_Attendance { get; set; }
        public int StatusID { get; set; }
        public int SubjectID { get; set; }
        public int StudentID { get; set; }
        [Display(Name = "Статус")]
        public Status Status { get; set; }
        [Display(Name = "Студент")]
        public Student Student { get; set; }
        [Display(Name = "Предмет")]
        public Subject Subject { get; set; }
    }
}
