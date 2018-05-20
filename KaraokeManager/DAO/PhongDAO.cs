using KaraokeManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
