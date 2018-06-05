using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    class Program
    {
        public enum Department
        {
            Agriculture,
            BusinessAdmin,
            Sociology,
            Psychology,
            Biology,
            InformationTechnology
        }

        public class Student
        {
            public string Name;
            public string MatricNo;
            public Department department;

            public Student(string name, string matno, Department dept)
            {
                Name = name;
                MatricNo = matno;
                department = dept;
            }

        }

        public class OldStudentFinder
        {
            public static IEnumerable<Student> FindStudentByName(IEnumerable<Student> studentlist, string name)
            {
                foreach(var p in studentlist)
                {
                    if (p.Name == name)
                        yield return p;
                }
            }
            public static IEnumerable<Student> FindStudentByDepartment(IEnumerable<Student> studentlist, Department department)
            {
                foreach (var p in studentlist)
                {
                    if (p.department == department)
                        yield return p;
                }
            }
        }

        public interface IFinder<T>
        {
            IEnumerable<T> Finder(IEnumerable<T> items, IFindBy<T> findby);
        }

        public class DepartmentFindBy : IFindBy<Student>
        {
            private Department department;

            public DepartmentFindBy(Department dept)
            {
                department = dept;
            }

            public bool MeetsCriteria(Student t)
            {
                return department == t.department;
            }
        }

        public class NameFindBy : IFindBy<Student>
        {
            private string name;

            public NameFindBy(string name)
            {
                this.name = name;
            }

            public bool MeetsCriteria(Student t)
            {
                return this.name == t.Name;
            }
        }


        public class StudentFinder : IFinder<Student>
        {
            public IEnumerable<Student> Finder(IEnumerable<Student> items, IFindBy<Student> findby)
            {
                foreach (var p in items)
                {
                    if (findby.MeetsCriteria(p))
                        yield return p;
                }
            }

            //internal IEnumerable<Student> Finder(Student[] students, DepartmentFindBy departmentFindBy)
            //{
            //    throw new NotImplementedException();
            //}
        }

        public interface IFindBy<T>
        {
            bool MeetsCriteria(T t);
        }


        static void Main(string[] args)
        {
            var st1 = new Student("Lola", "0906353637", Department.Sociology);
            var st2 = new Student("Winnie", "0906353633", Department.Agriculture);
            var st3 = new Student("Muna", "0906353635", Department.BusinessAdmin);
            var st4 = new Student("Hassan", "0906353638", Department.Biology);

            Student[] students = {st1, st2, st3, st4 };

            //var results = OldStudentFinder.FindStudentByName(students, "Muna");
            //foreach(var s in results)
            //{
            //    Console.WriteLine($"We found {s.Name}");
            //}

            //results = OldStudentFinder.FindStudentByDepartment(students, Department.Sociology);
            //foreach (var s in results)
            //{
            //    Console.WriteLine($"We found {s.Name} with department {s.department}");
            //}

            ///////////////////////////////////////////////////////////////////////////

            var sf = new StudentFinder();
            foreach (var s in sf.Finder(students, new DepartmentFindBy(Department.BusinessAdmin)))
            {
                Console.WriteLine( $"The student with name: {s.Name} and department {s.department} was found");

            }
            foreach (var s in sf.Finder(students, new NameFindBy("Lola")))
            {
                Console.WriteLine($"The student with name: {s.Name} and department {s.department} was found");

            }

            Console.ReadLine();

        }
    }
}
