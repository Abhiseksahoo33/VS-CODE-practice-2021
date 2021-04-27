using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empdatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn=null;

            try
            {
                conn = new SqlConnection("integrated security=true; data source=ABHI-SEK\MSSQLSERVER01,initial catalog=Empdb");
                conn.Close();
                Console.WriteLine("CONNECTED .....");

            }
            catch (Exception e)
            {

                Console.WriteLine(e); ;
            }
            finally
                {
                if(conn!=null)
                {
                    conn.Close();
                }


            }
        }
    }
}
