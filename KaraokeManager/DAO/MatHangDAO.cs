using KaraokeManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KaraokeManager.Utilities;

namespace KaraokeManager.DAO
{
    class MatHangDAO
    {
        private static MatHangDAO instance;

        private MatHangDAO() { }

        public static MatHangDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new MatHangDAO();
                return instance;
            }
        }

        public DataTable getOverallMatHangList()
        {
            string query = "EXECUTE uspGetOverallMatHang";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public DataTable getOverallMatHangListByLoai(string loaiMatHang)
        {
            string query = "EXECUTE uspGetOverallMatHangByLoai @TenLoaiMatHang ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { loaiMatHang });
            return data;
        }

        public int getMaMatHangByTenMatHang(string tenMatHang)
        {
            string query = "EXECUTE uspGetMaMatHangByTenMatHang @TenMatHang";
            int maMatHang = (int) DataProvider.Instance.ExecuteScalar(query, new object[] { tenMatHang });
            return maMatHang;
        }
    }
}
