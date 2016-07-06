namespace NPPBiaHoi.ucHoaDon
{
    partial class ucHoaDonBanBuon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucHoaDonBanBuon));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.grdHoaDonBanBuon = new DevExpress.XtraGrid.GridControl();
            this.grvHoaDonBanBuon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThoiGian = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThanhToan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChiTiet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnChiTiet = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colSua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSua = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grdHoaDonBanBuon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvHoaDonBanBuon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(9, 10);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(76, 28);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // grdHoaDonBanBuon
            // 
            this.grdHoaDonBanBuon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdHoaDonBanBuon.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdHoaDonBanBuon.Location = new System.Drawing.Point(0, 46);
            this.grdHoaDonBanBuon.MainView = this.grvHoaDonBanBuon;
            this.grdHoaDonBanBuon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdHoaDonBanBuon.Name = "grdHoaDonBanBuon";
            this.grdHoaDonBanBuon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnChiTiet,
            this.btnSua,
            this.btnXoa});
            this.grdHoaDonBanBuon.Size = new System.Drawing.Size(1015, 470);
            this.grdHoaDonBanBuon.TabIndex = 1;
            this.grdHoaDonBanBuon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvHoaDonBanBuon});
            // 
            // grvHoaDonBanBuon
            // 
            this.grvHoaDonBanBuon.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKhachHang,
            this.colThoiGian,
            this.colTongTien,
            this.colThanhToan,
            this.colGhiChu,
            this.colChiTiet,
            this.colSua,
            this.colXoa});
            this.grvHoaDonBanBuon.GridControl = this.grdHoaDonBanBuon;
            this.grvHoaDonBanBuon.Name = "grvHoaDonBanBuon";
            // 
            // colKhachHang
            // 
            this.colKhachHang.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colKhachHang.AppearanceHeader.Options.UseFont = true;
            this.colKhachHang.AppearanceHeader.Options.UseTextOptions = true;
            this.colKhachHang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKhachHang.Caption = "Khách hàng";
            this.colKhachHang.FieldName = "Ten";
            this.colKhachHang.Name = "colKhachHang";
            this.colKhachHang.OptionsColumn.ReadOnly = true;
            this.colKhachHang.Visible = true;
            this.colKhachHang.VisibleIndex = 0;
            this.colKhachHang.Width = 89;
            // 
            // colThoiGian
            // 
            this.colThoiGian.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colThoiGian.AppearanceHeader.Options.UseFont = true;
            this.colThoiGian.AppearanceHeader.Options.UseTextOptions = true;
            this.colThoiGian.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colThoiGian.Caption = "Thời gian";
            this.colThoiGian.FieldName = "ThoiGian";
            this.colThoiGian.Name = "colThoiGian";
            this.colThoiGian.OptionsColumn.ReadOnly = true;
            this.colThoiGian.Visible = true;
            this.colThoiGian.VisibleIndex = 1;
            this.colThoiGian.Width = 156;
            // 
            // colTongTien
            // 
            this.colTongTien.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTongTien.AppearanceHeader.Options.UseFont = true;
            this.colTongTien.AppearanceHeader.Options.UseTextOptions = true;
            this.colTongTien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTongTien.Caption = "Tổng tiền";
            this.colTongTien.FieldName = "TongTien";
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.OptionsColumn.ReadOnly = true;
            this.colTongTien.Visible = true;
            this.colTongTien.VisibleIndex = 2;
            this.colTongTien.Width = 120;
            // 
            // colThanhToan
            // 
            this.colThanhToan.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colThanhToan.AppearanceHeader.Options.UseFont = true;
            this.colThanhToan.AppearanceHeader.Options.UseTextOptions = true;
            this.colThanhToan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colThanhToan.Caption = "Thanh toán";
            this.colThanhToan.FieldName = "ThanhToan";
            this.colThanhToan.Name = "colThanhToan";
            this.colThanhToan.OptionsColumn.ReadOnly = true;
            this.colThanhToan.Visible = true;
            this.colThanhToan.VisibleIndex = 3;
            this.colThanhToan.Width = 112;
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
            this.colGhiChu.VisibleIndex = 4;
            this.colGhiChu.Width = 173;
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
            this.colChiTiet.Width = 48;
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.AutoHeight = false;
            this.btnChiTiet.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnChiTiet.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
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
            this.colSua.Width = 32;
            // 
            // btnSua
            // 
            this.btnSua.AutoHeight = false;
            this.btnSua.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnSua.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
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
            this.colXoa.VisibleIndex = 7;
            this.colXoa.Width = 32;
            // 
            // btnXoa
            // 
            this.btnXoa.AutoHeight = false;
            this.btnXoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnXoa.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // ucHoaDonBanBuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grdHoaDonBanBuon);
            this.Controls.Add(this.btnThem);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucHoaDonBanBuon";
            this.Size = new System.Drawing.Size(1015, 516);
            ((System.ComponentModel.ISupportInitialize)(this.grdHoaDonBanBuon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvHoaDonBanBuon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraGrid.GridControl grdHoaDonBanBuon;
        private DevExpress.XtraGrid.Views.Grid.GridView grvHoaDonBanBuon;
        private DevExpress.XtraGrid.Columns.GridColumn colKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn colThoiGian;
        private DevExpress.XtraGrid.Columns.GridColumn colTongTien;
        private DevExpress.XtraGrid.Columns.GridColumn colThanhToan;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn colChiTiet;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnChiTiet;
        private DevExpress.XtraGrid.Columns.GridColumn colSua;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnSua;
        private DevExpress.XtraGrid.Columns.GridColumn colXoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnXoa;
    }
}
