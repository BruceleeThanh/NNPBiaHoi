namespace NPPBiaHoi.ucKhachHang
{
    partial class ucKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucKhachHang));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.grdKhachHang = new DevExpress.XtraGrid.GridControl();
            this.grvKhachHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenChuCuaHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKhoangCach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDangQuanLy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkDangQuanLy = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colChiTiet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnChiTiet = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colSua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSua = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grdKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDangQuanLy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(15, 15);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 32);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // grdKhachHang
            // 
            this.grdKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdKhachHang.Location = new System.Drawing.Point(0, 65);
            this.grdKhachHang.MainView = this.grvKhachHang;
            this.grdKhachHang.Name = "grdKhachHang";
            this.grdKhachHang.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnChiTiet,
            this.chkDangQuanLy,
            this.btnSua,
            this.btnXoa});
            this.grdKhachHang.Size = new System.Drawing.Size(1228, 603);
            this.grdKhachHang.TabIndex = 4;
            this.grdKhachHang.UseEmbeddedNavigator = true;
            this.grdKhachHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvKhachHang});
            // 
            // grvKhachHang
            // 
            this.grvKhachHang.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.grvKhachHang.Appearance.HeaderPanel.Options.UseFont = true;
            this.grvKhachHang.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.grvKhachHang.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grvKhachHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenKhachHang,
            this.colTenChuCuaHang,
            this.colDiaChi,
            this.colSoDienThoai,
            this.colKhoangCach,
            this.colDangQuanLy,
            this.colChiTiet,
            this.colSua,
            this.colXoa});
            this.grvKhachHang.GridControl = this.grdKhachHang;
            this.grvKhachHang.IndicatorWidth = 40;
            this.grvKhachHang.Name = "grvKhachHang";
            this.grvKhachHang.OptionsFind.AlwaysVisible = true;
            this.grvKhachHang.OptionsView.EnableAppearanceOddRow = true;
            this.grvKhachHang.OptionsView.RowAutoHeight = true;
            this.grvKhachHang.OptionsView.ShowFooter = true;
            this.grvKhachHang.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.True;
            this.grvKhachHang.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.grvKhachHang_CustomDrawRowIndicator);
            // 
            // colTenKhachHang
            // 
            this.colTenKhachHang.Caption = "Khách hàng";
            this.colTenKhachHang.FieldName = "Ten";
            this.colTenKhachHang.Name = "colTenKhachHang";
            this.colTenKhachHang.OptionsColumn.ReadOnly = true;
            this.colTenKhachHang.Visible = true;
            this.colTenKhachHang.VisibleIndex = 0;
            this.colTenKhachHang.Width = 203;
            // 
            // colTenChuCuaHang
            // 
            this.colTenChuCuaHang.Caption = "Tên chủ cửa hàng";
            this.colTenChuCuaHang.FieldName = "TenChuCuaHang";
            this.colTenChuCuaHang.Name = "colTenChuCuaHang";
            this.colTenChuCuaHang.OptionsColumn.ReadOnly = true;
            this.colTenChuCuaHang.Visible = true;
            this.colTenChuCuaHang.VisibleIndex = 1;
            this.colTenChuCuaHang.Width = 168;
            // 
            // colDiaChi
            // 
            this.colDiaChi.Caption = "Địa chỉ";
            this.colDiaChi.FieldName = "DiaChi";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.OptionsColumn.ReadOnly = true;
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 2;
            this.colDiaChi.Width = 292;
            // 
            // colSoDienThoai
            // 
            this.colSoDienThoai.Caption = "Số điện thoại";
            this.colSoDienThoai.FieldName = "SoDienThoai";
            this.colSoDienThoai.Name = "colSoDienThoai";
            this.colSoDienThoai.OptionsColumn.ReadOnly = true;
            this.colSoDienThoai.Visible = true;
            this.colSoDienThoai.VisibleIndex = 3;
            this.colSoDienThoai.Width = 121;
            // 
            // colKhoangCach
            // 
            this.colKhoangCach.Caption = "Khoảng cách";
            this.colKhoangCach.FieldName = "KhoangCach";
            this.colKhoangCach.Name = "colKhoangCach";
            this.colKhoangCach.OptionsColumn.ReadOnly = true;
            this.colKhoangCach.Visible = true;
            this.colKhoangCach.VisibleIndex = 4;
            this.colKhoangCach.Width = 138;
            // 
            // colDangQuanLy
            // 
            this.colDangQuanLy.Caption = "Đang Quản lý";
            this.colDangQuanLy.ColumnEdit = this.chkDangQuanLy;
            this.colDangQuanLy.FieldName = "KichHoat";
            this.colDangQuanLy.Name = "colDangQuanLy";
            this.colDangQuanLy.OptionsColumn.ReadOnly = true;
            this.colDangQuanLy.Visible = true;
            this.colDangQuanLy.VisibleIndex = 5;
            this.colDangQuanLy.Width = 103;
            // 
            // chkDangQuanLy
            // 
            this.chkDangQuanLy.AutoHeight = false;
            this.chkDangQuanLy.Caption = "Đang quản lý";
            this.chkDangQuanLy.Name = "chkDangQuanLy";
            this.chkDangQuanLy.ReadOnly = true;
            this.chkDangQuanLy.ValueChecked = ((byte)(1));
            this.chkDangQuanLy.ValueUnchecked = ((byte)(0));
            // 
            // colChiTiet
            // 
            this.colChiTiet.Caption = "Chi tiết";
            this.colChiTiet.ColumnEdit = this.btnChiTiet;
            this.colChiTiet.Name = "colChiTiet";
            this.colChiTiet.OptionsColumn.ReadOnly = true;
            this.colChiTiet.Visible = true;
            this.colChiTiet.VisibleIndex = 6;
            this.colChiTiet.Width = 66;
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.AutoHeight = false;
            this.btnChiTiet.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnChiTiet.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnChiTiet.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnChiTiet_ButtonClick);
            // 
            // colSua
            // 
            this.colSua.Caption = "Sửa";
            this.colSua.ColumnEdit = this.btnSua;
            this.colSua.Name = "colSua";
            this.colSua.OptionsColumn.ReadOnly = true;
            this.colSua.Visible = true;
            this.colSua.VisibleIndex = 7;
            this.colSua.Width = 46;
            // 
            // btnSua
            // 
            this.btnSua.AppearanceReadOnly.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.AppearanceReadOnly.Image")));
            this.btnSua.AppearanceReadOnly.Options.UseImage = true;
            this.btnSua.AutoHeight = false;
            this.btnSua.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnSua.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.btnSua.Name = "btnSua";
            this.btnSua.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnSua.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnSua_ButtonClick);
            // 
            // colXoa
            // 
            this.colXoa.Caption = "Xóa";
            this.colXoa.ColumnEdit = this.btnXoa;
            this.colXoa.Name = "colXoa";
            this.colXoa.OptionsColumn.ReadOnly = true;
            this.colXoa.Visible = true;
            this.colXoa.VisibleIndex = 8;
            this.colXoa.Width = 48;
            // 
            // btnXoa
            // 
            this.btnXoa.AppearanceReadOnly.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.AppearanceReadOnly.Image")));
            this.btnXoa.AppearanceReadOnly.Options.UseImage = true;
            this.btnXoa.AutoHeight = false;
            this.btnXoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnXoa.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnXoa.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnXoa_ButtonClick);
            // 
            // ucKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.grdKhachHang);
            this.Controls.Add(this.btnThem);
            this.Name = "ucKhachHang";
            this.Size = new System.Drawing.Size(1228, 668);
            this.Load += new System.EventHandler(this.ucKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDangQuanLy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraGrid.GridControl grdKhachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView grvKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn colTenChuCuaHang;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colSoDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn colKhoangCach;
        private DevExpress.XtraGrid.Columns.GridColumn colDangQuanLy;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkDangQuanLy;
        private DevExpress.XtraGrid.Columns.GridColumn colChiTiet;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnChiTiet;
        private DevExpress.XtraGrid.Columns.GridColumn colSua;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnSua;
        private DevExpress.XtraGrid.Columns.GridColumn colXoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnXoa;
    }
}
