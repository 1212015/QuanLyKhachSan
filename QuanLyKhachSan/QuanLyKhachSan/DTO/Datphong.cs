using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class Datphong
    {
        public string maDP { get; set; }
        public string maPhong { get; set; }
        public string maKh { get; set; }
        public DateTime ngayBD { get; set; }
        public DateTime ngayTra { get; set; }
        public DateTime ngayDat { get; set; }
        public int donGia { get; set; }
        public string moTa { get; set; }
        public string tinhTrang { get; set; }

        public Datphong(string maDP, string maPhong, string maKh, DateTime ngayBD, DateTime ngayTra, DateTime ngayDat, int donGia, string moTa, string tinhTrang)
        {
            this.maDP = maDP;
            this.maPhong = maPhong;
            this.maKh = maKh;
            this.ngayBD = ngayBD;
            this.ngayTra = ngayTra;
            this.ngayDat = ngayDat;
            this.donGia = donGia;
            this.moTa = moTa;
            this.tinhTrang = tinhTrang;
        }
    }
}
