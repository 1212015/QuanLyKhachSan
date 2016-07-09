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
    public partial class Đăngkí : Form
    {
        Phuongthuc bus = new Phuongthuc();
        public Đăngkí()
        {
            InitializeComponent();

        }

        private void BTClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTOK_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length == 0 || txtUser.Text.Length == 0 || txtPass.Text.Length == 0 ||
                txtSDT.Text.Length == 0 || txtCMND.Text.Length == 0 || txtMota.Text.Length == 0 ||
                txtEmail.Text.Length == 0 || txtDiachi.Text.Length == 0)
            {
                MessageBox.Show("Dữ liệu không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int sl;
            sl = bus.Lay_makh();
            sl = sl + 1;
            DTO.Khachhang p = new DTO.Khachhang(sl.ToString(), txtName.Text, txtUser.Text, txtPass.Text, txtCMND.Text, txtDiachi.Text, txtSDT.Text, txtMota.Text, txtEmail.Text);
            try
            {
                bus.Add_khachhang(p);
                MessageBox.Show("Đăng kí thành công");
            }
            catch(Exception)
            {
                MessageBox.Show("Đăng kí thất bại");
            }
        }

        private void Đăngkí_Load(object sender, EventArgs e)
        {

        }
    }
}
