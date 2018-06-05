using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public class Student
    {
        public int Id { get; set; }

        public string FullName { get; set; }
        public string MatricNo { get; set; }

        public Department department { get; set; }


        public Student (List<Course> courses, Department department, string Name, string MatricNo)
        {
            this.department = department;
            this.department.SetCourses(courses);
            this.FullName = Name;
            this.MatricNo = MatricNo;
            

        }

    public Student (List<Course> courses,  string Name, string MatricNo)
        {
            this.department = department;
            this.department.SetCourses(courses);
            this.FullName = Name;
            this.MatricNo = MatricNo;
            this.department = new Department(courses, "");

        }


        public Student(string Name, string MatricNo)
        {
            this.FullName = Name;
            this.MatricNo = MatricNo;
        }

        public void AddCourses(List<Course> courses)
        {
            this.department.SetCourses(courses);
        }

        public void AddDepartment(Department department)
        {
            this.department = department;
        }



        public override string ToString()
        {
            return $"My Name is {FullName} and my department is {department}, I registered for {department.FirstCourse()}";
        }

    }

   
}
