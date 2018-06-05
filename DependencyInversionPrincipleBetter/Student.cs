using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public class Student : IStudent
    {
        public int Id { get; set; }

        public string FullName { get; set; }
        public string MatricNo { get; set; }

        public IDepartment department { get; set; }

        public Student()
        {

        }

        public Student (List<ICourse> courses, IDepartment department, string Name, string MatricNo)
        {
            this.department = department;
            this.department.SetCourses(courses);
            this.FullName = Name;
            this.MatricNo = MatricNo;
            

        }

    public Student (List<ICourse> courses,  string Name, string MatricNo)
        {
            this.department = department;
            this.department.SetCourses(courses);
            this.FullName = Name;
            this.MatricNo = MatricNo;
            this.department = Factory.CreateDepartment();

        }


        public Student(string Name, string MatricNo)
        {
            this.FullName = Name;
            this.MatricNo = MatricNo;
        }

        public Student(IDepartment department)
        {
            this.department = department;
        }

        public void AddCourses(List<ICourse> courses)
        {
            this.department.SetCourses(courses);
        }

        public void AddDepartment(IDepartment department)
        {
            this.department = department;
        }



        public override string ToString()
        {
            return $"My Name is {FullName} and my department is {department}, I registered for {department.FirstCourse()}";
        }

    }

   
}
