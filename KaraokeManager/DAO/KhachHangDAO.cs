using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KaraokeManager.Utilities;

namespace KaraokeManager.DAO
{
    class KhachHangDAO
    {
        private static KhachHangDAO instance;

        private KhachHangDAO() { }

        public static KhachHangDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhachHangDAO();
                return instance;
            }
        }

        public List<Tuple<string, string>> getMaKHTenKH()
        {
            List<Tuple<string, string>> maKHTenKHList = new List<Tuple<string, string>>();
            string query = "EXECUTE uspGetMaKHTenKH";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                Tuple<string, string> khachHang = new Tuple<string, string>(row["MaKhachHang"].ToString(), row["HoTenKH"].ToString());
                maKHTenKHList.Add(khachHang);
            }
            return maKHTenKHList;
        }
    }
}
