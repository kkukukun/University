using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using University.Models;

namespace University.Data
{
    public class DbInitializer
    {
        public static void Initialize(UniversityContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }
            var students = new Student[]
            {
            new Student{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
            new Student{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };
            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();

            var status = new Status[] {
            new Status{Id = 1, StatusName = "Был"},
            new Status{Id = 2, StatusName = "Неуважительно "},
            new Status{Id = 3, StatusName = "Уважительно"}
            };
            foreach (Status st in status)
            {
                context.Status.Add(st);
            }
            context.SaveChanges();
            var attendances = new Attendance[]
            { 
            new Attendance{Subject="Programm",Date=DateTime.Parse("2021-02-14"),Hours=2,StatusID=1,StudentID=1},
            new Attendance{Subject="Programm",Date=DateTime.Parse("2021-02-14"),Hours=2,StatusID=2,StudentID=2},
            new Attendance{Subject="Metro",Date=DateTime.Parse("2021-02-20"),Hours=2,StatusID=3,StudentID=3},
            new Attendance{Subject="Metro",Date=DateTime.Parse("2021-02-13"),Hours = 2, StatusID = 1, StudentID = 4 },
            new Attendance{Subject="Metro", Date=DateTime.Parse("2021-02-11"), Hours = 2, StatusID = 3, StudentID = 1  },
            new Attendance{Subject="Metro",Date=DateTime.Parse("2021-02-11"), Hours = 2, StatusID = 1, StudentID = 5 }
            };
            foreach (Attendance a in attendances)
            {
                context.Attendances.Add(a);
            }
            context.SaveChanges();

        }
    }
}