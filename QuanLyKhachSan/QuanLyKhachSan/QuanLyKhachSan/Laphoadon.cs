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
    public partial class Laphoadon : Form
    {
        Phuongthuc bus = new Phuongthuc();

        DataTable a = new DataTable();
        public Laphoadon()
        {
            InitializeComponent();
           

            LayThongTinDatPhongDelegate getBooksInfo = new LayThongTinDatPhongDelegate(LayThongTinDatPhong);
            getBooksInfo.BeginInvoke(null, null);
        }

        private void BTOK_Click(object sender, EventArgs e)
        {
            if (txtMaphong.Text.Length == 0 || txtTien.Text.Length == 0)
            {
                MessageBox.Show("Dữ liệu không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool ktra = false;

            foreach (DataRow phong in a.Rows)
            {
                if (txtMaphong.Text == phong["MADP"].ToString().TrimEnd())
                    ktra = true;
            }

            if (ktra == false)
            {
                MessageBox.Show("Mã đặt phòng không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int sl = bus.Lay_SL_hoadon();
            sl = sl + 1;

            DTO.Hoadon hoadon = new DTO.Hoadon(sl.ToString(), dtthanhtoan.Value, float.Parse(txtTien.Text), txtMaphong.Text);
            try
            {
                bus.Add_hoa_don(hoadon);
                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Laphoadon_Load(object sender, EventArgs e)
        {
            
        }

        private void cbKhachsan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string p = "";
            foreach (DataRow ks in a.Rows)
            {
                if (ks["TENKS"].ToString() == cbKhachsan.SelectedItem.ToString())
                {
                    p = ks["MAKS"].ToString();
                }
            }

            dtgPhong.DataSource = bus.Lay_Dat_phong(p);
        }

        private delegate void LayThongTinDatPhongDelegate();

        private void LayThongTinDatPhong()
        {
            a = bus.Laybang("KHACHSAN");


            this.Invoke(new DisableProgressBarDelegate(DisableProgressBar));
        }

        private delegate void DisableProgressBarDelegate();
        private void DisableProgressBar()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new DisableProgressBarDelegate(DisableProgressBar));
            }
            else
            {
                foreach (DataRow ks in a.Rows)
                {
                    cbKhachsan.Items.Add(ks["TENKS"]);
                }
                cbKhachsan.SelectedIndex = 0;
                progressControl.Visible = false;
            }
        }
    }
}
