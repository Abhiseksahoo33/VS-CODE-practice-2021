using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
   static class Program
    {


        public static void m1()
        {
            Console.WriteLine("inside static method m1()");
        }
        public static void m2()
        {
            Console.WriteLine("inside static method m2()");
        }


        /*
        	'm3': cannot declare instance members in a static class	Static 
       
        public  void m3()
        {
            Console.WriteLine("inside static method m3()");  
        }

        */
        static void Main(string[] args)
        {
            Program.m1();
            Program.m2(); // called using class name 
        }
    }
}
