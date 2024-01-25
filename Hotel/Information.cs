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
    public partial class Information : Form
    {
        CustomerInfo ci = new CustomerInfo();

        public Information()
        {
            InitializeComponent();
        }

        private void Information_Load(object sender, EventArgs e)
        {
            DataTable log_dt = ci.read_log();
            int rowcount = log_dt.Rows.Count;
            for(int i = 0; i < rowcount; i++)
            {
                richtextbox.Text += log_dt.Rows[i][0].ToString() + Environment.NewLine;
            }
        }
    }
}
