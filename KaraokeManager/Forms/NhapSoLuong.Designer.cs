namespace KaraokeManager.Forms
{
    partial class NhapSoLuong
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
            this.sbtnDongY = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnHuyBo = new DevExpress.XtraEditors.SimpleButton();
            this.txtSoLuong = new DevExpress.XtraEditors.TextEdit();
            this.lblMoTa = new DevExpress.XtraEditors.LabelControl();
            this.lblSoLuong = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbtnDongY
            // 
            this.sbtnDongY.Location = new System.Drawing.Point(40, 95);
            this.sbtnDongY.Name = "sbtnDongY";
            this.sbtnDongY.Size = new System.Drawing.Size(75, 23);
            this.sbtnDongY.TabIndex = 0;
            this.sbtnDongY.Text = "Đồng ý";
            this.sbtnDongY.Click += new System.EventHandler(this.sbtnDongY_Click);
            // 
            // sbtnHuyBo
            // 
            this.sbtnHuyBo.Location = new System.Drawing.Point(184, 95);
            this.sbtnHuyBo.Name = "sbtnHuyBo";
            this.sbtnHuyBo.Size = new System.Drawing.Size(75, 23);
            this.sbtnHuyBo.TabIndex = 1;
            this.sbtnHuyBo.Text = "Hủy bỏ";
            this.sbtnHuyBo.Click += new System.EventHandler(this.sbtnHuyBo_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(159, 49);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(100, 20);
            this.txtSoLuong.TabIndex = 2;
            // 
            // lblMoTa
            // 
            this.lblMoTa.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMoTa.Appearance.Options.UseFont = true;
            this.lblMoTa.Location = new System.Drawing.Point(40, 12);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(110, 16);
            this.lblMoTa.TabIndex = 3;
            this.lblMoTa.Text = "Nhập số lượng cho ";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Location = new System.Drawing.Point(40, 52);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(42, 13);
            this.lblSoLuong.TabIndex = 4;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // NhapSoLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 138);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.sbtnHuyBo);
            this.Controls.Add(this.sbtnDongY);
            this.Name = "NhapSoLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nhập số lượng";
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton sbtnDongY;
        private DevExpress.XtraEditors.SimpleButton sbtnHuyBo;
        private DevExpress.XtraEditors.TextEdit txtSoLuong;
        private DevExpress.XtraEditors.LabelControl lblMoTa;
        private DevExpress.XtraEditors.LabelControl lblSoLuong;
    }
}