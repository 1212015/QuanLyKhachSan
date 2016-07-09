namespace QuanLyKhachSan
{
    partial class ThongKeDoanhThuForm
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
            this.btnOnYear = new System.Windows.Forms.Button();
            this.btnOnMonth = new System.Windows.Forms.Button();
            this.cbxYears = new System.Windows.Forms.ComboBox();
            this.cbxMonths = new System.Windows.Forms.ComboBox();
            this.reportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOnYear
            // 
            this.btnOnYear.Location = new System.Drawing.Point(1018, 12);
            this.btnOnYear.Name = "btnOnYear";
            this.btnOnYear.Size = new System.Drawing.Size(115, 33);
            this.btnOnYear.TabIndex = 9;
            this.btnOnYear.Text = "Theo năm";
            this.btnOnYear.UseVisualStyleBackColor = true;
            this.btnOnYear.Click += new System.EventHandler(this.btnOnYear_Click);
            // 
            // btnOnMonth
            // 
            this.btnOnMonth.Location = new System.Drawing.Point(880, 12);
            this.btnOnMonth.Name = "btnOnMonth";
            this.btnOnMonth.Size = new System.Drawing.Size(115, 33);
            this.btnOnMonth.TabIndex = 8;
            this.btnOnMonth.Text = "Theo tháng";
            this.btnOnMonth.UseVisualStyleBackColor = true;
            this.btnOnMonth.Click += new System.EventHandler(this.btnOnMonth_Click);
            // 
            // cbxYears
            // 
            this.cbxYears.FormattingEnabled = true;
            this.cbxYears.Location = new System.Drawing.Point(561, 17);
            this.cbxYears.Name = "cbxYears";
            this.cbxYears.Size = new System.Drawing.Size(100, 24);
            this.cbxYears.TabIndex = 7;
            // 
            // cbxMonths
            // 
            this.cbxMonths.FormattingEnabled = true;
            this.cbxMonths.Location = new System.Drawing.Point(398, 17);
            this.cbxMonths.Name = "cbxMonths";
            this.cbxMonths.Size = new System.Drawing.Size(83, 24);
            this.cbxMonths.TabIndex = 6;
            // 
            // reportViewer
            // 
            this.reportViewer.ActiveViewIndex = -1;
            this.reportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.reportViewer.Location = new System.Drawing.Point(1, 68);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.Size = new System.Drawing.Size(1155, 530);
            this.reportViewer.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(676, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "năm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(496, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "tháng";
            // 
            // ThongKeDoanhThuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 598);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.btnOnYear);
            this.Controls.Add(this.btnOnMonth);
            this.Controls.Add(this.cbxYears);
            this.Controls.Add(this.cbxMonths);
            this.Name = "ThongKeDoanhThuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê doanh thu khách sạn";
            this.Load += new System.EventHandler(this.ThongKeDoanhThuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOnYear;
        private System.Windows.Forms.Button btnOnMonth;
        private System.Windows.Forms.ComboBox cbxYears;
        private System.Windows.Forms.ComboBox cbxMonths;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer reportViewer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}