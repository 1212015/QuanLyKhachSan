using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BUS;
using DAO;

namespace QuanLyKhachSan
{
    //public class Info
    //{
    //    public static string makh;
    //}

    public partial class Form1 : Form
    {

        Phuongthuc bus = new Phuongthuc();

        public Form1()
        {
            InitializeComponent();
        }


        private delegate void LoginCheckDelegate(string user, string pass);

        private void LoginCheck(string user, string pass)
        {
            if (bus.Kiemtra_Dangnhap(user, pass) == 1)
            {
                DataTable p = bus.Lay_makh(txtUser.Text);
                string makh = "";
                foreach (DataRow k in p.Rows)
                {
                    makh = k["MAKH"].ToString();
                }
                this.Invoke(new ShowKhachHangWindowDelegate(ShowKhachHangWindow), makh);
            }
            else
            {
                this.Invoke(new ErrorShowDelegate(ErrorShow));
            }

        }

        private delegate void ErrorShowDelegate();

        private void ErrorShow()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new ErrorShowDelegate(ErrorShow));
            }
            else
            {
                progressBar.Visible = false;
                MessageBox.Show("Tài khoản, mật khẩu không đúng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private delegate void ShowKhachHangWindowDelegate(string MaKH);

        private void ShowKhachHangWindow(string maKH)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new ShowKhachHangWindowDelegate(ShowKhachHangWindow), maKH);
            }
            else
            {
                progressBar.Visible = false;
                Khachhang a = new Khachhang(maKH);

                this.Hide();
                a.ShowDialog();
                this.Show();
            }
        }

        private void BTLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Length == 0 || txtPass.Text.Length == 0)
            {
                MessageBox.Show("Tài khoản, mật khẩu không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (rdKhach.Checked)
            {
                progressBar.Visible = true;
                LoginCheckDelegate Kiem_tra = new LoginCheckDelegate(LoginCheck);
                Kiem_tra.BeginInvoke(txtUser.Text, txtPass.Text, null, null);
            }

            if (rdQuanly.Checked)
            {
                if (txtUser.Text == "admin" && txtPass.Text == "admin")
                {
                    Quanly a = new Quanly();

                    this.Hide();
                    a.ShowDialog();
                    this.Show();
                    
                }
                else MessageBox.Show("Tài khoản, mật khẩu không đúng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdKhach.Checked = true;
        }

        private void BTDangki_Click(object sender, EventArgs e)
        {
            Đăngkí a = new Đăngkí();
            a.Show();
        }

    }
}
