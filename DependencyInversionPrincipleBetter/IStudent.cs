using System.Collections.Generic;

namespace DependencyInversionPrinciple
{
    public interface IStudent
    {
        IDepartment department { get; set; }
        string FullName { get; set; }
        int Id { get; set; }
        string MatricNo { get; set; }

        void AddCourses(List<ICourse> courses);
        void AddDepartment(IDepartment department);
        string ToString();
    }
}