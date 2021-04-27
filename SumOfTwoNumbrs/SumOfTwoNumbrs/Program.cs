using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTwoNumbrs
{
    class Program
    {
        public void add(int a , int b )
        {

            int c = a + b;
            Console.WriteLine("sum of {0}  and {1} is {2}", a,b,c);  // (0) = a  , (1)=b , (2)=c

        }
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("enter the two number "); // bydefault it will take input as string .
            a = Convert.ToInt32(Console.ReadLine());  // convert the string to integer format 
            b = Convert.ToInt32(Console.ReadLine());  // convert the string to integer format 
           Program obj = new  Program();
            obj.add(a,b);
        }
    }
}
