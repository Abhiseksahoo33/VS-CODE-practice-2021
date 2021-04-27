using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructorExample2
{
    class Employee
    {
        int empid;
        string name;
        double Basic;

        Employee() // instance constructor 
        {
            this.empid = 01;
            this.name = "Abhisek";
            this.Basic = 2178455;
        }
        Employee(int empid, string name, double basic)  // instance constructor
        {
            this.empid = empid;
            this.name = name;
            this.Basic = basic;
        }

        //override the Tostring method 
        public override string ToString()
        {
            return "Employee number = " +empid  
                + "    name =  "+name+ 
                "      basic ="+Basic;
        }
        static void Main(string[] args)
        {
            Employee obj1 = new Employee();
            Employee obj2 = new Employee(02 , "prasad" , 54446.465);
                
            Console.WriteLine(obj1); // will call the o param constructor 
            Console.WriteLine(obj2); // will call the  param constructor 
            
        }
    }
}
