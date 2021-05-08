using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClsEmployeeDllFile;

//referenece is added  ClsEmployeeDllFile;


namespace DemoListExamples
{
    class Program
    {
        private static List<Employee> employeelist;

        public static void AddEmployeeMain()
        {
            Employee employee = new Employee();
            Console.WriteLine("Enter Employee Id: ");
            employee.Empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name: ");
            employee.Name = Console.ReadLine();
            Console.WriteLine("Enter the Basic: ");
            employee.Basic = Convert.ToDouble(Console.ReadLine());

            EmployeeCrud employeecrud = new EmployeeCrud();
            Console.WriteLine(employeecrud.AddEmployee(employee)); 
         }

        public static void ShowEmployeeMain()
        {
            EmployeeCrud employeecrud = new EmployeeCrud();
            employeelist = employeecrud.Show();

            foreach(Employee employee in employeelist)
            {
                Console.WriteLine(employee);
            }
        }

        public static void SearchEmployeemain()
        {
            int empno;
            Console.WriteLine("Enter the employee id :");
            empno = Convert.ToInt32(Console.ReadLine());
            EmployeeCrud employeecrud = new EmployeeCrud();
          
        }

        static void Main(string[] args)
        {
            int ch;
            do
            {
                Console.WriteLine("OPTIONS: ");
                Console.WriteLine("1 : Add Employee details ");
                Console.WriteLine("2 : Show Employee details ");
                Console.WriteLine("3 : Search Employee details");
                Console.WriteLine("4 : Delete Employee from List");
                Console.WriteLine("5 : Update Employee details  ");
                Console.WriteLine("6 : EXIT ");

                Console.WriteLine("Enter your choice  :   ");
                ch = Convert.ToInt32(Console.ReadLine());

                switch(ch)
                {
                    case 1:
                          AddEmployeeMain();
                          break;
                    case 2:
                        ShowEmployeeMain();
                        break;
                   /* case 3:
                        SearchEmployee();
                        break;
                    case 4:
                        DeleteEmployee();
                        break;
                    case 5:
                        UpdateEmployee();
                        break; */
                    case 6 :
                        return;

                    default:
                        Console.WriteLine("Invalid choice .. | Please choose between 1 to 6");
                        break;
                }
            } while (ch != 6);
        }
    }
}
