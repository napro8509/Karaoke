using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KaraokeManager.Utilities;

namespace KaraokeManager.DAO
{
    class LoaiMatHangDAO
    {
        private static LoaiMatHangDAO instance;

        private LoaiMatHangDAO() { }

        public static LoaiMatHangDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoaiMatHangDAO();
                return instance;
            }
        }

        public string[] getTenLoaiMatHang()
        {
            List<String> lst = new List<string>();
            DataTable dt = DataProvider.Instance.ExecuteQuery("SELECT TenLoaiMatHang FROM LOAIMATHANG");
            string[] result = new string[dt.Rows.Count + 1];
            result[0] = "Tất cả";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                result[i + 1] = dt.Rows[i]["TenLoaiMatHang"].ToString();
            }
            return result;
        }
    }
}
