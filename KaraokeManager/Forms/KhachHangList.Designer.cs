namespace KaraokeManager
{
    partial class KhachHangList
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gctDanhSachKhachHang = new DevExpress.XtraGrid.GridControl();
            this.uspGetMaKHTenKHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maKHTenKH = new KaraokeManager.DataSet.MaKHTenKH();
            this.gvwDanhSachKhachHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoTenKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.uspGetMaKHTenKHTableAdapter = new KaraokeManager.DataSet.MaKHTenKHTableAdapters.uspGetMaKHTenKHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gctDanhSachKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspGetMaKHTenKHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maKHTenKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwDanhSachKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // gctDanhSachKhachHang
            // 
            this.gctDanhSachKhachHang.DataSource = this.uspGetMaKHTenKHBindingSource;
            this.gctDanhSachKhachHang.Location = new System.Drawing.Point(13, 13);
            this.gctDanhSachKhachHang.MainView = this.gvwDanhSachKhachHang;
            this.gctDanhSachKhachHang.Name = "gctDanhSachKhachHang";
            this.gctDanhSachKhachHang.Size = new System.Drawing.Size(580, 298);
            this.gctDanhSachKhachHang.TabIndex = 0;
            this.gctDanhSachKhachHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwDanhSachKhachHang});
            // 
            // uspGetMaKHTenKHBindingSource
            // 
            this.uspGetMaKHTenKHBindingSource.DataMember = "uspGetMaKHTenKH";
            this.uspGetMaKHTenKHBindingSource.DataSource = this.maKHTenKH;
            // 
            // maKHTenKH
            // 
            this.maKHTenKH.DataSetName = "MaKHTenKH";
            this.maKHTenKH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvwDanhSachKhachHang
            // 
            this.gvwDanhSachKhachHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaKhachHang,
            this.colHoTenKH});
            this.gvwDanhSachKhachHang.GridControl = this.gctDanhSachKhachHang;
            this.gvwDanhSachKhachHang.Name = "gvwDanhSachKhachHang";
            this.gvwDanhSachKhachHang.OptionsBehavior.Editable = false;
            this.gvwDanhSachKhachHang.DoubleClick += new System.EventHandler(this.gvwDanhSachKhachHang_DoubleClick);
            // 
            // colMaKhachHang
            // 
            this.colMaKhachHang.Caption = "Mã khách hàng";
            this.colMaKhachHang.FieldName = "MaKhachHang";
            this.colMaKhachHang.Name = "colMaKhachHang";
            this.colMaKhachHang.Visible = true;
            this.colMaKhachHang.VisibleIndex = 0;
            this.colMaKhachHang.Width = 137;
            // 
            // colHoTenKH
            // 
            this.colHoTenKH.Caption = "Họ tên khách hàng";
            this.colHoTenKH.FieldName = "HoTenKH";
            this.colHoTenKH.Name = "colHoTenKH";
            this.colHoTenKH.Visible = true;
            this.colHoTenKH.VisibleIndex = 1;
            this.colHoTenKH.Width = 425;
            // 
            // uspGetMaKHTenKHTableAdapter
            // 
            this.uspGetMaKHTenKHTableAdapter.ClearBeforeFill = true;
            // 
            // KhachHangList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 323);
            this.Controls.Add(this.gctDanhSachKhachHang);
            this.Name = "KhachHangList";
            this.Text = "Danh sách khách hàng";
            this.Load += new System.EventHandler(this.KhachHangList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gctDanhSachKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspGetMaKHTenKHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maKHTenKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwDanhSachKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gctDanhSachKhachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwDanhSachKhachHang;
        private KaraokeManager.DataSet.MaKHTenKH maKHTenKH;
        private System.Windows.Forms.BindingSource uspGetMaKHTenKHBindingSource;
        private KaraokeManager.DataSet.MaKHTenKHTableAdapters.uspGetMaKHTenKHTableAdapter uspGetMaKHTenKHTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn colHoTenKH;
    }
}