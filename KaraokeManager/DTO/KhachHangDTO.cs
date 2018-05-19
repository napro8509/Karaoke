using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeManager.DTO
{
    class KhachHangDTO
    {
        public int MaKhachHang { get; set; }
        public string HoTenKH { get; set; }
        public int LoaiKH { get; set; }
        public DateTime NgaySinhKH { get; set; }
        public int GioiTinhKH { get; set; }
        public string SoDienThoaiKH { get; set; }
        public string DiaChiKH { get; set; }
        public int TienNoKH { get; set; }
        public string MaKhuyenMai { get; set; }

        public KhachHangDTO() { }

        public KhachHangDTO(int maKhachHang, string hoTenKH, int loaiKH, DateTime ngaySinhKH, int gioiTinhKH, string soDienThoaiKH, string diaChiKH, int tienNoKH, string maKhuyenMai)
        {
            this.MaKhachHang = maKhachHang;
            this.HoTenKH = hoTenKH;
            this.LoaiKH = loaiKH;
            this.NgaySinhKH = ngaySinhKH;
            this.GioiTinhKH = gioiTinhKH;
            this.SoDienThoaiKH = soDienThoaiKH;
            this.DiaChiKH = diaChiKH;
            this.TienNoKH = tienNoKH;
            this.MaKhuyenMai = maKhuyenMai;
        }

        public KhachHangDTO(DataRow row)
        {
            this.MaKhachHang = (int)row["MaKhachHang"];
            this.HoTenKH = row["HoTenKH"].ToString();
            this.LoaiKH = (int)row["LoaiKH"];
            this.NgaySinhKH = (DateTime)row["NgaySinhKH"];
            this.GioiTinhKH = (int)row["GioiTinhKH"];
            this.SoDienThoaiKH = row["SoDienThoaiKH"].ToString();
            this.DiaChiKH = row["DiaChiKH"].ToString();
            this.TienNoKH = (int)row["TienNoKH"];
            this.MaKhuyenMai = row["MaKhuyenMai"].ToString();

        }
    }
}
