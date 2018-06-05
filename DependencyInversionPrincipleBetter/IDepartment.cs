using System.Collections.Generic;

namespace DependencyInversionPrinciple
{
    public interface IDepartment
    {
        int Id { get; set; }
        string Name { get; set; }

        string FirstCourse();
        void SetCourses(List<ICourse> coursesOffered);
        string ToString();
    }
}