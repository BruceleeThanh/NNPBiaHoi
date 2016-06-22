namespace NPPBiaHoi.ucSanPham
{
    partial class frmChiTietSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTietSanPham));
            this.rdoLoai = new DevExpress.XtraEditors.RadioGroup();
            this.mmoMieuTa = new DevExpress.XtraEditors.MemoEdit();
            this.picAnh = new DevExpress.XtraEditors.PictureEdit();
            this.chkDangQuanLy = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtDungTich = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenSanPham = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoLuongSanPham = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoLuongVo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.rdoLoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmoMieuTa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDangQuanLy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDungTich.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSanPham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongSanPham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongVo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // rdoLoai
            // 
            this.rdoLoai.Location = new System.Drawing.Point(398, 15);
            this.rdoLoai.Name = "rdoLoai";
            this.rdoLoai.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rdoLoai.Properties.Appearance.Options.UseBackColor = true;
            this.rdoLoai.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rdoLoai.Properties.Columns = 2;
            this.rdoLoai.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(1)), "Keg"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(2)), "Sọt")});
            this.rdoLoai.Size = new System.Drawing.Size(127, 25);
            this.rdoLoai.TabIndex = 38;
            // 
            // mmoMieuTa
            // 
            this.mmoMieuTa.Location = new System.Drawing.Point(137, 163);
            this.mmoMieuTa.Name = "mmoMieuTa";
            this.mmoMieuTa.Size = new System.Drawing.Size(187, 86);
            this.mmoMieuTa.TabIndex = 36;
            // 
            // picAnh
            // 
            this.picAnh.Location = new System.Drawing.Point(355, 95);
            this.picAnh.Name = "picAnh";
            this.picAnh.Properties.InitialImage = ((System.Drawing.Image)(resources.GetObject("picAnh.Properties.InitialImage")));
            this.picAnh.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picAnh.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picAnh.Size = new System.Drawing.Size(150, 150);
            this.picAnh.TabIndex = 35;
            // 
            // chkDangQuanLy
            // 
            this.chkDangQuanLy.EditValue = true;
            this.chkDangQuanLy.Location = new System.Drawing.Point(447, 54);
            this.chkDangQuanLy.Name = "chkDangQuanLy";
            this.chkDangQuanLy.Properties.Caption = "";
            this.chkDangQuanLy.Size = new System.Drawing.Size(19, 19);
            this.chkDangQuanLy.TabIndex = 34;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl8.Location = new System.Drawing.Point(355, 57);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(74, 13);
            this.labelControl8.TabIndex = 33;
            this.labelControl8.Text = "Đang quản lý";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Location = new System.Drawing.Point(355, 21);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(23, 13);
            this.labelControl7.TabIndex = 32;
            this.labelControl7.Text = "Loại";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Location = new System.Drawing.Point(22, 175);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(42, 13);
            this.labelControl5.TabIndex = 31;
            this.labelControl5.Text = "Miêu tả";
            // 
            // txtDungTich
            // 
            this.txtDungTich.Location = new System.Drawing.Point(137, 54);
            this.txtDungTich.Name = "txtDungTich";
            this.txtDungTich.Size = new System.Drawing.Size(187, 20);
            this.txtDungTich.TabIndex = 30;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Location = new System.Drawing.Point(22, 57);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(77, 13);
            this.labelControl4.TabIndex = 29;
            this.labelControl4.Text = "Dung tích (lít)";
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Location = new System.Drawing.Point(137, 18);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(187, 20);
            this.txtTenSanPham.TabIndex = 28;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(22, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(79, 13);
            this.labelControl1.TabIndex = 27;
            this.labelControl1.Text = "Tên sản phẩm";
            // 
            // txtSoLuongSanPham
            // 
            this.txtSoLuongSanPham.Location = new System.Drawing.Point(137, 92);
            this.txtSoLuongSanPham.Name = "txtSoLuongSanPham";
            this.txtSoLuongSanPham.Size = new System.Drawing.Size(187, 20);
            this.txtSoLuongSanPham.TabIndex = 40;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(22, 95);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(107, 13);
            this.labelControl2.TabIndex = 39;
            this.labelControl2.Text = "Số lượng sản phẩm";
            // 
            // txtSoLuongVo
            // 
            this.txtSoLuongVo.Location = new System.Drawing.Point(137, 129);
            this.txtSoLuongVo.Name = "txtSoLuongVo";
            this.txtSoLuongVo.Size = new System.Drawing.Size(187, 20);
            this.txtSoLuongVo.TabIndex = 42;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Location = new System.Drawing.Point(22, 132);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 13);
            this.labelControl3.TabIndex = 41;
            this.labelControl3.Text = "Số lượng vỏ";
            // 
            // frmChiTietSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 271);
            this.Controls.Add(this.txtSoLuongVo);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtSoLuongSanPham);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.rdoLoai);
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
            this.Name = "frmChiTietSanPham";
            this.Text = "frmChiTietSanPham";
            ((System.ComponentModel.ISupportInitialize)(this.rdoLoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmoMieuTa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDangQuanLy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDungTich.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSanPham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongSanPham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongVo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.RadioGroup rdoLoai;
        private DevExpress.XtraEditors.MemoEdit mmoMieuTa;
        private DevExpress.XtraEditors.PictureEdit picAnh;
        private DevExpress.XtraEditors.CheckEdit chkDangQuanLy;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtDungTich;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtTenSanPham;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtSoLuongSanPham;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtSoLuongVo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}