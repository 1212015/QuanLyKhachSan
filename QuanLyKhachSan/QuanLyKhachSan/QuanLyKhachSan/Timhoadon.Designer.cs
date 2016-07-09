namespace QuanLyKhachSan
{
    partial class Timhoadon
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
            this.rdkhachang = new System.Windows.Forms.RadioButton();
            this.rdthanhtien = new System.Windows.Forms.RadioButton();
            this.txtkh = new System.Windows.Forms.TextBox();
            this.txttien = new System.Windows.Forms.TextBox();
            this.dtgHoadon = new System.Windows.Forms.DataGridView();
            this.BTOK = new System.Windows.Forms.Button();
            this.rdNgaylap = new System.Windows.Forms.RadioButton();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // rdkhachang
            // 
            this.rdkhachang.AutoSize = true;
            this.rdkhachang.Location = new System.Drawing.Point(69, 76);
            this.rdkhachang.Name = "rdkhachang";
            this.rdkhachang.Size = new System.Drawing.Size(126, 21);
            this.rdkhachang.TabIndex = 0;
            this.rdkhachang.TabStop = true;
            this.rdkhachang.Text = "Mã khách hàng";
            this.rdkhachang.UseVisualStyleBackColor = true;
            // 
            // rdthanhtien
            // 
            this.rdthanhtien.AutoSize = true;
            this.rdthanhtien.Location = new System.Drawing.Point(69, 134);
            this.rdthanhtien.Name = "rdthanhtien";
            this.rdthanhtien.Size = new System.Drawing.Size(97, 21);
            this.rdthanhtien.TabIndex = 2;
            this.rdthanhtien.TabStop = true;
            this.rdthanhtien.Text = "Thành tiền";
            this.rdthanhtien.UseVisualStyleBackColor = true;
            // 
            // txtkh
            // 
            this.txtkh.Location = new System.Drawing.Point(249, 76);
            this.txtkh.Name = "txtkh";
            this.txtkh.Size = new System.Drawing.Size(216, 22);
            this.txtkh.TabIndex = 3;
            // 
            // txttien
            // 
            this.txttien.Location = new System.Drawing.Point(249, 134);
            this.txttien.Name = "txttien";
            this.txttien.Size = new System.Drawing.Size(216, 22);
            this.txttien.TabIndex = 5;
            // 
            // dtgHoadon
            // 
            this.dtgHoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHoadon.Location = new System.Drawing.Point(23, 277);
            this.dtgHoadon.Name = "dtgHoadon";
            this.dtgHoadon.RowTemplate.Height = 24;
            this.dtgHoadon.Size = new System.Drawing.Size(506, 190);
            this.dtgHoadon.TabIndex = 6;
            // 
            // BTOK
            // 
            this.BTOK.Location = new System.Drawing.Point(415, 244);
            this.BTOK.Name = "BTOK";
            this.BTOK.Size = new System.Drawing.Size(97, 27);
            this.BTOK.TabIndex = 7;
            this.BTOK.Text = "Xác nhận";
            this.BTOK.UseVisualStyleBackColor = true;
            this.BTOK.Click += new System.EventHandler(this.BTOK_Click);
            // 
            // rdNgaylap
            // 
            this.rdNgaylap.AutoSize = true;
            this.rdNgaylap.Location = new System.Drawing.Point(69, 191);
            this.rdNgaylap.Name = "rdNgaylap";
            this.rdNgaylap.Size = new System.Drawing.Size(85, 21);
            this.rdNgaylap.TabIndex = 8;
            this.rdNgaylap.TabStop = true;
            this.rdNgaylap.Text = "Ngày lập";
            this.rdNgaylap.UseVisualStyleBackColor = true;
            // 
            // dtNgay
            // 
            this.dtNgay.Location = new System.Drawing.Point(249, 191);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(216, 22);
            this.dtNgay.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(130, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tìm kiếm hóa đơn";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 481);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(196, 23);
            this.progressBar.Step = 5;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 11;
            this.progressBar.Visible = false;
            // 
            // Timhoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 516);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.dtNgay);
            this.Controls.Add(this.rdNgaylap);
            this.Controls.Add(this.BTOK);
            this.Controls.Add(this.dtgHoadon);
            this.Controls.Add(this.txttien);
            this.Controls.Add(this.txtkh);
            this.Controls.Add(this.rdthanhtien);
            this.Controls.Add(this.rdkhachang);
            this.Name = "Timhoadon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm hóa đơn";
            ((System.ComponentModel.ISupportInitialize)(this.dtgHoadon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdkhachang;
        private System.Windows.Forms.RadioButton rdthanhtien;
        private System.Windows.Forms.TextBox txtkh;
        private System.Windows.Forms.TextBox txttien;
        private System.Windows.Forms.DataGridView dtgHoadon;
        private System.Windows.Forms.Button BTOK;
        private System.Windows.Forms.RadioButton rdNgaylap;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}