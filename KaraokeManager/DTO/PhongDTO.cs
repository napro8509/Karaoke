using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeManager.DTO
{
    class PhongDTO
    {
        public string MaPhong { get; set; }
        public string TenPhong { get; set; }
        public int MaLoaiPhong { get; set; }
        public int TinhTrang { get; set; }

        public PhongDTO() { }

        public PhongDTO(string maPhong, string tenPhong, int maLoaiPhong, int tinhTrang)
        {
            this.MaPhong = maPhong;
            this.TenPhong = tenPhong;
            this.MaLoaiPhong = maLoaiPhong;
            this.TinhTrang = tinhTrang;
        }

        public PhongDTO(DataRow row)
        {
            this.MaPhong = row["MaPhong"].ToString();
            this.TenPhong = row["TenPhong"].ToString();
            this.MaLoaiPhong = (int)row["MaLoaiPhong"];
            this.TinhTrang = (int)row["TinhTrang"];
        }
    }
}
