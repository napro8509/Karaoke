using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeManager.DTO
{
    class MatHangDTO
    {
        public int MaMatHang { get; set; }
        public string TenMatHang { get; set; }
        public int MaLoaiMatHang { get; set; }
        public int MaNhaCungCap { get; set; }
        public string DonViTinh { get; set; }
        public int GiaVon { get; set; }
        public int GiaBan { get; set; }
        public int SoLuongTon { get; set; }

        public MatHangDTO() { }

        public MatHangDTO(int maMatHang, string tenMatHang, int maLoaiMatHang, int maNhaCungCap, string donViTinh, int giaVon, int giaBan, int soLuongTon)
        {
            this.MaMatHang = maMatHang;
            this.TenMatHang = tenMatHang;
            this.MaLoaiMatHang = maLoaiMatHang;
            this.MaNhaCungCap = maNhaCungCap;
            this.DonViTinh = donViTinh;
            this.GiaVon = giaVon;
            this.GiaBan = giaBan;
            this.SoLuongTon = soLuongTon;
        }

        public MatHangDTO(DataRow row)
        {
            this.MaMatHang = (int)row["MaMatHang"];
            this.TenMatHang = row["TenMatHang"].ToString();
            this.MaLoaiMatHang = (int)row["MaLoaiMatHang"];
            this.MaNhaCungCap = (int)row["MaNhaCungCap"];
            this.DonViTinh = row["DonViTinh"].ToString();
            this.GiaVon = (int)row["GiaVon"];
            this.GiaBan = (int)row["GiaBan"];
            this.SoLuongTon = (int)row["SoLuongTon"];
        }
    }
}
