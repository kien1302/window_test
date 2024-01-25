
namespace Hotel
{
    partial class Information
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
            this.richtextbox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richtextbox
            // 
            this.richtextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.richtextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.richtextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richtextbox.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richtextbox.ForeColor = System.Drawing.SystemColors.Window;
            this.richtextbox.Location = new System.Drawing.Point(12, 12);
            this.richtextbox.Name = "richtextbox";
            this.richtextbox.ReadOnly = true;
            this.richtextbox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richtextbox.Size = new System.Drawing.Size(307, 337);
            this.richtextbox.TabIndex = 0;
            this.richtextbox.Text = "";
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(331, 361);
            this.Controls.Add(this.richtextbox);
            this.Name = "Information";
            this.ShowIcon = false;
            this.Text = "Information";
            this.Load += new System.EventHandler(this.Information_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richtextbox;
    }
}