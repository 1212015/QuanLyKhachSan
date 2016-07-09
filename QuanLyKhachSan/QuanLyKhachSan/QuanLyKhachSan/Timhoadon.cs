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
    public partial class Timhoadon : Form
    {
        Phuongthuc bus = new Phuongthuc();
        public Timhoadon()
        {
            InitializeComponent();
            rdkhachang.Checked = true;
        }

        private void BTOK_Click(object sender, EventArgs e)
        {
            if (rdkhachang.Checked)
            {
                progressBar.Visible = true;
                LoadingOnCustomerDelegate load = new LoadingOnCustomerDelegate(LoadingOnCustomer);
                load.BeginInvoke(txtkh.Text, null, null);
            }

            if (rdthanhtien.Checked)
            {
                progressBar.Visible = true;
                LoadingOnPriceDelegate load = new LoadingOnPriceDelegate(LoadingOnPrice);
                load.BeginInvoke(float.Parse(txttien.Text), null, null);
            }

            if (rdNgaylap.Checked)
            {
                progressBar.Visible = true;
                LoadingOnDateDelegate load = new LoadingOnDateDelegate(LoadingOnDate);
                load.BeginInvoke(dtNgay.Value.Day, dtNgay.Value.Month, dtNgay.Value.Year, null, null);
            }
        }

        DataTable listHoaDon;
        private delegate void LoadingOnCustomerDelegate(string MaKH);
        private void LoadingOnCustomer(string MaKH)
        {
            listHoaDon = bus.Tim_kiem_Makh(MaKH);

            this.Invoke(new LoadOnGridDelegate(LoadOnGrid));
        }

        private delegate void LoadingOnPriceDelegate(float price);
        private void LoadingOnPrice(float price)
        {
            listHoaDon = bus.Tim_kiem_Tien(price);

            this.Invoke(new LoadOnGridDelegate(LoadOnGrid));
        }

        private delegate void LoadingOnDateDelegate(int day, int month, int year);
        private void LoadingOnDate(int day, int month, int year)
        {
            listHoaDon = bus.Tim_kiem_Ngay(day, month, year);

            this.Invoke(new LoadOnGridDelegate(LoadOnGrid));
        }

        private delegate void LoadOnGridDelegate();
        private void LoadOnGrid()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new LoadOnGridDelegate(LoadOnGrid));
            }
            else
            {
                progressBar.Visible = false;
                progressBar.Value = 0;
                dtgHoadon.DataSource = listHoaDon;
            }
        }
    }
}
