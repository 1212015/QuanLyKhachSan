using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class Khachhang : Form
    {
        string Makh = "";
        public Khachhang(string makh)
        {
            InitializeComponent();
            Makh = makh;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Timkiem a = new Timkiem();
            a.Show();
        }

        private void Aboutbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Datphong_Click(object sender, EventArgs e)
        {
            DatPhong a = new DatPhong(Makh);
            a.Show();
        }
    }
}
