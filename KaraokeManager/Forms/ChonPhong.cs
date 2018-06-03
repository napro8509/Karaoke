using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using KaraokeManager.Utilities;

namespace KaraokeManager.Forms
{
    public partial class ChonPhong : DevExpress.XtraEditors.XtraForm
    {
        public int soTang;
        List<Tang> tangList;
        List<Phong> phongList;
        public DevExpress.XtraTab.XtraTabPage[] xtpTang;
        public System.Windows.Forms.ListView[] lvwTang;
        public int cheDo;
        public string tenPhongHienTai;
        public string tenPhongDuocChon;

        //option 1: chọn phòng trống (chuyển phòng)
        //option 2: chọn phòng đang được sử dụng (gộp phòng)
        public ChonPhong(string tenPhongHienTai, int[][] tinhTrangPhong, int option)
        {
            InitializeComponent();

            tangList = new List<Tang>();
            phongList = new List<Phong>();

            //Khởi tạo thông tin tầng, phòng
            soTang = DAO.PhongDAO.Instance.getSoTang();
            xtpTang = new DevExpress.XtraTab.XtraTabPage[soTang];
            lvwTang = new ListView[soTang];
            this.cheDo = option;
            this.tenPhongHienTai = tenPhongHienTai;

            switch (cheDo)
            {
                case 1:
                    Helpers.Instance.LoadPhongList(
                        ilstPhong,
                        soTang,
                        lvwTang,
                        tangList,
                        xtcDanhSachLau,
                        xtpTang,
                        tenPhongHienTai,
                        tinhTrangPhong,
                        1);
                    break;
                case 2:
                    Helpers.Instance.LoadPhongList(
                        ilstPhong,
                        soTang,
                        lvwTang,
                        tangList,
                        xtcDanhSachLau,
                        xtpTang,
                        tenPhongHienTai,
                        tinhTrangPhong,
                        2);
                    break;
            }

            for (int i = 0; i < soTang; i++)
            {
                lvwTang[i].DoubleClick += new System.EventHandler(lvwTang_DoubleClick);
            }
        }

        private void lvwTang_DoubleClick(object sender, EventArgs e)
        {
            var lvw = (ListView)sender;
            string name = lvw.SelectedItems[0].Text;
            string text = " dữ liệu từ phòng " + tenPhongHienTai + " qua phòng " + name;
            switch (cheDo)
            {
                case 1:
                    if (MessageBox.Show("Chuyển" + text, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
  DialogResult.Yes)
                        return;
                    else
                    {
                        tenPhongDuocChon = name;
                        this.DialogResult = DialogResult.OK;
                    }
                    break;
                case 2:
                    if (MessageBox.Show("Gộp" + text, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
DialogResult.Yes)
                        return;
                    else
                    {
                        tenPhongDuocChon = name;
                        this.DialogResult = DialogResult.OK;
                    }
                    break;
            }
        }
    }
}