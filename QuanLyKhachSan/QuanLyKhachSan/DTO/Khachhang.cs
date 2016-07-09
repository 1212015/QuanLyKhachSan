using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class Khachhang
    {
        public string makh { set; get; }
        public string hoten { set; get; }
        public string tendn { set; get; }
        public string matkhau { set; get; }
        public string cmnd { set; get; }
        public string diachi { set; get; }
        public string dienthoai { set; get; }
        public string mota { set; get; }
        public string email { set; get; }

        public Khachhang(string makh, string hoten, string tendn, string matkhau, string cmnd, string diachi, string dienthoai, string mota, string email)
        {
            this.makh = makh;
            this.hoten = hoten;
            this.tendn = tendn;
            this.matkhau = matkhau;
            this.cmnd = cmnd;
            this.diachi = diachi;
            this.dienthoai = dienthoai;
            this.mota = mota;
            this.email = email;
        }
    }
}
