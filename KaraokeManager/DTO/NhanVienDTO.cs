using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeManager.DTO
{
    class NhanVienDTO
    {
        public int MaNhanVien { get; set; }
        public string HoTenNV { get; set; }
        public DateTime NgaySinhNV { get; set; }
        public int GioiTinhNV { get; set; }
        public string SoDienThoaiNV { get; set; }
        public string DiaChiNV { get; set; }
        public int LuongCoBan { get; set; }
        public int Thuong { get; set; }
        public int Phat { get; set; }
        public int TongLuong { get; set; }

        public NhanVienDTO() { }

        public NhanVienDTO(int maNhanVien, string hoTenNV, DateTime ngaySinhNV, int gioiTinhNV, string soDienThoaiNV, string diaChiNV, int luongCoBan, int thuong, int phat, int tongLuong)
        {
            this.MaNhanVien = maNhanVien;
            this.HoTenNV = hoTenNV;
            this.NgaySinhNV = ngaySinhNV;
            this.GioiTinhNV = gioiTinhNV;
            this.SoDienThoaiNV = soDienThoaiNV;
            this.DiaChiNV = diaChiNV;
            this.LuongCoBan = luongCoBan;
            this.Thuong = thuong;
            this.Phat = phat;
            this.TongLuong = tongLuong;
        }

        public NhanVienDTO(DataRow row)
        {
            this.MaNhanVien = (int)row["MaNhanVien"];
            this.HoTenNV = row["HoTenNV"].ToString();
            this.NgaySinhNV = (DateTime)row["NgaySinhNV"];
            this.GioiTinhNV = (int)row["GioiTinhNV"];
            this.SoDienThoaiNV = row["SoDienThoaiNV"].ToString();
            this.DiaChiNV = row["DiaChiNV"].ToString();
            this.LuongCoBan = (int)row["LuongCoBan"];
            this.Thuong = (int)row["Thuong"];
            this.Phat = (int)row["Phat"];
            this.TongLuong = (int)row["TongLuong"];

        }
    }
}
