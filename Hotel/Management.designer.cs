
namespace Hotel
{
    partial class Management
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.customer_box = new System.Windows.Forms.TextBox();
            this.rid_label = new System.Windows.Forms.Label();
            this.roomtype_lb = new System.Windows.Forms.Label();
            this.sdate_lb = new System.Windows.Forms.Label();
            this.roomtype_box = new System.Windows.Forms.TextBox();
            this.fname_label = new System.Windows.Forms.Label();
            this.update_btn = new System.Windows.Forms.Button();
            this.remove_btn = new System.Windows.Forms.Button();
            this.manage_grid = new System.Windows.Forms.DataGridView();
            this.rid_box = new System.Windows.Forms.ComboBox();
            this.sdate_box = new System.Windows.Forms.DateTimePicker();
            this.status_box = new System.Windows.Forms.TextBox();
            this.status_lb = new System.Windows.Forms.Label();
            this.edate_box = new System.Windows.Forms.DateTimePicker();
            this.edate_lb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.manage_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // refresh_btn
            // 
            this.refresh_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.refresh_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh_btn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.refresh_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.refresh_btn.Location = new System.Drawing.Point(225, 365);
            this.refresh_btn.Margin = new System.Windows.Forms.Padding(2);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(68, 30);
            this.refresh_btn.TabIndex = 38;
            this.refresh_btn.Text = "Refresh";
            this.refresh_btn.UseVisualStyleBackColor = false;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // customer_box
            // 
            this.customer_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.customer_box.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.customer_box.ForeColor = System.Drawing.Color.White;
            this.customer_box.Location = new System.Drawing.Point(142, 110);
            this.customer_box.Margin = new System.Windows.Forms.Padding(2);
            this.customer_box.Name = "customer_box";
            this.customer_box.Size = new System.Drawing.Size(151, 21);
            this.customer_box.TabIndex = 1;
            this.customer_box.TextChanged += new System.EventHandler(this.customer_box_TextChanged);
            // 
            // rid_label
            // 
            this.rid_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.rid_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rid_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rid_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rid_label.Location = new System.Drawing.Point(36, 64);
            this.rid_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rid_label.Name = "rid_label";
            this.rid_label.Size = new System.Drawing.Size(90, 23);
            this.rid_label.TabIndex = 19;
            this.rid_label.Text = "Room ID";
            this.rid_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // roomtype_lb
            // 
            this.roomtype_lb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.roomtype_lb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomtype_lb.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomtype_lb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.roomtype_lb.Location = new System.Drawing.Point(36, 162);
            this.roomtype_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.roomtype_lb.Name = "roomtype_lb";
            this.roomtype_lb.Size = new System.Drawing.Size(90, 23);
            this.roomtype_lb.TabIndex = 21;
            this.roomtype_lb.Text = "Type";
            this.roomtype_lb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sdate_lb
            // 
            this.sdate_lb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.sdate_lb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sdate_lb.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdate_lb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sdate_lb.Location = new System.Drawing.Point(36, 260);
            this.sdate_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sdate_lb.Name = "sdate_lb";
            this.sdate_lb.Size = new System.Drawing.Size(90, 23);
            this.sdate_lb.TabIndex = 22;
            this.sdate_lb.Text = "Entry Date";
            this.sdate_lb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // roomtype_box
            // 
            this.roomtype_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.roomtype_box.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.roomtype_box.ForeColor = System.Drawing.Color.White;
            this.roomtype_box.Location = new System.Drawing.Point(142, 162);
            this.roomtype_box.Margin = new System.Windows.Forms.Padding(2);
            this.roomtype_box.Name = "roomtype_box";
            this.roomtype_box.ReadOnly = true;
            this.roomtype_box.Size = new System.Drawing.Size(151, 21);
            this.roomtype_box.TabIndex = 2;
            // 
            // fname_label
            // 
            this.fname_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.fname_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fname_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fname_label.Location = new System.Drawing.Point(35, 110);
            this.fname_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fname_label.Name = "fname_label";
            this.fname_label.Size = new System.Drawing.Size(90, 23);
            this.fname_label.TabIndex = 20;
            this.fname_label.Text = "Customer";
            this.fname_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.update_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_btn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.update_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.update_btn.Location = new System.Drawing.Point(39, 365);
            this.update_btn.Margin = new System.Windows.Forms.Padding(2);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(68, 30);
            this.update_btn.TabIndex = 13;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_Click);
            // 
            // remove_btn
            // 
            this.remove_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.remove_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.remove_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remove_btn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.remove_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.remove_btn.Location = new System.Drawing.Point(132, 365);
            this.remove_btn.Margin = new System.Windows.Forms.Padding(2);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(68, 30);
            this.remove_btn.TabIndex = 14;
            this.remove_btn.Text = "Remove";
            this.remove_btn.UseVisualStyleBackColor = false;
            this.remove_btn.Click += new System.EventHandler(this.remove_Click);
            // 
            // manage_grid
            // 
            this.manage_grid.AllowUserToAddRows = false;
            this.manage_grid.AllowUserToDeleteRows = false;
            this.manage_grid.AllowUserToResizeColumns = false;
            this.manage_grid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.manage_grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.manage_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.manage_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.manage_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.manage_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.manage_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.manage_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.manage_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.manage_grid.ColumnHeadersHeight = 30;
            this.manage_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.manage_grid.DefaultCellStyle = dataGridViewCellStyle3;
            this.manage_grid.EnableHeadersVisualStyles = false;
            this.manage_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.manage_grid.Location = new System.Drawing.Point(326, 64);
            this.manage_grid.Margin = new System.Windows.Forms.Padding(2);
            this.manage_grid.Name = "manage_grid";
            this.manage_grid.ReadOnly = true;
            this.manage_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.manage_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.manage_grid.RowHeadersVisible = false;
            this.manage_grid.RowHeadersWidth = 51;
            this.manage_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.manage_grid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.manage_grid.RowTemplate.Height = 24;
            this.manage_grid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.manage_grid.Size = new System.Drawing.Size(759, 332);
            this.manage_grid.TabIndex = 26;
            this.manage_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.manageGrid_CellContentClick);
            // 
            // rid_box
            // 
            this.rid_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.rid_box.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.rid_box.ForeColor = System.Drawing.Color.White;
            this.rid_box.FormattingEnabled = true;
            this.rid_box.Location = new System.Drawing.Point(142, 63);
            this.rid_box.Name = "rid_box";
            this.rid_box.Size = new System.Drawing.Size(151, 21);
            this.rid_box.TabIndex = 37;
            this.rid_box.SelectedIndexChanged += new System.EventHandler(this.rid_box_SelectedIndexChanged);
            // 
            // sdate_box
            // 
            this.sdate_box.CalendarFont = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdate_box.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.sdate_box.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.sdate_box.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.sdate_box.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.sdate_box.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.sdate_box.CustomFormat = "        MM /  dd  / yyyy";
            this.sdate_box.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.sdate_box.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.sdate_box.Location = new System.Drawing.Point(142, 262);
            this.sdate_box.Margin = new System.Windows.Forms.Padding(2);
            this.sdate_box.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.sdate_box.MinDate = new System.DateTime(2021, 5, 1, 0, 0, 0, 0);
            this.sdate_box.Name = "sdate_box";
            this.sdate_box.RightToLeftLayout = true;
            this.sdate_box.Size = new System.Drawing.Size(151, 21);
            this.sdate_box.TabIndex = 32;
            this.sdate_box.Value = new System.DateTime(2021, 11, 1, 0, 0, 0, 0);
            // 
            // status_box
            // 
            this.status_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.status_box.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.status_box.ForeColor = System.Drawing.Color.White;
            this.status_box.Location = new System.Drawing.Point(142, 210);
            this.status_box.Margin = new System.Windows.Forms.Padding(2);
            this.status_box.Name = "status_box";
            this.status_box.ReadOnly = true;
            this.status_box.Size = new System.Drawing.Size(151, 21);
            this.status_box.TabIndex = 33;
            // 
            // status_lb
            // 
            this.status_lb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.status_lb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.status_lb.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_lb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.status_lb.Location = new System.Drawing.Point(36, 210);
            this.status_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.status_lb.Name = "status_lb";
            this.status_lb.Size = new System.Drawing.Size(90, 23);
            this.status_lb.TabIndex = 34;
            this.status_lb.Text = "Status";
            this.status_lb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // edate_box
            // 
            this.edate_box.CalendarFont = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edate_box.CalendarForeColor = System.Drawing.Color.Black;
            this.edate_box.CalendarMonthBackground = System.Drawing.Color.Black;
            this.edate_box.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.edate_box.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.edate_box.CustomFormat = "        MM /  dd  / yyyy";
            this.edate_box.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.edate_box.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.edate_box.Location = new System.Drawing.Point(142, 317);
            this.edate_box.Margin = new System.Windows.Forms.Padding(2);
            this.edate_box.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.edate_box.MinDate = new System.DateTime(2021, 5, 2, 0, 0, 0, 0);
            this.edate_box.Name = "edate_box";
            this.edate_box.RightToLeftLayout = true;
            this.edate_box.Size = new System.Drawing.Size(151, 21);
            this.edate_box.TabIndex = 36;
            this.edate_box.Value = new System.DateTime(2021, 11, 1, 0, 0, 0, 0);
            // 
            // edate_lb
            // 
            this.edate_lb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.edate_lb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edate_lb.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edate_lb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.edate_lb.Location = new System.Drawing.Point(36, 315);
            this.edate_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.edate_lb.Name = "edate_lb";
            this.edate_lb.Size = new System.Drawing.Size(90, 23);
            this.edate_lb.TabIndex = 35;
            this.edate_lb.Text = "Depart Date";
            this.edate_lb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1134, 456);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.rid_box);
            this.Controls.Add(this.edate_box);
            this.Controls.Add(this.edate_lb);
            this.Controls.Add(this.status_box);
            this.Controls.Add(this.status_lb);
            this.Controls.Add(this.sdate_box);
            this.Controls.Add(this.manage_grid);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.roomtype_box);
            this.Controls.Add(this.customer_box);
            this.Controls.Add(this.sdate_lb);
            this.Controls.Add(this.roomtype_lb);
            this.Controls.Add(this.fname_label);
            this.Controls.Add(this.rid_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Management";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management";
            this.Load += new System.EventHandler(this.Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.manage_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.TextBox customer_box;
        private System.Windows.Forms.Label rid_label;
        private System.Windows.Forms.Label roomtype_lb;
        private System.Windows.Forms.Label sdate_lb;
        private System.Windows.Forms.TextBox roomtype_box;
        private System.Windows.Forms.Label fname_label;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.DataGridView manage_grid;
        private System.Windows.Forms.ComboBox rid_box;
        private System.Windows.Forms.DateTimePicker sdate_box;
        private System.Windows.Forms.TextBox status_box;
        private System.Windows.Forms.Label status_lb;
        private System.Windows.Forms.DateTimePicker edate_box;
        private System.Windows.Forms.Label edate_lb;
    }
}