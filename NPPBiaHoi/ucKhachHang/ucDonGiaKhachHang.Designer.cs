namespace NPPBiaHoi.ucKhachHang
{
    partial class ucDonGiaKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDonGiaKhachHang));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.grdDonGiaKhachHang = new DevExpress.XtraGrid.GridControl();
            this.grvDonGiaKhachHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThoiGianCapNhat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLichSuDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnLichSuDonGia = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colSua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSua = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdDonGiaKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDonGiaKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLichSuDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSua)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDonGiaKhachHang
            // 
            this.grdDonGiaKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDonGiaKhachHang.Location = new System.Drawing.Point(0, 65);
            this.grdDonGiaKhachHang.MainView = this.grvDonGiaKhachHang;
            this.grdDonGiaKhachHang.Name = "grdDonGiaKhachHang";
            this.grdDonGiaKhachHang.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnLichSuDonGia,
            this.btnSua});
            this.grdDonGiaKhachHang.Size = new System.Drawing.Size(1230, 605);
            this.grdDonGiaKhachHang.TabIndex = 0;
            this.grdDonGiaKhachHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvDonGiaKhachHang});
            // 
            // grvDonGiaKhachHang
            // 
            this.grvDonGiaKhachHang.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.grvDonGiaKhachHang.Appearance.GroupPanel.Options.UseFont = true;
            this.grvDonGiaKhachHang.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.grvDonGiaKhachHang.Appearance.HeaderPanel.Options.UseFont = true;
            this.grvDonGiaKhachHang.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.grvDonGiaKhachHang.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grvDonGiaKhachHang.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.grvDonGiaKhachHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKhachHang,
            this.colSanPham,
            this.colDonGia,
            this.colThoiGianCapNhat,
            this.colLichSuDonGia,
            this.colSua});
            this.grvDonGiaKhachHang.GridControl = this.grdDonGiaKhachHang;
            this.grvDonGiaKhachHang.GroupPanelText = "Kéo cột vào đây để gộp nhóm!";
            this.grvDonGiaKhachHang.IndicatorWidth = 50;
            this.grvDonGiaKhachHang.Name = "grvDonGiaKhachHang";
            this.grvDonGiaKhachHang.OptionsView.AllowCellMerge = true;
            this.grvDonGiaKhachHang.OptionsView.AllowHtmlDrawHeaders = true;
            this.grvDonGiaKhachHang.OptionsView.EnableAppearanceEvenRow = true;
            this.grvDonGiaKhachHang.OptionsView.EnableAppearanceOddRow = true;
            this.grvDonGiaKhachHang.OptionsView.ShowAutoFilterRow = true;
            this.grvDonGiaKhachHang.OptionsView.ShowFooter = true;
            this.grvDonGiaKhachHang.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.grvDonGiaKhachHang_CustomDrawRowIndicator);
            // 
            // colKhachHang
            // 
            this.colKhachHang.AppearanceHeader.Options.UseTextOptions = true;
            this.colKhachHang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKhachHang.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colKhachHang.Caption = "Khách hàng";
            this.colKhachHang.FieldName = "TenKhachHang";
            this.colKhachHang.Name = "colKhachHang";
            this.colKhachHang.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colKhachHang.OptionsColumn.ReadOnly = true;
            this.colKhachHang.Visible = true;
            this.colKhachHang.VisibleIndex = 0;
            this.colKhachHang.Width = 297;
            // 
            // colSanPham
            // 
            this.colSanPham.Caption = "Sản phẩm";
            this.colSanPham.FieldName = "TenSanPham";
            this.colSanPham.Name = "colSanPham";
            this.colSanPham.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colSanPham.OptionsColumn.ReadOnly = true;
            this.colSanPham.Visible = true;
            this.colSanPham.VisibleIndex = 1;
            this.colSanPham.Width = 234;
            // 
            // colDonGia
            // 
            this.colDonGia.Caption = "Đơn giá";
            this.colDonGia.FieldName = "DonGia";
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDonGia.OptionsColumn.ReadOnly = true;
            this.colDonGia.Visible = true;
            this.colDonGia.VisibleIndex = 2;
            this.colDonGia.Width = 199;
            // 
            // colThoiGianCapNhat
            // 
            this.colThoiGianCapNhat.Caption = "Thời gian cập nhật";
            this.colThoiGianCapNhat.FieldName = "ThoiGianCapNhat";
            this.colThoiGianCapNhat.Name = "colThoiGianCapNhat";
            this.colThoiGianCapNhat.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colThoiGianCapNhat.OptionsColumn.ReadOnly = true;
            this.colThoiGianCapNhat.Visible = true;
            this.colThoiGianCapNhat.VisibleIndex = 3;
            this.colThoiGianCapNhat.Width = 139;
            // 
            // colLichSuDonGia
            // 
            this.colLichSuDonGia.AppearanceCell.Options.UseTextOptions = true;
            this.colLichSuDonGia.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLichSuDonGia.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colLichSuDonGia.Caption = "Lịch sử đơn giá";
            this.colLichSuDonGia.ColumnEdit = this.btnLichSuDonGia;
            this.colLichSuDonGia.Name = "colLichSuDonGia";
            this.colLichSuDonGia.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colLichSuDonGia.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colLichSuDonGia.OptionsColumn.AllowMove = false;
            this.colLichSuDonGia.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colLichSuDonGia.OptionsFilter.AllowAutoFilter = false;
            this.colLichSuDonGia.OptionsFilter.AllowFilter = false;
            this.colLichSuDonGia.Visible = true;
            this.colLichSuDonGia.VisibleIndex = 4;
            this.colLichSuDonGia.Width = 122;
            // 
            // btnLichSuDonGia
            // 
            this.btnLichSuDonGia.AutoHeight = false;
            this.btnLichSuDonGia.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnLichSuDonGia.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btnLichSuDonGia.Name = "btnLichSuDonGia";
            this.btnLichSuDonGia.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // colSua
            // 
            this.colSua.AppearanceCell.Options.UseTextOptions = true;
            this.colSua.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSua.Caption = "Sửa";
            this.colSua.ColumnEdit = this.btnSua;
            this.colSua.Name = "colSua";
            this.colSua.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colSua.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colSua.OptionsColumn.AllowMove = false;
            this.colSua.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSua.OptionsFilter.AllowAutoFilter = false;
            this.colSua.OptionsFilter.AllowFilter = false;
            this.colSua.Visible = true;
            this.colSua.VisibleIndex = 5;
            this.colSua.Width = 62;
            // 
            // btnSua
            // 
            this.btnSua.AppearanceFocused.Options.UseTextOptions = true;
            this.btnSua.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnSua.AutoHeight = false;
            this.btnSua.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnSua.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.btnSua.Name = "btnSua";
            this.btnSua.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnSua.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnSua_ButtonClick);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(15, 15);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 32);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // ucDonGiaKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grdDonGiaKhachHang);
            this.Name = "ucDonGiaKhachHang";
            this.Size = new System.Drawing.Size(1230, 670);
            this.Load += new System.EventHandler(this.ucDonGiaKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDonGiaKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDonGiaKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLichSuDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSua)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdDonGiaKhachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView grvDonGiaKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn colKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn colSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn colDonGia;
        private DevExpress.XtraGrid.Columns.GridColumn colThoiGianCapNhat;
        private DevExpress.XtraGrid.Columns.GridColumn colLichSuDonGia;
        private DevExpress.XtraGrid.Columns.GridColumn colSua;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnLichSuDonGia;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
    }
}
