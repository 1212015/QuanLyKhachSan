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
    public partial class DatPhong : Form
    {
        Phuongthuc bus = new Phuongthuc();

        string Makh = "";

        DataTable a = new DataTable();
        public DatPhong(string makh)
        {
            InitializeComponent();
            a = bus.Laybang("KHACHSAN");
            Makh = makh;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DatPhong_Load(object sender, EventArgs e)
        {
            foreach (DataRow ks in a.Rows)
            {
                cbKhachsan.Items.Add(ks["TENKS"]);
            }
            cbKhachsan.SelectedIndex = 0;
        }

        private void cbKhachsan_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtgPhong.DataSource = null;
            string p = "";
            foreach (DataRow ks in a.Rows)
            {
                if (ks["TENKS"].ToString() == cbKhachsan.SelectedItem.ToString())
                {
                    p = ks["MAKS"].ToString();
                }
            }

            dtgPhong.DataSource = bus.Tim_danhsach_phong_trong(p);
            txtkhachsan.Text = cbKhachsan.SelectedItem.ToString();
        }

        private void BTOK_Click(object sender, EventArgs e)
        {
            if (txtPhong.Text.Length == 0 || txtkhachsan.Text.Length == 0)
            {
                MessageBox.Show("Dữ liệu không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int sl;
            sl = bus.Lay_SL_Dat_phong();
            sl = sl + 1;

            DataTable p = new DataTable();
            p = bus.Lay_don_gia(txtPhong.Text);
            int dongia = 0;
            foreach (DataRow o in p.Rows)
            {
                dongia = int.Parse(o["DONGIA"].ToString());
            }
            string mota = "";
            p = bus.Lay_mo_ta(txtPhong.Text);
            foreach (DataRow o in p.Rows)
            {
                mota = (o["MOTA"].ToString());
            }
            DTO.Datphong a = new DTO.Datphong(sl.ToString(), txtPhong.Text, Makh, dtStart.Value, dtEnd.Value, DateTime.Now, dongia, mota, "đã xác nhận");

            try
            {
                bus.Add_Datphong(a);
                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
