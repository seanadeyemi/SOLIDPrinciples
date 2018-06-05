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
            List<ICourse> deptCourses = new List<ICourse>();

            ICourse c1 = Factory.CreateCourse();
            c1.Name = "Animal Production";
            c1.Id = 0;

            deptCourses.Add(c1);

            ICourse c2 = Factory.CreateCourse();
            c2.Name = "Wildlife Management" ;
            c2.Id = 1;
           
            deptCourses.Add(c2);

            IDepartment chuksDepartment = Factory.CreateDepartment();
            
            Console.WriteLine(chuksDepartment);

            List<ICourse> chuksCourses = new List<ICourse>();
            ICourse ch1 = Factory.CreateCourse();

            ch1.department = chuksDepartment;
            ch1.Id = 0;
            ch1.Name = "Animal Production";

             ICourse ch2 = Factory.CreateCourse();

            ch2.department = chuksDepartment;
            ch2.Id = 1;
            ch2.Name = "Wildlife Management";


            chuksCourses.Add(ch1);
            chuksCourses.Add(ch2);

            //  Student student = new Student(chuksCourses, chuksDepartment, "Chuks Mabi", "0908875554");

            IStudent student = Factory.CreateStudent();
            student.FullName = "Chuks Mabi";
            student.MatricNo = "0908875554";
          
            student.AddDepartment(chuksDepartment);
            student.AddCourses(chuksCourses);



            Console.WriteLine(student);
            Console.ReadLine();

        }
    }
}
