using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Employee_CRUD_RDLC_webapp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string ConnectionString = @"Data Source=ABHI-SEK\MSSQLSERVER01;Initial Catalog=sqlpractice;Persist Security Info=True;User ID=sa;Password=abhip0215# ";
        protected void Page_Load(object sender, EventArgs e)
        {

        } 
        protected void btnClick_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Employee_SelectAll"; // stored procedure 
            cmd.CommandType = System.Data.CommandType.StoredProcedure;  // telling system that it is a stored procedure 
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            conn.Close();

            rv.LocalReport.DataSources.Add(new Microsoft.Reporting.WebForms.ReportDataSource("DataSet1", dt));
            rv.LocalReport.ReportPath = Server.MapPath("~/Report/Report.rdlc");
            rv.LocalReport.EnableHyperlinks = true;

        }
        
    }
}