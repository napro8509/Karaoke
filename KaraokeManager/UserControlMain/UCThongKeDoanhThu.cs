﻿using System;
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
    public partial class UCThongKeDoanhThu : UserControl
    {
        public UCThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void UCThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
    }
}
