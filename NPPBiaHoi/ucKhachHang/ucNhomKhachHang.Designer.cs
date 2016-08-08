namespace NPPBiaHoi.ucKhachHang
{
    partial class ucNhomKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucNhomKhachHang));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.grvNhomKhachHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMieuTa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDangQuanLy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkDangQuanLy = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colSua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSua = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colDanhSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDanhSach = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.grdNhomKhachHang = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.grvNhomKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDangQuanLy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdNhomKhachHang)).BeginInit();
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
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // grvNhomKhachHang
            // 
            this.grvNhomKhachHang.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.grvNhomKhachHang.Appearance.HeaderPanel.Options.UseFont = true;
            this.grvNhomKhachHang.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.grvNhomKhachHang.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grvNhomKhachHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTen,
            this.colMieuTa,
            this.colDangQuanLy,
            this.colSua,
            this.colXoa,
            this.colDanhSach});
            this.grvNhomKhachHang.GridControl = this.grdNhomKhachHang;
            this.grvNhomKhachHang.IndicatorWidth = 50;
            this.grvNhomKhachHang.Name = "grvNhomKhachHang";
            this.grvNhomKhachHang.OptionsView.EnableAppearanceEvenRow = true;
            this.grvNhomKhachHang.OptionsView.ShowFooter = true;
            this.grvNhomKhachHang.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.grvNhomKhachHang_CustomDrawRowIndicator);
            // 
            // colTen
            // 
            this.colTen.Caption = "Tên";
            this.colTen.FieldName = "Ten";
            this.colTen.Name = "colTen";
            this.colTen.OptionsColumn.ReadOnly = true;
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 0;
            this.colTen.Width = 166;
            // 
            // colMieuTa
            // 
            this.colMieuTa.Caption = "Miêu tả";
            this.colMieuTa.FieldName = "MieuTa";
            this.colMieuTa.Name = "colMieuTa";
            this.colMieuTa.OptionsColumn.ReadOnly = true;
            this.colMieuTa.Visible = true;
            this.colMieuTa.VisibleIndex = 1;
            this.colMieuTa.Width = 479;
            // 
            // colDangQuanLy
            // 
            this.colDangQuanLy.Caption = "Đang quản lý";
            this.colDangQuanLy.ColumnEdit = this.chkDangQuanLy;
            this.colDangQuanLy.FieldName = "KichHoat";
            this.colDangQuanLy.Name = "colDangQuanLy";
            this.colDangQuanLy.OptionsColumn.ReadOnly = true;
            this.colDangQuanLy.Visible = true;
            this.colDangQuanLy.VisibleIndex = 2;
            this.colDangQuanLy.Width = 108;
            // 
            // chkDangQuanLy
            // 
            this.chkDangQuanLy.AccessibleName = "Đang quản lý";
            this.chkDangQuanLy.AutoHeight = false;
            this.chkDangQuanLy.Name = "chkDangQuanLy";
            this.chkDangQuanLy.ReadOnly = true;
            this.chkDangQuanLy.ValueChecked = ((byte)(1));
            this.chkDangQuanLy.ValueUnchecked = ((byte)(0));
            // 
            // colSua
            // 
            this.colSua.Caption = "Sửa";
            this.colSua.ColumnEdit = this.btnSua;
            this.colSua.Name = "colSua";
            this.colSua.OptionsColumn.ReadOnly = true;
            this.colSua.Visible = true;
            this.colSua.VisibleIndex = 4;
            this.colSua.Width = 41;
            // 
            // btnSua
            // 
            this.btnSua.AutoHeight = false;
            this.btnSua.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnSua.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
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
            this.colXoa.VisibleIndex = 5;
            this.colXoa.Width = 40;
            // 
            // btnXoa
            // 
            this.btnXoa.AutoHeight = false;
            this.btnXoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnXoa.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnXoa.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnXoa_ButtonClick);
            // 
            // colDanhSach
            // 
            this.colDanhSach.Caption = "Danh sách";
            this.colDanhSach.ColumnEdit = this.btnDanhSach;
            this.colDanhSach.Name = "colDanhSach";
            this.colDanhSach.Visible = true;
            this.colDanhSach.VisibleIndex = 3;
            // 
            // btnDanhSach
            // 
            this.btnDanhSach.AutoHeight = false;
            this.btnDanhSach.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnDanhSach.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.btnDanhSach.Name = "btnDanhSach";
            this.btnDanhSach.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnDanhSach.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnDanhSach_ButtonClick);
            // 
            // grdNhomKhachHang
            // 
            this.grdNhomKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdNhomKhachHang.Location = new System.Drawing.Point(0, 65);
            this.grdNhomKhachHang.MainView = this.grvNhomKhachHang;
            this.grdNhomKhachHang.Name = "grdNhomKhachHang";
            this.grdNhomKhachHang.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.chkDangQuanLy,
            this.btnSua,
            this.btnXoa,
            this.btnDanhSach});
            this.grdNhomKhachHang.Size = new System.Drawing.Size(1230, 605);
            this.grdNhomKhachHang.TabIndex = 2;
            this.grdNhomKhachHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvNhomKhachHang});
            // 
            // ucNhomKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grdNhomKhachHang);
            this.Name = "ucNhomKhachHang";
            this.Size = new System.Drawing.Size(1230, 670);
            this.Load += new System.EventHandler(this.ucNhomKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvNhomKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDangQuanLy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdNhomKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraGrid.Views.Grid.GridView grvNhomKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraGrid.Columns.GridColumn colMieuTa;
        private DevExpress.XtraGrid.Columns.GridColumn colDangQuanLy;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkDangQuanLy;
        private DevExpress.XtraGrid.Columns.GridColumn colSua;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnSua;
        private DevExpress.XtraGrid.Columns.GridColumn colXoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnXoa;
        private DevExpress.XtraGrid.GridControl grdNhomKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn colDanhSach;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDanhSach;
    }
}
