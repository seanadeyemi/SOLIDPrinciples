using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public class ForeignStudent : IStudent
    {
        public IDepartment department { get ; set ; }
        public string FullName { get; set ; }
        public int Id { get; set ; }
        public string MatricNo { get; set ; }

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
            return "I am a foreign student";
        }
    }
}
