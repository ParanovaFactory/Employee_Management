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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SQLConnection conn = new SQLConnection();

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from LoginInfo where UserName = @p1", conn.connection());
            cmd.Parameters.AddWithValue("@p1", TxtUserName.Text);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                LblUserName.Text = dr.GetValue(0).ToString();
                LblPassword.Text = dr.GetValue(1).ToString();
            }
            dr.Close();

            string userName = TxtUserName.Text;
            string password = TxtPassword.Text;

            if (LblUserName.Text == userName && LblPassword.Text == password)
            {
                OperationPanel operationPanel = new OperationPanel();
                operationPanel.Show();
                this.Hide();
                MessageBox.Show("Welcome");
            }
            else
            {
                MessageBox.Show("user name or Password wrong");
            }
            conn.connection().Close();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LlblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }
    }
}
