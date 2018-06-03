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
    class PhongDAO
    {
        private static PhongDAO instance;

        private PhongDAO() { }

        public static PhongDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhongDAO();
                return instance;
            }
        }

        public List<string> getPhongListTheoTang(string floor)
        {
            List<string> phongList = new List<string>();
            string query = @"EXECUTE uspGetPhongTheoTang @Floor = N'" + floor + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                string phong = row["MaPhong"].ToString();
                phongList.Add(phong);
            }
            return phongList;
        }

        public int getSoTang()
        {
            string query = @"SELECT COUNT(DISTINCT Tang) FROM PHONG";
            int soTang = (int) DataProvider.Instance.ExecuteScalar(query);
            return soTang;
        }

        public List<Tuple<String, int>> getThongTinTang()
        {
            List<Tuple<string, int>> thongTinTang = new List<Tuple<string, int>>();
            string query = @"SELECT Tang, SoPhong FROM 
            ((SELECT Tang, count(*) AS SoPhong, 1 AS filter FROM PHONG WHERE Tang LIKE '[a-Z][a-Z]%' GROUP BY Tang)
            UNION ALL
            (SELECT Tang, count(*) AS SoPhong, 2 AS filter FROM PHONG WHERE Tang NOT LIKE '[a-Z][a-Z]%' GROUP BY Tang)) tablealias";
            DataTable data = (DataTable)DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in data.Rows)
            {
                string tang = row["Tang"].ToString();
                int soPhong = Int32.Parse(row["SoPhong"].ToString());
                thongTinTang.Add(new Tuple<string, int>(tang, soPhong));
            }
            return thongTinTang;
        }
    }
}
