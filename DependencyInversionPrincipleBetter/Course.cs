using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public class Course : ICourse
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IDepartment department { get; set; }


        public Course(IDepartment department)
        {
            this.department = department;
        }
    }
}
