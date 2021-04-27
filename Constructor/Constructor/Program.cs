using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        Program() //constructor 
        {
            Console.WriteLine("normal constructor");
        }


        static Program() // static constructor 
        {
            Console.WriteLine("static constructor");
        }
        static void Main(string[] args) // will call static constructor first 
        {
            Program obj = new Program(); // will call normal constructor  second after static 

        }
    }
}
