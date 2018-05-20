using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeManager.DAO
{
    class LoaiPhongDAO
    {
        private static LoaiPhongDAO instance;

        private LoaiPhongDAO() { }

        public static LoaiPhongDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoaiPhongDAO();
                return instance;
            }
        }

    }
}
