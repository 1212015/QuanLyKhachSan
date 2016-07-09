namespace QuanLyKhachSan
{
    partial class Laphoadon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbKhachsan = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaphong = new System.Windows.Forms.TextBox();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtthanhtoan = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgPhong = new System.Windows.Forms.DataGridView();
            this.BTOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.progressControl = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.cbKhachsan);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtMaphong);
            this.panel1.Controls.Add(this.txtTien);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtthanhtoan);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtgPhong);
            this.panel1.Location = new System.Drawing.Point(28, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 469);
            this.panel1.TabIndex = 4;
            // 
            // cbKhachsan
            // 
            this.cbKhachsan.FormattingEnabled = true;
            this.cbKhachsan.Location = new System.Drawing.Point(334, 245);
            this.cbKhachsan.Name = "cbKhachsan";
            this.cbKhachsan.Size = new System.Drawing.Size(170, 24);
            this.cbKhachsan.TabIndex = 16;
            this.cbKhachsan.SelectedIndexChanged += new System.EventHandler(this.cbKhachsan_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Danh sách đặt phòng của khách sạn :";
            // 
            // txtMaphong
            // 
            this.txtMaphong.Location = new System.Drawing.Point(241, 207);
            this.txtMaphong.Name = "txtMaphong";
            this.txtMaphong.Size = new System.Drawing.Size(200, 22);
            this.txtMaphong.TabIndex = 14;
            // 
            // txtTien
            // 
            this.txtTien.Location = new System.Drawing.Point(241, 154);
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(200, 22);
            this.txtTien.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Thành tiền";
            // 
            // dtthanhtoan
            // 
            this.dtthanhtoan.Location = new System.Drawing.Point(241, 101);
            this.dtthanhtoan.Name = "dtthanhtoan";
            this.dtthanhtoan.Size = new System.Drawing.Size(200, 22);
            this.dtthanhtoan.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(91, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Mã đặt phòng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(91, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ngày thanh toán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vui lòng điền đầy đủ thông tin";
            // 
            // dtgPhong
            // 
            this.dtgPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPhong.Location = new System.Drawing.Point(32, 284);
            this.dtgPhong.Name = "dtgPhong";
            this.dtgPhong.RowTemplate.Height = 24;
            this.dtgPhong.Size = new System.Drawing.Size(482, 159);
            this.dtgPhong.TabIndex = 0;
            // 
            // BTOK
            // 
            this.BTOK.Location = new System.Drawing.Point(492, 560);
            this.BTOK.Name = "BTOK";
            this.BTOK.Size = new System.Drawing.Size(98, 32);
            this.BTOK.TabIndex = 12;
            this.BTOK.Text = "Xác nhận";
            this.BTOK.UseVisualStyleBackColor = true;
            this.BTOK.Click += new System.EventHandler(this.BTOK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 46);
            this.label2.TabIndex = 15;
            this.label2.Text = "LẬP HÓA ĐƠN";
            // 
            // progressControl
            // 
            this.progressControl.Location = new System.Drawing.Point(28, 560);
            this.progressControl.Name = "progressControl";
            this.progressControl.Size = new System.Drawing.Size(89, 23);
            this.progressControl.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressControl.TabIndex = 16;
            // 
            // Laphoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(602, 595);
            this.Controls.Add(this.progressControl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTOK);
            this.Controls.Add(this.panel1);
            this.Name = "Laphoadon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập hóa đơn";
            this.Load += new System.EventHandler(this.Laphoadon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtthanhtoan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgPhong;
        private System.Windows.Forms.Button BTOK;
        private System.Windows.Forms.TextBox txtMaphong;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbKhachsan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressControl;
    }
}