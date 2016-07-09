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
    public partial class Tim_thanhpho : Form
    {
        Phuongthuc bus = new Phuongthuc();
        public Tim_thanhpho()
        {
            InitializeComponent();
        }

        private void BT_Search_Click(object sender, EventArgs e)
        {
            if (txtThanhpho.Text.Length == 0)
            {
                MessageBox.Show("Dữ liệu không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                DataTable a = bus.Tim_thanh_pho(txtThanhpho.Text);
                dtgData.DataSource = a;
            }
            catch
            {
            }
        }
    }
}
