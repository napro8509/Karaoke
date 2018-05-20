using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaraokeManager.UserControlMain
{
    public partial class UCSuDungDichVu : UserControl
    {
        public UCSuDungDichVu()
        {
            InitializeComponent();
        }

        private void UCSuDungDichVu_Load(Object sender, EventArgs e)
        {
            MessageBox.Show("You are in the UserControl.Load event.");
            LoadPhongList();
        }

        private void LoadPhongList()
        {
            List<string> hamList = DAO.PhongDAO.Instance.getPhongListTheoTang("Hầm");
            List<string> lau1List = DAO.PhongDAO.Instance.getPhongListTheoTang("1");
            List<string> lau2List = DAO.PhongDAO.Instance.getPhongListTheoTang("2");
            lvwHam.Columns.Add("Phong");
            lvwLau1.Columns.Add("Phong");
            lvwLau2.Columns.Add("Phong");
            foreach (string tenPhong in hamList)
            {
                lvwHam.Items.Add(tenPhong);
            }
            foreach (string tenPhong in lau1List)
            {
                lvwLau1.Items.Add(tenPhong);
            }
            foreach (string tenPhong in lau2List)
            {
                lvwLau2.Items.Add(tenPhong);
            }
        }
    }
}
