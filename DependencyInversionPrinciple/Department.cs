using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private List<Course> CoursesOffered;

        public Department(List<Course> coursesOffered, string Name)
        {
            this.Name = Name;
            SetCourses(coursesOffered);
        }

        public void SetCourses(List<Course> coursesOffered)
        {
            this.CoursesOffered = coursesOffered;
        }

        public string FirstCourse()
        {
            return CoursesOffered[0].Name;
        }

        public override string ToString()
        {
            return $"Department: {this.Name}";
        }
    }
}
