using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_RDLC_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Employee_info_DataSet1.Emp' table. You can move, or remove it, as needed.
          ///  this.EmpTableAdapter.Fill(this.Employee_info_DataSet1.Emp);

            this.reportViewer1.RefreshReport();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=ABHI-SEK\MSSQLSERVER01;Initial Catalog=sqlpractice;Persist Security Info=True;User ID=sa;Password=abhip0215#");
        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand command = new SqlCommand("Select * from Emp", connection);
            SqlDataAdapter d = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            d.Fill(dt);
            reportViewer1.LocalReport.DataSources.Clear(); // clear the report viewer initially ..
            ReportDataSource source = new ReportDataSource("Employee_info_DataSet1", dt);
            reportViewer1.LocalReport.ReportPath = @"F:\VS 2019\CODE\Employee_RDLC_Demo\Employee_RDLC_Demo\Employe_info_Report1.rdlc";// path is not mentioned the rdlc report will be place inside the bin/debug folder .
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.RefreshReport();
        }
    }
}
