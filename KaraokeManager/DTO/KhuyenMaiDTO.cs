using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeManager.DTO
{
    class KhuyenMaiDTO
    {
        public string MaKhuyenMai { get; set; }
        public string TenKM { get; set; }
        public string NoiDungKM { get; set; }

        public KhuyenMaiDTO() { }
        
        public KhuyenMaiDTO(string maKhuyenMai, string tenKM, string noiDungKM)
        {
            this.MaKhuyenMai = maKhuyenMai;
            this.TenKM = tenKM;
            this.NoiDungKM = noiDungKM;
        }
    }
}
