using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorHirarchy
{
    class First
    {

        static First()
        {
            Console.WriteLine("base class static constructor -02");
        }

        public First()
        {
            Console.WriteLine("base class  constructor -03");
        }
    }
    class Second :First
    {

        static Second()
        {
            Console.WriteLine("Derived  class static constructor-01 ");
        }

       public Second()
        {
            Console.WriteLine("Derived  class  constructor -04 ");
        }
    }

    class Demo
    {
        static void Main(string[] args)
        {
            Second obj = new Second();
        }
    }
}
