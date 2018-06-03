using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KaraokeManager.DTO;
using KaraokeManager.DAO;
using KaraokeManager.Forms;
using KaraokeManager.Utilities;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid;

namespace KaraokeManager.UserControlMain
{
    public partial class UCSuDungDichVu : UserControl
    {
        //Lưu số tầng hiện có
        public int soTang;

        //Lưu thông tin tầng
        List<Tang> tangList;

        //Lưu thông tin các phòng đang được sử dụng
        List<Phong> phongList;

        //Lưu thông tin mặt hàng tại phòng đang được chọn
        public DataTable dtMatHangDaChon;

        public DevExpress.XtraTab.XtraTabPage[] xtpTang;
        public System.Windows.Forms.ListView[] lvwTang;
        Timer tmrThoiGianHat;
        const int giaGio = 100000;
        const float heSoThue = 0.1f;

        public UCSuDungDichVu()
        {
            InitializeComponent();

            tangList = new List<Tang>();
            phongList = new List<Phong>();
            tmrThoiGianHat = new Timer();

            //Thiết lập thông số mặc định
            tedGioBatDat.EditValue = new DateTime(1, 1, 1, DateTime.Now.Hour, DateTime.Now.Minute, 0);
            tedGioKetThuc.EditValue = new DateTime(1, 1, 1, DateTime.Now.Hour, DateTime.Now.Minute, 0);
            dedNgay.EditValue = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);

            //Khởi tạo thông tin tầng, phòng
            soTang = DAO.PhongDAO.Instance.getSoTang();
            xtpTang = new DevExpress.XtraTab.XtraTabPage[soTang];
            lvwTang = new ListView[soTang];

            Helpers.Instance.LoadPhongList(
                ilstPhong, 
                soTang, 
                lvwTang, 
                tangList,
                xtcDanhSachLau,
                xtpTang);
            Helpers.Instance.LoadMatHangList(gctDanhSachMatHang);
            Helpers.Instance.LoadLoaiMatHangList(lstPhanLoai);

            for (int i = 0; i < soTang; i++)
            {
                lvwTang[i].DoubleClick += new System.EventHandler(lvwTang_DoubleClick);
            }

        }

        private void UCSuDungDichVu_Load(Object sender, EventArgs e)
        {
            dtMatHangDaChon = new DataTable();
            dtMatHangDaChon.Clear();
            dtMatHangDaChon.Columns.Add("TenMatHangDaChon");
            dtMatHangDaChon.Columns.Add("DonViTinhDaChon");
            dtMatHangDaChon.Columns.Add("GiaDaChon");
            dtMatHangDaChon.Columns.Add("SoLuongDaChon");
            dtMatHangDaChon.Columns.Add("ThanhTienDaChon");

            txtThoiGianHat.Text = "00:00";
            tmrThoiGianHat.Interval = 60000;
            tmrThoiGianHat.Tick += new EventHandler(this.tmrThoiGianHat_Tick);
        }

