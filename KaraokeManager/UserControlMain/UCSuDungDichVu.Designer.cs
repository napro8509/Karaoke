namespace KaraokeManager.UserControlMain
{
    partial class UCSuDungDichVu
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.xtpDanhSachLau = new DevExpress.XtraTab.XtraTabControl();
            this.xtpLau1 = new DevExpress.XtraTab.XtraTabPage();
            this.lvwLau1 = new System.Windows.Forms.ListView();
            this.xtpLau2 = new DevExpress.XtraTab.XtraTabPage();
            this.xtpLau3 = new DevExpress.XtraTab.XtraTabPage();
            this.spnlPhong = new DevExpress.XtraEditors.SidePanel();
            this.spnlDatHang = new DevExpress.XtraEditors.SidePanel();
            this.timeEdit1 = new DevExpress.XtraEditors.TimeEdit();
            this.listView1 = new System.Windows.Forms.ListView();
            this.TenMatHang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DonViTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaMatHang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.xtpDanhSachLau)).BeginInit();
            this.xtpDanhSachLau.SuspendLayout();
            this.xtpLau1.SuspendLayout();
            this.spnlPhong.SuspendLayout();
            this.spnlDatHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtpDanhSachLau
            // 
            this.xtpDanhSachLau.Location = new System.Drawing.Point(3, 3);
            this.xtpDanhSachLau.Name = "xtpDanhSachLau";
            this.xtpDanhSachLau.SelectedTabPage = this.xtpLau1;
            this.xtpDanhSachLau.Size = new System.Drawing.Size(226, 495);
            this.xtpDanhSachLau.TabIndex = 0;
            this.xtpDanhSachLau.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtpLau1,
            this.xtpLau2,
            this.xtpLau3});
            // 
            // xtpLau1
            // 
            this.xtpLau1.Controls.Add(this.lvwLau1);
            this.xtpLau1.Name = "xtpLau1";
            this.xtpLau1.Size = new System.Drawing.Size(220, 467);
            this.xtpLau1.Text = "Lầu 1";
            // 
            // lvwLau1
            // 
            this.lvwLau1.Location = new System.Drawing.Point(4, 4);
            this.lvwLau1.Name = "lvwLau1";
            this.lvwLau1.Size = new System.Drawing.Size(289, 460);
            this.lvwLau1.TabIndex = 0;
            this.lvwLau1.UseCompatibleStateImageBehavior = false;
            // 
            // xtpLau2
            // 
            this.xtpLau2.Name = "xtpLau2";
            this.xtpLau2.Size = new System.Drawing.Size(220, 467);
            this.xtpLau2.Text = "Lầu 2";
            // 
            // xtpLau3
            // 
            this.xtpLau3.Name = "xtpLau3";
            this.xtpLau3.Size = new System.Drawing.Size(220, 467);
            this.xtpLau3.Text = "Lầu 3";
            // 
            // spnlPhong
            // 
            this.spnlPhong.Controls.Add(this.xtpDanhSachLau);
            this.spnlPhong.Location = new System.Drawing.Point(3, 3);
            this.spnlPhong.Name = "spnlPhong";
            this.spnlPhong.Size = new System.Drawing.Size(234, 499);
            this.spnlPhong.TabIndex = 1;
            this.spnlPhong.Text = "sidePanel1";
            // 
            // spnlDatHang
            // 
            this.spnlDatHang.Controls.Add(this.timeEdit1);
            this.spnlDatHang.Controls.Add(this.listView1);
            this.spnlDatHang.Location = new System.Drawing.Point(243, 0);
            this.spnlDatHang.Name = "spnlDatHang";
            this.spnlDatHang.Size = new System.Drawing.Size(592, 502);
            this.spnlDatHang.TabIndex = 2;
            this.spnlDatHang.Text = "sidePanel2";
            // 
            // timeEdit1
            // 
            this.timeEdit1.EditValue = new System.DateTime(2018, 5, 16, 0, 0, 0, 0);
            this.timeEdit1.Location = new System.Drawing.Point(4, 7);
            this.timeEdit1.Name = "timeEdit1";
            this.timeEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeEdit1.Size = new System.Drawing.Size(90, 20);
            this.timeEdit1.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaMatHang,
            this.TenMatHang,
            this.DonViTinh,
            this.Gia});
            this.listView1.Location = new System.Drawing.Point(377, 179);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(212, 317);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // TenMatHang
            // 
            this.TenMatHang.DisplayIndex = 0;
            // 
            // DonViTinh
            // 
            this.DonViTinh.DisplayIndex = 1;
            // 
            // Gia
            // 
            this.Gia.DisplayIndex = 2;
            // 
            // MaMatHang
            // 
            this.MaMatHang.DisplayIndex = 3;
            // 
            // UCSuDungDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.spnlDatHang);
            this.Controls.Add(this.spnlPhong);
            this.Name = "UCSuDungDichVu";
            this.Size = new System.Drawing.Size(835, 502);
            ((System.ComponentModel.ISupportInitialize)(this.xtpDanhSachLau)).EndInit();
            this.xtpDanhSachLau.ResumeLayout(false);
            this.xtpLau1.ResumeLayout(false);
            this.spnlPhong.ResumeLayout(false);
            this.spnlDatHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtpDanhSachLau;
        private DevExpress.XtraTab.XtraTabPage xtpLau1;
        private DevExpress.XtraTab.XtraTabPage xtpLau2;
        private DevExpress.XtraTab.XtraTabPage xtpLau3;
        private System.Windows.Forms.ListView lvwLau1;
        private DevExpress.XtraEditors.SidePanel spnlPhong;
        private DevExpress.XtraEditors.SidePanel spnlDatHang;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader TenMatHang;
        private System.Windows.Forms.ColumnHeader DonViTinh;
        private System.Windows.Forms.ColumnHeader Gia;
        private DevExpress.XtraEditors.TimeEdit timeEdit1;
        private System.Windows.Forms.ColumnHeader MaMatHang;
    }
}
