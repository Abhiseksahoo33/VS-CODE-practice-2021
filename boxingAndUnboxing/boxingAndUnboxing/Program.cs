using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boxingAndUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 12;
            string s = "abhisek";
              

            //boxing 
            object x1 = x;
            object x2 = s;


            //unboxing object(refrence type) type to value type
            int y1 = (Int32)x1;
            String y2 = (String)x2;

            Console.WriteLine(x1);
            Console.WriteLine(x2);
            Console.WriteLine(y1);
            Console.WriteLine(y2);
           

        }
    }
}
