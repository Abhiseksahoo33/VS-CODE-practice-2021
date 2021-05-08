using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; // added
using System.Data.SqlClient;  // added
using System.Configuration;  // added



namespace Employeedb
{
    class Program
    {

        static void addEmployee()
        {
           
            int empno, basic;
            string name, dept, desig;
            Console.WriteLine("Enter Employee ID:");
            empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name :");
            name = Console.ReadLine();   
            Console.WriteLine("Enter Department :");
            dept = Console.ReadLine();  
            Console.WriteLine("Enter Degisnation :");
            desig = Console.ReadLine();
            Console.WriteLine("Enter Basic:");
            basic = Convert.ToInt32(Console.ReadLine());
          
            // make connection 
            String strconn = ConfigurationManager.ConnectionStrings["sqlpracticeconn"].ConnectionString;
            SqlConnection conn = new SqlConnection(strconn); // make connection the configuration (App.configuration) 
            
            SqlDataAdapter ad = new SqlDataAdapter("select * from Emp", conn);

            //commandbuilder used to reflect the changes from frontend to backend
            SqlCommandBuilder cmd = new SqlCommandBuilder(ad);

            //dataset added
            DataSet ds = new DataSet();
            ad.Fill(ds, "Emp");

            DataRow dr = ds.Tables["Emp"].NewRow(); // new row will be added to hold the data 
            dr["Empno"] = empno;
            dr["name"] = name;
            dr["dept"] = dept;
            dr["desig"] = desig;
            dr["basic"] = basic;
            ds.Tables["Emp"].Rows.Add(dr);
            ad.Update(ds, "Emp");

            Console.WriteLine("*** Record inserted successfully ***");

        }
        static void searchEmployee()
        {
            int empno;
            Console.WriteLine("Enter the Employee ID: ");
            empno = Convert.ToInt32(Console.ReadLine());
            String strconn = ConfigurationManager.ConnectionStrings["sqlpracticeconn"].ConnectionString;
            SqlConnection conn = new SqlConnection(strconn); // make connection the configuration (App.configuration) 
          
            SqlDataAdapter ad = new SqlDataAdapter("select * from Emp Where Empno=@empno", conn);
            ad.SelectCommand.Parameters.AddWithValue("@Empno", empno);
            DataSet ds = new DataSet();
            ad.Fill(ds, "Emp");
            int count = ds.Tables["Emp"].Rows.Count;
            if (count == 1)
            {
                Console.WriteLine("*****************************");
                Console.WriteLine("Employee name  :  " + ds.Tables["Emp"].Rows[0]["name"]);
                Console.WriteLine("Department     :  " + ds.Tables["Emp"].Rows[0]["dept"]);
                Console.WriteLine("Designation    :  " + ds.Tables["Emp"].Rows[0]["desig"]);
                Console.WriteLine("Basic          :  " + ds.Tables["Emp"].Rows[0]["basic"]);

            }
            else
            {
                Console.WriteLine("Data not Found ...");
            }

        }

        static void updateEmployee()
        {
            int empno, basic;
            string name, dept, desig;
            Console.WriteLine("Enter Employee ID:");
            empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name :");
            name = Console.ReadLine();
            Console.WriteLine("Enter Department :");
            dept = Console.ReadLine();
            Console.WriteLine("Enter Degisnation :");
            desig = Console.ReadLine();
            Console.WriteLine("Enter Basic:");
            basic = Convert.ToInt32(Console.ReadLine());
            String strconn = ConfigurationManager.ConnectionStrings["sqlpracticeconn"].ConnectionString;
            SqlConnection conn = new SqlConnection(strconn); // make connection the configuration (App.configuration) 

            SqlDataAdapter ad = new SqlDataAdapter("select * from Emp Where Empno=@empno", conn);
            ad.SelectCommand.Parameters.AddWithValue("@Empno", empno);
            SqlCommandBuilder cmd = new SqlCommandBuilder(ad);
            DataSet ds = new DataSet();
            ad.Fill(ds, "Emp");
            DataRow dr = ds.Tables["Emp"].Rows[0];
            if (dr != null)
            {
                dr["name"] = name;
                dr["dept"] = dept;
                dr["desig"] = desig;
                dr["basic"] = basic;
                ad.Update(ds,"Emp");
                Console.WriteLine("*** Record updated ***");

            }
            else
            {
                Console.WriteLine("ERROR _  :  Record not found ...");
            }
        }
        static void deleteEmployee()
        {
            int empno;
            Console.WriteLine("Enter Employee ID:");
            empno = Convert.ToInt32(Console.ReadLine());
          
            String strconn = ConfigurationManager.ConnectionStrings["sqlpracticeconn"].ConnectionString;
            SqlConnection conn = new SqlConnection(strconn); // make connection the configuration (App.configuration) 

            SqlDataAdapter ad = new SqlDataAdapter("select * from Emp Where Empno=@empno", conn);
            ad.SelectCommand.Parameters.AddWithValue("@Empno", empno);
            SqlCommandBuilder cmd = new SqlCommandBuilder(ad);
            DataSet ds = new DataSet();
            ad.Fill(ds, "Emp");
            DataRow dr = ds.Tables["Emp"].Rows[0];

            dr.Delete();
            ad.Update(ds, "Emp");
            Console.WriteLine("*** Record Deleted ***");
        }
        static void Main(string[] args)
        {
            int ch;
            do
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("OPTION");
                Console.WriteLine("1: Add Employee details");
                Console.WriteLine("2: Search Employee details ");
                Console.WriteLine("3: Update Employee details ");
                Console.WriteLine("4: Delete employee details ");
                Console.WriteLine("6: Exit ");
                Console.WriteLine("------------------------------");
                Console.WriteLine("Enter your choice ");
                ch = Convert.ToInt32(Console.ReadLine());

                switch(ch)

                {
                    case 1:
                        addEmployee();
                        break;
                    case 2:
                        searchEmployee();
                        break;
                    case 3:
                        updateEmployee();
                        break;
                    case 4:
                        deleteEmployee();
                        break;


                    case 6:
                        return;
                    default:
                        Console.WriteLine("Invalid choice ");
                        break;
                       

                }               
            } while (ch != 6);

        }
    }
}
