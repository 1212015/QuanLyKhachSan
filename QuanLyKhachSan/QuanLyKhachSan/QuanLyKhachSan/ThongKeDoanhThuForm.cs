using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class ThongKeDoanhThuForm : Form
    {
        public ThongKeDoanhThuForm()
        {
            InitializeComponent();
        }

        private void ThongKeDoanhThuForm_Load(object sender, EventArgs e)
        {
            // add 12 months to combobox
            for (int i = 1; i <= 12; i++)
            {
                cbxMonths.Items.Add(i);
            }

            // add 10 years to combobox
            for (int i = 2005; i <= 2015; i++)
            {
                cbxYears.Items.Add(i);
            }

            cbxMonths.SelectedIndex = 0;
            cbxYears.SelectedIndex = 0;
        }

        private void btnOnMonth_Click(object sender, EventArgs e)
        {
            RevenueReport report = new RevenueReport();
            report.SetParameterValue("txtTimeSpec", "Tháng " + cbxMonths.SelectedItem + " Năm " + cbxYears.SelectedItem);
            report.SetParameterValue("thang", int.Parse(cbxMonths.SelectedItem.ToString()));
            report.SetParameterValue("nam", int.Parse(cbxYears.SelectedItem.ToString()));

            reportViewer.ReportSource = report;
        }

        private void btnOnYear_Click(object sender, EventArgs e)
        {
            RevenueReport report = new RevenueReport();
            report.SetParameterValue("txtTimeSpec", "Năm " + cbxYears.SelectedItem);
            report.SetParameterValue("thang", 0);
            report.SetParameterValue("nam", int.Parse(cbxYears.SelectedItem.ToString()));

            reportViewer.ReportSource = report;
        }

    }
}
