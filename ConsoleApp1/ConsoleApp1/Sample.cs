using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface I1
    {
        void View();
    }
    interface I2
    {
        void View();
    }
    class Demo:I1
    {
        public void View()
        {
            Console.WriteLine("Interfaec I1 Method");
        }
        public void View1()
        {
            Console.WriteLine("Demo class Method");
        }
        public void Display()
        {
            Console.WriteLine("Demo class hello Demo");
        }
        public virtual void Print()
        {
            Console.WriteLine("Sample class hello");
        }
    }
    class Sample: Demo
    {
        public override void Print()
        {
            Console.WriteLine(Sample class hello);
        }
    }

    class Sample : Demo
    {
        public override void Print()
        {
            Console.WriteLine("Sample class hello");
        }
    }


    class program
    {
        public static void Main(string [] args)
        {
            Demo sap = new Sample();
            sap.Print();
            sap.Display();
            sap.View1();
            sap.View2();
        }
    }


}
