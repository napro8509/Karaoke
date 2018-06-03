using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KaraokeManager.Utilities;

namespace KaraokeManager.DAO
{
    class ChiTietHDKHDAO
    {
        private static ChiTietHDKHDAO instance;

        private ChiTietHDKHDAO() { }

        public static ChiTietHDKHDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChiTietHDKHDAO();
                return instance;
            }
        }

        public bool addChiTietHDKH(int MaHoaDonKhachHang,
            int MaMatHang,
            int SoLuongCTHDKH,
            int ThanhTien)
        {
            string query = string.Format(
                @"INSERT INTO CHITIETHDKH VALUES ({0}, {1}, {2}, {3})",
                MaHoaDonKhachHang, MaMatHang, SoLuongCTHDKH, ThanhTien);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return (result > 0);
        }
    }
}
