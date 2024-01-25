using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Hotel
{
    public partial class MainMenu : Form
    {
        public class MyColorTable : ProfessionalColorTable
        {
            public override Color ToolStripDropDownBackground
            {
                get
                {
                    return Color.FromArgb(70, 70, 70);
                }
            }

            public override Color ImageMarginGradientBegin
            {
                get
                {
                    return Color.FromArgb(70, 70, 70);
                }
            }

            public override Color ImageMarginGradientMiddle
            {
                get
                {
                    return Color.FromArgb(70, 70, 70);
                }
            }

            public override Color ImageMarginGradientEnd
            {
                get
                {
                    return Color.FromArgb(70, 70, 70);
                }
            }

            public override Color MenuBorder
            {
                get
                {
                    return Color.FromArgb(70, 70, 70);
                }
            }

            public override Color MenuItemBorder
            {
                get
                {
                    return Color.FromArgb(70, 70, 70);
                }
            }

            public override Color MenuItemSelected
            {
                get
                {
                    return Color.FromArgb(70, 70, 70);
                }
            }

            public override Color MenuStripGradientBegin
            {
                get
                {
                    return Color.FromArgb(70, 70, 70);
                }
            }

            public override Color MenuStripGradientEnd
            {
                get
                {
                    return Color.FromArgb(70, 70, 70);
                }
            }

            public override Color MenuItemSelectedGradientBegin
            {
                get
                {
                    return Color.FromArgb(70, 70, 70);
                }
            }

            public override Color MenuItemSelectedGradientEnd
            {
                get
                {
                    return Color.FromArgb(70, 70, 70);
                }
            }

            public override Color MenuItemPressedGradientBegin
            {
                get
                {
                    return Color.FromArgb(70, 70, 70);
                }
            }

            public override Color MenuItemPressedGradientEnd
            {
                get
                {
                    return Color.FromArgb(70, 70, 70);
                }
            }
        }

        DB db = new DB();
        Room ro = new Room();
        public MainMenu()
        {
            InitializeComponent();
            menustrip.Renderer = new ToolStripProfessionalRenderer(new MyColorTable());
        }

        private void single_grid_Load()
        {

            single_grid.RowTemplate.Height = 90;
            single_grid.DataSource = ro.getsingleroomlist();
            single_grid.AllowUserToResizeColumns = false;
            single_grid.ColumnHeadersVisible = false;
            
            foreach (DataGridViewRow row in single_grid.Rows)
            {
                row.DividerHeight = 20;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value.ToString() == "FREE")
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(65,65,65);
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(20,20,20);
                    }
                }
            }
            foreach (DataGridViewColumn col in single_grid.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
                if (col.HeaderText == "status")
                {
                    col.Width = 220;
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
        }

        private void double_grid_Load()
        {
            
            double_grid.RowTemplate.Height = 90;
            double_grid.DataSource = ro.getdoubleroomlist();
            double_grid.AllowUserToResizeColumns = false;
            double_grid.ColumnHeadersVisible = false;
            foreach (DataGridViewRow row in double_grid.Rows)
            {
                row.DividerHeight = 20;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value.ToString() == "FREE")
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(65,65,65);
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(20,20,20);
                    }
                }
            }
            foreach (DataGridViewColumn col in double_grid.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
                if (col.HeaderText == "status")
                {
                    col.Width = 220;
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
        }


        private void Main_Load(object sender, EventArgs e)
        {
            timer.Start();
            single_grid_Load();
            double_grid_Load();
            
        }

        private void button_Noti_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Close();
            DB db = new DB();
            db.closeConnection();
            Login lof = new Login();
            lof.Show();
        }

        private void MainMenu_SizeChanged(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            time_label.Text = DateTime.Now.ToString("HH:mm");
            day_label.Text = DateTime.Now.ToString("ddd");
            date_label.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void management_mitem_Click(object sender, EventArgs e)
        {
            Management ma = new Management();
            ma.Show();
        }

        private void single_grid_SelectionChanged(object sender, EventArgs e)
        {
            single_grid.ClearSelection();
        }

        private void double_grid_SelectionChanged(object sender, EventArgs e)
        {
            double_grid.ClearSelection();
        }

        private void exit_img_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            single_grid_Load();
            double_grid_Load();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void customer_mitem_Click(object sender, EventArgs e)
        {
            customerlist c = new customerlist();
            c.Show();
        }

        private void information_mitem_Click(object sender, EventArgs e)
        {
            Information i = new Information();
            i.Show();
        }
    }
    
}
