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
using DevExpress.XtraGrid.Columns;
using KaraokeManager.DAO;
using KaraokeManager.DTO;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace KaraokeManager
{
    public partial class KhachHangList : DevExpress.XtraEditors.XtraForm
    {
        private Tuple<string, string> khachHang;

        public Tuple<string, string> KhachHang
        {
            get { return khachHang; }
            set { khachHang = value; }
        }
        public KhachHangList()
        {
            InitializeComponent();
        }

        private void KhachHangList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'maKHTenKH.uspGetMaKHTenKH' table. You can move, or remove it, as needed.
            this.uspGetMaKHTenKHTableAdapter.Fill(this.maKHTenKH.uspGetMaKHTenKH);
        }

        private void gvwDanhSachKhachHang_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);

            string hoTenKH = "";
            try
            {
                hoTenKH = gvwDanhSachKhachHang.GetRowCellValue(info.RowHandle, "HoTenKH").ToString();
                string maKhachHang = (info.RowHandle + 1).ToString();
                khachHang = new Tuple<string, string>(hoTenKH, maKhachHang);
                this.DialogResult = DialogResult.OK; //Trở về MainForm

                //if (info.InRow || info.InRowCell)
                //{
                //    string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}