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

namespace KaraokeManager.Forms
{
    public partial class NhapSoLuong : DevExpress.XtraEditors.XtraForm
    {
        public string soLuong { get; set; }

        public NhapSoLuong(string tenMatHang, string soLuong)
        {
            InitializeComponent();
            lblMoTa.Text += tenMatHang;
            txtSoLuong.Text = soLuong;
        }

        private void sbtnDongY_Click(object sender, EventArgs e)
        {
            soLuong = txtSoLuong.Text;
            this.DialogResult = DialogResult.OK; //Trở về MainForm
        }

        private void sbtnHuyBo_Click(object sender, EventArgs e)
        {
            soLuong = txtSoLuong.Text;
            this.DialogResult = DialogResult.OK; //Trở về MainForm
        }
    }
}