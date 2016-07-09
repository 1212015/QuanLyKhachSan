using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class Quanly : Form
    {
        public Quanly()
        {
            InitializeComponent();
        }

        private void Laphoadon_Click(object sender, EventArgs e)
        {
            Laphoadon a = new Laphoadon();
            a.Show();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Timhoadon a = new Timhoadon();
            a.Show();
        }

        private void btnRevenueStat_Click(object sender, EventArgs e)
        {
            ThongKeDoanhThuForm form = new ThongKeDoanhThuForm();
            form.Show();
        }

        private void btnHotelStat_Click(object sender, EventArgs e)
        {
            ThongKeThongTinPhongTrong form = new ThongKeThongTinPhongTrong();
            form.Show();
        }
    }
}
