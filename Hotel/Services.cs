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
    public partial class Services : Form
    {
        Room ro = new Room();
        public string setusername = StaticInfo.getusername;

        public Services()
        {
            InitializeComponent();
        }

        public void services_grid_load()
        {
            services_grid.BackgroundColor = Color.FromArgb(50, 50, 50);
            services_grid.RowTemplate.Height = 90;
            services_grid.DataSource = ro.get_services_list();
            services_grid.Columns[1].DefaultCellStyle.Format = "C";
            services_grid.Columns[3].DefaultCellStyle.Format = "C";
            services_grid.AllowUserToResizeColumns = false;
            services_grid.ColumnHeadersVisible = false;
            int lastrow = services_grid.RowCount;

            foreach (DataGridViewRow row in services_grid.Rows)
            {
                row.DividerHeight = 15;
                services_grid.Columns[1].DividerWidth = 24;
            }
        }

        private void Services_Load(object sender, EventArgs e)
        {
            name_box.DataSource = ro.display_services_list();
            name_box.ValueMember = "sid";
            name_box.DisplayMember = "sname";
            services_grid_load();
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirm to order service?", "Ordering service", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int amount = Convert.ToInt32(amount_box.Text.ToString());
                int sid = Convert.ToInt32(name_box.SelectedValue.ToString());
                DataTable price_dt = ro.service_price_cal(sid, amount);
                double new_price = Convert.ToDouble(price_dt.Rows[0][0].ToString());
                ro.update_customer_price(new_price,setusername);
            }



        }
    }
}
