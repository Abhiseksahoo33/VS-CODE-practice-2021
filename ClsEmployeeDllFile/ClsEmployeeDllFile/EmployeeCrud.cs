using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// creating with class library file .. 
namespace ClsEmployeeDllFile
{
    public class EmployeeCrud
    {
        
        static List<Employee> employeeList;
        static EmployeeCrud()
        {
            employeeList = new List<Employee>();

        }

        //Adding of employee
        public string AddEmployee(Employee employee)
        {
            employeeList.Add(employee);
            return " Employee details added successfully....";
        }

        // showing employee details 
        public List<Employee> Show()
        {
            return employeeList;
        }

        //search employee details by empno 
        public static Employee SearchEmployee(int empno)
        {
            Employee employee = null;
            foreach (Employee e in employeeList)
            {
                if (e.Empno == empno)
                {
                    employee = e;
                }
            }
            return employee;
        }

        // delete employee details by empno

        public string DeleteEmployee(int empno)
        {
            Employee employee = SearchEmployee(empno);
            if (employee != null)
            {
                employeeList.Remove(employee);
                return "Employee details removed ";
            }
            return "Details not found";
        }

        //update employee details 
        public string UpdateEmployee(Employee updEmployee)
        {
            Employee res = SearchEmployee(updEmployee.Empno);
            if (res != null)
            {
                foreach (Employee employee in employeeList)
                {
                    if (employee.Empno == updEmployee.Empno)
                    {
                        employee.Name = updEmployee.Name;
                        employee.Basic = updEmployee.Basic;

                    }
                }
                return "Record Updated ";

            }
            return "Record not found";

        }

        
    }
}
