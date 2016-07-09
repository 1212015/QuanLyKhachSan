using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace DAO
{
    public class Xuly
    {
        CungCapDuLieu da = new CungCapDuLieu();
        DataTable dulieu = new DataTable();
        public int Kiemtra_Dangnhap(string User, string Pass)
        {
            IList<string> a = new List<string>();
            a.Add("@TENDANGNHAP");
            a.Add("@MATKHAU");
            ArrayList b = new ArrayList();
            b.Add(User);
            b.Add(Pass);
            return da.ExecuteStoreProc_Check("DANG_NHAP", a, b);
        }

        public int Lay_makh()
        {
            IList<string> a = new List<string>();
            ArrayList b = new ArrayList();
            return da.ExecuteStoreProc_Check("SL_KHACH", a, b);
        }

        public int Lay_SL_Dat_phong()
        {
            IList<string> a = new List<string>();
            ArrayList b = new ArrayList();
            return da.ExecuteStoreProc_Check("SL_DAT", a, b);
        }

        public void Add_khachhang(DTO.Khachhang p)
        {
            IList<string> a = new List<string>();
            a.Add("@MAKH");
            a.Add("@HOTEN");
            a.Add("@TENDANGNHAP");
            a.Add("@MATKHAU");
            a.Add("@CMND");
            a.Add("@DIACHI");
            a.Add("@DIENTHOAI");
            a.Add("@MOTA");
            a.Add("@EMAIL");

            ArrayList b = new ArrayList();
            b.Add(p.makh);
            b.Add(p.hoten);
            b.Add(p.tendn);
            b.Add(p.matkhau);
            b.Add(p.cmnd);
            b.Add(p.diachi);
            b.Add(p.dienthoai);
            b.Add(p.mota);
            b.Add(p.email);

            da.ExecuteStoreProc("THEM_KHACH_HANG",a,b);
        }

        public DataTable Tim_sao(int sao, string thanhpho)
        {
            DataTable p;
            IList<string> a = new List<string>();
            a.Add("@SOSAO");
            a.Add("@THANHPHO");
            ArrayList b = new ArrayList();
            b.Add(sao);
            b.Add(thanhpho);
            p = da.ExecuteStoreProc_Data("TIMKIEM_SAO", a, b);
            return p;
        }

        public DataTable Tim_gia(float gia, string thanhpho)
        {
            DataTable p;
            IList<string> a = new List<string>();
            a.Add("@GIA");
            a.Add("@THANHPHO");
            ArrayList b = new ArrayList();
            b.Add(gia);
            b.Add(thanhpho);
            p = da.ExecuteStoreProc_Data("TIMKIEM_GIA", a, b);
            return p;
        }

        public DataTable Tim_thanh_pho( string thanhpho)
        {
            DataTable p;
            IList<string> a = new List<string>();
            a.Add("@THANHPHO");
            ArrayList b = new ArrayList();
            b.Add(thanhpho);
            p = da.ExecuteStoreProc_Data("TIMKIEM_THANHPHO", a, b);
            return p;
        }

        public DataTable Tim_danhsach_phong_trong(string maks)
        {
            DataTable p;
            IList<string> a = new List<string>();
            a.Add("@MAKS");
            ArrayList b = new ArrayList();
            b.Add(maks);
            p = da.ExecuteStoreProc_Data("LAY_PHONG_TRONG", a, b);
            return p;
        }

        public DataTable Lay_makh(string makh)
        {
            DataTable p;
            IList<string> a = new List<string>();
            a.Add("@MAKH");
            ArrayList b = new ArrayList();
            b.Add(makh);
            p = da.ExecuteStoreProc_Data("LAY_MA_KH", a, b);
            return p;
        }

        public DataTable Laybang(string table)
        {
            string sql = string.Format("select * from " + table + " ");
            dulieu = da.GetTable(sql);
            return dulieu;

            
        }

        public DataTable Lay_don_gia(string maphong)
        {
            DataTable p;
            IList<string> a = new List<string>();
            a.Add("@MAPHONG");
            ArrayList b = new ArrayList();
            b.Add(maphong);
            p = da.ExecuteStoreProc_Data("LAY_DON_GIA", a, b);
            return p;
        }

        public DataTable Lay_mo_ta(string maphong)
        {
            DataTable p;
            IList<string> a = new List<string>();
            a.Add("@MAPHONG");
            ArrayList b = new ArrayList();
            b.Add(maphong);
            p = da.ExecuteStoreProc_Data("LAY_MO_TA", a, b);
            return p;
        }

        public DataTable Lay_DS_TP()
        {
            DataTable p;
            IList<string> a = new List<string>();
            ArrayList b = new ArrayList();
            p = da.ExecuteStoreProc_Data("LAY_DS_THANHPHO", a, b);
            return p;
        }

        public DataTable Lay_ThongTin_PhongTrong(string thanhpho, int sosao)
        {
            DataTable p;
            IList<string> a = new List<string>();
            a.Add("@THANHPHO");
            a.Add("@SOSAO");
            ArrayList b = new ArrayList();
            b.Add(thanhpho);
            b.Add(sosao);
            p = da.ExecuteStoreProc_Data("LAY_DS_PHONGTRONG", a, b);
            return p;
        }

        public void Add_Datphong(DTO.Datphong p)
        {
            IList<string> a = new List<string>();
            a.Add("@MADP");
            a.Add("@MAPHONG");
            a.Add("@MAKH");
            a.Add("@NGAYBATDAU");
            a.Add("@NGAYTRAPHONG");
            a.Add("@NGAYDAT");
            a.Add("@DONGIA");
            a.Add("@MOTA");
            a.Add("@TINHTRANG");
            ArrayList b = new ArrayList();
            b.Add(p.maDP);
            b.Add(p.maPhong);
            b.Add(p.maKh);
            b.Add(p.ngayBD);
            b.Add(p.ngayTra);
            b.Add(p.ngayDat);
            b.Add(p.donGia);
            b.Add(p.moTa);
            b.Add(p.tinhTrang);

            da.ExecuteStoreProc("DAT_PHONG", a, b);
        }

        public int Lay_SL_hoadon()
        {
            IList<string> a = new List<string>();
            ArrayList b = new ArrayList();
            return da.ExecuteStoreProc_Check("SL_HOADON", a, b);
        }

        public void Add_hoa_don(DTO.Hoadon p)
        {
            IList<string> a = new List<string>();
            a.Add("@MAHD");
            a.Add("@NGAYTHANHTOAN");
            a.Add("@TONGTIEN");
            a.Add("@MADP");
            ArrayList b = new ArrayList();
            b.Add(p.maHD);
            b.Add(p.ngayLap);
            b.Add(p.tongtien);
            b.Add(p.maDP);

            da.ExecuteStoreProc("LAP_HOA_DON", a, b);
        }

        public DataTable Tim_kiem_Makh(string Makh)
        {
            DataTable p;
            IList<string> a = new List<string>();
            a.Add("@MAKH");
            ArrayList b = new ArrayList();
            b.Add(Makh);
            p = da.ExecuteStoreProc_Data("TIM_HOADON_MAKH", a, b);
            return p;
        }

        public DataTable Tim_kiem_Tien(float tien)
        {
            DataTable p;
            IList<string> a = new List<string>();
            a.Add("@TIEN");
            ArrayList b = new ArrayList();
            b.Add(tien);
            p = da.ExecuteStoreProc_Data("TIM_HOADON_TIEN", a, b);
            return p;
        }

        public DataTable Tim_kiem_Ngay(int ngay, int thang, int nam)
        {
            DataTable p;
            IList<string> a = new List<string>();
            a.Add("@NGAY");
            a.Add("@THANG");
            a.Add("@NAM");
            ArrayList b = new ArrayList();
            b.Add(ngay);
            b.Add(thang);
            b.Add(nam);
            p = da.ExecuteStoreProc_Data("TIM_HOADON_NGAY", a, b);
            return p;
        }

        public DataTable Lay_Dat_phong(string maks)
        {
            DataTable p;
            IList<string> a = new List<string>();
            a.Add("@MAKS");
            ArrayList b = new ArrayList();
            b.Add(maks);
            p = da.ExecuteStoreProc_Data("LAY_DAT_PHONG", a, b);
            return p;
        }
    }
}
