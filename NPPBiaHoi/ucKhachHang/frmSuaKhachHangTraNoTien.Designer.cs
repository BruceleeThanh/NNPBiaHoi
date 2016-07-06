namespace NPPBiaHoi.ucKhachHang
{
    partial class frmSuaKhachHangTraNoTien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuaKhachHangTraNoTien));
            this.grdSuaLichSuKhachHangTraNoTien = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colThoiGian = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateThoiGian = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colSoTienTraLanNay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spinSoTienTraLanNay = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mmoGhiChu = new DevExpress.XtraEditors.MemoEdit();
            this.spinTongTienNo = new DevExpress.XtraEditors.SpinEdit();
            this.lueTenKhachHang = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdSuaLichSuKhachHangTraNoTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateThoiGian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateThoiGian.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSoTienTraLanNay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmoGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTongTienNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTenKhachHang.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdSuaLichSuKhachHangTraNoTien
            // 
            this.grdSuaLichSuKhachHangTraNoTien.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdSuaLichSuKhachHangTraNoTien.Location = new System.Drawing.Point(-1, 116);
            this.grdSuaLichSuKhachHangTraNoTien.MainView = this.gridView1;
            this.grdSuaLichSuKhachHangTraNoTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdSuaLichSuKhachHangTraNoTien.Name = "grdSuaLichSuKhachHangTraNoTien";
            this.grdSuaLichSuKhachHangTraNoTien.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.dateThoiGian,
            this.spinSoTienTraLanNay});
            this.grdSuaLichSuKhachHangTraNoTien.Size = new System.Drawing.Size(723, 246);
            this.grdSuaLichSuKhachHangTraNoTien.TabIndex = 15;
            this.grdSuaLichSuKhachHangTraNoTien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colThoiGian,
            this.colSoTienTraLanNay,
            this.colGhiChu});
            this.gridView1.GridControl = this.grdSuaLichSuKhachHangTraNoTien;
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
            // dateThoiGian
            // 
            this.dateThoiGian.AutoHeight = false;
            this.dateThoiGian.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.dateThoiGian.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateThoiGian.Name = "dateThoiGian";
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
            // spinSoTienTraLanNay
            // 
            this.spinSoTienTraLanNay.AutoHeight = false;
            this.spinSoTienTraLanNay.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.spinSoTienTraLanNay.Name = "spinSoTienTraLanNay";
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
            // mmoGhiChu
            // 
            this.mmoGhiChu.Location = new System.Drawing.Point(428, 15);
            this.mmoGhiChu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mmoGhiChu.Name = "mmoGhiChu";
            this.mmoGhiChu.Size = new System.Drawing.Size(254, 81);
            this.mmoGhiChu.TabIndex = 14;
            // 
            // spinTongTienNo
            // 
            this.spinTongTienNo.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinTongTienNo.Enabled = false;
            this.spinTongTienNo.Location = new System.Drawing.Point(155, 71);
            this.spinTongTienNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.spinTongTienNo.Name = "spinTongTienNo";
            this.spinTongTienNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinTongTienNo.Size = new System.Drawing.Size(171, 22);
            this.spinTongTienNo.TabIndex = 13;
            // 
            // lueTenKhachHang
            // 
            this.lueTenKhachHang.Location = new System.Drawing.Point(155, 14);
            this.lueTenKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lueTenKhachHang.Name = "lueTenKhachHang";
            this.lueTenKhachHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueTenKhachHang.Size = new System.Drawing.Size(171, 22);
            this.lueTenKhachHang.TabIndex = 12;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Location = new System.Drawing.Point(358, 17);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(51, 17);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Ghi chú";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(23, 75);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(136, 17);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Tổng tiền nợ (VNĐ)";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(23, 17);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(110, 17);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Tên khách hàng";
            // 
            // btnHuy
            // 
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(640, 369);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(66, 28);
            this.btnHuy.TabIndex = 17;
            this.btnHuy.Text = "Hủy";
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(574, 369);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(59, 28);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "Lưu";
            // 
            // frmSuaKhachHangTraNoTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 412);
            this.Controls.Add(this.grdSuaLichSuKhachHangTraNoTien);
            this.Controls.Add(this.mmoGhiChu);
            this.Controls.Add(this.spinTongTienNo);
            this.Controls.Add(this.lueTenKhachHang);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSuaKhachHangTraNoTien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa lịch sử khách hàng trả nợ tiền";
            ((System.ComponentModel.ISupportInitialize)(this.grdSuaLichSuKhachHangTraNoTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateThoiGian.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateThoiGian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSoTienTraLanNay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmoGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTongTienNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTenKhachHang.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdSuaLichSuKhachHangTraNoTien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colThoiGian;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit dateThoiGian;
        private DevExpress.XtraGrid.Columns.GridColumn colSoTienTraLanNay;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit spinSoTienTraLanNay;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraEditors.MemoEdit mmoGhiChu;
        private DevExpress.XtraEditors.SpinEdit spinTongTienNo;
        private DevExpress.XtraEditors.LookUpEdit lueTenKhachHang;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
    }
}