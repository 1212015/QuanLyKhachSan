using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class Timkiem : Form
    {
        public Timkiem()
        {
            InitializeComponent();

            cbhang.Items.Add("Giá cả, thành phố");
            cbhang.Items.Add("Số sao, thành phố");
            cbhang.Items.Add("Thành phố");

            cbhang.SelectedIndex = 0;
        }

        private void BTClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTOK_Click(object sender, EventArgs e)
        {
            if (cbhang.SelectedIndex == 0)
            {
                Tim_gia a = new Tim_gia();
                a.Show();
            }
            if (cbhang.SelectedIndex == 1)
            {
                Tim_sao a = new Tim_sao();
                a.Show();
            }

            if (cbhang.SelectedIndex == 2)
            {
                Tim_thanhpho a = new Tim_thanhpho();
                a.Show();
            }
        }
    }
}
