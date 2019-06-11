using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Sample
    {
        public void print()
        {
            Console.WriteLine("hello");
        }
    }

    class program
    {
        public static void Main(string [] args)
        {
            Sample sap = new Sample();
            sap.print();
        }
    }
}
