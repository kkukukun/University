using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace University.Models
{
    public class Group
    {
        public int ID { get; set; }

        [Display(Name = "Аббревиатура")]
        public string Abbreviation { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Название")]
        public string Name { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Дата формирования")]
        public DateTime Date_Creaction { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
