using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace University.Models
{
    public class Attendance
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public int Hours { get; set; }
        public DateTime Date { get; set; }
        public int StatusID { get; set; }
        public int StudentID { get; set; }
        public Status Status { get; set; }
        public Student Student { get; set; }
    }
}
