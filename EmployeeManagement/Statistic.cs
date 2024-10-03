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
    public partial class Statistic : Form
    {
        public Statistic()
        {
            InitializeComponent();
        }

        SQLConnection conn = new SQLConnection();

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select count(*) from TblEmployee", conn.connection());
            SqlCommand cmd1 = new SqlCommand("select count(*) from TblEmployee where EmpMarryStatus = 1", conn.connection());
            SqlCommand cmd2 = new SqlCommand("select count(*) from TblEmployee where EmpMarryStatus = 0", conn.connection());
            SqlCommand cmd3 = new SqlCommand("select count(distinct(EmpCity)) from TblEmployee", conn.connection());
            SqlCommand cmd4 = new SqlCommand("select sum(EmpSalary) from TblEmployee", conn.connection());
            SqlCommand cmd5 = new SqlCommand("select avg(EmpSalary) from TblEmployee", conn.connection());

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LblNumOfEmp.Text = dr.GetValue(0).ToString();
            }
            dr.Close();

            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                LblMarryEmp.Text = dr1.GetValue(0).ToString();
            }
            dr1.Close();

            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                LblSingleEmp.Text = dr2.GetValue(0).ToString();
            }
            dr2.Close();

            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                LblCity.Text = dr3.GetValue(0).ToString();
            }
            dr3.Close();

            SqlDataReader dr4 = cmd4.ExecuteReader();
            while (dr4.Read())
            {
                LblSalrySum.Text = dr4.GetValue(0).ToString();
            }
            dr4.Close();

            SqlDataReader dr5 = cmd5.ExecuteReader();
            while (dr5.Read())
            {
                LblSalryAvg.Text = dr5.GetValue(0).ToString();
            }
            dr5.Close();

            conn.connection().Close();

            MessageBox.Show("Statisticts created sucessfuly");
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
