using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KaraokeManager.Utilities;

namespace KaraokeManager.DAO
{
    class HoaDonKhachHangDAO
    {
        private static HoaDonKhachHangDAO instance;

        private HoaDonKhachHangDAO() { }

        public static HoaDonKhachHangDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new HoaDonKhachHangDAO();
                return instance;
            }
        }

        public bool addHoaDonKhachHang(
            int MaKhachHang, 
            string MaPhong, 
            DateTime GioBatDau, 
            DateTime GioKetThuc, 
            int TienGio, 
            int TienAnUong, 
            int PhiDichVu, 
            int GiamGia, 
            int TienThue, 
            int TongCong, 
            DateTime Ngay, 
            int MaNguoiThu, 
            int TienKhachHangDua)
        {
            string gioBatDat = GioBatDau.ToString("hh:mm:ss");
            string gioKetThuc = GioKetThuc.ToString("hh:mm:ss");
            string ngay = Ngay.ToString("dd/MM/yyyy");
            string query = string.Format(
                @"SET DATEFORMAT DMY 
                INSERT INTO HOADONKHACHHANG(MaKhachHang, MaPhong, 
                GioBatDau, GioKetThuc, TienGio, TienAnUong, PhiDichVu, 
                GiamGia, TienThue, TongCong, Ngay, MaNguoiThu, TienKhachHangDua)
                VALUES ({0}, '{1}', '{2}', '{3}', {4}, {5}, {6}, {7}, 
                {8}, {9}, '{10}', {11}, {12})",
                MaKhachHang,
                MaPhong,
                gioBatDat,
                gioKetThuc,
                TienGio,
                TienAnUong,
                PhiDichVu,
                GiamGia,
                TienThue,
                TongCong,
                ngay,
                MaNguoiThu,
                TienKhachHangDua);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return (result > 0);
        }

        public int getMaxMaHoaDonKhachHang()
        {
            string query = "SELECT MAX(MaHoaDonKhachHang) FROM HOADONKHACHHANG";
            int max = (int)DataProvider.Instance.ExecuteScalar(query);
            return max;
        }
    }
}
