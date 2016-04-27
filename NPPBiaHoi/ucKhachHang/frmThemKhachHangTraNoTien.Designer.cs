namespace NPPBiaHoi.ucKhachHang
{
    partial class frmThemKhachHangTraNoTien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemLichSuKhachHangTraNoTien));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lueTenKhachHang = new DevExpress.XtraEditors.LookUpEdit();
            this.spinTongTienNo = new DevExpress.XtraEditors.SpinEdit();
            this.mmoGhiChu = new DevExpress.XtraEditors.MemoEdit();
            this.grdThemLichSuKhachHangTraNoTien = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colThoiGian = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoTienTraLanNay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.dateThoiGian = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.spinSoTienTraLanNay = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTenKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTongTienNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmoGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdThemLichSuKhachHangTraNoTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateThoiGian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateThoiGian.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSoTienTraLanNay)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(21, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(89, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên khách hàng";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(21, 65);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(106, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tổng tiền nợ (VNĐ)";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Location = new System.Drawing.Point(308, 18);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(41, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Ghi chú";
            // 
            // lueTenKhachHang
            // 
            this.lueTenKhachHang.Location = new System.Drawing.Point(134, 15);
            this.lueTenKhachHang.Name = "lueTenKhachHang";
            this.lueTenKhachHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueTenKhachHang.Size = new System.Drawing.Size(147, 20);
            this.lueTenKhachHang.TabIndex = 3;
            // 
            // spinTongTienNo
            // 
            this.spinTongTienNo.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinTongTienNo.Enabled = false;
            this.spinTongTienNo.Location = new System.Drawing.Point(134, 62);
            this.spinTongTienNo.Name = "spinTongTienNo";
            this.spinTongTienNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinTongTienNo.Size = new System.Drawing.Size(147, 20);
            this.spinTongTienNo.TabIndex = 4;
            // 
            // mmoGhiChu
            // 
            this.mmoGhiChu.Location = new System.Drawing.Point(368, 16);
            this.mmoGhiChu.Name = "mmoGhiChu";
            this.mmoGhiChu.Size = new System.Drawing.Size(218, 66);
            this.mmoGhiChu.TabIndex = 5;
            // 
            // grdThemLichSuKhachHangTraNoTien
            // 
            this.grdThemLichSuKhachHangTraNoTien.Location = new System.Drawing.Point(0, 98);
            this.grdThemLichSuKhachHangTraNoTien.MainView = this.gridView1;
            this.grdThemLichSuKhachHangTraNoTien.Name = "grdThemLichSuKhachHangTraNoTien";
            this.grdThemLichSuKhachHangTraNoTien.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.dateThoiGian,
            this.spinSoTienTraLanNay});
            this.grdThemLichSuKhachHangTraNoTien.Size = new System.Drawing.Size(620, 200);
            this.grdThemLichSuKhachHangTraNoTien.TabIndex = 6;
            this.grdThemLichSuKhachHangTraNoTien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colThoiGian,
            this.colSoTienTraLanNay,
            this.colGhiChu});
            this.gridView1.GridControl = this.grdThemLichSuKhachHangTraNoTien;
            this.gridView1.Name = "gridView1";
            // 
            // colThoiGian
            // 
            this.colThoiGian.AppearanceHeader.Options.UseTextOptions = true;
            this.colThoiGian.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colThoiGian.Caption = "Thời gian";
            this.colThoiGian.ColumnEdit = this.dateThoiGian;
            this.colThoiGian.FieldName = "ThoiGian";
            this.colThoiGian.Name = "colThoiGian";
            this.colThoiGian.Visible = true;
            this.colThoiGian.VisibleIndex = 0;
            this.colThoiGian.Width = 140;
            // 
            // colSoTienTraLanNay
            // 
            this.colSoTienTraLanNay.AppearanceHeader.Options.UseTextOptions = true;
            this.colSoTienTraLanNay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSoTienTraLanNay.Caption = "Số tiền trả lần này";
            this.colSoTienTraLanNay.ColumnEdit = this.spinSoTienTraLanNay;
            this.colSoTienTraLanNay.FieldName = "SoTien";
            this.colSoTienTraLanNay.Name = "colSoTienTraLanNay";
            this.colSoTienTraLanNay.Visible = true;
            this.colSoTienTraLanNay.VisibleIndex = 1;
            this.colSoTienTraLanNay.Width = 147;
            // 
            // colGhiChu
            // 
            this.colGhiChu.AppearanceHeader.Options.UseTextOptions = true;
            this.colGhiChu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGhiChu.Caption = "Ghi chú";
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 2;
            this.colGhiChu.Width = 315;
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(493, 304);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(51, 23);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            // 
            // btnHuy
            // 
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(550, 304);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(57, 23);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy";
            // 
            // dateThoiGian
            // 
            this.dateThoiGian.AutoHeight = false;
            this.dateThoiGian.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.dateThoiGian.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateThoiGian.Name = "dateThoiGian";
            // 
            // spinSoTienTraLanNay
            // 
            this.spinSoTienTraLanNay.AutoHeight = false;
            this.spinSoTienTraLanNay.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.spinSoTienTraLanNay.Name = "spinSoTienTraLanNay";
            // 
            // frmThemLichSuKhachHangTraNoTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 335);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.grdThemLichSuKhachHangTraNoTien);
            this.Controls.Add(this.mmoGhiChu);
            this.Controls.Add(this.spinTongTienNo);
            this.Controls.Add(this.lueTenKhachHang);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThemLichSuKhachHangTraNoTien";
            this.Text = "Thêm lịch sử khách hàng trả nợ tiền";
            ((System.ComponentModel.ISupportInitialize)(this.lueTenKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTongTienNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmoGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdThemLichSuKhachHangTraNoTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateThoiGian.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateThoiGian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSoTienTraLanNay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit lueTenKhachHang;
        private DevExpress.XtraEditors.SpinEdit spinTongTienNo;
        private DevExpress.XtraEditors.MemoEdit mmoGhiChu;
        private DevExpress.XtraGrid.GridControl grdThemLichSuKhachHangTraNoTien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colThoiGian;
        private DevExpress.XtraGrid.Columns.GridColumn colSoTienTraLanNay;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit dateThoiGian;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit spinSoTienTraLanNay;
    }
}