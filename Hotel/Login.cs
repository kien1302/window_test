using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotel
{
    public partial class Login : Form
    {
        User us = new User();
        DB db = new DB();

        public Login()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
        }

        private void box_UserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                password_Box.Focus();
            }
        }

        private void box_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login_btn.PerformClick();
            }
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string username = username_Box.Text;
            string password = password_Box.Text;
            string role = null;
            if (us.login(username, password))
            {
                role = us.getrole(username);
                if (role == "ma")
                {
                    MessageBox.Show("Login successful", "Login", MessageBoxButtons.OK);
                    this.Hide();
                    MainMenu mm = new MainMenu();
                    mm.Show();

                }
                else if (role == "cus")
                {
                    MessageBox.Show("Login successful", "Login", MessageBoxButtons.OK);
                    StaticInfo.getusername = username;
                    this.Hide();
                    CustomerAccess ca = new CustomerAccess();
                    ca.Show();
                }
            }
            else
            {
                MessageBox.Show("Check username or password", "Login", MessageBoxButtons.OK);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void register_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register rf = new Register();
            rf.ShowDialog();
        }
    }
}
