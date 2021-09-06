using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace University.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Имя")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Фамилия")]
        public string FirstMidName { get; set; }

        [Display(Name = "Дата зачисления")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }
        [Display(Name = "Фамилия Имя")]
        public string FullName
        {
            get
            {
                return FirstMidName +" "+ LastName;
            }
        }
        [Display(Name = "Группа")]
        public Group Group { get; set; }
        public int GroupId { get; set; }
        public ICollection<Attendance> Attendances { get; set; }
    }
}
