using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethod
{
    class Program
    {

        void show ()
        {
            // Console.WriteLine()  is also a static method as console is a class 
            Console.WriteLine("hello inside the show method "); 
        }


        static void display()
        {
            Console.WriteLine("inside static method called by class name");
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.show(); // called by object of class 
            Program.display(); // static method called by class name 

        }
    }
}
