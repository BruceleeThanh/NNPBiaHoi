namespace NPPBiaHoi.ucKhachHang
{
    partial class frmLichSuHoaDonKhachHang
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
            this.lblTenKH = new DevExpress.XtraEditors.LabelControl();
            this.lblTenSP = new DevExpress.XtraEditors.LabelControl();
            this.lblTenKhachHang = new DevExpress.XtraEditors.LabelControl();
            this.lblTenSanPham = new DevExpress.XtraEditors.LabelControl();
            this.lblMaSanPham = new DevExpress.XtraEditors.LabelControl();
            this.lblMaKhachHang = new DevExpress.XtraEditors.LabelControl();
            this.grdLichSuDonGia = new DevExpress.XtraGrid.GridControl();
            this.grvLichSuDonGia = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lblMaKH = new DevExpress.XtraEditors.LabelControl();
            this.lblMaSP = new DevExpress.XtraEditors.LabelControl();
            this.colMa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThoiGianCapNhat = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdLichSuDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvLichSuDonGia)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenKH
            // 
            this.lblTenKH.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblTenKH.Location = new System.Drawing.Point(23, 41);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(106, 16);
            this.lblTenKH.TabIndex = 0;
            this.lblTenKH.Text = "Tên khách hàng:";
            // 
            // lblTenSP
            // 
            this.lblTenSP.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblTenSP.Location = new System.Drawing.Point(478, 41);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(104, 17);
            this.lblTenSP.TabIndex = 1;
            this.lblTenSP.Text = "Tên Sản phẩm:";
            // 
            // lblTenKhachHang
            // 
            this.lblTenKhachHang.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblTenKhachHang.Location = new System.Drawing.Point(135, 41);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(75, 16);
            this.lblTenKhachHang.TabIndex = 2;
            this.lblTenKhachHang.Text = "Khách hàng";
            // 
            // lblTenSanPham
            // 
            this.lblTenSanPham.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblTenSanPham.Location = new System.Drawing.Point(588, 40);
            this.lblTenSanPham.Name = "lblTenSanPham";
            this.lblTenSanPham.Size = new System.Drawing.Size(69, 17);
            this.lblTenSanPham.TabIndex = 3;
            this.lblTenSanPham.Text = "Sản phẩm";
            // 
            // lblMaSanPham
            // 
            this.lblMaSanPham.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblMaSanPham.Location = new System.Drawing.Point(588, 80);
            this.lblMaSanPham.Name = "lblMaSanPham";
            this.lblMaSanPham.Size = new System.Drawing.Size(93, 17);
            this.lblMaSanPham.TabIndex = 4;
            this.lblMaSanPham.Text = "Mã Sản phẩm";
            // 
            // lblMaKhachHang
            // 
            this.lblMaKhachHang.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblMaKhachHang.Location = new System.Drawing.Point(135, 80);
            this.lblMaKhachHang.Name = "lblMaKhachHang";
            this.lblMaKhachHang.Size = new System.Drawing.Size(98, 16);
            this.lblMaKhachHang.TabIndex = 5;
            this.lblMaKhachHang.Text = "Mã Khách hàng";
            // 
            // grdLichSuDonGia
            // 
            this.grdLichSuDonGia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdLichSuDonGia.Location = new System.Drawing.Point(4, 115);
            this.grdLichSuDonGia.MainView = this.grvLichSuDonGia;
            this.grdLichSuDonGia.Name = "grdLichSuDonGia";
            this.grdLichSuDonGia.Size = new System.Drawing.Size(895, 339);
            this.grdLichSuDonGia.TabIndex = 6;
            this.grdLichSuDonGia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvLichSuDonGia});
            // 
            // grvLichSuDonGia
            // 
            this.grvLichSuDonGia.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMa,
            this.colThoiGianCapNhat});
            this.grvLichSuDonGia.GridControl = this.grdLichSuDonGia;
            this.grvLichSuDonGia.Name = "grvLichSuDonGia";
            // 
            // lblMaKH
            // 
            this.lblMaKH.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblMaKH.Location = new System.Drawing.Point(23, 81);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(103, 16);
            this.lblMaKH.TabIndex = 7;
            this.lblMaKH.Text = "Mã Khách hàng:";
            // 
            // lblMaSP
            // 
            this.lblMaSP.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblMaSP.Location = new System.Drawing.Point(478, 81);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(98, 17);
            this.lblMaSP.TabIndex = 8;
            this.lblMaSP.Text = "Mã Sản phẩm:";
            // 
            // colMa
            // 
            this.colMa.Caption = "Mã";
            this.colMa.FieldName = "Ma";
            this.colMa.Name = "colMa";
            this.colMa.OptionsColumn.ReadOnly = true;
            this.colMa.Visible = true;
            this.colMa.VisibleIndex = 0;
            // 
            // colThoiGianCapNhat
            // 
            this.colThoiGianCapNhat.Caption = "Thời gian cập nhật";
            this.colThoiGianCapNhat.DisplayFormat.FormatString = "g";
            this.colThoiGianCapNhat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colThoiGianCapNhat.Name = "colThoiGianCapNhat";
            this.colThoiGianCapNhat.Visible = true;
            this.colThoiGianCapNhat.VisibleIndex = 1;
            // 
            // frmLichSuHoaDonKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(901, 510);
            this.Controls.Add(this.lblMaSP);
            this.Controls.Add(this.lblMaKH);
            this.Controls.Add(this.grdLichSuDonGia);
            this.Controls.Add(this.lblMaKhachHang);
            this.Controls.Add(this.lblMaSanPham);
            this.Controls.Add(this.lblTenSanPham);
            this.Controls.Add(this.lblTenKhachHang);
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.lblTenKH);
            this.MaximizeBox = false;
            this.Name = "frmLichSuHoaDonKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch sử đơn giá";
            ((System.ComponentModel.ISupportInitialize)(this.grdLichSuDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvLichSuDonGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblTenKH;
        private DevExpress.XtraEditors.LabelControl lblTenSP;
        private DevExpress.XtraEditors.LabelControl lblTenKhachHang;
        private DevExpress.XtraEditors.LabelControl lblTenSanPham;
        private DevExpress.XtraEditors.LabelControl lblMaSanPham;
        private DevExpress.XtraEditors.LabelControl lblMaKhachHang;
        private DevExpress.XtraGrid.GridControl grdLichSuDonGia;
        private DevExpress.XtraGrid.Views.Grid.GridView grvLichSuDonGia;
        private DevExpress.XtraEditors.LabelControl lblMaKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMa;
        private DevExpress.XtraEditors.LabelControl lblMaSP;
        private DevExpress.XtraGrid.Columns.GridColumn colThoiGianCapNhat;
    }
}