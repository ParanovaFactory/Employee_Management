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
    public partial class OperationPanel : Form
    {
        public OperationPanel()
        {
            InitializeComponent();
        }

        SQLConnection conn = new SQLConnection();

        void list()
        {
            SqlCommand cmd = new SqlCommand("Select * from TblEmployee", conn.connection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void Clean()
        {
            LblId.Text = " ";
            TxtName.Clear();
            TxtSurname.Clear();
            TxtJob.Clear();
            TxtSalary.Clear();
            CmbCity.Text = " ";
            RbMarry.Checked = false;
            RbSingle.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtName.Focus();
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            list();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("Insert into TblEmployee (EmpName,EmpSurname,EmpCity,EmpSalary,EmpMarryStatus,EmpJob) values(@p1,@p2,@p3,@p4,@p5,@p6)", conn.connection());
                sqlCommand.Parameters.AddWithValue("@p1", TxtName.Text);
                sqlCommand.Parameters.AddWithValue("@p2", TxtSurname.Text);
                sqlCommand.Parameters.AddWithValue("@p3", CmbCity.Text);
                sqlCommand.Parameters.AddWithValue("@p4", Convert.ToInt32(TxtSalary.Text));
                sqlCommand.Parameters.AddWithValue("@p6", TxtJob.Text);
                int ms = RbMarry.Checked ? 1 : 0;
                sqlCommand.Parameters.AddWithValue("@p5", ms);
                sqlCommand.ExecuteNonQuery();
                conn.connection().Close();
                list();
                MessageBox.Show("Emloyee has been saved");
            }
            catch (Exception)
            {
                MessageBox.Show("Enter the invalid value");

                throw;
            }
            
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("Update TblEmployee set EmpName = @p1, EmpSurname = @p2, EmpCity = @p3, EmpSalary = @p4, EmpMarryStatus = @p5, EmpJob = @p6 where EmployeeId = @p7", conn.connection());
                sqlCommand.Parameters.AddWithValue("@p1", TxtName.Text);
                sqlCommand.Parameters.AddWithValue("@p2", TxtSurname.Text);
                sqlCommand.Parameters.AddWithValue("@p3", CmbCity.Text);
                sqlCommand.Parameters.AddWithValue("@p4", Convert.ToInt32(TxtSalary.Text));
                sqlCommand.Parameters.AddWithValue("@p7", Convert.ToInt32(LblId.Text));
                sqlCommand.Parameters.AddWithValue("@p6", TxtJob.Text);
                int ms = RbMarry.Checked ? 1 : 0;
                sqlCommand.Parameters.AddWithValue("@p5", ms);
                sqlCommand.ExecuteNonQuery();
                conn.connection().Close();
                list();
                MessageBox.Show("Emloyee has been updated");
            }
            catch (Exception)
            {
                MessageBox.Show("Enter the invalid value");

                throw;
            }
            
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("Delete from TblEmployee where EmployeeId = @p1", conn.connection());
                sqlCommand.Parameters.AddWithValue("@p1", Convert.ToInt32(LblId.Text));
                sqlCommand.ExecuteNonQuery();
                conn.connection().Close();
                list();
                MessageBox.Show("Emloyee has been deleted");
            }
            catch (Exception)
            {
                MessageBox.Show("Enter the invalid value for EmployeeId");

                throw;
            }
            
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LblId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtSurname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            CmbCity.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            TxtSalary.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            TxtJob.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

            int ms = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value);

            if (ms == 1)
            {
                RbMarry.Checked = true;
                RbSingle.Checked = false;
            }
            else
            {
                RbSingle.Checked = true;
                RbMarry.Checked = false;
            }
        }

        private void BtnStatistic_Click(object sender, EventArgs e)
        {
            Statistic statistic = new Statistic();
            statistic.Show();
        }

        private void BtnChart_Click(object sender, EventArgs e)
        {
            Charts charts = new Charts();
            charts.Show();
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
        }
    }
}