using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeManager.DTO
{
    class NguoiDungDTO
    {
        public int MaNguoiDung { get; set; }
        public string TenGhiDanh { get; set; }
        public string MatMa { get; set; }
        public string TenNguoiDung { get; set; }
        public int LoaiTaiKhoan { get; set; }

        public NguoiDungDTO() { }

        public NguoiDungDTO(int maNguoiDung, string tenGhiDanh, string matMa, string tenNguoiDung, int loaiTaiKhoan)
        {
            this.MaNguoiDung = maNguoiDung;
            this.TenGhiDanh = tenGhiDanh;
            this.MatMa = matMa;
            this.TenNguoiDung = tenNguoiDung;
            this.LoaiTaiKhoan = loaiTaiKhoan;
        }

        public NguoiDungDTO(DataRow row)
        {
            this.MaNguoiDung = (int)row["MaNguoiDung"];
            this.TenGhiDanh = row["TenGhiDanh"].ToString();
            this.MatMa = row["MatMa"].ToString();
            this.TenNguoiDung = row["TenNguoiDung"].ToString();
            this.LoaiTaiKhoan = (int)row["LoaiTaiKhoan"];
        }
    }
}
