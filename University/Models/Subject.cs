using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace University.Models
{
    public class Subject
    { 
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name_Subject { get; set; }
        public ICollection<Attendance> Attendances { get; set; }
    }
}
