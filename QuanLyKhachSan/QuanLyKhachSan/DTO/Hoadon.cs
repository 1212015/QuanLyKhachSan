using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class Hoadon
    {
        public string maHD;
        public DateTime ngayLap;
        public float tongtien;
        public string maDP;

        public Hoadon(string maHD, DateTime ngayLap, float tongtien, string maDP)
        {
            this.maHD = maHD;
            this.ngayLap = ngayLap;
            this.tongtien = tongtien;
            this.maDP = maDP;
        }
    }
}
