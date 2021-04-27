using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readname
{
    class Program
    {
        static void Main(string[] args)
        {
            String name;
            Console.WriteLine("Enter your name ");
           // Console.Write("Enter your name "); will print the name on the same line 

            name = Console.ReadLine();
            Console.WriteLine("Your name is : "+name);
        }
    }
}
