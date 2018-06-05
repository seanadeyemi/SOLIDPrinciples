using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Course> deptCourses = new List<Course>();
            deptCourses.Add(new Course {  Id = 0,  Name = "Animal Production" });
            deptCourses.Add(new Course { Id = 1, Name = "Wildlife Management" });

            Department chuksDepartment = new Department(deptCourses, "Agric");
            
            Console.WriteLine(chuksDepartment);

            List<Course> chuksCourses = new List<Course>();
            chuksCourses.Add(new Course { department = chuksDepartment, Id = 0,  Name = "Animal Production" });
            chuksCourses.Add(new Course { department = chuksDepartment, Id = 1, Name = "Wildlife Management" });

          //  Student student = new Student(chuksCourses, chuksDepartment, "Chuks Mabi", "0908875554");

             Student student = new Student("Chuks Mabi", "0908875554");
            student.AddDepartment(chuksDepartment);
            student.AddCourses(chuksCourses);



            Console.WriteLine(student);
            Console.ReadLine();

        }
    }
}
