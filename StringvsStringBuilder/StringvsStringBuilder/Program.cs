using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringvsStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder obj = new StringBuilder("Welcome to dotnet .. ");
            Console.WriteLine(obj);
            Console.WriteLine(obj.AppendLine("This is the example of stringbuilder")); // append one line 
            //Console.WriteLine(obj.Append("This is the example of stringbuilder")); // append one line with a new line space 
            Console.WriteLine(obj.Remove(5 ,10)); // remove elemts from index 5  to length 10 

        }
    }
}
