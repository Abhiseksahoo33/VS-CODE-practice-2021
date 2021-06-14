using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Employee_Crud_Webform
{
    public partial class _Default : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                LoadRecord();
            }

        }
        SqlConnection con = new SqlConnection(@"Data Source=ABHI-SEK\MSSQLSERVER01;Initial Catalog=sqlpractice;Persist Security Info=True;User ID=sa;Password=abhip0215#");

        protected void Button1_Click(object sender, EventArgs e)
        {


            con.Open();
            SqlCommand comm = new SqlCommand("Insert into Emp values('"+int.Parse(TextBox4.Text)+"','" +TextBox2.Text +"','" +DropDownList1.SelectedValue +"','" +DropDownList2.SelectedValue +"','" +int.Parse(TextBox3.Text) + "');", con);
            comm.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this,this.GetType(),"script" , "alert('Successfully Inserted ');",true);
            LoadRecord();
        }

        void LoadRecord()
        {
            SqlCommand comm = new SqlCommand("select * from Emp", con);
            SqlDataAdapter d = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand comm = new SqlCommand("update  Emp set Name='"+ TextBox2.Text+ "',dept='" + DropDownList1.SelectedValue + "',desig='" + DropDownList2.SelectedValue + "',basic='" + int.Parse(TextBox3.Text) + "' where Empno='"+int.Parse(TextBox4.Text)+"'", con);
            comm.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Updated');", true);
            LoadRecord();

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand comm = new SqlCommand("Delete  Emp  where Empno='" + int.Parse(TextBox4.Text) + "'", con);
            comm.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Deleted');", true);
            LoadRecord();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("select * from Emp where Empno='" + int.Parse(TextBox4.Text) + "'", con);
            SqlDataAdapter d = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void GETButton5_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand comm = new SqlCommand("select * from Emp where Empno='" + int.Parse(TextBox4.Text) + "'", con);
            SqlDataReader r = comm.ExecuteReader();
            while(r.Read())
            {
                TextBox2.Text = r.GetValue(1).ToString();
                DropDownList1.SelectedValue = r.GetValue(2).ToString();
                DropDownList2.SelectedValue = r.GetValue(3).ToString();
                TextBox3.Text = r.GetValue(4).ToString();
            }
        }

        protected void ShowAllButton6_Click(object sender, EventArgs e)
        {
            LoadRecord();

        }

        protected void DeleteAllButton7_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand comm = new SqlCommand("Delete from  Emp", con);
            comm.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Deleted');", true);
            LoadRecord();
        }

        protected void RDLCButton8_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Employee_SelectAll"; // stored procedure 
            cmd.CommandType = System.Data.CommandType.StoredProcedure;  // telling system that it is a stored procedure 
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            con.Close();

            rv.LocalReport.DataSources.Add(new Microsoft.Reporting.WebForms.ReportDataSource("DataSet1", dt));
            rv.LocalReport.ReportPath = Server.MapPath("~/Report/Report.rdlc");
            rv.LocalReport.EnableHyperlinks = true;
        }

        
    }
}