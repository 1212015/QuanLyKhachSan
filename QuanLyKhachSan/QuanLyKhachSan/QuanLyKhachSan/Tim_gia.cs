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
    public partial class Tim_gia : Form
    {
        Phuongthuc bus = new Phuongthuc();
        public Tim_gia()
        {
            InitializeComponent();
        }

        private void BT_Search_Click(object sender, EventArgs e)
        {
            if (txtThanhpho.Text.Length == 0 || txtGia.Text.Length == 0)
            {
                MessageBox.Show("Dữ liệu không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataTable a = bus.Tim_gia(float.Parse(txtGia.Text), txtThanhpho.Text);

            dtgData.DataSource = a;
        }
    }
}
