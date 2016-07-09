namespace QuanLyKhachSan
{
    partial class ThongKeThongTinPhongTrong
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPhongTrong = new System.Windows.Forms.DataGridView();
            this.MaKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SlgTrong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.cbxSao = new System.Windows.Forms.ComboBox();
            this.cbxTP = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongTrong)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(495, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Số sao";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Thành phố";
            // 
            // dgvPhongTrong
            // 
            this.dgvPhongTrong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongTrong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKS,
            this.TenKS,
            this.MaLP,
            this.TenLP,
            this.SlgTrong});
            this.dgvPhongTrong.Location = new System.Drawing.Point(12, 60);
            this.dgvPhongTrong.Name = "dgvPhongTrong";
            this.dgvPhongTrong.RowTemplate.Height = 24;
            this.dgvPhongTrong.Size = new System.Drawing.Size(774, 444);
            this.dgvPhongTrong.TabIndex = 9;
            // 
            // MaKS
            // 
            this.MaKS.DataPropertyName = "MAKS";
            this.MaKS.HeaderText = "Mã khách sạn";
            this.MaKS.Name = "MaKS";
            // 
            // TenKS
            // 
            this.TenKS.DataPropertyName = "TENKS";
            this.TenKS.HeaderText = "Tên Khách sạn";
            this.TenKS.Name = "TenKS";
            this.TenKS.Width = 120;
            // 
            // MaLP
            // 
            this.MaLP.DataPropertyName = "MALOAIPHONG";
            this.MaLP.HeaderText = "Mã loại phòng";
            this.MaLP.Name = "MaLP";
            // 
            // TenLP
            // 
            this.TenLP.DataPropertyName = "TENLOAIPHONG";
            this.TenLP.HeaderText = "Tên loại phòng";
            this.TenLP.Name = "TenLP";
            this.TenLP.Width = 120;
            // 
            // SlgTrong
            // 
            this.SlgTrong.DataPropertyName = "SLTRONG";
            this.SlgTrong.HeaderText = "Số lượng phòng trống";
            this.SlgTrong.Name = "SlgTrong";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(635, 12);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(151, 30);
            this.btnThongKe.TabIndex = 8;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // cbxSao
            // 
            this.cbxSao.FormattingEnabled = true;
            this.cbxSao.Location = new System.Drawing.Point(368, 16);
            this.cbxSao.Name = "cbxSao";
            this.cbxSao.Size = new System.Drawing.Size(121, 24);
            this.cbxSao.TabIndex = 7;
            // 
            // cbxTP
            // 
            this.cbxTP.FormattingEnabled = true;
            this.cbxTP.Location = new System.Drawing.Point(123, 16);
            this.cbxTP.Name = "cbxTP";
            this.cbxTP.Size = new System.Drawing.Size(121, 24);
            this.cbxTP.TabIndex = 6;
            // 
            // ThongKeThongTinPhongTrong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 516);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPhongTrong);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.cbxSao);
            this.Controls.Add(this.cbxTP);
            this.Name = "ThongKeThongTinPhongTrong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê phòng trống";
            this.Load += new System.EventHandler(this.ThongKeThongTinPhongTrong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongTrong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPhongTrong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlgTrong;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.ComboBox cbxSao;
        private System.Windows.Forms.ComboBox cbxTP;
    }
}