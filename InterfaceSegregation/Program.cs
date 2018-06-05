using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{

    public interface IDevice
    {
        void Scan();
        void Print();
        void Copy();
    }

    public class MultiFunctionDevice : IDevice //IPrintDevice, IScanDevice, ICopyDevice
    { 
        public void Copy()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        public void Scan()
        {
            throw new NotImplementedException();
        }
    }
    public interface IPrintDevice
    {
        void Print();
    }

   public interface IScanDevice
    {
        void Scan();
    }


    public interface ICopyDevice
    {
        void Copy();
    }

    interface IColorPrinter : IPrintDevice
    {
        void ColorPrinting();
        


    }

    public class LaserJetColor : IColorPrinter
    {
        public void ColorPrinting()
        {
            Console.WriteLine("Printing color with laserjet");
        }

        public void Print()
        {
            ColorPrinting();
        }
    }


    public class Printer : IPrintDevice
    {
      

        public void Print()
        {
          //  throw new NotImplementedException();
        }

       
    }
    class Program
    {
      
        static void Main(string[] args)
        {
            MultiFunctionDevice mf = new MultiFunctionDevice();
            mf.Print();
            mf.Scan();
            mf.Copy();
        }
    }
}
