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

    public partial class CustomerAccess : Form
    {
        DB db = new DB();

        public string setusername = StaticInfo.getusername;
        public string setbook_username = StaticInfo.getbook_username;
        public string setbook_rid = StaticInfo.getbook_rid;
        public string setbook_entrydate = StaticInfo.getbook_entrydate;
        public string setbook_departdate = StaticInfo.getbook_departdate;

        CustomerInfo ci = new CustomerInfo();

        public CustomerAccess()
        {
            InitializeComponent();
        }

        public void get_free_room_load()
        {
            roomlist_grid.RowTemplate.Height = 90;
            roomlist_grid.DataSource = ci.get_free_room();
            roomlist_grid.AllowUserToResizeColumns = false;
            roomlist_grid.ColumnHeadersVisible = false;
            
            int lastcol = roomlist_grid.ColumnCount;

            foreach (DataGridViewRow row in roomlist_grid.Rows)
            {
                row.DividerHeight = 20;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value.ToString() == "no")
                    {
                        int cellcol = cell.ColumnIndex;
                        int cellrow = cell.RowIndex;
                        roomlist_grid.Rows[cellrow].Cells[cellcol - 1].Style.BackColor = Color.FromArgb(40,40,40);

                    }
                    cell.Style.BackColor = Color.FromArgb(95, 95, 95);
                }
            }

            foreach (DataGridViewColumn col in roomlist_grid.Columns)
            {
                col.DividerWidth = 24;
                if (col.HeaderText == "status")
                {
                    col.Visible = false;
                }
                roomlist_grid.Columns[lastcol - 1].Visible = false;
            }
        }

        public void checkuser()
        {
            DataTable displayname_dt = ci.getdisplayname(setusername);
            DataTable check_dt = ci.check_user_room(setusername);
            DataTable roomid_dt = ci.getuser_roomid(setusername);
            DataTable dayleft_dt = ci.getuser_room_dayleft(setusername);
            username_lb.Text = displayname_dt.Rows[0][0].ToString();
            if (check_dt.Rows[0][0].ToString() != "")
            {
                roomlist_panel.Visible = false;
                roomid_lb.Text = "Room ID:  " + roomid_dt.Rows[0][0].ToString();
                dayleft_lb.Text = "Days left:  " + dayleft_dt.Rows[0][0].ToString();
                roomidshow_lb.Visible = false;
                information_lb.Visible = false;
                booking_panel.Visible = false;
                hotelroom_img.Visible = true;
                service_panel.Visible = true;
            }
            else
            {
                roomlist_panel.Visible = true;
                roomid_lb.Visible = false;
                dayleft_lb.Visible = false;
                hotelroom_img.Visible = false;
                roomidshow_lb.Visible = true;
                information_lb.Visible = true;
                booking_panel.Visible = true;
                service_panel.Visible = false;
            }
        }

        private void CustomerAccess_Load(object sender, EventArgs e)
        {
            roomlist_grid.BackgroundColor = Color.FromArgb(50, 50, 50);
            checkuser();
            get_free_room_load();
            roomlist_grid.ClearSelection();
        }

        private void CustomerAccess_Click(object sender, EventArgs e)
        {
            roomlist_grid.ClearSelection();
        }

        private void roomlist_grid_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            
            roomlist_grid.ClearSelection();
        }

        private void roomlist_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && roomlist_grid.Rows[e.RowIndex].Cells[e.ColumnIndex] != null)
            {
                int rid = Convert.ToInt32(roomlist_grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                DataTable rid_status_dt = ci.get_status_from_rid(rid);
                if (rid_status_dt.Rows[0][0].ToString() == "no")
                {
                    roomidshow_lb.Text = "None";
                }
                else
                {
                    roomidshow_lb.Text = rid.ToString();
                }
            }
        }

        private void book_btn_Click(object sender, EventArgs e)
        {
            if (roomidshow_lb.Text == "Not Available")
            {
                MessageBox.Show("Select other room", "Booking", MessageBoxButtons.OK);
            }
            else if (roomidshow_lb.Text == "")
            {
                MessageBox.Show("Please select a room", "Booking", MessageBoxButtons.OK);
            }
            else
            {
                setbook_username = setusername;
                setbook_rid = roomidshow_lb.Text.ToString();
                setbook_entrydate = sdate_box.Value.ToString("MM/dd/yyyy");
                setbook_departdate = edate_box.Value.ToString("MM/dd/yyyy");
                string message = setbook_username + ", Room " + setbook_rid + ", ED " + setbook_entrydate + ", DD " + setbook_departdate + '\n';
                ci.store_log(message);
                MessageBox.Show("Booked Successfuly! Please wait for response", "Booking", MessageBoxButtons.OK);
            }
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Close();
            DB db = new DB();
            db.closeConnection();
            Login lof = new Login();
            lof.Show();
        }

        private void services_btn_Click(object sender, EventArgs e)
        {
            Services se = new Services();
            se.Show();
        }
    }
}
