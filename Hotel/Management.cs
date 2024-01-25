using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Hotel
{
    public partial class Management : Form
    {
        Room ro = new Room();
        DB db = new DB();

        public Management()
        {
            InitializeComponent();
        }

        public void room_id_box_Load()
        {
            rid_box.ValueMember = "rid";
            rid_box.DisplayMember = "rid";
            rid_box.DataSource = ro.getallroom();
            rid_box.SelectedIndex = -1;
        }

        public void manange_grid_Load()
        {
            manage_grid.RowTemplate.Height = 38;
            manage_grid.DataSource = ro.getallroom_name();      
            manage_grid.Columns[0].Width = 40;
            manage_grid.Columns[1].Width = 60;
            manage_grid.Columns[2].Width = 50;
            manage_grid.Columns[3].Width = 50;
            manage_grid.Columns[4].Width = 60;
            manage_grid.Columns[5].Width = 60;
            manage_grid.Columns[6].Width = 40;
            manage_grid.Columns[7].Width = 80;
            manage_grid.Columns[7].DefaultCellStyle.Format = "C";
            manage_grid.AllowUserToResizeColumns = false;
        }

        private void Management_Load(object sender, EventArgs e)
        {
            room_id_box_Load();
            manange_grid_Load();
        }

        private void rid_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int rid = Convert.ToInt32(rid_box.SelectedValue);
                DataTable dt = new DataTable();
                dt = ro.getroomorderbyid(rid);
                customer_box.Text = dt.Rows[0][0].ToString();
                roomtype_box.Text = dt.Rows[0][1].ToString();
                status_box.Text = dt.Rows[0][2].ToString();
                sdate_box.Value = Convert.ToDateTime(dt.Rows[0][3].ToString());
                edate_box.Value = Convert.ToDateTime(dt.Rows[0][4].ToString());
            }
            catch 
            {
                customer_box.Text = "";
                roomtype_box.Text = "";
                status_box.Text = "";
                sdate_box.Value = DateTime.Now;
                edate_box.Value = DateTime.Now;
            }
        }

        private void remove_Click(object sender, EventArgs e)
        {
            try
            {
                int rid = Convert.ToInt32(rid_box.Text);
                string customer = customer_box.Text;
       
                if (MessageBox.Show("Confirm to remove the room order?", "Remove order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ro.roomorder_delete(rid))
                    {
                        ro.customer_del_rid(customer);
                        ro.update_price();
                        MessageBox.Show("Order removed", "Remove order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        customer_box.Text = "";
                        sdate_box.Value = DateTime.Now;
                        edate_box.Value = DateTime.Now;
                    }
                    else
                    {
                        MessageBox.Show("Order is not removed, check again", "Remove order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {

            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                int rid = Convert.ToInt32(rid_box.Text);
                string customer = customer_box.Text;
                string type = roomtype_box.Text;
                string status = status_box.Text;
                DateTime sdate = sdate_box.Value;
                DateTime edate = edate_box.Value;
                if(ro.roomorder_update(rid,customer,type,status,sdate,edate))
                {
                    ro.customer_add_rid(customer, rid);
                    ro.update_price();
                    MessageBox.Show("Done", "Room Order", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Fail, check again", "Room Order", MessageBoxButtons.OK);
                }
            }       
        }

        private void manageGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex > -1 && manage_grid.Rows[e.RowIndex].Cells[e.ColumnIndex] != null)
                {
                    int rid = Convert.ToInt32(manage_grid.Rows[e.RowIndex].Cells[0].Value.ToString());
                    SqlCommand cmd = new SqlCommand("select rid, username, roomtype, status, sdate, edate from RoomOrder WHERE rid =" + rid, db.GetConnection);
                    db.openConnection();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                    rid_box.Text = (sdr["rid"].ToString());
                    if (sdr["username"].ToString() == "")
                    {
                        customer_box.Text = "";
                    }
                    else
                    {
                        customer_box.Text = (sdr["username"].ToString());
                    }
                    roomtype_box.Text = (sdr["roomtype"].ToString());
                    status_box.Text = (sdr["status"].ToString());
                    if (sdr["sdate"].ToString() == "" || sdr["edate"].ToString() == "")
                    {
                        sdate_box.Value = DateTime.Now;
                        edate_box.Value = DateTime.Now;
                    }
                    else
                    {
                        sdate_box.Value = Convert.ToDateTime(sdr["sdate"].ToString());
                        edate_box.Value = Convert.ToDateTime(sdr["edate"].ToString());
                    }
                }
                db.closeConnection();
                }
            }

        bool verif()
        {
            if ((rid_box.Text.Trim() == "")
                || (roomtype_box.Text.Trim() == "")
                || (status_box.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void customer_box_TextChanged(object sender, EventArgs e)
        {
            if(customer_box.Text != null)
                status_box.Text = "no";
            if (customer_box.Text == "")
                status_box.Text = "yes";
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            manange_grid_Load();
        }

    }
}
