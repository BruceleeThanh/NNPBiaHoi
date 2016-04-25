namespace NPPBiaHoi.ucHoaDon
{
    partial class frmSuaHoaDonBanLe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuaHoaDonBanLe));
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdSuaHoaDonBanLe = new DevExpress.XtraGrid.GridControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dateThoiGian = new DevExpress.XtraEditors.DateEdit();
            this.lueTenSanPham = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.spinSoLuong = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSuaHoaDonBanLe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateThoiGian.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateThoiGian.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTenSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(514, 336);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(61, 23);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(581, 336);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(61, 23);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "Hủy";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenSanPham,
            this.colSoLuong,
            this.colGhiChu});
            this.gridView1.GridControl = this.grdSuaHoaDonBanLe;
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
            this.colTenSanPham.Width = 142;
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
            this.colSoLuong.Width = 84;
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
            this.colGhiChu.VisibleIndex = 2;
            this.colGhiChu.Width = 304;
            // 
            // grdSuaHoaDonBanLe
            // 
            this.grdSuaHoaDonBanLe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.grdSuaHoaDonBanLe.Location = new System.Drawing.Point(0, 26);
            this.grdSuaHoaDonBanLe.MainView = this.gridView1;
            this.grdSuaHoaDonBanLe.Name = "grdSuaHoaDonBanLe";
            this.grdSuaHoaDonBanLe.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lueTenSanPham,
            this.repositoryItemLookUpEdit2,
            this.spinSoLuong});
            this.grdSuaHoaDonBanLe.Size = new System.Drawing.Size(654, 307);
            this.grdSuaHoaDonBanLe.TabIndex = 4;
            this.grdSuaHoaDonBanLe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(12, 7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Thời gian: ";
            // 
            // dateThoiGian
            // 
            this.dateThoiGian.EditValue = null;
            this.dateThoiGian.Location = new System.Drawing.Point(72, 4);
            this.dateThoiGian.Name = "dateThoiGian";
            this.dateThoiGian.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateThoiGian.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateThoiGian.Size = new System.Drawing.Size(100, 20);
            this.dateThoiGian.TabIndex = 9;
            // 
            // lueTenSanPham
            // 
            this.lueTenSanPham.AutoHeight = false;
            this.lueTenSanPham.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.lueTenSanPham.Name = "lueTenSanPham";
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            // 
            // spinSoLuong
            // 
            this.spinSoLuong.AutoHeight = false;
            this.spinSoLuong.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.spinSoLuong.Name = "spinSoLuong";
            // 
            // frmSuaHoaDonBanLe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 361);
            this.Controls.Add(this.dateThoiGian);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.grdSuaHoaDonBanLe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSuaHoaDonBanLe";
            this.Text = "Sửa hóa đơn bán lẻ";
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSuaHoaDonBanLe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateThoiGian.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateThoiGian.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTenSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colTenSanPham;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl grdSuaHoaDonBanLe;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lueTenSanPham;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit spinSoLuong;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dateThoiGian;
    }
}