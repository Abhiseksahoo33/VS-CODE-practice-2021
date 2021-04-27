using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMethodOverriding
{

    class First
    {
        public void show()
            
            
        {
            Console.WriteLine("Base class method .. ");
        }
    }

    class Second : First
    {
        public void show()
        {
            //base.show(); // used to call both base and derived class methods  first parent then child 
            Console.WriteLine("Derived class method .. derived class method will override the base class method  ");  // derived class method will override the base class method  - 01
        }
    }
    class Main1
    {
        static void Main(string[] args)
        {
            Second obj = new Second();
            obj.show();

        }
    }
}
