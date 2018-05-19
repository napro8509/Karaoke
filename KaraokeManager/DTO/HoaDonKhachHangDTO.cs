using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeManager.DTO
{
    class HoaDonKhachHangDTO
    {
        public int MaHoaDonKhachHang { get; set; }
        public int MaKhachHang { get; set; }
        public string MaPhong { get; set; }
        public DateTime GioBatDau { get; set; }
        public DateTime GioKetThuc { get; set; }
        public int TienGio { get; set; }
        public int TienAnUong { get; set; }
        public int PhiDichVu { get; set; }
        public int GiamGia { get; set; }
        public int TienThue { get; set; }
        public int TongCong { get; set; }
        public DateTime Ngay { get; set; }
        public int MaNguoiThu { get; set; }
        public int TienKhachHangDua { get; set; }

        public HoaDonKhachHangDTO() { }
        
        public HoaDonKhachHangDTO(int maHoaDonKhachHang, int maKhachHang, string maPhong, DateTime gioBatDau, DateTime gioKetThuc, int tienGio, int tienAnUong, int phiDichVu, int giamGia, int tienThue, int tongCong, DateTime ngay, int maNguoiThu, int tienKhachHangDua)
        {
            this.MaHoaDonKhachHang = maHoaDonKhachHang;
            this.MaKhachHang = maKhachHang;
            this.MaPhong = maPhong;
            this.GioBatDau = gioBatDau;
            this.GioKetThuc = gioKetThuc;
            this.TienGio = tienGio;
            this.TienAnUong = tienAnUong;
            this.PhiDichVu = phiDichVu;
            this.GiamGia = giamGia;
            this.TienThue = tienThue;
            this.TongCong = tongCong;
            this.Ngay = ngay;
            this.MaNguoiThu = maNguoiThu;
            this.TienKhachHangDua = tienKhachHangDua;
        }

        public HoaDonKhachHangDTO(DataRow row)
        {
            this.MaHoaDonKhachHang = (int)row["MaHoaDonKhachHang"];
            this.MaKhachHang = (int)row["MaKhachHang"];
            this.MaPhong = row["MaPhong"].ToString();
            this.GioBatDau = (DateTime)row["GioBatDau"];
            this.GioKetThuc = (DateTime)row["GioKetThuc"];
            this.TienGio = (int)row["TienGio"];
            this.TienAnUong = (int)row["TienAnUong"];
            this.PhiDichVu = (int)row["PhiDichVu"];
            this.GiamGia = (int)row["GiamGia"];
            this.TienThue = (int)row["TienThue"];
            this.TongCong = (int)row["TongCong"];
            this.Ngay = (DateTime)row["Ngay"];
            this.MaNguoiThu = (int)row["MaNguoiThu"];
            this.TienKhachHangDua = (int)row["TienKhachHangDua"];
        }
    }
}
