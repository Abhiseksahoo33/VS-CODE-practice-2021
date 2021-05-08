using System;
using System.Collections.Generic;
using System.Text;


//added a  entity class 
namespace ClsEmployeeDllFile
{
    public class Employee
    {

        public int Empno { get; set; }
        public string Name { get; set; }
        public double Basic { get; set; }

        public override string ToString()
        {
            return "Employee ID : " + Empno + " Name  " + Name + "  Basic  " + Basic;
        }
    }
}
