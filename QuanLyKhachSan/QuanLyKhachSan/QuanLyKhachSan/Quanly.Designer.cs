namespace QuanLyKhachSan
{
    partial class Quanly
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quanly));
            this.label3 = new System.Windows.Forms.Label();
            this.btnHotelStat = new System.Windows.Forms.Button();
            this.btnRevenueStat = new System.Windows.Forms.Button();
            this.Laphoadon = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(219, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 46);
            this.label3.TabIndex = 12;
            this.label3.Text = "MENU";
            // 
            // btnHotelStat
            // 
            this.btnHotelStat.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnHotelStat.ForeColor = System.Drawing.Color.White;
            this.btnHotelStat.Location = new System.Drawing.Point(344, 235);
            this.btnHotelStat.Name = "btnHotelStat";
            this.btnHotelStat.Size = new System.Drawing.Size(165, 33);
            this.btnHotelStat.TabIndex = 18;
            this.btnHotelStat.Text = "Thống kê khách sạn";
            this.btnHotelStat.UseVisualStyleBackColor = false;
            this.btnHotelStat.Click += new System.EventHandler(this.btnHotelStat_Click);
            // 
            // btnRevenueStat
            // 
            this.btnRevenueStat.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRevenueStat.ForeColor = System.Drawing.Color.White;
            this.btnRevenueStat.Location = new System.Drawing.Point(119, 235);
            this.btnRevenueStat.Name = "btnRevenueStat";
            this.btnRevenueStat.Size = new System.Drawing.Size(165, 33);
            this.btnRevenueStat.TabIndex = 17;
            this.btnRevenueStat.Text = "Thống kê doanh thu";
            this.btnRevenueStat.UseVisualStyleBackColor = false;
            this.btnRevenueStat.Click += new System.EventHandler(this.btnRevenueStat_Click);
            // 
            // Laphoadon
            // 
            this.Laphoadon.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Laphoadon.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Laphoadon.Image = ((System.Drawing.Image)(resources.GetObject("Laphoadon.Image")));
            this.Laphoadon.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.Laphoadon.Location = new System.Drawing.Point(348, 176);
            this.Laphoadon.Name = "Laphoadon";
            this.Laphoadon.Size = new System.Drawing.Size(122, 33);
            this.Laphoadon.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Laphoadon.TabIndex = 14;
            this.Laphoadon.Text = "Lập hóa đơn";
            this.Laphoadon.Click += new System.EventHandler(this.Laphoadon_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Image = global::QuanLyKhachSan.Properties.Resources.search_icon;
            this.buttonX1.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.buttonX1.Location = new System.Drawing.Point(122, 176);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(122, 33);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 13;
            this.buttonX1.Text = "Tìm kiếm";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // Quanly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 357);
            this.Controls.Add(this.btnHotelStat);
            this.Controls.Add(this.btnRevenueStat);
            this.Controls.Add(this.Laphoadon);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.label3);
            this.Name = "Quanly";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý (Dành cho nhân viên)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX Laphoadon;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHotelStat;
        private System.Windows.Forms.Button btnRevenueStat;
    }
}