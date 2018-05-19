using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeManager.DTO
{
    class NhaCungCapDTO
    {
        public int MaNhaCungCap { get; set; }
        public string TenNhaCungCap { get; set; }
        public int TienNo { get; set; }

        public NhaCungCapDTO() { }
        
        public NhaCungCapDTO(int maNhaCungCap, string tenNhaCungCap, int tienNo)
        {
            this.MaNhaCungCap = maNhaCungCap;
            this.TenNhaCungCap = tenNhaCungCap;
            this.TienNo = tienNo;
        }

        public NhaCungCapDTO(DataRow row)
        {
            this.MaNhaCungCap = (int)row["MaNhaCungCap"];
            this.TenNhaCungCap = row["TenNhaCungCap"].ToString();
            this.TienNo = (int)row["TienNo"];
        }
    }
}
