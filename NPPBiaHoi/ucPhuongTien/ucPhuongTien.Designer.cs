namespace NPPBiaHoi.ucPhuongTien
{
    partial class ucPhuongTien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPhuongTien));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            this.grdPhuongTien = new DevExpress.XtraGrid.GridControl();
            this.grvPhuongTien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBienSo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaiTrong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKichHoat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkKichHoat = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colChiTiet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnChiTiet = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colSua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSua = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdPhuongTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPhuongTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkKichHoat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).BeginInit();
            this.SuspendLayout();
            // 
            // grdPhuongTien
            // 
            this.grdPhuongTien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdPhuongTien.Location = new System.Drawing.Point(0, 42);
            this.grdPhuongTien.MainView = this.grvPhuongTien;
            this.grdPhuongTien.Name = "grdPhuongTien";
            this.grdPhuongTien.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnSua,
            this.btnXoa,
            this.chkKichHoat,
            this.btnChiTiet});
            this.grdPhuongTien.Size = new System.Drawing.Size(667, 351);
            this.grdPhuongTien.TabIndex = 0;
            this.grdPhuongTien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvPhuongTien});
            // 
            // grvPhuongTien
            // 
            this.grvPhuongTien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTen,
            this.colBienSo,
            this.colTaiTrong,
            this.colLoai,
            this.colKichHoat,
            this.colChiTiet,
            this.colSua,
            this.colXoa});
            this.grvPhuongTien.GridControl = this.grdPhuongTien;
            this.grvPhuongTien.IndicatorWidth = 30;
            this.grvPhuongTien.Name = "grvPhuongTien";
            this.grvPhuongTien.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.grvPhuongTien_CustomDrawRowIndicator);
            // 
            // colTen
            // 
            this.colTen.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTen.AppearanceHeader.Options.UseFont = true;
            this.colTen.AppearanceHeader.Options.UseTextOptions = true;
            this.colTen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTen.Caption = "Tên xe";
            this.colTen.FieldName = "Ten";
            this.colTen.Name = "colTen";
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 0;
            this.colTen.Width = 118;
            // 
            // colBienSo
            // 
            this.colBienSo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colBienSo.AppearanceHeader.Options.UseFont = true;
            this.colBienSo.AppearanceHeader.Options.UseTextOptions = true;
            this.colBienSo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBienSo.Caption = "Biển số";
            this.colBienSo.FieldName = "BienSo";
            this.colBienSo.Name = "colBienSo";
            this.colBienSo.Visible = true;
            this.colBienSo.VisibleIndex = 1;
            this.colBienSo.Width = 135;
            // 
            // colTaiTrong
            // 
            this.colTaiTrong.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTaiTrong.AppearanceHeader.Options.UseFont = true;
            this.colTaiTrong.AppearanceHeader.Options.UseTextOptions = true;
            this.colTaiTrong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTaiTrong.Caption = "Tải trọng";
            this.colTaiTrong.FieldName = "TaiTrong";
            this.colTaiTrong.Name = "colTaiTrong";
            this.colTaiTrong.Visible = true;
            this.colTaiTrong.VisibleIndex = 2;
            this.colTaiTrong.Width = 130;
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
            this.colLoai.VisibleIndex = 3;
            this.colLoai.Width = 58;
            // 
            // colKichHoat
            // 
            this.colKichHoat.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colKichHoat.AppearanceHeader.Options.UseFont = true;
            this.colKichHoat.AppearanceHeader.Options.UseTextOptions = true;
            this.colKichHoat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKichHoat.Caption = "Kích hoạt";
            this.colKichHoat.ColumnEdit = this.chkKichHoat;
            this.colKichHoat.Name = "colKichHoat";
            this.colKichHoat.Visible = true;
            this.colKichHoat.VisibleIndex = 4;
            this.colKichHoat.Width = 68;
            // 
            // chkKichHoat
            // 
            this.chkKichHoat.AutoHeight = false;
            this.chkKichHoat.Name = "chkKichHoat";
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
            this.colChiTiet.VisibleIndex = 5;
            this.colChiTiet.Width = 50;
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
            this.colSua.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colSua.AppearanceHeader.Options.UseFont = true;
            this.colSua.AppearanceHeader.Options.UseTextOptions = true;
            this.colSua.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSua.Caption = "Sửa";
            this.colSua.ColumnEdit = this.btnSua;
            this.colSua.Name = "colSua";
            this.colSua.Visible = true;
            this.colSua.VisibleIndex = 6;
            this.colSua.Width = 42;
            // 
            // btnSua
            // 
            this.btnSua.AutoHeight = false;
            this.btnSua.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnSua.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
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
            this.colXoa.Visible = true;
            this.colXoa.VisibleIndex = 7;
            this.colXoa.Width = 48;
            // 
            // btnXoa
            // 
            this.btnXoa.AutoHeight = false;
            this.btnXoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnXoa.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnXoa.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnXoa_ButtonClick);
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(14, 11);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(64, 23);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // ucPhuongTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grdPhuongTien);
            this.Name = "ucPhuongTien";
            this.Size = new System.Drawing.Size(667, 393);
            ((System.ComponentModel.ISupportInitialize)(this.grdPhuongTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPhuongTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkKichHoat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdPhuongTien;
        private DevExpress.XtraGrid.Views.Grid.GridView grvPhuongTien;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraGrid.Columns.GridColumn colBienSo;
        private DevExpress.XtraGrid.Columns.GridColumn colTaiTrong;
        private DevExpress.XtraGrid.Columns.GridColumn colSua;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnSua;
        private DevExpress.XtraGrid.Columns.GridColumn colXoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraGrid.Columns.GridColumn colLoai;
        private DevExpress.XtraGrid.Columns.GridColumn colKichHoat;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkKichHoat;
        private DevExpress.XtraGrid.Columns.GridColumn colChiTiet;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnChiTiet;
    }
}
