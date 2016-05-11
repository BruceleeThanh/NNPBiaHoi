namespace NPPBiaHoi.ucSanPham
{
    partial class ucSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSanPham));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            this.grdSanPham = new DevExpress.XtraGrid.GridControl();
            this.grvSanPham = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuongSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuongVo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDungTich = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKichHoat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkKichHoat = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colSua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSua = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colChiTiet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnChiTiet = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnThemSanPham = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkKichHoat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // grdSanPham
            // 
            this.grdSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdSanPham.Location = new System.Drawing.Point(0, 39);
            this.grdSanPham.MainView = this.grvSanPham;
            this.grdSanPham.Name = "grdSanPham";
            this.grdSanPham.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.chkKichHoat,
            this.btnSua,
            this.btnXoa,
            this.btnChiTiet});
            this.grdSanPham.Size = new System.Drawing.Size(679, 334);
            this.grdSanPham.TabIndex = 0;
            this.grdSanPham.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvSanPham});
            // 
            // grvSanPham
            // 
            this.grvSanPham.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenSanPham,
            this.colSoLuongSanPham,
            this.colSoLuongVo,
            this.colDungTich,
            this.colLoai,
            this.colKichHoat,
            this.colSua,
            this.colXoa,
            this.colChiTiet});
            this.grvSanPham.GridControl = this.grdSanPham;
            this.grvSanPham.IndicatorWidth = 30;
            this.grvSanPham.Name = "grvSanPham";
            this.grvSanPham.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.grvSanPham_CustomDrawRowIndicator);
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
            this.colTenSanPham.Visible = true;
            this.colTenSanPham.VisibleIndex = 0;
            this.colTenSanPham.Width = 94;
            // 
            // colSoLuongSanPham
            // 
            this.colSoLuongSanPham.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colSoLuongSanPham.AppearanceHeader.Options.UseFont = true;
            this.colSoLuongSanPham.AppearanceHeader.Options.UseTextOptions = true;
            this.colSoLuongSanPham.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSoLuongSanPham.Caption = "Số lượng sản phẩm";
            this.colSoLuongSanPham.FieldName = "SoLuongSanPham";
            this.colSoLuongSanPham.Name = "colSoLuongSanPham";
            this.colSoLuongSanPham.Visible = true;
            this.colSoLuongSanPham.VisibleIndex = 1;
            this.colSoLuongSanPham.Width = 118;
            // 
            // colSoLuongVo
            // 
            this.colSoLuongVo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colSoLuongVo.AppearanceHeader.Options.UseFont = true;
            this.colSoLuongVo.AppearanceHeader.Options.UseTextOptions = true;
            this.colSoLuongVo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSoLuongVo.Caption = "Số lượng vỏ";
            this.colSoLuongVo.FieldName = "SoLuongVo";
            this.colSoLuongVo.Name = "colSoLuongVo";
            this.colSoLuongVo.Visible = true;
            this.colSoLuongVo.VisibleIndex = 2;
            this.colSoLuongVo.Width = 89;
            // 
            // colDungTich
            // 
            this.colDungTich.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colDungTich.AppearanceHeader.Options.UseFont = true;
            this.colDungTich.AppearanceHeader.Options.UseTextOptions = true;
            this.colDungTich.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDungTich.Caption = "Dung tích";
            this.colDungTich.FieldName = "DungTich";
            this.colDungTich.Name = "colDungTich";
            this.colDungTich.Visible = true;
            this.colDungTich.VisibleIndex = 3;
            this.colDungTich.Width = 81;
            // 
            // colLoai
            // 
            this.colLoai.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colLoai.AppearanceHeader.Options.UseFont = true;
            this.colLoai.AppearanceHeader.Options.UseTextOptions = true;
            this.colLoai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLoai.Caption = "Loại";
            this.colLoai.FieldName = "Loai";
            this.colLoai.Name = "colLoai";
            this.colLoai.Visible = true;
            this.colLoai.VisibleIndex = 4;
            this.colLoai.Width = 67;
            // 
            // colKichHoat
            // 
            this.colKichHoat.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colKichHoat.AppearanceHeader.Options.UseFont = true;
            this.colKichHoat.AppearanceHeader.Options.UseTextOptions = true;
            this.colKichHoat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKichHoat.Caption = "Đang quản lý";
            this.colKichHoat.ColumnEdit = this.chkKichHoat;
            this.colKichHoat.FieldName = "KichHoat";
            this.colKichHoat.Name = "colKichHoat";
            this.colKichHoat.Visible = true;
            this.colKichHoat.VisibleIndex = 5;
            this.colKichHoat.Width = 84;
            // 
            // chkKichHoat
            // 
            this.chkKichHoat.AutoHeight = false;
            this.chkKichHoat.Name = "chkKichHoat";
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
            this.colSua.Visible = true;
            this.colSua.VisibleIndex = 7;
            this.colSua.Width = 38;
            // 
            // btnSua
            // 
            this.btnSua.AutoHeight = false;
            this.btnSua.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnSua.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btnSua.Name = "btnSua";
            this.btnSua.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
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
            this.colXoa.Visible = true;
            this.colXoa.VisibleIndex = 8;
            this.colXoa.Width = 44;
            // 
            // btnXoa
            // 
            this.btnXoa.AutoHeight = false;
            this.btnXoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnXoa.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // colChiTiet
            // 
            this.colChiTiet.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colChiTiet.AppearanceHeader.Options.UseFont = true;
            this.colChiTiet.AppearanceHeader.Options.UseTextOptions = true;
            this.colChiTiet.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colChiTiet.Caption = "Chi tiết";
            this.colChiTiet.ColumnEdit = this.btnChiTiet;
            this.colChiTiet.Name = "colChiTiet";
            this.colChiTiet.Visible = true;
            this.colChiTiet.VisibleIndex = 6;
            this.colChiTiet.Width = 55;
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.AutoHeight = false;
            this.btnChiTiet.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnChiTiet.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // btnThemSanPham
            // 
            this.btnThemSanPham.Image = ((System.Drawing.Image)(resources.GetObject("btnThemSanPham.Image")));
            this.btnThemSanPham.Location = new System.Drawing.Point(9, 10);
            this.btnThemSanPham.Name = "btnThemSanPham";
            this.btnThemSanPham.Size = new System.Drawing.Size(109, 23);
            this.btnThemSanPham.TabIndex = 1;
            this.btnThemSanPham.Text = "Thêm sản phẩm";
            this.btnThemSanPham.Click += new System.EventHandler(this.btnThemSanPham_Click);
            // 
            // ucSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.btnThemSanPham);
            this.Controls.Add(this.grdSanPham);
            this.Name = "ucSanPham";
            this.Size = new System.Drawing.Size(679, 373);
            ((System.ComponentModel.ISupportInitialize)(this.grdSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkKichHoat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChiTiet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdSanPham;
        private DevExpress.XtraGrid.Views.Grid.GridView grvSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn colTenSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuongSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuongVo;
        private DevExpress.XtraGrid.Columns.GridColumn colDungTich;
        private DevExpress.XtraGrid.Columns.GridColumn colLoai;
        private DevExpress.XtraGrid.Columns.GridColumn colKichHoat;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkKichHoat;
        private DevExpress.XtraGrid.Columns.GridColumn colSua;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnSua;
        private DevExpress.XtraGrid.Columns.GridColumn colXoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThemSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn colChiTiet;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnChiTiet;
    }
}
