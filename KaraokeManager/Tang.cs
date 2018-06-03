using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeManager
{
    class Tang
    {
        public int soThuTu { get; set; }
        public String ten { get; set; }
        public List<String> tenPhong { get; set; }
        public Tang()
        {
            tenPhong = new List<string>();
        }

        public Tang(int soThuTu, String ten, List<String> maPhong)
        {
            this.soThuTu = soThuTu;
            this.ten = ten;
            this.tenPhong = maPhong;
        }
    }
}
