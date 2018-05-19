using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeManager.DTO
{
    class ChiTietHDKHDTO
    {
        public int MaHoaDonKhachHang { get; set; }
        public int MaMatHang { get; set; }
        public int SoLuongCTHDKH { get; set; }
        public int ThanhTien { get; set; }

        public ChiTietHDKHDTO() { }

        public ChiTietHDKHDTO(int maHoaDonKhachHang, int maMatHang, int soLuongCTHDKH, int thanhTien)
        {
            this.MaHoaDonKhachHang = maHoaDonKhachHang;
            this.MaMatHang = maMatHang;
            this.SoLuongCTHDKH = soLuongCTHDKH;
            this.ThanhTien = thanhTien;
        }

        public ChiTietHDKHDTO(DataRow row)
        {
            this.MaHoaDonKhachHang = (int)row["MaHoaDonKhachHang"];
            this.MaMatHang = (int)row["MaMatHang"];
            this.SoLuongCTHDKH = (int)row["SoLuongCTHDKH"];
            this.ThanhTien = (int)row["ThanhTien"];
        }
    }
}
