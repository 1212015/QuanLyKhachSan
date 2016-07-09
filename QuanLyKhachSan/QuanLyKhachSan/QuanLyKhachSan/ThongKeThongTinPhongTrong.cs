using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BUS;

namespace QuanLyKhachSan
{
    public partial class ThongKeThongTinPhongTrong : Form
    {

        Phuongthuc bus = new Phuongthuc();

        public ThongKeThongTinPhongTrong()
        {
            InitializeComponent();
            dgvPhongTrong.AutoGenerateColumns = false;
        }

        private void ThongKeThongTinPhongTrong_Load(object sender, EventArgs e)
        {
            DataTable Tps = bus.Lay_DS_TP();
            foreach (DataRow tp in Tps.Rows)
            {
                cbxTP.Items.Add(tp["THANHPHO"]);
            }

            for (int i = 1; i <= 5; i++)
            {
                cbxSao.Items.Add(i);
            }

            cbxSao.SelectedIndex = 0;
            cbxTP.SelectedIndex = 0;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            dgvPhongTrong.DataSource = bus.Lay_ThongTin_PhongTrong(cbxTP.SelectedItem.ToString(), int.Parse(cbxSao.SelectedItem.ToString()));
        }


    }
}
