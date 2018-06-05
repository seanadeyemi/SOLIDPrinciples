using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class Student
    {
        private readonly List<string> names = new List<string>();

        public int AddName(string name)
        {
            names.Add($"Name: {name}");
            return names.Count();
        }

        public void RemoveName(int index)
        {
            names.RemoveAt(index);
        }

        public override string ToString()
        {
            return String.Join(Environment.NewLine, names);
        }

        //public void Save(string filename)
        //{
        //    File.WriteAllText(filename, ToString());
        //}

    }

    
    class Program
    {
        static void Main(string[] args)
        {
            var st = new Student();
            st.AddName("Chuks");
            st.AddName("Gaby");
            st.AddName("Winnie");
            st.AddName("Samuel");
            st.AddName("Lola");
            st.AddName("Muna");

            //st.Save(@"C:\Users\seana\Documents\students.txt");
            string fname = @"C:\Users\seana\Documents\students.txt";
            var p = new Persistence.Persistence();
            p.SaveToFile(st, fname, true);
            Process.Start(fname);



            Console.WriteLine("Hello");
            Console.WriteLine(st);


            Console.ReadLine();
        }
    }
}