        private void sbtnTimKiem_Click(object sender, EventArgs e)
        {
            if (phongList.Count > 0 || txtPhong.Text != "")
            {
                KhachHangList khl = new KhachHangList();
                if (khl.ShowDialog() == DialogResult.OK)
                {
                    txtTenKhachHang.Text = khl.KhachHang.Item1;
                    txtMaKH.Text = khl.KhachHang.Item2;
                }
            }
            else
            {
                MessageBox.Show("Bạn cần khởi động một phòng trước", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sbtnBatDat_Click(object sender, EventArgs e)
        {
            if (phongList.Count > 0 || txtPhong.Text != "")
            {
                tedGioBatDat.EditValue = new DateTime(1, 1, 1, DateTime.Now.Hour, DateTime.Now.Minute, 0);
                sbtnBatDat.Enabled = false;
                txtThoiGianHat.Text = "00:00";
                tmrThoiGianHat.Start();
            }
            else
            {
                MessageBox.Show("Bạn cần khởi động một phòng trước", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sbtnKetThuc_Click(object sender, EventArgs e)
        {
            if (phongList.Count > 0 || txtPhong.Text != "")
            {
                tedGioKetThuc.EditValue = new DateTime(1, 1, 1, DateTime.Now.Hour, DateTime.Now.Minute, 0);
                sbtnKetThuc.Enabled = false;
            }
            else
            {
                MessageBox.Show("Bạn cần khởi động một phòng trước", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvwDanhSachMatHang_DoubleClick(object sender, EventArgs e)
        {
            if (phongList.Count > 0 || txtPhong.Text != "")
            {
                //DXMouseEventArgs ea = e as DXMouseEventArgs;
                //GridView view = sender as GridView;
                //GridHitInfo info = view.CalcHitInfo(ea.Location);
                try
                {
                    GridView gridView = gctDanhSachMatHang.FocusedView as GridView;
                    DataRowView row = (DataRowView)gridView.GetRow(gridView.FocusedRowHandle);

                    String tenMatHang = row.Row.ItemArray[0].ToString();
                    String donViTinh = row.Row.ItemArray[1].ToString();
                    int gia = Int32.Parse(row.Row.ItemArray[2].ToString());
                    int soLuong = 1;
                    int thanhTien = soLuong * gia;

                    DataRow destRow = dtMatHangDaChon.NewRow();
                    destRow[0] = tenMatHang;
                    destRow[1] = donViTinh;
                    destRow[2] = String.Format("{0:n0}", gia);
                    destRow[3] = soLuong;
                    destRow[4] = String.Format("{0:n0}", thanhTien);
                    dtMatHangDaChon.Rows.Add(destRow);
                    gctMatHangDaChon.DataSource = dtMatHangDaChon;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Bạn cần khởi động một phòng trước", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvwMatHangDaChon_DoubleClick(object sender, EventArgs e)
        {
            if (phongList.Count > 0 || txtPhong.Text != "")
            {
                DXMouseEventArgs ea = e as DXMouseEventArgs;
                GridView view = sender as GridView;
                GridHitInfo info = view.CalcHitInfo(ea.Location);
                string tenMatHangDaChon = gvwMatHangDaChon.GetRowCellValue(info.RowHandle, "TenMatHangDaChon").ToString();
                string soLuongDaChon = gvwMatHangDaChon.GetRowCellValue(info.RowHandle, "SoLuongDaChon").ToString();
                NhapSoLuong nsl = new NhapSoLuong(tenMatHangDaChon, soLuongDaChon);
                if (nsl.ShowDialog() == DialogResult.OK)
                {
                    GridView gridView = gctMatHangDaChon.FocusedView as GridView;
                    DataRowView row = (DataRowView)gridView.GetRow(gridView.FocusedRowHandle);

                    String tenMatHang = row.Row.ItemArray[0].ToString();
                    String donViTinh = row.Row.ItemArray[1].ToString();
                    int gia = Helpers.Instance.convertSeparatedStringToInt(row.Row.ItemArray[2].ToString());
                    int soLuong = Int32.Parse(nsl.soLuong);
                    int thanhTien = soLuong * gia;

                    gvwMatHangDaChon.DeleteRow(view.FocusedRowHandle);

                    DataRow destRow = dtMatHangDaChon.NewRow();

                    destRow[0] = tenMatHang;
                    destRow[1] = donViTinh;
                    destRow[2] = String.Format("{0:n0}", gia);
                    destRow[3] = soLuong;
                    destRow[4] = String.Format("{0:n0}", thanhTien);

                    dtMatHangDaChon.Rows.Add(destRow);
                    gctMatHangDaChon.DataSource = dtMatHangDaChon;
                }
            }
            else
            {
                MessageBox.Show("Bạn cần khởi động một phòng trước", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstPhanLoai_Click(object sender, EventArgs e)
        {
            if (lstPhanLoai.SelectedItem.ToString() == "Tất cả")
            {
                Helpers.Instance.LoadMatHangList(gctDanhSachMatHang);
            }
            else
            {
                DataTable matHangList = DAO.MatHangDAO.Instance.getOverallMatHangListByLoai(lstPhanLoai.SelectedItem.ToString());
                gctDanhSachMatHang.DataSource = matHangList;
            }
        }

        private void sbtnThem_Click(object sender, EventArgs e)
        {
            if (phongList.Count > 0 || txtPhong.Text != "")
            {
                try
                {
                    GridView gridView = gctDanhSachMatHang.FocusedView as GridView;
                    DataRowView row = (DataRowView)gridView.GetRow(gridView.FocusedRowHandle);

                    String tenMatHang = row.Row.ItemArray[0].ToString();
                    String donViTinh = row.Row.ItemArray[1].ToString();
                    int soLuong = 1;
                    int gia = Int32.Parse(row.Row.ItemArray[2].ToString());
                    int thanhTien = soLuong * gia;

                    DataRow destRow = dtMatHangDaChon.NewRow();
                    destRow[0] = tenMatHang;
                    destRow[1] = donViTinh;
                    destRow[2] = String.Format("{0:n0}", gia);
                    destRow[3] = soLuong;
                    destRow[4] = String.Format("{0:n0}", thanhTien);
                    dtMatHangDaChon.Rows.Add(destRow);
                    gctMatHangDaChon.DataSource = dtMatHangDaChon;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Bạn cần khởi động một phòng trước", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sbtnBot_Click(object sender, EventArgs e)
        {
            if (phongList.Count > 0 || txtPhong.Text != "")
            {
                if (MessageBox.Show("Xoá mặt hàng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
                    DialogResult.Yes)
                    return;
                gvwMatHangDaChon.DeleteRow(gvwMatHangDaChon.FocusedRowHandle);
            }
            else
            {
                MessageBox.Show("Bạn cần khởi động một phòng trước", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lvwTang_DoubleClick(object sender, EventArgs e)
        {
            if (txtPhong.Text != "")    //nếu đã có phòng được chọn, lưu thông tin phòng cũ
            {
                foreach(Phong pre in phongList)
                {
                    if (pre.ten == txtPhong.Text)
                    {
                        foreach(Tang t in tangList) //tìm kiếm mã tầng
                        {
                            if (t.ten == txtTang.Text)
                            {
                                pre.tang = t.soThuTu;
                                break;
                            }
                        }
                        pre.gioBatDau = DateTime.ParseExact(tedGioBatDat.Text, "hh:mm tt", System.Globalization.CultureInfo.CurrentCulture);
                        pre.gioKetThuc = DateTime.ParseExact(tedGioKetThuc.Text, "hh:mm tt", System.Globalization.CultureInfo.CurrentCulture);
                        pre.ngay = DateTime.ParseExact(dedNgay.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.CurrentCulture);
                        pre.tenKhachHang = txtTenKhachHang.Text;
                        pre.maKhachHang = txtMaKH.Text;
                        pre.matHangDaChon = dtMatHangDaChon;
                        DateTime thoiGianHat = DateTime.ParseExact(txtThoiGianHat.Text, "hh:mm", System.Globalization.CultureInfo.CurrentCulture);
                        pre.tienGio = Helpers.Instance.tinhTienGio(thoiGianHat, giaGio);
                        pre.tienAnUong = Helpers.Instance.tinhTienAnUong(dtMatHangDaChon);
                        pre.phiDichVu = 0;
                        pre.tienThue = (int)(heSoThue * (pre.tienAnUong + pre.tienGio + pre.phiDichVu));
                        pre.tongCong = pre.tienGio + pre.tienAnUong + pre.phiDichVu + pre.tienThue;
                        break;
                    }
                }
            }

            //lấy thông tin phòng mới được chọn
            var lvw = (ListView)sender;
            string name = lvw.Name;
            int tang = Int32.Parse(name.Remove(0, 7));
            string maPhong;
            if (lvw.SelectedItems.Count == 0)
                return;
            else
            {
                maPhong = tangList[tang].tenPhong[lvw.SelectedItems[0].Index];
            }
            int thuTuPhong = lvwTang[tang].SelectedItems[0].Index;

            //kiểm tra phòng mới được chọn đã được sử dụng hay chưa
            bool isPhongMoi = false;
            if (lvwTang[tang].Items[thuTuPhong].ImageIndex == 0)
            {
                isPhongMoi = true;
                lvwTang[tang].Items[thuTuPhong].ImageIndex = 1;
            }

            if (isPhongMoi) //nếu là phòng chưa được sử dụng thì tạo mới
            {
                sbtnBatDat.Enabled = true;
                Phong p = new Phong(
                    phongList.Count, 
                    tang, 
                    maPhong,
                    true,
                    DateTime.ParseExact(tedGioBatDat.Text, "hh:mm tt", System.Globalization.CultureInfo.CurrentCulture),
                    DateTime.ParseExact(tedGioKetThuc.Text, "hh:mm tt", System.Globalization.CultureInfo.CurrentCulture),
                    DateTime.ParseExact(dedNgay.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.CurrentCulture),
                    "",
                    "",
                    new DataTable(),
                    0,
                    0,
                    0,
                    0,
                    0);

                phongList.Add(p);

                tedGioBatDat.EditValue = new DateTime(1, 1, 1, DateTime.Now.Hour, DateTime.Now.Minute, 0);
                tedGioKetThuc.EditValue = new DateTime(1, 1, 1, DateTime.Now.Hour, DateTime.Now.Minute, 0);
                //dedNgay.EditValue = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
                txtTenKhachHang.Text = "";
                txtMaKH.Text = "";

                dtMatHangDaChon = new DataTable();
                dtMatHangDaChon.Clear();
                dtMatHangDaChon.Columns.Add("TenMatHangDaChon");
                dtMatHangDaChon.Columns.Add("DonViTinhDaChon");
                dtMatHangDaChon.Columns.Add("GiaDaChon");
                dtMatHangDaChon.Columns.Add("SoLuongDaChon");
                dtMatHangDaChon.Columns.Add("ThanhTienDaChon");

                gctMatHangDaChon.DataSource = dtMatHangDaChon;
                txtThoiGianHat.Text = "00:00";
                txtTienGio.Text = "0";
                txtTienAnUong.Text = "0";
                txtPhiDichVu.Text = "0";
                txtTienThue.Text = "0";
                txtTongCong.Text = "0";
            }
            else
            {   //nếu là phòng đã được sử dụng thì load thông tin phòng ra
                foreach(Phong p in phongList)
                {
                    if (p.ten == maPhong)
                    {
                        tedGioBatDat.Text = p.gioBatDau.ToString("hh:mm tt");
                        tedGioKetThuc.Text = p.gioKetThuc.ToString("hh:mm tt");
                        dedNgay.Text = p.ngay.ToString("dd/MM/yyyy");
                        txtTenKhachHang.Text = p.tenKhachHang;
                        txtMaKH.Text = p.maKhachHang;

                        dtMatHangDaChon = new DataTable();
                        dtMatHangDaChon.Clear();
                        dtMatHangDaChon.Columns.Add("TenMatHangDaChon");
                        dtMatHangDaChon.Columns.Add("DonViTinhDaChon");
                        dtMatHangDaChon.Columns.Add("GiaDaChon");
                        dtMatHangDaChon.Columns.Add("SoLuongDaChon");
                        dtMatHangDaChon.Columns.Add("ThanhTienDaChon");
                        dtMatHangDaChon = p.matHangDaChon;

                        gctMatHangDaChon.DataSource = dtMatHangDaChon;
                        txtThoiGianHat.Text = Helpers.Instance.tinhThoiGianHat(p.gioBatDau);
                        txtTienGio.Text = String.Format("{0:n0}", p.tienGio);
                        txtTienAnUong.Text = String.Format("{0:n0}", p.tienAnUong);
                        txtPhiDichVu.Text = String.Format("{0:n0}", p.phiDichVu);
                        txtTongCong.Text = String.Format("{0:n0}", p.tongCong);
                        break;
                    }
                }
            }
            txtPhong.Text = maPhong;
            txtTang.Text = tangList[tang].ten;
        }

        private void tmrThoiGianHat_Tick(object sender, EventArgs e)
        {
            if (sbtnBatDat.Enabled == false)
            {
                DateTime gioBatDau = DateTime.ParseExact(tedGioBatDat.Text, "hh:mm tt", System.Globalization.CultureInfo.CurrentCulture);
                txtThoiGianHat.Text = Helpers.Instance.tinhThoiGianHat(gioBatDau);
            }
        }

        private void gvwMatHangDaChon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && e.Modifiers == Keys.Control)
            {
                if (MessageBox.Show("Xóa mặt hàng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
                  DialogResult.Yes)
                    return;
                GridView view = sender as GridView;
                view.DeleteRow(view.FocusedRowHandle);
            }
        }

        private void sbtnChuyenPhong_Click(object sender, EventArgs e)
        {
            if (phongList.Count > 0 || txtPhong.Text != "")
            {
                int[][] tinhTrangPhong = new int[soTang][];
                string tenPhongHienTai = txtPhong.Text;
                int soThuTuPhongHienTai = Helpers.Instance.getIndexOfPhongByName(tangList, tenPhongHienTai);
                int soThuTuTangHienTai = Helpers.Instance.getIndexOfTangByNameOfPhong(tangList, tenPhongHienTai);

                for (int i = 0; i < soTang; i++)
                {
                    tinhTrangPhong[i] = new int[tangList[i].tenPhong.Count];
                    for (int j = 0; j < tangList[i].tenPhong.Count; j++)
                    {
                        tinhTrangPhong[i][j] = lvwTang[i].Items[j].ImageIndex;
                    }
                }
                ChonPhong cp = new ChonPhong(tenPhongHienTai, tinhTrangPhong, 1);
                if (cp.ShowDialog() == DialogResult.OK)
                {
                    string tenPhongChuyen = cp.tenPhongDuocChon;
                    string tenTangChuyen = Helpers.Instance.getTenTangByName(tangList, cp.tenPhongDuocChon);
                    int soThuTuPhongChuyen = Helpers.Instance.getIndexOfPhongByName(tangList, cp.tenPhongDuocChon);
                    int soThuTuTangChuyen = Helpers.Instance.getIndexOfTangByName(tangList, tenTangChuyen);

                    txtPhong.Text = tenPhongChuyen;
                    txtTang.Text = tenTangChuyen;

                    Phong phongHienTai = Helpers.Instance.getPhongByName(phongList, tenPhongHienTai);

                    Phong p = new Phong(
                    phongHienTai.soThuTu,
                    soThuTuTangChuyen,
                    tenPhongChuyen,
                    true,
                    phongHienTai.gioBatDau,
                    phongHienTai.gioKetThuc,
                    phongHienTai.ngay,
                    phongHienTai.maKhachHang,
                    phongHienTai.tenKhachHang,
                    phongHienTai.matHangDaChon,
                    phongHienTai.tienGio,
                    phongHienTai.tienAnUong,
                    phongHienTai.phiDichVu,
                    phongHienTai.tienThue,
                    phongHienTai.tongCong);

                    phongList.Add(p);

                    phongList.Remove(phongHienTai);

                    lvwTang[soThuTuTangHienTai].Items[soThuTuPhongHienTai].ImageIndex = 0;
                    lvwTang[soThuTuTangChuyen].Items[soThuTuPhongChuyen].ImageIndex = 1;
                }
            }
            else
            {
                MessageBox.Show("Bạn cần khởi động một phòng trước", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sbtnGopPhong_Click(object sender, EventArgs e)
        {
            if (phongList.Count > 0 || txtPhong.Text != "")
            {
                int[][] tinhTrangPhong = new int[soTang][];
                string tenPhongHienTai = txtPhong.Text;
                int soThuTuPhongHienTai = Helpers.Instance.getIndexOfPhongByName(tangList, tenPhongHienTai);
                int soThuTuTangHienTai = Helpers.Instance.getIndexOfTangByNameOfPhong(tangList, tenPhongHienTai);

                for (int i = 0; i < soTang; i++)
                {
                    tinhTrangPhong[i] = new int[tangList[i].tenPhong.Count];
                    for (int j = 0; j < tangList[i].tenPhong.Count; j++)
                    {
                        tinhTrangPhong[i][j] = lvwTang[i].Items[j].ImageIndex;
                    }
                }
                ChonPhong cp = new ChonPhong(tenPhongHienTai, tinhTrangPhong, 2);
                if (cp.ShowDialog() == DialogResult.OK)
                {
                    string tenPhongGop = cp.tenPhongDuocChon;
                    string tenTangGop = Helpers.Instance.getTenTangByName(tangList, cp.tenPhongDuocChon);
                    int soThuTuPhongGop = Helpers.Instance.getIndexOfPhongByName(tangList, cp.tenPhongDuocChon);
                    int soThuTuTangGop = Helpers.Instance.getIndexOfTangByName(tangList, tenTangGop);

                    txtPhong.Text = tenPhongGop;
                    txtTang.Text = tenTangGop;

                    Phong phongHienTai = Helpers.Instance.getPhongByName(phongList, tenPhongHienTai);
                    Phong phongGop = Helpers.Instance.getPhongByName(phongList, tenPhongGop);
                    DateTime gioBatDau = DateTime.Compare(phongHienTai.gioBatDau, phongGop.gioBatDau) < 0 ? phongHienTai.gioBatDau : phongGop.gioBatDau;
                    DateTime gioKetThuc = DateTime.Compare(phongHienTai.gioKetThuc, phongGop.gioKetThuc) < 0 ? phongHienTai.gioKetThuc : phongGop.gioKetThuc;

                    DataTable dtUnion = phongHienTai.matHangDaChon.AsEnumerable()
  .Union(phongGop.matHangDaChon.AsEnumerable()).CopyToDataTable<DataRow>();

                    gctMatHangDaChon.DataSource = dtUnion;

                    int tienGio = phongHienTai.tienGio + phongGop.tienGio;
                    int tienAnUong = phongHienTai.tienAnUong + phongGop.tienAnUong;
                    int phiDichVu = phongHienTai.phiDichVu + phongGop.phiDichVu;
                    int tienThue = phongHienTai.tienThue + phongGop.tienThue;
                    int tongCong = phongHienTai.tongCong + phongGop.tongCong;

                    txtTienGio.Text = String.Format("{0:n0}", tienGio);
                    txtTienAnUong.Text = String.Format("{0:n0}", tienAnUong);
                    txtPhiDichVu.Text = String.Format("{0:n0}", phiDichVu);
                    txtTienThue.Text = String.Format("{0:n0}", tienThue);
                    txtTongCong.Text = String.Format("{0:n0}", tongCong);

                    Phong p = new Phong(
                    phongHienTai.soThuTu,
                    soThuTuTangGop,
                    tenPhongGop,
                    true,
                    gioBatDau,
                    gioKetThuc,
                    phongGop.ngay,
                    phongGop.maKhachHang,
                    phongGop.tenKhachHang,
                    dtUnion,
                    tienGio,
                    tienAnUong,
                    phiDichVu,
                    tienThue,
                    tongCong);

                    phongList.Remove(phongHienTai);
                    phongList.Remove(phongGop);

                    phongList.Add(p);

                    lvwTang[soThuTuTangHienTai].Items[soThuTuPhongHienTai].ImageIndex = 0;
                }
            }
            else
            {
                MessageBox.Show("Bạn cần khởi động một phòng trước", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sbtnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                int maKhachHang = Int32.Parse(txtMaKH.Text);
                string maPhong = txtPhong.Text;
                DateTime gioBatDau = DateTime.ParseExact(tedGioBatDat.Text, "hh:mm tt", System.Globalization.CultureInfo.CurrentCulture);
                DateTime gioKetThuc = DateTime.ParseExact(tedGioKetThuc.Text, "hh:mm tt", System.Globalization.CultureInfo.CurrentCulture);
                int tienGio = Helpers.Instance.convertSeparatedStringToInt(txtTienGio.Text);
                int tienAnUong = Helpers.Instance.convertSeparatedStringToInt(txtTienAnUong.Text);
                int phiDichVu = Helpers.Instance.convertSeparatedStringToInt(txtPhiDichVu.Text);
                int giamGia = 0;
                int tienThue = Helpers.Instance.convertSeparatedStringToInt(txtTienThue.Text);
                int tongCong = Helpers.Instance.convertSeparatedStringToInt(txtTongCong.Text);
                DateTime ngay = DateTime.ParseExact(dedNgay.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.CurrentCulture);
                int maNguoiThu = 1;
                int tienKhachHangDua = tongCong;

                
                if (DAO.HoaDonKhachHangDAO.Instance.addHoaDonKhachHang(
                        maKhachHang,
                        maPhong,
                        gioBatDau,
                        gioKetThuc,
                        tienGio,
                        tienAnUong,
                        phiDichVu,
                        giamGia,
                        tienThue,
                        tongCong,
                        ngay,
                        maNguoiThu,
                        tienKhachHangDua))
                {
                    MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                DataTable dataTable = (DataTable) gctMatHangDaChon.DataSource;
                foreach (DataRow row in dataTable.Rows)
                {
                    int maHoaDonKhachHang = DAO.HoaDonKhachHangDAO.Instance.getMaxMaHoaDonKhachHang();
                    string tenMatHangDaChon = row["TenMatHangDaChon"].ToString();
                    int maMatHang = DAO.MatHangDAO.Instance.getMaMatHangByTenMatHang(tenMatHangDaChon);
                    int soLuongCTHDKH = Int32.Parse(row["SoLuongDaChon"].ToString());
                    int thanhTien = Helpers.Instance.convertSeparatedStringToInt(row["ThanhTienDaChon"].ToString());

                    DAO.ChiTietHDKHDAO.Instance.addChiTietHDKH(
                            maHoaDonKhachHang,
                            maMatHang,
                            soLuongCTHDKH,
                            thanhTien);
                }

                resetAllControl();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void resetAllControl()
        {
            //Thiết lập thông số mặc định
            tedGioBatDat.EditValue = new DateTime(1, 1, 1, DateTime.Now.Hour, DateTime.Now.Minute, 0);
            tedGioKetThuc.EditValue = new DateTime(1, 1, 1, DateTime.Now.Hour, DateTime.Now.Minute, 0);
            dedNgay.EditValue = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);

            txtThoiGianHat.Text = "00:00";
            txtTang.Text = string.Empty;
            txtPhong.Text = string.Empty;
            txtTenKhachHang.Text = string.Empty;
            txtMaKH.Text = string.Empty;
            txtTienGio.Text = string.Empty;
            txtTienAnUong.Text = string.Empty;
            txtPhiDichVu.Text = string.Empty;
            txtTienThue.Text = string.Empty;
            txtTongCong.Text = string.Empty;

            gctMatHangDaChon.DataSource = new DataTable();
        }
    }
}
