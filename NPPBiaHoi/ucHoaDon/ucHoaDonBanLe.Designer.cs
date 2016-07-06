namespace NPPBiaHoi.ucHoaDon
{
    partial class ucHoaDonBanLe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucHoaDonBanLe));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            this.grdHoaDonBanLe = new DevExpress.XtraGrid.GridControl();
            this.grvHoaDonBanLe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThoiGian = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSua = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.lueTenSanPham = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.spinSoLuong = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.dateThoiGian = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdHoaDonBanLe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvHoaDonBanLe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTenSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateThoiGian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateThoiGian.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdHoaDonBanLe
            // 
            this.grdHoaDonBanLe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdHoaDonBanLe.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdHoaDonBanLe.Location = new System.Drawing.Point(0, 50);
            this.grdHoaDonBanLe.MainView = this.grvHoaDonBanLe;
            this.grdHoaDonBanLe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdHoaDonBanLe.Name = "grdHoaDonBanLe";
            this.grdHoaDonBanLe.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lueTenSanPham,
            this.spinSoLuong,
            this.dateThoiGian,
            this.btnSua,
            this.btnXoa});
            this.grdHoaDonBanLe.Size = new System.Drawing.Size(986, 434);
            this.grdHoaDonBanLe.TabIndex = 1;
            this.grdHoaDonBanLe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvHoaDonBanLe});
            // 
            // grvHoaDonBanLe
            // 
            this.grvHoaDonBanLe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenSanPham,
            this.colSoLuong,
            this.colThoiGian,
            this.colGhiChu,
            this.colSua,
            this.colXoa});
            this.grvHoaDonBanLe.GridControl = this.grdHoaDonBanLe;
            this.grvHoaDonBanLe.IndicatorWidth = 30;
            this.grvHoaDonBanLe.Name = "grvHoaDonBanLe";
            this.grvHoaDonBanLe.OptionsView.ShowAutoFilterRow = true;
            this.grvHoaDonBanLe.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.grvHoaDonBanLe_CustomDrawRowIndicator);
            // 
            // colTenSanPham
            // 
            this.colTenSanPham.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTenSanPham.AppearanceHeader.Options.UseFont = true;
            this.colTenSanPham.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenSanPham.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenSanPham.Caption = "Tên sản phẩm";
            this.colTenSanPham.FieldName = "Ten";
            this.colTenSanPham.Name = "colTenSanPham";
            this.colTenSanPham.OptionsColumn.ReadOnly = true;
            this.colTenSanPham.Visible = true;
            this.colTenSanPham.VisibleIndex = 1;
            this.colTenSanPham.Width = 114;
            // 
            // colSoLuong
            // 
            this.colSoLuong.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colSoLuong.AppearanceHeader.Options.UseFont = true;
            this.colSoLuong.AppearanceHeader.Options.UseTextOptions = true;
            this.colSoLuong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSoLuong.Caption = "Số lượng";
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.OptionsColumn.ReadOnly = true;
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 2;
            this.colSoLuong.Width = 85;
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
            this.colThoiGian.FieldName = "ThoiGian";
            this.colThoiGian.Name = "colThoiGian";
            this.colThoiGian.OptionsColumn.ReadOnly = true;
            this.colThoiGian.Visible = true;
            this.colThoiGian.VisibleIndex = 0;
            this.colThoiGian.Width = 99;
            // 
            // colGhiChu
            // 
            this.colGhiChu.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colGhiChu.AppearanceHeader.Options.UseFont = true;
            this.colGhiChu.AppearanceHeader.Options.UseTextOptions = true;
            this.colGhiChu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGhiChu.Caption = "Ghi chú";
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.OptionsColumn.ReadOnly = true;
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 3;
            this.colGhiChu.Width = 239;
            // 
            // colSua
            // 
            this.colSua.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colSua.AppearanceHeader.Options.UseFont = true;
            this.colSua.AppearanceHeader.Options.UseTextOptions = true;
            this.colSua.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSua.Caption = "Sửa";
            this.colSua.ColumnEdit = this.btnSua;
            this.colSua.Name = "colSua";
            this.colSua.OptionsFilter.AllowAutoFilter = false;
            this.colSua.OptionsFilter.AllowFilter = false;
            this.colSua.Visible = true;
            this.colSua.VisibleIndex = 4;
            this.colSua.Width = 41;
            // 
            // btnSua
            // 
            this.btnSua.AutoHeight = false;
            this.btnSua.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnSua.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, "", null, null, true)});
            this.btnSua.Name = "btnSua";
            this.btnSua.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnSua.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnSua_ButtonClick);
            // 
            // colXoa
            // 
            this.colXoa.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colXoa.AppearanceHeader.Options.UseFont = true;
            this.colXoa.AppearanceHeader.Options.UseTextOptions = true;
            this.colXoa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colXoa.Caption = "Xóa";
            this.colXoa.ColumnEdit = this.btnXoa;
            this.colXoa.Name = "colXoa";
            this.colXoa.OptionsFilter.AllowAutoFilter = false;
            this.colXoa.OptionsFilter.AllowFilter = false;
            this.colXoa.Visible = true;
            this.colXoa.VisibleIndex = 5;
            this.colXoa.Width = 35;
            // 
            // btnXoa
            // 
            this.btnXoa.AutoHeight = false;
            this.btnXoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnXoa.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject6, "", null, null, true)});
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnXoa.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnXoa_ButtonClick);
            // 
            // lueTenSanPham
            // 
            this.lueTenSanPham.AutoHeight = false;
            this.lueTenSanPham.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.lueTenSanPham.Name = "lueTenSanPham";
            // 
            // spinSoLuong
            // 
            this.spinSoLuong.AutoHeight = false;
            this.spinSoLuong.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.spinSoLuong.Name = "spinSoLuong";
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
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(14, 12);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(87, 28);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // ucHoaDonBanLe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grdHoaDonBanLe);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucHoaDonBanLe";
            this.Size = new System.Drawing.Size(986, 484);
            this.Load += new System.EventHandler(this.ucHoaDonBanLe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdHoaDonBanLe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvHoaDonBanLe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTenSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateThoiGian.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateThoiGian)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdHoaDonBanLe;
        private DevExpress.XtraGrid.Views.Grid.GridView grvHoaDonBanLe;
        private DevExpress.XtraGrid.Columns.GridColumn colTenSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colThoiGian;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn colSua;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnSua;
        private DevExpress.XtraGrid.Columns.GridColumn colXoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnXoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lueTenSanPham;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit spinSoLuong;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit dateThoiGian;
        private DevExpress.XtraEditors.SimpleButton btnThem;
    }
}
