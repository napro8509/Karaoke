using KaraokeManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public List<MatHangDTO> getMatHangList()
        {
            List<MatHangDTO> matHangList = new List<MatHangDTO>();
            string query = "EXECUTE uspGetMatHang";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            
            foreach (DataRow row in data.Rows)
            {
                MatHangDTO matHang = new MatHangDTO(row);
                matHangList.Add(matHang);
            }
            return matHangList;
        }
    }
}
