using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeManager.DTO
{
    class LoaiPhongDTO
    {
        public int MaLoaiPhong { get; set; }
        public string TenLoaiPhong { get; set; }
        public int GiaNgay { get; set; }
        public int GiaDem { get; set; }

        public LoaiPhongDTO() { }

        public LoaiPhongDTO(int maLoaiPhong, string tenLoaiPhong, int giaNgay, int giaDem)
        {
            this.MaLoaiPhong = maLoaiPhong;
            this.TenLoaiPhong = tenLoaiPhong;
            this.GiaNgay = giaNgay;
            this.GiaDem = giaDem;
        }

        public LoaiPhongDTO(DataRow row)
        {
            this.MaLoaiPhong = (int)row["MaLoaiPhong"];
            this.TenLoaiPhong = row["TenLoaiPhong"].ToString();
            this.GiaNgay = (int)row["GiaNgay"];
            this.GiaDem = (int)row["GiaDem"];
        }
    }
}
