using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaraokeManager.Utilities
{
    class Helpers
    {
        private static Helpers instance;

        private Helpers() { }

        public static Helpers Instance
        {
            get
            {
                if (instance == null)
                    instance = new Helpers();
                return instance;
            }
        }

        public void LoadPhongList(
            ImageList ilstPhong, 
            int soTang, 
            ListView[] lvwTang, 
            List<Tang> tangList, 
            DevExpress.XtraTab.XtraTabControl xtcDanhSachLau, 
            DevExpress.XtraTab.XtraTabPage[] xtpTang)
        {
            //Lấy thông tin số tầng, khởi tạo XtraTabPage
            List<Tuple<string, int>> thongTinTang = DAO.PhongDAO.Instance.getThongTinTang();

            foreach (Tuple<string, int> tang in thongTinTang)
            {
                tangList.Add(new Tang(tangList.Count, tang.Item1, DAO.PhongDAO.Instance.getPhongListTheoTang(tang.Item1)));
            }

            for (int i = 0; i < soTang; i++)
            {
                xtpTang[i] = new DevExpress.XtraTab.XtraTabPage();
                lvwTang[i] = new System.Windows.Forms.ListView();
                //xtpTang[i].SuspendLayout();
                //xtpTang[i].ResumeLayout(false);

                // 
                // xtpTang
                // 
                int tenTang;
                xtpTang[i].Controls.Add(lvwTang[i]);
                xtpTang[i].Name = "xtpTang" + i;
                xtpTang[i].Size = new System.Drawing.Size(286, 409);

                // Nếu là tầng hầm thì giữ nguyên tên, nếu là tầng trên thì định dạng lại tên
                if (Int32.TryParse(thongTinTang[i].Item1, out tenTang))
                    xtpTang[i].Text = "Lầu " + thongTinTang[i].Item1;
                else
                    xtpTang[i].Text = thongTinTang[i].Item1;

                //
                xtcDanhSachLau.TabPages.Add(xtpTang[i]);

                // 
                // lvwTang
                // 
                lvwTang[i].Location = new System.Drawing.Point(4, 4);
                lvwTang[i].Name = "lvwTang" + i;
                lvwTang[i].Size = new System.Drawing.Size(279, 402);
                lvwTang[i].TabIndex = 0;
                lvwTang[i].TileSize = new System.Drawing.Size(70, 70);
                lvwTang[i].UseCompatibleStateImageBehavior = false;
                xtpTang[i].Controls.Add(lvwTang[i]);
            }

            xtcDanhSachLau.SelectedTabPage = xtpTang[0];

            ilstPhong.Images.Add("microphone_off", new Bitmap(global::KaraokeManager.Properties.Resources.microphone_off_48x48));
            ilstPhong.Images.Add("microphone_on", new Bitmap(global::KaraokeManager.Properties.Resources.microphone_on_48x48));

            ilstPhong.ImageSize = new Size(48, 48);
            ilstPhong.ColorDepth = ColorDepth.Depth32Bit;

            for (int i = 0; i < soTang; i++)
            {
                lvwTang[i].Columns.Add("Phong");
                lvwTang[i].LargeImageList = ilstPhong;
                foreach (string tenPhong in tangList[i].tenPhong)
                {
                    lvwTang[i].Items.Add(new ListViewItem(tenPhong, 0)); //0: index of microphone_off_48x48 in (ImageList) ilstPhong
                }
            }
        }

        //overloadding function
        //option 1: chọn phòng trống (chuyển phòng)
        //option 2: chọn phòng đang được sử dụng (gộp phòng)
        public void LoadPhongList(
            ImageList ilstPhong,
            int soTang,
            ListView[] lvwTang,
            List<Tang> tangList,
            DevExpress.XtraTab.XtraTabControl xtcDanhSachLau,
            DevExpress.XtraTab.XtraTabPage[] xtpTang,
            string tenPhongHienTai, 
            int[][] tinhTrangPhong,
            int option)
        {
            //Lấy thông tin số tầng, khởi tạo XtraTabPage
            List<Tuple<string, int>> thongTinTang = DAO.PhongDAO.Instance.getThongTinTang();

            foreach (Tuple<string, int> tang in thongTinTang)
            {
                tangList.Add(new Tang(tangList.Count, tang.Item1, DAO.PhongDAO.Instance.getPhongListTheoTang(tang.Item1)));
            }

            for (int i = 0; i < soTang; i++)
            {
                xtpTang[i] = new DevExpress.XtraTab.XtraTabPage();
                lvwTang[i] = new System.Windows.Forms.ListView();
                //xtpTang[i].SuspendLayout();
                //xtpTang[i].ResumeLayout(false);

                // 
                // xtpTang
                // 
                int tenTang;
                xtpTang[i].Controls.Add(lvwTang[i]);
                xtpTang[i].Name = "xtpTang" + i;
                xtpTang[i].Size = new System.Drawing.Size(286, 409);

                // Nếu là tầng hầm thì giữ nguyên tên, nếu là tầng trên thì định dạng lại tên
                if (Int32.TryParse(thongTinTang[i].Item1, out tenTang))
                    xtpTang[i].Text = "Lầu " + thongTinTang[i].Item1;
                else
                    xtpTang[i].Text = thongTinTang[i].Item1;

                //
                xtcDanhSachLau.TabPages.Add(xtpTang[i]);

                // 
                // lvwTang
                // 
                lvwTang[i].Location = new System.Drawing.Point(4, 4);
                lvwTang[i].Name = "lvwTang" + i;
                lvwTang[i].Size = new System.Drawing.Size(279, 402);
                lvwTang[i].TabIndex = 0;
                lvwTang[i].TileSize = new System.Drawing.Size(70, 70);
                lvwTang[i].UseCompatibleStateImageBehavior = false;
                xtpTang[i].Controls.Add(lvwTang[i]);
            }

            xtcDanhSachLau.SelectedTabPage = xtpTang[0];

            ilstPhong.Images.Add("microphone_off", new Bitmap(global::KaraokeManager.Properties.Resources.microphone_off_48x48));
            ilstPhong.Images.Add("microphone_on", new Bitmap(global::KaraokeManager.Properties.Resources.microphone_on_48x48));

            ilstPhong.ImageSize = new Size(48, 48);
            ilstPhong.ColorDepth = ColorDepth.Depth32Bit;

            for (int i = 0; i < soTang; i++)
            {
                lvwTang[i].Columns.Add("Phong");
                lvwTang[i].LargeImageList = ilstPhong;
                for (int j = 0; j < tangList[i].tenPhong.Count; j++)
                {
                    if (tangList[i].tenPhong[j] != tenPhongHienTai)
                    switch (option)
                    {
                        case 1:
                            if (tinhTrangPhong[i][j] == 0)
                                lvwTang[i].Items.Add(new ListViewItem(tangList[i].tenPhong[j], 0)); //0: index of microphone_off_48x48 in (ImageList) ilstPhong
                            break;
                        case 2:
                            if (tinhTrangPhong[i][j] == 1)
                                lvwTang[i].Items.Add(new ListViewItem(tangList[i].tenPhong[j], 1)); //0: index of microphone_off_48x48 in (ImageList) ilstPhong
                            break;
                    }
                }
            }
        }

        public void LoadMatHangList(DevExpress.XtraGrid.GridControl gctDanhSachMatHang)
        {
            DataTable matHangList = DAO.MatHangDAO.Instance.getOverallMatHangList();
            gctDanhSachMatHang.DataSource = matHangList;
        }

        public void LoadLoaiMatHangList(DevExpress.XtraEditors.ListBoxControl lstPhanLoai)
        {
            lstPhanLoai.Items.Clear();
            lstPhanLoai.Items.AddRange(DAO.LoaiMatHangDAO.Instance.getTenLoaiMatHang());
        }

        public string tinhThoiGianHat(DateTime gioBatDau)
        {
            int hour = DateTime.Now.Hour - gioBatDau.Hour;
            int min = DateTime.Now.Minute - gioBatDau.Minute;
            string thoiGianHat = hour.ToString().PadLeft(2, '0') + ":" + min.ToString().PadLeft(2, '0');
            return thoiGianHat;
        }

        public int tinhTienGio(DateTime thoiGianHat, int giaGio)
        {
            return (int)((thoiGianHat.Hour + ((float)thoiGianHat.Minute) / 60) * giaGio);
        }

        public int tinhTienAnUong(DataTable dtMatHangDaChon)
        {
            int tienAnUong = 0;

            foreach (DataRow row in dtMatHangDaChon.Rows)
            {
                string value = row["ThanhTienDaChon"].ToString();
                tienAnUong += convertSeparatedStringToInt(value);
            }

            return tienAnUong;
        }


        public int convertSeparatedStringToInt(string s)
        {
            string result = s;
            string[] sign = new string[] { ",", "." };
            foreach (string i in sign)
            {
                result = result.Replace(i, string.Empty);
            }
            return Int32.Parse(result);
        }

        public int getIndexOfPhongByName(List<Tang> tangList, string tenPhong)
        {
            foreach (Tang t in tangList)
            {
                for(int i = 0; i < t.tenPhong.Count; i++)
                {
                    if (t.tenPhong[i] == tenPhong)
                        return i;
                }
            }
            return 0;
        }

        public int getIndexOfTangByNameOfPhong(List<Tang> tangList, string tenPhong)
        {
            for (int i = 0; i < tangList.Count; i++)
            {
                for (int j = 0; j < tangList[i].tenPhong.Count; j++)
                {
                    if (tangList[i].tenPhong[j] == tenPhong)
                        return i;
                }
            }
            return 0;
        }

        public string getTenTangByName(List<Tang> tangList, string tenPhong)
        {
            foreach (Tang t in tangList)
            {
                for (int i = 0; i < t.tenPhong.Count; i++)
                {
                    if (t.tenPhong[i] == tenPhong)
                        return t.ten;
                }
            }
            return null;
        }

        public int getIndexOfTangByName(List<Tang> tangList, string tenTang)
        {
            for(int i = 0; i < tangList.Count; i++)
            {
                if (tangList[i].ten == tenTang)
                    return i;
            }
            return 0;
        }

        public Phong getPhongByName(List<Phong> phongList, string tenPhong)
        {
            foreach (Phong p in phongList)
            {
                if (p.ten == tenPhong)
                    return p;
            }
            return null;
        }
    }
}
