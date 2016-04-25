namespace NPPBiaHoi.ucHoaDon
{
    partial class frmThemHoaDonBanLe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemHoaDonBanLe));
            this.grdThemHoaDonBanLe = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lueTenSanPham = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spinSoLuong = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colThoiGian = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateThoiGian = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdThemHoaDonBanLe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTenSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateThoiGian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateThoiGian.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdThemHoaDonBanLe
            // 
            this.grdThemHoaDonBanLe.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdThemHoaDonBanLe.Location = new System.Drawing.Point(0, 0);
            this.grdThemHoaDonBanLe.MainView = this.gridView1;
            this.grdThemHoaDonBanLe.Name = "grdThemHoaDonBanLe";
            this.grdThemHoaDonBanLe.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lueTenSanPham,
            this.spinSoLuong,
            this.dateThoiGian});
            this.grdThemHoaDonBanLe.Size = new System.Drawing.Size(654, 333);
            this.grdThemHoaDonBanLe.TabIndex = 0;
            this.grdThemHoaDonBanLe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenSanPham,
            this.colSoLuong,
            this.colThoiGian,
            this.colGhiChu});
            this.gridView1.GridControl = this.grdThemHoaDonBanLe;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colTenSanPham
            // 
            this.colTenSanPham.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTenSanPham.AppearanceHeader.Options.UseFont = true;
            this.colTenSanPham.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenSanPham.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenSanPham.Caption = "Tên sản phẩm";
            this.colTenSanPham.ColumnEdit = this.lueTenSanPham;
            this.colTenSanPham.Name = "colTenSanPham";
            this.colTenSanPham.Visible = true;
            this.colTenSanPham.VisibleIndex = 0;
            this.colTenSanPham.Width = 118;
            // 
            // lueTenSanPham
            // 
            this.lueTenSanPham.AutoHeight = false;
            this.lueTenSanPham.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.lueTenSanPham.Name = "lueTenSanPham";
            // 
            // colSoLuong
            // 
            this.colSoLuong.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colSoLuong.AppearanceHeader.Options.UseFont = true;
            this.colSoLuong.AppearanceHeader.Options.UseTextOptions = true;
            this.colSoLuong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSoLuong.Caption = "Số lượng";
            this.colSoLuong.ColumnEdit = this.spinSoLuong;
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 1;
            this.colSoLuong.Width = 62;
            // 
            // spinSoLuong
            // 
            this.spinSoLuong.AutoHeight = false;
            this.spinSoLuong.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.spinSoLuong.Name = "spinSoLuong";
            // 
            // colThoiGian
            // 
            this.colThoiGian.AppearanceCell.Options.UseTextOptions = true;
            this.colThoiGian.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colThoiGian.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colThoiGian.AppearanceHeader.Options.UseFont = true;
            this.colThoiGian.AppearanceHeader.Options.UseTextOptions = true;
            this.colThoiGian.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colThoiGian.Caption = "Thời gian";
            this.colThoiGian.ColumnEdit = this.dateThoiGian;
            this.colThoiGian.Name = "colThoiGian";
            this.colThoiGian.Visible = true;
            this.colThoiGian.VisibleIndex = 2;
            this.colThoiGian.Width = 109;
            // 
            // dateThoiGian
            // 
            this.dateThoiGian.AutoHeight = false;
            this.dateThoiGian.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateThoiGian.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateThoiGian.Name = "dateThoiGian";
            // 
            // colGhiChu
            // 
            this.colGhiChu.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colGhiChu.AppearanceHeader.Options.UseFont = true;
            this.colGhiChu.AppearanceHeader.Options.UseTextOptions = true;
            this.colGhiChu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGhiChu.Caption = "Ghi chú";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 3;
            this.colGhiChu.Width = 260;
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(581, 335);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(61, 23);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "Hủy";
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(514, 335);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(61, 23);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            // 
            // frmThemHoaDonBanLe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 361);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.grdThemHoaDonBanLe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThemHoaDonBanLe";
            this.Text = "Thêm hóa đơn bán lẻ";
            ((System.ComponentModel.ISupportInitialize)(this.grdThemHoaDonBanLe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTenSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateThoiGian.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateThoiGian)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdThemHoaDonBanLe;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTenSanPham;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lueTenSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit spinSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraGrid.Columns.GridColumn colThoiGian;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit dateThoiGian;
    }
}