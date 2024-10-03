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

namespace EmployeeManagement
{
    public partial class Charts : Form
    {
        public Charts()
        {
            InitializeComponent();
        }

        SQLConnection conn = new SQLConnection();

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Charts_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select EmpCity,count(EmpCity) from TblEmployee group by EmpCity", conn.connection());
            SqlCommand cmd1 = new SqlCommand("Select EmpJob,avg(EmpSalary) from TblEmployee group by EmpJob", conn.connection());
            SqlCommand cmd2 = new SqlCommand("Select EmpJob,count(EmpJob) from TblEmployee group by EmpJob", conn.connection());

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) 
            { 
                chartCity.Series["Employee City"].Points.AddXY(reader[0], reader[1]);
            }
            reader.Close();

            SqlDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                chartSalary.Series["Average Salary"].Points.AddXY(reader1[0], reader1[1]);
            }
            reader1.Close();

            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                chartJob.Series["Employee Job"].Points.AddXY(reader2[0], reader2[1]);
            }
            reader2.Close();
        }
    }
}
