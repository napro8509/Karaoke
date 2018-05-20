using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using KaraokeManager.DAO;
using KaraokeManager.DTO;

namespace KaraokeManager
{
    public partial class Form2 : DevExpress.XtraEditors.XtraForm
    {
        private List<MatHangDTO> matHangList;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UserControlMain.UCSuDungDichVu ucSuDungDichVu = new UserControlMain.UCSuDungDichVu();
            //ucSuDungDichVu.Dock = DockStyle.Fill;
            ucSuDungDichVu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            addTabControl(ucSuDungDichVu, "Sử dụng dịch vụ", "icons8-adjust-16");
        }

        private void xtraTabControlMain_ControlAdded(object sender, ControlEventArgs e)
        {
            xtraTabControlMain.SelectedTabPageIndex = xtraTabControlMain.TabPages.Count - 1;
        }

        private void addTabControl(UserControl userControl, string itemTabName, string icon)
        {
            bool isExist = false;

            foreach(XtraTabPage tabItem in xtraTabControlMain.TabPages)
            {
                if (tabItem.Text == itemTabName)
                {
                    isExist = true;
                    xtraTabControlMain.SelectedTabPage = tabItem;
                }
            }

            if (isExist == false)
            {
                AddTab addTab = new AddTab();
                addTab.AddTabControl(xtraTabControlMain, itemTabName, icon, userControl);
            }
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UserControlMain.UCThongKeDoanhThu ucThongKeDoanhThu = new UserControlMain.UCThongKeDoanhThu();
            addTabControl(ucThongKeDoanhThu, "Thống kê doanh thu", "icons8-chart-16");
        }

        private void xtraTabControlMain_CloseButtonClick(object sender, EventArgs e)
        {
            xtraTabControlMain.TabPages.RemoveAt(xtraTabControlMain.SelectedTabPageIndex);
            xtraTabControlMain.SelectedTabPageIndex = xtraTabControlMain.TabPages.Count - 1;
        }

    }
}
