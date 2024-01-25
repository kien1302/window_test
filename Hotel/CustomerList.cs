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
    public partial class customerlist : Form
    {
        CustomerInfo ci = new CustomerInfo();

        public customerlist()
        {
            InitializeComponent();
        }

        public void customerlist_grid_load()
        {
            customerlist_grid.RowTemplate.Height = 45;
            customerlist_grid.DataSource = ci.getcustomerlist();
            customerlist_grid.Columns[0].Width = 30;
            customerlist_grid.Columns[1].Width = 30;
            customerlist_grid.Columns[2].Width = 30;
            customerlist_grid.Columns[3].Width = 30;
            customerlist_grid.Columns[4].Width = 30;
            customerlist_grid.Columns[5].Width = 80;
            customerlist_grid.AllowUserToResizeColumns = false;
        }

        private void customerlist_Load(object sender, EventArgs e)
        {
            customerlist_grid.DataSource = ci.getcustomerlist();
        }
    }
}
