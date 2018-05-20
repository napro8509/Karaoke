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
            this.xtpHam = new DevExpress.XtraTab.XtraTabPage();
            this.xtpLau1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtpLau2 = new DevExpress.XtraTab.XtraTabPage();
            this.spnlPhong = new DevExpress.XtraEditors.SidePanel();
            this.spnlDatHang = new DevExpress.XtraEditors.SidePanel();
            this.timeEdit1 = new DevExpress.XtraEditors.TimeEdit();
            this.listView1 = new System.Windows.Forms.ListView();
            this.MaMatHang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenMatHang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DonViTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwHam = new System.Windows.Forms.ListView();
            this.lvwLau1 = new System.Windows.Forms.ListView();
            this.lvwLau2 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.xtpDanhSachLau)).BeginInit();
            this.xtpDanhSachLau.SuspendLayout();
            this.xtpHam.SuspendLayout();
            this.xtpLau1.SuspendLayout();
            this.xtpLau2.SuspendLayout();
            this.spnlPhong.SuspendLayout();
            this.spnlDatHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtpDanhSachLau
            // 
            this.xtpDanhSachLau.Location = new System.Drawing.Point(3, 10);
            this.xtpDanhSachLau.Name = "xtpDanhSachLau";
            this.xtpDanhSachLau.SelectedTabPage = this.xtpHam;
            this.xtpDanhSachLau.Size = new System.Drawing.Size(226, 437);
            this.xtpDanhSachLau.TabIndex = 0;
            this.xtpDanhSachLau.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtpHam,
            this.xtpLau1,
            this.xtpLau2});
            // 
            // xtpHam
            // 
            this.xtpHam.Controls.Add(this.lvwHam);
            this.xtpHam.Name = "xtpHam";
            this.xtpHam.Size = new System.Drawing.Size(220, 409);
            this.xtpHam.Text = "Hầm";
            // 
            // xtpLau1
            // 
            this.xtpLau1.Controls.Add(this.lvwLau1);
            this.xtpLau1.Name = "xtpLau1";
            this.xtpLau1.Size = new System.Drawing.Size(220, 409);
            this.xtpLau1.Text = "Lầu 1";
            // 
            // xtpLau2
            // 
            this.xtpLau2.Controls.Add(this.lvwLau2);
            this.xtpLau2.Name = "xtpLau2";
            this.xtpLau2.Size = new System.Drawing.Size(220, 409);
            this.xtpLau2.Text = "Lầu 2";
            // 
            // spnlPhong
            // 
            this.spnlPhong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.spnlPhong.Controls.Add(this.xtpDanhSachLau);
            this.spnlPhong.Location = new System.Drawing.Point(3, 0);
            this.spnlPhong.Name = "spnlPhong";
            this.spnlPhong.Size = new System.Drawing.Size(234, 453);
            this.spnlPhong.TabIndex = 1;
            this.spnlPhong.Text = "sidePanel1";
            // 
            // spnlDatHang
            // 
            this.spnlDatHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.spnlDatHang.Controls.Add(this.timeEdit1);
            this.spnlDatHang.Controls.Add(this.listView1);
            this.spnlDatHang.Location = new System.Drawing.Point(243, 0);
            this.spnlDatHang.Name = "spnlDatHang";
            this.spnlDatHang.Size = new System.Drawing.Size(592, 453);
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
            this.listView1.Location = new System.Drawing.Point(365, 125);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(212, 317);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // MaMatHang
            // 
            this.MaMatHang.DisplayIndex = 3;
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
            // lvwHam
            // 
            this.lvwHam.Location = new System.Drawing.Point(4, 4);
            this.lvwHam.Name = "lvwHam";
            this.lvwHam.Size = new System.Drawing.Size(213, 402);
            this.lvwHam.TabIndex = 0;
            this.lvwHam.UseCompatibleStateImageBehavior = false;
            this.lvwHam.View = System.Windows.Forms.View.Tile;
            // 
            // lvwLau1
            // 
            this.lvwLau1.Location = new System.Drawing.Point(4, 3);
            this.lvwLau1.Name = "lvwLau1";
            this.lvwLau1.Size = new System.Drawing.Size(213, 403);
            this.lvwLau1.TabIndex = 1;
            this.lvwLau1.UseCompatibleStateImageBehavior = false;
            this.lvwLau1.View = System.Windows.Forms.View.Tile;
            // 
            // lvwLau2
            // 
            this.lvwLau2.Location = new System.Drawing.Point(4, 5);
            this.lvwLau2.Name = "lvwLau2";
            this.lvwLau2.Size = new System.Drawing.Size(213, 401);
            this.lvwLau2.TabIndex = 1;
            this.lvwLau2.UseCompatibleStateImageBehavior = false;
            this.lvwLau2.View = System.Windows.Forms.View.Tile;
            // 
            // UCSuDungDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.spnlDatHang);
            this.Controls.Add(this.spnlPhong);
            this.Name = "UCSuDungDichVu";
            this.Size = new System.Drawing.Size(835, 453);
            this.Load += new System.EventHandler(this.UCSuDungDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtpDanhSachLau)).EndInit();
            this.xtpDanhSachLau.ResumeLayout(false);
            this.xtpHam.ResumeLayout(false);
            this.xtpLau1.ResumeLayout(false);
            this.xtpLau2.ResumeLayout(false);
            this.spnlPhong.ResumeLayout(false);
            this.spnlDatHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtpDanhSachLau;
        private DevExpress.XtraTab.XtraTabPage xtpHam;
        private DevExpress.XtraTab.XtraTabPage xtpLau1;
        private DevExpress.XtraTab.XtraTabPage xtpLau2;
        private DevExpress.XtraEditors.SidePanel spnlPhong;
        private DevExpress.XtraEditors.SidePanel spnlDatHang;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader TenMatHang;
        private System.Windows.Forms.ColumnHeader DonViTinh;
        private System.Windows.Forms.ColumnHeader Gia;
        private DevExpress.XtraEditors.TimeEdit timeEdit1;
        private System.Windows.Forms.ColumnHeader MaMatHang;
        private System.Windows.Forms.ListView lvwHam;
        private System.Windows.Forms.ListView lvwLau1;
        private System.Windows.Forms.ListView lvwLau2;
    }
}
