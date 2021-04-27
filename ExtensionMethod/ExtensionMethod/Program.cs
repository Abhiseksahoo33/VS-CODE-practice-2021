using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    class Program
    {

        public static string Sayhello(this string)
        {
            return "  Good evening ";
        }
        static void Main(string[] args)
        {
            string s1 = "welcome to dotnet programming ...";
            Console.WriteLine(s1);
            Console.WriteLine("length of the string is : "+s1.Length);
            Console.WriteLine(s1.Sayhello());

        }
    }
}
