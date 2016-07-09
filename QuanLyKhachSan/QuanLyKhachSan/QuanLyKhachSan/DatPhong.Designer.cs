namespace QuanLyKhachSan
{
    partial class DatPhong
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.txtkhachsan = new System.Windows.Forms.TextBox();
            this.cbKhachsan = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgPhong = new System.Windows.Forms.DataGridView();
            this.BTOK = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "ĐẶT PHÒNG";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.dtEnd);
            this.panel1.Controls.Add(this.dtStart);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtPhong);
            this.panel1.Controls.Add(this.txtkhachsan);
            this.panel1.Controls.Add(this.cbKhachsan);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtgPhong);
            this.panel1.Location = new System.Drawing.Point(55, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 469);
            this.panel1.TabIndex = 3;
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(226, 207);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(200, 22);
            this.dtEnd.TabIndex = 11;
            // 
            // dtStart
            // 
            this.dtStart.Location = new System.Drawing.Point(226, 162);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(200, 22);
            this.dtStart.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(105, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ngày trả phòng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(105, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ngày bắt đầu";
            // 
            // txtPhong
            // 
            this.txtPhong.Location = new System.Drawing.Point(226, 116);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(200, 22);
            this.txtPhong.TabIndex = 7;
            // 
            // txtkhachsan
            // 
            this.txtkhachsan.Location = new System.Drawing.Point(226, 66);
            this.txtkhachsan.Name = "txtkhachsan";
            this.txtkhachsan.Size = new System.Drawing.Size(200, 22);
            this.txtkhachsan.TabIndex = 6;
            // 
            // cbKhachsan
            // 
            this.cbKhachsan.FormattingEnabled = true;
            this.cbKhachsan.Location = new System.Drawing.Point(343, 242);
            this.cbKhachsan.Name = "cbKhachsan";
            this.cbKhachsan.Size = new System.Drawing.Size(159, 24);
            this.cbKhachsan.TabIndex = 5;
            this.cbKhachsan.SelectedIndexChanged += new System.EventHandler(this.cbKhachsan_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(261, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Danh sách phòng trống của khách sạn :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(367, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Khách hàng vui lòng chọn khách sạn và phòng muốn đặt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phòng";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khách sạn";
            // 
            // dtgPhong
            // 
            this.dtgPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPhong.Location = new System.Drawing.Point(32, 284);
            this.dtgPhong.Name = "dtgPhong";
            this.dtgPhong.RowTemplate.Height = 24;
            this.dtgPhong.Size = new System.Drawing.Size(470, 159);
            this.dtgPhong.TabIndex = 0;
            // 
            // BTOK
            // 
            this.BTOK.Location = new System.Drawing.Point(429, 572);
            this.BTOK.Name = "BTOK";
            this.BTOK.Size = new System.Drawing.Size(98, 32);
            this.BTOK.TabIndex = 4;
            this.BTOK.Text = "Xác nhận";
            this.BTOK.UseVisualStyleBackColor = true;
            this.BTOK.Click += new System.EventHandler(this.BTOK_Click);
            // 
            // DatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(650, 609);
            this.Controls.Add(this.BTOK);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "DatPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt phòng";
            this.Load += new System.EventHandler(this.DatPhong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgPhong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.TextBox txtkhachsan;
        private System.Windows.Forms.ComboBox cbKhachsan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTOK;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;

    }
}