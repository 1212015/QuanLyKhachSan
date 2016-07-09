namespace QuanLyKhachSan
{
    partial class Timkiem
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
            this.cbhang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTOK = new System.Windows.Forms.Button();
            this.BTClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vui lòng chọn hạng mục tìm kiếm";
            // 
            // cbhang
            // 
            this.cbhang.BackColor = System.Drawing.Color.White;
            this.cbhang.FormattingEnabled = true;
            this.cbhang.Location = new System.Drawing.Point(158, 104);
            this.cbhang.Name = "cbhang";
            this.cbhang.Size = new System.Drawing.Size(152, 24);
            this.cbhang.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hạng mục";
            // 
            // BTOK
            // 
            this.BTOK.Location = new System.Drawing.Point(176, 175);
            this.BTOK.Name = "BTOK";
            this.BTOK.Size = new System.Drawing.Size(81, 29);
            this.BTOK.TabIndex = 3;
            this.BTOK.Text = "Xác nhận";
            this.BTOK.UseVisualStyleBackColor = true;
            this.BTOK.Click += new System.EventHandler(this.BTOK_Click);
            // 
            // BTClose
            // 
            this.BTClose.Location = new System.Drawing.Point(282, 175);
            this.BTClose.Name = "BTClose";
            this.BTClose.Size = new System.Drawing.Size(81, 29);
            this.BTClose.TabIndex = 4;
            this.BTClose.Text = "Hủy bỏ";
            this.BTClose.UseVisualStyleBackColor = true;
            this.BTClose.Click += new System.EventHandler(this.BTClose_Click);
            // 
            // Timkiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(375, 301);
            this.Controls.Add(this.BTClose);
            this.Controls.Add(this.BTOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbhang);
            this.Controls.Add(this.label1);
            this.Name = "Timkiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbhang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTOK;
        private System.Windows.Forms.Button BTClose;
    }
}