using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeManager
{
    class Phong
    {
        public int soThuTu { get; set; }  //thứ tự trong phongList
        public int tang { get; set; }
        public string ten { get; set; }
        public bool trangThai { get; set; }
        public DateTime gioBatDau { get; set; }
        public DateTime gioKetThuc { get; set; }
        public DateTime ngay { get; set; }
        public string tenKhachHang { get; set; }
        public string maKhachHang { get; set; }
        public DataTable matHangDaChon { get; set; }
        public int tienGio { get; set; }
        public int tienAnUong { get; set; }
        public int phiDichVu { get; set; }
        public int tienThue { get; set; }
        public int tongCong { get; set; }
        public Phong()
        { }
        public Phong(
            int soThuTu,
            int tang,
            string ten,
            bool trangThai,
            DateTime gioBatDau, 
            DateTime gioKetThuc, 
            DateTime ngay, 
            string tenKhachHang, 
            string maKhachHang, 
            DataTable matHangDatChon,
            int tienGio,
            int tienAnUong,
            int phiDichVu,
            int tienThue,
            int tongCong)
        {
            this.soThuTu = soThuTu;
            this.tang = tang;
            this.ten = ten;
            this.trangThai = trangThai;
            this.matHangDaChon = new DataTable();
            this.matHangDaChon.Clear();
            this.matHangDaChon.Columns.Add("TenMatHangDaChon");
            this.matHangDaChon.Columns.Add("DonViTinhDaChon");
            this.matHangDaChon.Columns.Add("SoLuongDaChon");
            this.matHangDaChon.Columns.Add("GiaDaChon");
            this.matHangDaChon.Columns.Add("ThanhTienDaChon");

            this.gioBatDau = gioBatDau;
            this.gioKetThuc = gioKetThuc;
            this.ngay = ngay;
            this.tenKhachHang = tenKhachHang;
            this.maKhachHang = maKhachHang;
            this.matHangDaChon = matHangDaChon;
            this.tienGio = tienGio;
            this.tienAnUong = tienAnUong;
            this.phiDichVu = phiDichVu;
            this.tienThue = tienThue;
            this.tongCong = tongCong;
        }

        public Phong(int tang, string ten)
        {
            this.tang = tang;
            this.ten = ten;
            this.trangThai = false;
            this.gioBatDau = new DateTime();
            this.gioKetThuc = new DateTime();
            this.ngay = new DateTime();
            this.tenKhachHang = "";
            this.maKhachHang = "";

            this.matHangDaChon = new DataTable();
            this.matHangDaChon.Clear();
            this.matHangDaChon.Columns.Add("TenMatHangDaChon");
            this.matHangDaChon.Columns.Add("DonViTinhDaChon");
            this.matHangDaChon.Columns.Add("SoLuongDaChon");
            this.matHangDaChon.Columns.Add("GiaDaChon");
            this.matHangDaChon.Columns.Add("ThanhTienDaChon");

            this.tienGio = 0;
            this.tienAnUong = 0;
            this.phiDichVu = 0;
            this.tienThue = 0;
            this.tongCong = 0;


        }
    }
}
