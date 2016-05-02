namespace NPPBiaHoi.ucHoaDon
{
    partial class frmChiTietNhapHang
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
            this.luePhuongTien = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lueNhanVien = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.timeThoiGian = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.grdThemHoaDonNhapHang = new DevExpress.XtraGrid.GridControl();
            this.grvThemNhapHangChiTiet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTraVo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoVoCoTheMuon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChú = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lueSanPham = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.spinSoLuong = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.spinTraVo = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.luePhuongTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeThoiGian.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeThoiGian.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdThemHoaDonNhapHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvThemNhapHangChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTraVo)).BeginInit();
            this.SuspendLayout();
            // 
            // luePhuongTien
            // 
            this.luePhuongTien.Location = new System.Drawing.Point(519, 47);
            this.luePhuongTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.luePhuongTien.Name = "luePhuongTien";
            this.luePhuongTien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luePhuongTien.Size = new System.Drawing.Size(211, 20);
            this.luePhuongTien.TabIndex = 18;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Location = new System.Drawing.Point(374, 72);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(117, 13);
            this.labelControl6.TabIndex = 16;
            this.labelControl6.Text = "Nhân viên nhập hàng";
            // 
            // lueNhanVien
            // 
            this.lueNhanVien.Location = new System.Drawing.Point(519, 70);
            this.lueNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lueNhanVien.Name = "lueNhanVien";
            this.lueNhanVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueNhanVien.Size = new System.Drawing.Size(211, 20);
            this.lueNhanVien.TabIndex = 17;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Location = new System.Drawing.Point(374, 51);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(130, 13);
            this.labelControl5.TabIndex = 15;
            this.labelControl5.Text = "Phương tiện nhập hàng";
            // 
            // timeThoiGian
            // 
            this.timeThoiGian.EditValue = new System.DateTime(2016, 4, 26, 0, 0, 0, 0);
            this.timeThoiGian.Location = new System.Drawing.Point(519, 24);
            this.timeThoiGian.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timeThoiGian.Name = "timeThoiGian";
            this.timeThoiGian.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeThoiGian.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeThoiGian.Properties.DisplayFormat.FormatString = "";
            this.timeThoiGian.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.timeThoiGian.Properties.EditFormat.FormatString = "";
            this.timeThoiGian.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.timeThoiGian.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.timeThoiGian.Properties.Mask.EditMask = "T";
            this.timeThoiGian.Size = new System.Drawing.Size(211, 20);
            this.timeThoiGian.TabIndex = 14;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(374, 27);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 13);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Thời gian";
            // 
            // grdThemHoaDonNhapHang
            // 
            this.grdThemHoaDonNhapHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdThemHoaDonNhapHang.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdThemHoaDonNhapHang.Location = new System.Drawing.Point(2, 112);
            this.grdThemHoaDonNhapHang.MainView = this.grvThemNhapHangChiTiet;
            this.grdThemHoaDonNhapHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdThemHoaDonNhapHang.Name = "grdThemHoaDonNhapHang";
            this.grdThemHoaDonNhapHang.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lueSanPham,
            this.spinSoLuong,
            this.spinTraVo});
            this.grdThemHoaDonNhapHang.Size = new System.Drawing.Size(756, 309);
            this.grdThemHoaDonNhapHang.TabIndex = 23;
            this.grdThemHoaDonNhapHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvThemNhapHangChiTiet});
            // 
            // grvThemNhapHangChiTiet
            // 
            this.grvThemNhapHangChiTiet.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.grvThemNhapHangChiTiet.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grvThemNhapHangChiTiet.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.grvThemNhapHangChiTiet.Appearance.HeaderPanel.Options.UseFont = true;
            this.grvThemNhapHangChiTiet.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.grvThemNhapHangChiTiet.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grvThemNhapHangChiTiet.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSanPham,
            this.colSoLuong,
            this.colTraVo,
            this.colSoVoCoTheMuon,
            this.colGhiChú});
            this.grvThemNhapHangChiTiet.GridControl = this.grdThemHoaDonNhapHang;
            this.grvThemNhapHangChiTiet.Name = "grvThemNhapHangChiTiet";
            this.grvThemNhapHangChiTiet.OptionsView.ShowGroupPanel = false;
            // 
            // colSanPham
            // 
            this.colSanPham.Caption = "Sản phẩm";
            this.colSanPham.FieldName = "Ten";
            this.colSanPham.Name = "colSanPham";
            this.colSanPham.OptionsEditForm.Caption = "Sản phẩm";
            this.colSanPham.Visible = true;
            this.colSanPham.VisibleIndex = 0;
            this.colSanPham.Width = 114;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Caption = "Số lượng";
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.OptionsEditForm.Caption = "Số lượng";
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 1;
            this.colSoLuong.Width = 112;
            // 
            // colTraVo
            // 
            this.colTraVo.Caption = "Trả vỏ";
            this.colTraVo.FieldName = "TraVo";
            this.colTraVo.Name = "colTraVo";
            this.colTraVo.OptionsEditForm.Caption = "Trả vỏ";
            this.colTraVo.Visible = true;
            this.colTraVo.VisibleIndex = 2;
            this.colTraVo.Width = 138;
            // 
            // colSoVoCoTheMuon
            // 
            this.colSoVoCoTheMuon.Caption = "Số vỏ có thể mượn";
            this.colSoVoCoTheMuon.Name = "colSoVoCoTheMuon";
            this.colSoVoCoTheMuon.OptionsEditForm.Caption = "Số vỏ đang nợ";
            this.colSoVoCoTheMuon.Visible = true;
            this.colSoVoCoTheMuon.VisibleIndex = 3;
            this.colSoVoCoTheMuon.Width = 153;
            // 
            // colGhiChú
            // 
            this.colGhiChú.Caption = "Ghi chú";
            this.colGhiChú.Name = "colGhiChú";
            this.colGhiChú.OptionsEditForm.Caption = "Ghi chú";
            this.colGhiChú.Visible = true;
            this.colGhiChú.VisibleIndex = 4;
            this.colGhiChú.Width = 221;
            // 
            // lueSanPham
            // 
            this.lueSanPham.AutoHeight = false;
            this.lueSanPham.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.lueSanPham.Name = "lueSanPham";
            // 
            // spinSoLuong
            // 
            this.spinSoLuong.AutoHeight = false;
            this.spinSoLuong.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.spinSoLuong.Name = "spinSoLuong";
            // 
            // spinTraVo
            // 
            this.spinTraVo.AutoHeight = false;
            this.spinTraVo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinTraVo.Name = "spinTraVo";
            // 
            // frmChiTietNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 426);
            this.Controls.Add(this.grdThemHoaDonNhapHang);
            this.Controls.Add(this.luePhuongTien);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.lueNhanVien);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.timeThoiGian);
            this.Controls.Add(this.labelControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChiTietNhapHang";
            this.Text = "Chi tiết nhập hàng";
            ((System.ComponentModel.ISupportInitialize)(this.luePhuongTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeThoiGian.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeThoiGian.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdThemHoaDonNhapHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvThemNhapHangChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTraVo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit luePhuongTien;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LookUpEdit lueNhanVien;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit timeThoiGian;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl grdThemHoaDonNhapHang;
        private DevExpress.XtraGrid.Views.Grid.GridView grvThemNhapHangChiTiet;
        private DevExpress.XtraGrid.Columns.GridColumn colSanPham;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lueSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit spinSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colTraVo;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit spinTraVo;
        private DevExpress.XtraGrid.Columns.GridColumn colSoVoCoTheMuon;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChú;
    }
}