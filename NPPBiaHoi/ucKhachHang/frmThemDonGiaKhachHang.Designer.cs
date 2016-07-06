namespace NPPBiaHoi.ucKhachHang
{
    partial class frmThemDonGiaKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemDonGiaKhachHang));
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtDonGia = new DevExpress.XtraEditors.TextEdit();
            this.lueSanPham = new DevExpress.XtraEditors.LookUpEdit();
            this.lueKhachHang = new DevExpress.XtraEditors.LookUpEdit();
            this.timeThoiGianCapNhat = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSanPham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeThoiGianCapNhat.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeThoiGianCapNhat.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(146, 148);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(71, 29);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(227, 148);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(71, 29);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(12, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(75, 16);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Khách hàng";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(12, 54);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(69, 17);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Sản phẩm";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Location = new System.Drawing.Point(12, 82);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(49, 16);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Đơn giá";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Location = new System.Drawing.Point(12, 110);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(127, 17);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Thời gian cập nhật";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(146, 77);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(152, 22);
            this.txtDonGia.TabIndex = 7;
            // 
            // lueSanPham
            // 
            this.lueSanPham.Location = new System.Drawing.Point(146, 50);
            this.lueSanPham.Name = "lueSanPham";
            this.lueSanPham.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueSanPham.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ma", "Mã sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten", "Tên sản phẩm")});
            this.lueSanPham.Properties.DisplayMember = "Ten";
            this.lueSanPham.Properties.ValueMember = "Ma";
            this.lueSanPham.Size = new System.Drawing.Size(152, 22);
            this.lueSanPham.TabIndex = 10;
            // 
            // lueKhachHang
            // 
            this.lueKhachHang.Location = new System.Drawing.Point(146, 23);
            this.lueKhachHang.Name = "lueKhachHang";
            this.lueKhachHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueKhachHang.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ma", "Mã khách hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten", "Tên khách hàng")});
            this.lueKhachHang.Properties.DisplayMember = "Ten";
            this.lueKhachHang.Properties.ValueMember = "Ma";
            this.lueKhachHang.Size = new System.Drawing.Size(152, 22);
            this.lueKhachHang.TabIndex = 11;
            // 
            // timeThoiGianCapNhat
            // 
            this.timeThoiGianCapNhat.EditValue = new System.DateTime(2016, 4, 26, 0, 0, 0, 0);
            this.timeThoiGianCapNhat.Location = new System.Drawing.Point(146, 106);
            this.timeThoiGianCapNhat.Name = "timeThoiGianCapNhat";
            this.timeThoiGianCapNhat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeThoiGianCapNhat.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.timeThoiGianCapNhat.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeThoiGianCapNhat.Properties.DisplayFormat.FormatString = "";
            this.timeThoiGianCapNhat.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.timeThoiGianCapNhat.Properties.EditFormat.FormatString = "";
            this.timeThoiGianCapNhat.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.timeThoiGianCapNhat.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.timeThoiGianCapNhat.Properties.Mask.EditMask = "T";
            this.timeThoiGianCapNhat.Size = new System.Drawing.Size(152, 22);
            this.timeThoiGianCapNhat.TabIndex = 9;
            // 
            // frmThemDonGiaKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 183);
            this.Controls.Add(this.lueKhachHang);
            this.Controls.Add(this.lueSanPham);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.timeThoiGianCapNhat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThemDonGiaKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm đơn giá khách hàng";
            this.Load += new System.EventHandler(this.frmThemDonGiaKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSanPham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeThoiGianCapNhat.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeThoiGianCapNhat.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtDonGia;
        private DevExpress.XtraEditors.LookUpEdit lueSanPham;
        private DevExpress.XtraEditors.LookUpEdit lueKhachHang;
        private DevExpress.XtraEditors.DateEdit timeThoiGianCapNhat;
    }
}