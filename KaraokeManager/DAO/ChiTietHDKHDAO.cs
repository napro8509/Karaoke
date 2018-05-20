using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
