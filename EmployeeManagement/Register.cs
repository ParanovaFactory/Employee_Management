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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        SQLConnection conn = new SQLConnection();

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into LoginInfo (UserName, Password) values(@p1,@p2)", conn.connection());

                cmd.Parameters.AddWithValue("@p1", TxtUserName.Text);
                cmd.Parameters.AddWithValue("@p2", TxtPassword.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("You have beend registered");

                conn.connection().Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Enter the invalid value");
                throw;
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LlblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
