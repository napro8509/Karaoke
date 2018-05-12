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

namespace KaraokeManager
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UserControlMain.UCSuDungDichVu ucSuDungDichVu = new UserControlMain.UCSuDungDichVu();
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
    }
}
