namespace KaraokeManager.Forms
{
    partial class ChonPhong
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
            this.xtcDanhSachLau = new DevExpress.XtraTab.XtraTabControl();
            this.ilstPhong = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xtcDanhSachLau)).BeginInit();
            this.SuspendLayout();
            // 
            // xtcDanhSachLau
            // 
            this.xtcDanhSachLau.Location = new System.Drawing.Point(13, 13);
            this.xtcDanhSachLau.Name = "xtcDanhSachLau";
            this.xtcDanhSachLau.Size = new System.Drawing.Size(322, 303);
            this.xtcDanhSachLau.TabIndex = 0;
            // 
            // ilstPhong
            // 
            this.ilstPhong.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ilstPhong.ImageSize = new System.Drawing.Size(16, 16);
            this.ilstPhong.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ChonPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 328);
            this.Controls.Add(this.xtcDanhSachLau);
            this.Name = "ChonPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chọn phòng";
            ((System.ComponentModel.ISupportInitialize)(this.xtcDanhSachLau)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtcDanhSachLau;
        private System.Windows.Forms.ImageList ilstPhong;
    }
}