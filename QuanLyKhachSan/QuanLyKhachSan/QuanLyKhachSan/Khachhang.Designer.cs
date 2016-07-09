namespace QuanLyKhachSan
{
    partial class Khachhang
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Khachhang));
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.Datphong = new DevComponents.DotNetBar.ButtonX();
            this.Aboutbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(208, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 46);
            this.label3.TabIndex = 9;
            this.label3.Text = "MENU";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Image = global::QuanLyKhachSan.Properties.Resources.search_icon;
            this.buttonX1.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.buttonX1.Location = new System.Drawing.Point(111, 152);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(122, 33);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 10;
            this.buttonX1.Text = "Tìm kiếm";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // Datphong
            // 
            this.Datphong.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Datphong.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Datphong.Image = ((System.Drawing.Image)(resources.GetObject("Datphong.Image")));
            this.Datphong.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.Datphong.Location = new System.Drawing.Point(337, 152);
            this.Datphong.Name = "Datphong";
            this.Datphong.Size = new System.Drawing.Size(122, 33);
            this.Datphong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Datphong.TabIndex = 11;
            this.Datphong.Text = "Đặt phòng";
            this.Datphong.Click += new System.EventHandler(this.Datphong_Click);
            // 
            // Aboutbtn
            // 
            this.Aboutbtn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Aboutbtn.BackColor = System.Drawing.SystemColors.Control;
            this.Aboutbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Aboutbtn.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            this.Aboutbtn.FlatAppearance.BorderSize = 0;
            this.Aboutbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Aboutbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Aboutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Aboutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aboutbtn.ForeColor = System.Drawing.Color.Black;
            this.Aboutbtn.Location = new System.Drawing.Point(417, 13);
            this.Aboutbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Aboutbtn.Name = "Aboutbtn";
            this.Aboutbtn.Size = new System.Drawing.Size(112, 28);
            this.Aboutbtn.TabIndex = 13;
            this.Aboutbtn.Text = "Đăng xuất";
            this.Aboutbtn.UseVisualStyleBackColor = false;
            this.Aboutbtn.Click += new System.EventHandler(this.Aboutbtn_Click);
            // 
            // Khachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 317);
            this.Controls.Add(this.Aboutbtn);
            this.Controls.Add(this.Datphong);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.label3);
            this.Name = "Khachhang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX Datphong;
        public System.Windows.Forms.Button Aboutbtn;

    }
}