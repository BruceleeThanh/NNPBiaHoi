namespace NPPBiaHoi.ucHoaDon
{
    partial class frmSuaHoaDonBanLe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuaHoaDonBanLe));
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.lueTenSanPham = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.timeThoiGian = new DevExpress.XtraEditors.DateEdit();
            this.spinSoLuong = new DevExpress.XtraEditors.SpinEdit();
            this.mmoGhiChu = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTenSanPham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeThoiGian.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeThoiGian.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmoGhiChu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(266, 198);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(61, 23);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(333, 198);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(61, 23);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lueTenSanPham
            // 
            this.lueTenSanPham.Location = new System.Drawing.Point(102, 21);
            this.lueTenSanPham.Name = "lueTenSanPham";
            this.lueTenSanPham.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueTenSanPham.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten", "Name6")});
            this.lueTenSanPham.Properties.NullText = "";
            this.lueTenSanPham.Size = new System.Drawing.Size(120, 20);
            this.lueTenSanPham.TabIndex = 24;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Location = new System.Drawing.Point(22, 104);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 12);
            this.labelControl4.TabIndex = 23;
            this.labelControl4.Text = "Ghi chú";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Location = new System.Drawing.Point(242, 25);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(49, 13);
            this.labelControl3.TabIndex = 22;
            this.labelControl3.Text = "Số lượng";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(22, 64);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 13);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "Thời gian";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(22, 25);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 13);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "Sản phẩm";
            // 
            // timeThoiGian
            // 
            this.timeThoiGian.EditValue = null;
            this.timeThoiGian.Location = new System.Drawing.Point(102, 60);
            this.timeThoiGian.Name = "timeThoiGian";
            this.timeThoiGian.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.timeThoiGian.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeThoiGian.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.timeThoiGian.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeThoiGian.Properties.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.timeThoiGian.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.timeThoiGian.Properties.EditFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.timeThoiGian.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.timeThoiGian.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.timeThoiGian.Properties.Mask.EditMask = "([012]?[1-9]|[123]0|31)/(0?[1-9]|1[012])/([123][0-9])?[0-9][0-9] (0?\\d|1\\d|2[0-3]" +
    "):[0-5]\\d";
            this.timeThoiGian.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.timeThoiGian.Properties.ShowOk = DevExpress.Utils.DefaultBoolean.True;
            this.timeThoiGian.Size = new System.Drawing.Size(175, 20);
            this.timeThoiGian.TabIndex = 19;
            // 
            // spinSoLuong
            // 
            this.spinSoLuong.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinSoLuong.Location = new System.Drawing.Point(305, 21);
            this.spinSoLuong.Name = "spinSoLuong";
            this.spinSoLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinSoLuong.Properties.MaxValue = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.spinSoLuong.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinSoLuong.Size = new System.Drawing.Size(77, 20);
            this.spinSoLuong.TabIndex = 18;
            // 
            // mmoGhiChu
            // 
            this.mmoGhiChu.Location = new System.Drawing.Point(102, 101);
            this.mmoGhiChu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mmoGhiChu.Name = "mmoGhiChu";
            this.mmoGhiChu.Size = new System.Drawing.Size(280, 79);
            this.mmoGhiChu.TabIndex = 17;
            // 
            // frmSuaHoaDonBanLe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 230);
            this.Controls.Add(this.lueTenSanPham);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.timeThoiGian);
            this.Controls.Add(this.spinSoLuong);
            this.Controls.Add(this.mmoGhiChu);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSuaHoaDonBanLe";
            this.Text = "Sửa hóa đơn bán lẻ";
            ((System.ComponentModel.ISupportInitialize)(this.lueTenSanPham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeThoiGian.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeThoiGian.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmoGhiChu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.LookUpEdit lueTenSanPham;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit timeThoiGian;
        private DevExpress.XtraEditors.SpinEdit spinSoLuong;
        private DevExpress.XtraEditors.MemoEdit mmoGhiChu;
    }
}