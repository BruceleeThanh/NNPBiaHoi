namespace NPPBiaHoi.ucPhuongTien
{
    partial class frmSuaPhuongTien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuaPhuongTien));
            this.rdoLoai = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnThemAnh = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTaiTrong = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtBienSo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.picAnh = new DevExpress.XtraEditors.PictureEdit();
            this.mmoMieuTa = new DevExpress.XtraEditors.MemoEdit();
            this.chkDangHoatDong = new DevExpress.XtraEditors.CheckEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.rdoLoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaiTrong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBienSo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmoMieuTa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDangHoatDong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // rdoLoai
            // 
            this.rdoLoai.Location = new System.Drawing.Point(84, 143);
            this.rdoLoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoLoai.Name = "rdoLoai";
            this.rdoLoai.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rdoLoai.Properties.Appearance.Options.UseBackColor = true;
            this.rdoLoai.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rdoLoai.Properties.Columns = 2;
            this.rdoLoai.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(0)), "Xe máy"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(1)), "Ô tô")});
            this.rdoLoai.Size = new System.Drawing.Size(187, 20);
            this.rdoLoai.TabIndex = 32;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Location = new System.Drawing.Point(304, 28);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(90, 13);
            this.labelControl6.TabIndex = 31;
            this.labelControl6.Text = "Đang hoạt động";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Location = new System.Drawing.Point(22, 182);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(42, 13);
            this.labelControl5.TabIndex = 30;
            this.labelControl5.Text = "Miêu tả";
            // 
            // btnThemAnh
            // 
            this.btnThemAnh.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnThemAnh.Appearance.Options.UseFont = true;
            this.btnThemAnh.Image = ((System.Drawing.Image)(resources.GetObject("btnThemAnh.Image")));
            this.btnThemAnh.Location = new System.Drawing.Point(304, 216);
            this.btnThemAnh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemAnh.Name = "btnThemAnh";
            this.btnThemAnh.Size = new System.Drawing.Size(90, 26);
            this.btnThemAnh.TabIndex = 29;
            this.btnThemAnh.Text = "Thêm ảnh";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Location = new System.Drawing.Point(22, 143);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(23, 13);
            this.labelControl4.TabIndex = 28;
            this.labelControl4.Text = "Loại";
            // 
            // txtTaiTrong
            // 
            this.txtTaiTrong.EditValue = "";
            this.txtTaiTrong.Location = new System.Drawing.Point(84, 102);
            this.txtTaiTrong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTaiTrong.Name = "txtTaiTrong";
            this.txtTaiTrong.Size = new System.Drawing.Size(187, 20);
            this.txtTaiTrong.TabIndex = 27;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Location = new System.Drawing.Point(22, 105);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(51, 13);
            this.labelControl3.TabIndex = 26;
            this.labelControl3.Text = "Tải trọng";
            // 
            // txtBienSo
            // 
            this.txtBienSo.EditValue = "";
            this.txtBienSo.Location = new System.Drawing.Point(84, 61);
            this.txtBienSo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBienSo.Name = "txtBienSo";
            this.txtBienSo.Size = new System.Drawing.Size(187, 20);
            this.txtBienSo.TabIndex = 25;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(22, 63);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 24;
            this.labelControl2.Text = "Biển số";
            // 
            // picAnh
            // 
            this.picAnh.Location = new System.Drawing.Point(304, 63);
            this.picAnh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picAnh.Name = "picAnh";
            this.picAnh.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picAnh.Size = new System.Drawing.Size(200, 148);
            this.picAnh.TabIndex = 23;
            // 
            // mmoMieuTa
            // 
            this.mmoMieuTa.Location = new System.Drawing.Point(84, 180);
            this.mmoMieuTa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mmoMieuTa.Name = "mmoMieuTa";
            this.mmoMieuTa.Size = new System.Drawing.Size(187, 96);
            this.mmoMieuTa.TabIndex = 22;
            // 
            // chkDangHoatDong
            // 
            this.chkDangHoatDong.Location = new System.Drawing.Point(406, 26);
            this.chkDangHoatDong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkDangHoatDong.Name = "chkDangHoatDong";
            this.chkDangHoatDong.Properties.Caption = "";
            this.chkDangHoatDong.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkDangHoatDong.Size = new System.Drawing.Size(25, 19);
            this.chkDangHoatDong.TabIndex = 21;
            // 
            // txtTen
            // 
            this.txtTen.EditValue = "";
            this.txtTen.Location = new System.Drawing.Point(84, 26);
            this.txtTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(187, 20);
            this.txtTen.TabIndex = 20;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(22, 28);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(19, 12);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "Tên";
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(370, 280);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(64, 26);
            this.btnLuu.TabIndex = 18;
            this.btnLuu.Text = "Lưu";
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(440, 280);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(64, 26);
            this.btnHuy.TabIndex = 17;
            this.btnHuy.Text = "Hủy";
            // 
            // frmSuaPhuongTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 315);
            this.Controls.Add(this.rdoLoai);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.btnThemAnh);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtTaiTrong);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtBienSo);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.picAnh);
            this.Controls.Add(this.mmoMieuTa);
            this.Controls.Add(this.chkDangHoatDong);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSuaPhuongTien";
            this.Text = "Sửa thông tin phương tiện";
            ((System.ComponentModel.ISupportInitialize)(this.rdoLoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaiTrong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBienSo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmoMieuTa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDangHoatDong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.RadioGroup rdoLoai;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnThemAnh;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtTaiTrong;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtBienSo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PictureEdit picAnh;
        private DevExpress.XtraEditors.MemoEdit mmoMieuTa;
        private DevExpress.XtraEditors.CheckEdit chkDangHoatDong;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
    }
}