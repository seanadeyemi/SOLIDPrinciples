using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public static class Factory
    {
        public static IStudent CreateStudent()
        {
            return new Student();
        }

        public static IDepartment CreateDepartment()
        {
            return new Department();
        }

        public static ICourse CreateCourse()
        {
            return new Course(CreateDepartment());
        }
    }
}
