namespace NPPBiaHoi.ucSanPham
{
    partial class frmThemSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemSanPham));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenSanPham = new DevExpress.XtraEditors.TextEdit();
            this.txtDungTich = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.chkDangQuanLy = new DevExpress.XtraEditors.CheckEdit();
            this.picAnh = new DevExpress.XtraEditors.PictureEdit();
            this.mmoMieuTa = new DevExpress.XtraEditors.MemoEdit();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemAnh = new DevExpress.XtraEditors.SimpleButton();
            this.rdoLoai = new DevExpress.XtraEditors.RadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSanPham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDungTich.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDangQuanLy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmoMieuTa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdoLoai.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(23, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(79, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên sản phẩm";
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Location = new System.Drawing.Point(111, 19);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(187, 20);
            this.txtTenSanPham.TabIndex = 1;
            // 
            // txtDungTich
            // 
            this.txtDungTich.Location = new System.Drawing.Point(111, 61);
            this.txtDungTich.Name = "txtDungTich";
            this.txtDungTich.Properties.Mask.EditMask = "f";
            this.txtDungTich.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDungTich.Size = new System.Drawing.Size(187, 20);
            this.txtDungTich.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Location = new System.Drawing.Point(23, 64);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(77, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Dung tích (lít)";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Location = new System.Drawing.Point(23, 150);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(42, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Miêu tả";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Location = new System.Drawing.Point(23, 106);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(23, 13);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Loại";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl8.Location = new System.Drawing.Point(329, 22);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(74, 13);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "Đang quản lý";
            // 
            // chkDangQuanLy
            // 
            this.chkDangQuanLy.EditValue = true;
            this.chkDangQuanLy.Location = new System.Drawing.Point(421, 19);
            this.chkDangQuanLy.Name = "chkDangQuanLy";
            this.chkDangQuanLy.Properties.Caption = "";
            this.chkDangQuanLy.Size = new System.Drawing.Size(19, 19);
            this.chkDangQuanLy.TabIndex = 15;
            // 
            // picAnh
            // 
            this.picAnh.Location = new System.Drawing.Point(328, 50);
            this.picAnh.Name = "picAnh";
            this.picAnh.Properties.InitialImage = ((System.Drawing.Image)(resources.GetObject("picAnh.Properties.InitialImage")));
            this.picAnh.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picAnh.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picAnh.Size = new System.Drawing.Size(150, 150);
            this.picAnh.TabIndex = 16;
            // 
            // mmoMieuTa
            // 
            this.mmoMieuTa.Location = new System.Drawing.Point(111, 144);
            this.mmoMieuTa.Name = "mmoMieuTa";
            this.mmoMieuTa.Size = new System.Drawing.Size(187, 86);
            this.mmoMieuTa.TabIndex = 21;
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(331, 248);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(66, 26);
            this.btnLuu.TabIndex = 22;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(412, 248);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(66, 26);
            this.btnHuy.TabIndex = 23;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThemAnh
            // 
            this.btnThemAnh.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnThemAnh.Appearance.Options.UseFont = true;
            this.btnThemAnh.Image = ((System.Drawing.Image)(resources.GetObject("btnThemAnh.Image")));
            this.btnThemAnh.Location = new System.Drawing.Point(329, 206);
            this.btnThemAnh.Name = "btnThemAnh";
            this.btnThemAnh.Size = new System.Drawing.Size(98, 24);
            this.btnThemAnh.TabIndex = 25;
            this.btnThemAnh.Text = "Thêm ảnh";
            this.btnThemAnh.Click += new System.EventHandler(this.btnThemAnh_Click);
            // 
            // rdoLoai
            // 
            this.rdoLoai.Location = new System.Drawing.Point(111, 103);
            this.rdoLoai.Name = "rdoLoai";
            this.rdoLoai.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rdoLoai.Properties.Appearance.Options.UseBackColor = true;
            this.rdoLoai.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rdoLoai.Properties.Columns = 2;
            this.rdoLoai.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(1)), "Keg"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(2)), "Sọt")});
            this.rdoLoai.Size = new System.Drawing.Size(187, 25);
            this.rdoLoai.TabIndex = 26;
            // 
            // frmThemSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 291);
            this.Controls.Add(this.rdoLoai);
            this.Controls.Add(this.btnThemAnh);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.mmoMieuTa);
            this.Controls.Add(this.picAnh);
            this.Controls.Add(this.chkDangQuanLy);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtDungTich);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtTenSanPham);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThemSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm sản phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSanPham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDungTich.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDangQuanLy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmoMieuTa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdoLoai.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtTenSanPham;
        private DevExpress.XtraEditors.TextEdit txtDungTich;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.CheckEdit chkDangQuanLy;
        private DevExpress.XtraEditors.PictureEdit picAnh;
        private DevExpress.XtraEditors.MemoEdit mmoMieuTa;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnThemAnh;
        private DevExpress.XtraEditors.RadioGroup rdoLoai;
    }
}