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
    public partial class Tim_sao : Form
    {
        Phuongthuc bus = new Phuongthuc();
        public Tim_sao()
        {
            InitializeComponent();
            //dtgData.DataSource = bus.Laybang("KHACHSAN");
        }

        private void BTOK_Click(object sender, EventArgs e)
        {
            if (txtThanhpho.Text.Length == 0 || txtSao.Text.Length == 0)
            {
                MessageBox.Show("Dữ liệu không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataTable a = bus.Tim_sao(int.Parse(txtSao.Text),txtThanhpho.Text);

            dtgData.DataSource = a;
        }
    }
}
