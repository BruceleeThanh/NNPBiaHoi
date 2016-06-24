namespace NPPBiaHoi.ucPhuongTien
{
    partial class ucChiPhiPhuongTien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucChiPhiPhuongTien));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.grdChiPhiPhuongTien = new DevExpress.XtraGrid.GridControl();
            this.grvChiPhiPhuongTien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenPhuongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThoiGian = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTienPhi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMieuTa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSua = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdChiPhiPhuongTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvChiPhiPhuongTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).BeginInit();
            this.SuspendLayout();
            // 
            // grdChiPhiPhuongTien
            // 
            this.grdChiPhiPhuongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdChiPhiPhuongTien.Location = new System.Drawing.Point(0, 40);
            this.grdChiPhiPhuongTien.MainView = this.grvChiPhiPhuongTien;
            this.grdChiPhiPhuongTien.Name = "grdChiPhiPhuongTien";
            this.grdChiPhiPhuongTien.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnSua,
            this.btnXoa});
            this.grdChiPhiPhuongTien.Size = new System.Drawing.Size(681, 327);
            this.grdChiPhiPhuongTien.TabIndex = 0;
            this.grdChiPhiPhuongTien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvChiPhiPhuongTien});
            // 
            // grvChiPhiPhuongTien
            // 
            this.grvChiPhiPhuongTien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenPhuongTien,
            this.colThoiGian,
            this.colTienPhi,
            this.colMieuTa,
            this.colSua,
            this.colXoa});
            this.grvChiPhiPhuongTien.GridControl = this.grdChiPhiPhuongTien;
            this.grvChiPhiPhuongTien.IndicatorWidth = 30;
            this.grvChiPhiPhuongTien.Name = "grvChiPhiPhuongTien";
            this.grvChiPhiPhuongTien.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.grvChiPhiPhuongTien_CustomDrawRowIndicator);
            // 
            // colTenPhuongTien
            // 
            this.colTenPhuongTien.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTenPhuongTien.AppearanceHeader.Options.UseFont = true;
            this.colTenPhuongTien.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenPhuongTien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenPhuongTien.Caption = "Tên chi phí";
            this.colTenPhuongTien.FieldName = "Ten";
            this.colTenPhuongTien.Name = "colTenPhuongTien";
            this.colTenPhuongTien.OptionsColumn.ReadOnly = true;
            this.colTenPhuongTien.Visible = true;
            this.colTenPhuongTien.VisibleIndex = 0;
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
            // 
            // colTienPhi
            // 
            this.colTienPhi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTienPhi.AppearanceHeader.Options.UseFont = true;
            this.colTienPhi.AppearanceHeader.Options.UseTextOptions = true;
            this.colTienPhi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTienPhi.Caption = "Tiền phí";
            this.colTienPhi.FieldName = "TienPhi";
            this.colTienPhi.Name = "colTienPhi";
            this.colTienPhi.OptionsColumn.ReadOnly = true;
            this.colTienPhi.Visible = true;
            this.colTienPhi.VisibleIndex = 2;
            // 
            // colMieuTa
            // 
            this.colMieuTa.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMieuTa.AppearanceHeader.Options.UseFont = true;
            this.colMieuTa.AppearanceHeader.Options.UseTextOptions = true;
            this.colMieuTa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMieuTa.Caption = "Miêu tả";
            this.colMieuTa.FieldName = "MieuTa";
            this.colMieuTa.Name = "colMieuTa";
            this.colMieuTa.OptionsColumn.ReadOnly = true;
            this.colMieuTa.Visible = true;
            this.colMieuTa.VisibleIndex = 3;
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
            this.colSua.VisibleIndex = 4;
            this.colSua.Width = 42;
            // 
            // btnSua
            // 
            this.btnSua.AutoHeight = false;
            this.btnSua.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnSua.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
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
            this.colXoa.VisibleIndex = 5;
            this.colXoa.Width = 42;
            // 
            // btnXoa
            // 
            this.btnXoa.AutoHeight = false;
            this.btnXoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnXoa.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", null, null, true)});
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnXoa.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnXoa_ButtonClick);
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(10, 9);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(64, 23);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // ucChiPhiPhuongTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grdChiPhiPhuongTien);
            this.Name = "ucChiPhiPhuongTien";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.grdChiPhiPhuongTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvChiPhiPhuongTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdChiPhiPhuongTien;
        private DevExpress.XtraGrid.Views.Grid.GridView grvChiPhiPhuongTien;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraGrid.Columns.GridColumn colTenPhuongTien;
        private DevExpress.XtraGrid.Columns.GridColumn colThoiGian;
        private DevExpress.XtraGrid.Columns.GridColumn colTienPhi;
        private DevExpress.XtraGrid.Columns.GridColumn colMieuTa;
        private DevExpress.XtraGrid.Columns.GridColumn colSua;
        private DevExpress.XtraGrid.Columns.GridColumn colXoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnSua;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnXoa;
    }
}
