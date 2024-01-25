using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Register : Form
    {
        User us = new User();
        Login lo = new Login();

        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            lo.Show();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            if (verif())
            { 
            string username = username_box.Text;
            string password = password_box.Text;
            string displayname = displayname_box.Text;
            string gender = gender_box.Text;
            int year = Convert.ToInt32(year_box.Text);
            int inumber = Convert.ToInt32(inumber_box.Text);
            int phone = Convert.ToInt32(phone_box.Text);
            
                if (us.auth_register(username, password, displayname) && us.info_register(username,year,gender,phone,inumber))
                {
                    MessageBox.Show("Register successful", "Register", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Check the information again", "Register", MessageBoxButtons.OK);
            }
        }

        bool verif()
        {
            if ((username_box.Text.Trim() == "")
            || (password_box.Text.Trim() == "")
            || (displayname_box.Text.Trim() == "")
            || (gender_box.Text.Trim() == "")
            || (inumber_box.Text.Trim() == "") 
            || (year_box.Text.Trim() == "")
            || (phone_box.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
