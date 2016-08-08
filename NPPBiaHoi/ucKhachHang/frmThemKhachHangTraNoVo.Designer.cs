namespace NPPBiaHoi.ucKhachHang
{
    partial class frmThemKhachHangTraNoVo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemKhachHangTraNoVo));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lueTenKhachHang = new DevExpress.XtraEditors.LookUpEdit();
            this.lueTenSanPham = new DevExpress.XtraEditors.LookUpEdit();
            this.spinTongSoLuongNo = new DevExpress.XtraEditors.SpinEdit();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.grdThemLichSuKhachHangTraNoVo = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colThoiGian = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateThoiGian = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colSoVoTraLanNay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lueLoai = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lueTenKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTenSanPham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTongSoLuongNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdThemLichSuKhachHangTraNoVo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateThoiGian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateThoiGian.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLoai)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(21, 18);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(91, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên khách hàng";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(322, 18);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(87, 17);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên sản phẩm";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(21, 66);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(109, 17);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Tổng số lượng nợ";
            // 
            // lueTenKhachHang
            // 
            this.lueTenKhachHang.Location = new System.Drawing.Point(134, 15);
            this.lueTenKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lueTenKhachHang.Name = "lueTenKhachHang";
            this.lueTenKhachHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueTenKhachHang.Size = new System.Drawing.Size(163, 22);
            this.lueTenKhachHang.TabIndex = 1;
            // 
            // lueTenSanPham
            // 
            this.lueTenSanPham.Location = new System.Drawing.Point(418, 15);
            this.lueTenSanPham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lueTenSanPham.Name = "lueTenSanPham";
            this.lueTenSanPham.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueTenSanPham.Size = new System.Drawing.Size(163, 22);
            this.lueTenSanPham.TabIndex = 2;
            // 
            // spinTongSoLuongNo
            // 
            this.spinTongSoLuongNo.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinTongSoLuongNo.Enabled = false;
            this.spinTongSoLuongNo.Location = new System.Drawing.Point(134, 63);
            this.spinTongSoLuongNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.spinTongSoLuongNo.Name = "spinTongSoLuongNo";
            this.spinTongSoLuongNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinTongSoLuongNo.Size = new System.Drawing.Size(163, 22);
            this.spinTongSoLuongNo.TabIndex = 3;
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(446, 358);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(69, 28);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            // 
            // btnHuy
            // 
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(521, 358);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(69, 28);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            // 
            // grdThemLichSuKhachHangTraNoVo
            // 
            this.grdThemLichSuKhachHangTraNoVo.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdThemLichSuKhachHangTraNoVo.Location = new System.Drawing.Point(-1, 102);
            this.grdThemLichSuKhachHangTraNoVo.MainView = this.gridView1;
            this.grdThemLichSuKhachHangTraNoVo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdThemLichSuKhachHangTraNoVo.Name = "grdThemLichSuKhachHangTraNoVo";
            this.grdThemLichSuKhachHangTraNoVo.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.dateThoiGian,
            this.repositoryItemSpinEdit1,
            this.lueLoai});
            this.grdThemLichSuKhachHangTraNoVo.Size = new System.Drawing.Size(611, 246);
            this.grdThemLichSuKhachHangTraNoVo.TabIndex = 6;
            this.grdThemLichSuKhachHangTraNoVo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colThoiGian,
            this.colSoVoTraLanNay,
            this.colLoai,
            this.colGhiChu});
            this.gridView1.GridControl = this.grdThemLichSuKhachHangTraNoVo;
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
            // colSoVoTraLanNay
            // 
            this.colSoVoTraLanNay.AppearanceHeader.Options.UseTextOptions = true;
            this.colSoVoTraLanNay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSoVoTraLanNay.Caption = "Số vỏ trả lần này";
            this.colSoVoTraLanNay.ColumnEdit = this.repositoryItemSpinEdit1;
            this.colSoVoTraLanNay.FieldName = "SoVoTra";
            this.colSoVoTraLanNay.Name = "colSoVoTraLanNay";
            this.colSoVoTraLanNay.Visible = true;
            this.colSoVoTraLanNay.VisibleIndex = 1;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // colLoai
            // 
            this.colLoai.AppearanceHeader.Options.UseTextOptions = true;
            this.colLoai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLoai.Caption = "Loại";
            this.colLoai.ColumnEdit = this.lueLoai;
            this.colLoai.FieldName = "Loai";
            this.colLoai.Name = "colLoai";
            this.colLoai.Visible = true;
            this.colLoai.VisibleIndex = 2;
            // 
            // lueLoai
            // 
            this.lueLoai.AutoHeight = false;
            this.lueLoai.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.lueLoai.Name = "lueLoai";
            // 
            // colGhiChu
            // 
            this.colGhiChu.AppearanceHeader.Options.UseTextOptions = true;
            this.colGhiChu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGhiChu.Caption = "Ghi chú";
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 3;
            // 
            // frmThemKhachHangTraNoVo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 398);
            this.Controls.Add(this.grdThemLichSuKhachHangTraNoVo);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.spinTongSoLuongNo);
            this.Controls.Add(this.lueTenSanPham);
            this.Controls.Add(this.lueTenKhachHang);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThemKhachHangTraNoVo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm khách hàng trả nợ vỏ";
            ((System.ComponentModel.ISupportInitialize)(this.lueTenKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTenSanPham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTongSoLuongNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdThemLichSuKhachHangTraNoVo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateThoiGian.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateThoiGian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLoai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit lueTenKhachHang;
        private DevExpress.XtraEditors.LookUpEdit lueTenSanPham;
        private DevExpress.XtraEditors.SpinEdit spinTongSoLuongNo;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraGrid.GridControl grdThemLichSuKhachHangTraNoVo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colThoiGian;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit dateThoiGian;
        private DevExpress.XtraGrid.Columns.GridColumn colSoVoTraLanNay;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colLoai;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lueLoai;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
    }
}