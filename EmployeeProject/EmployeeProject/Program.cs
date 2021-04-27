using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProject
{
    class EmpValidate
    {

        public StringBuilder validate (Employee employ)
        {
            StringBuilder sb = new StringBuilder();
            bool flag = true;
            if(employ.empno<=0)
            {
                sb.AppendLine("Employee number is invalid :  please enter number  > 0 ");
                flag = false;
                //Console.WriteLine("invalid employee number "); will execute first then sb.Appendline 
            }
            if(employ.name.Length <=4)
            {
                sb.AppendLine("Employee name should atleast more than 4 character ");
                flag = false;
            }
            if(!employ.dept.Equals("Dotnet") || !employ.dept.Equals("Angular"))
            {
                sb.AppendLine("Either dotnet or angular only allowed ");
                flag = false;

            }
            if(flag==true)

            {
                sb.AppendLine("All validation aree passed ... ");
            }
            return sb;

        }
        static void Main(string[] args)
        {
            Employee employ = new Employee();
            Console.WriteLine("enter the employee no : ");
            employ.empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the employee name : ");
            employ.name = Console.ReadLine();
            Console.WriteLine("enter the  department : ");
            employ.dept =Console.ReadLine();
            Console.WriteLine("enter the  designation : ");
            employ.desig =Console.ReadLine();
            Console.WriteLine("enter the  basic : ");
            employ.basic = Convert.ToInt32(Console.ReadLine());

            EmpValidate obj = new EmpValidate();
            Console.WriteLine(obj.validate(employ));


        }
    }
}
