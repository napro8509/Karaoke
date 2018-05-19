using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeManager.DTO
{
    class LoaiMatHangDTO
    {
        public int MaLoaiMatHang { get; set; }
        public string TenLoaiMatHang { get; set; }

        public LoaiMatHangDTO() { }

        public LoaiMatHangDTO(int maLoaiMatHang, string tenLoaiMatHang)
        {
            this.MaLoaiMatHang = maLoaiMatHang;
            this.TenLoaiMatHang = tenLoaiMatHang;
        }

        public LoaiMatHangDTO(DataRow row)
        {
            this.MaLoaiMatHang = (int)row["MaLoaiMatHang"];
            this.TenLoaiMatHang = row["TenLoaiMatHang"].ToString();
        }
    }
}
