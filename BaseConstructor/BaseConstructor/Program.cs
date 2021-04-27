using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseConstructor
{


    class Employee
    {
        int empid;
        string name;
        double basic;

        public Employee(int empid , string name , double basic)
        {
            this.empid = empid;
            this.name = name;
            this.basic = basic;


        }

        public override string ToString()
        {
            return  "Employee id "+  empid +  " \nEmployee name : "+name+ " \nbasic "+basic  ;
        }

    }
    class Manager :Employee
    {
        public Manager(int empid , string name , double basic ):base(empid,name,basic) // used to pass the object to the base class 
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Manager obj = new Manager(01,"Abhisek sahoo ",4554641);
            Console.WriteLine(obj);
        }
    }
}
