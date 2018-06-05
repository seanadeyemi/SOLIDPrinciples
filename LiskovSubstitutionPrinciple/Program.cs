using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{   


        public class Animal : IHasLegs
        {
        //  public virtual int Legs { get; set; }
        private int legs;

                public Animal()
                {
                    legs = 4;
                   // Legs = 4;
                }

        public int Legs
        {
            get { return legs; }
            set { legs = value; }
        }

        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Describe()
        {
            return "I am an animal and i have " + Legs + " legs.";
        }

        public override string ToString()
        {
            // return "I am an animal and i have "+Legs+" legs.";
            return Describe();
        }
    }

    public class Man : IHasLegs
    {
        private int legs;

        public Man()
        {
            legs = 2;
        }

        //public override int Legs { get => base.Legs; set => base.Legs = value; }
        public int Legs
        {
            get { return legs; }
            set { legs = value; }
        }

        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Describe()
        {
           return "I am a man and i have " + Legs + " legs."; ;
        }

        public override string ToString()
        {
            //return "I am a man and i have " + Legs + " legs.";
            return Describe();
        }
    }

    public interface IHasLegs
    {
         int Legs { get; set; }

        string Name { get; set; }

        string Describe();
    }




    class Program
    {
       



        static void Main(string[] args)
        {
            IHasLegs an = new Animal();
            

            Console.WriteLine( an );

            IHasLegs m = new Man();
         

            Console.WriteLine( m );
            Console.ReadLine();
        }
    }
}
