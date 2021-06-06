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

namespace CreateRDLC_App_Demo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.emp_info' table. You can move, or remove it, as needed.
           // this.emp_infoTableAdapter.Fill(this.DataSet1.emp_info);

            this.reportViewer1.RefreshReport();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=ABHI-SEK\MSSQLSERVER01;Initial Catalog=Empdb;User ID=sa;Password=abhip0215#");

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from Emp_info", connection);
            SqlDataAdapter d = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            d.Fill(dt);
            reportViewer1.LocalReport.DataSources.Clear(); // clear the report viewer initially ..
            ReportDataSource source = new ReportDataSource("DataSet1",dt);
            reportViewer1.LocalReport.ReportPath =@"F:\VS 2019\CODE\CreateRDLC_App_Demo1\CreateRDLC_App_Demo1\Report1.rdlc";// path is not mentioned the rdlc report will be place inside the bin/debug folder .
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.RefreshReport();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
