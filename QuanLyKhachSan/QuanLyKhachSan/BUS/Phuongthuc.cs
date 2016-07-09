using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BUS
{   
    public class Phuongthuc
    {
        private List<Xuly> dulieuXuLi = new List<Xuly>();

        public Phuongthuc()
        {
            dulieuXuLi.Add(new Xuly());
        }

        public int Kiemtra_Dangnhap(string User, string Pass)
        {
            return ((Xuly)dulieuXuLi[0]).Kiemtra_Dangnhap(User, Pass);
        }

        public int Lay_makh()
        {
            return ((Xuly)dulieuXuLi[0]).Lay_makh();
        }

        public void Add_khachhang(DTO.Khachhang a)
        {
            ((Xuly)dulieuXuLi[0]).Add_khachhang(a);
        }

        public DataTable Tim_sao(int sao, string thanhpho)
        {
            return ((Xuly)dulieuXuLi[0]).Tim_sao(sao, thanhpho);
        }

        public DataTable Tim_gia(float gia, string thanhpho)
        {
            return ((Xuly)dulieuXuLi[0]).Tim_gia(gia, thanhpho);
        }

        public DataTable Tim_thanh_pho( string thanhpho)
        {
            return ((Xuly)dulieuXuLi[0]).Tim_thanh_pho(thanhpho);
        }

        public DataTable Tim_danhsach_phong_trong(string maks)
        {
            return ((Xuly)dulieuXuLi[0]).Tim_danhsach_phong_trong(maks);
        }

        public DataTable Laybang(string table)
        {
            return ((Xuly)dulieuXuLi[0]).Laybang(table);
        }

        public DataTable Lay_makh(string makh)
        {
            return ((Xuly)dulieuXuLi[0]).Lay_makh(makh);
        }

        public int Lay_SL_Dat_phong()
        {
            return ((Xuly)dulieuXuLi[0]).Lay_SL_Dat_phong();
        }

        public DataTable Lay_DS_TP()
        {
            return ((Xuly)dulieuXuLi[0]).Lay_DS_TP();
        }

        public DataTable Lay_ThongTin_PhongTrong(string thanhpho, int sosao)
        {
            return dulieuXuLi[0].Lay_ThongTin_PhongTrong(thanhpho, sosao);
        }

        public DataTable Lay_don_gia(string maphong)
        {
            return ((Xuly)dulieuXuLi[0]).Lay_don_gia(maphong);
        }

        public DataTable Lay_mo_ta(string maphong)
        {
            return ((Xuly)dulieuXuLi[0]).Lay_mo_ta(maphong);
        }

        public void Add_Datphong(DTO.Datphong p)
        {
            ((Xuly)dulieuXuLi[0]).Add_Datphong(p);
        }

        public int Lay_SL_hoadon()
        {
            return ((Xuly)dulieuXuLi[0]).Lay_SL_hoadon();
        }

        public void Add_hoa_don(DTO.Hoadon p)
        {
            ((Xuly)dulieuXuLi[0]).Add_hoa_don(p);
        }

        public DataTable Tim_kiem_Makh(string Makh)
        {
            return ((Xuly)dulieuXuLi[0]).Tim_kiem_Makh(Makh);
        }

        public DataTable Tim_kiem_Tien(float tien)
        {
            return ((Xuly)dulieuXuLi[0]).Tim_kiem_Tien(tien);
        }

        public DataTable Tim_kiem_Ngay(int ngay, int thang, int nam)
        {
            return ((Xuly)dulieuXuLi[0]).Tim_kiem_Ngay(ngay,thang,nam);
        }

        public DataTable Lay_Dat_phong(string maks)
        {
            return ((Xuly)dulieuXuLi[0]).Lay_Dat_phong(maks);
        }
    }
}
