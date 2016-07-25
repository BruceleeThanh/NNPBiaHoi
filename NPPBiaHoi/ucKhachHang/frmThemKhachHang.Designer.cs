namespace NPPBiaHoi.ucKhachHang
{
    partial class frmThemKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemKhachHang));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtChuCuaHang = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoDienThoai = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtKhoangCach = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.chkDangQuanLy = new DevExpress.XtraEditors.CheckEdit();
            this.mmoHoTroDauTu = new DevExpress.XtraEditors.MemoEdit();
            this.mmoGhiChu = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.picAnh = new DevExpress.XtraEditors.PictureEdit();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.lueNhomKhachHang = new DevExpress.XtraEditors.LookUpEdit();
            this.btnThemAnh = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemNhomKhachHang = new DevExpress.XtraEditors.SimpleButton();
            this.grdThemKhachHang = new DevExpress.XtraGrid.GridControl();
            this.grvThemKhachHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChuCuaHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDienThoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoangCach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDangQuanLy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmoHoTroDauTu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmoGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueNhomKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdThemKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvThemKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(37, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(113, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nhóm khách hàng";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(157, 71);
            this.txtTen.Name = "txtTen";
            this.txtTen.Properties.Mask.BeepOnError = true;
            this.txtTen.Properties.Mask.EditMask = "([A-ZÀ-Ỹ][a-zà-ỹ]*((\\s)))+[A-ZÀ-Ỹ][a-zà-ỹ]*";
            this.txtTen.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtTen.Size = new System.Drawing.Size(244, 22);
            this.txtTen.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(37, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(23, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Tên";
            // 
            // txtChuCuaHang
            // 
            this.txtChuCuaHang.Location = new System.Drawing.Point(157, 120);
            this.txtChuCuaHang.Name = "txtChuCuaHang";
            this.txtChuCuaHang.Properties.Mask.BeepOnError = true;
            this.txtChuCuaHang.Properties.Mask.EditMask = "([A-ZÀ-Ỹ][a-zà-ỹ]*((\\s)))+[A-ZÀ-Ỹ][a-zà-ỹ]*";
            this.txtChuCuaHang.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtChuCuaHang.Size = new System.Drawing.Size(244, 22);
            this.txtChuCuaHang.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Location = new System.Drawing.Point(37, 121);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(96, 17);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Chủ cửa hàng";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(157, 169);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(244, 22);
            this.txtDiaChi.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Location = new System.Drawing.Point(37, 170);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(45, 17);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Địa chỉ";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(157, 218);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Properties.Mask.BeepOnError = true;
            this.txtSoDienThoai.Properties.Mask.EditMask = "((\\+[1-9]{1,2}|0)(12|16|18|19|8|9)[0-9][0-9]{7})|(0([2-8][0-9]{1,2})[0-9]{6})";
            this.txtSoDienThoai.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtSoDienThoai.Size = new System.Drawing.Size(244, 22);
            this.txtSoDienThoai.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Location = new System.Drawing.Point(37, 219);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(90, 17);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Số điện thoại";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(157, 267);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Mask.BeepOnError = true;
            this.txtEmail.Properties.Mask.EditMask = "[-0-9a-zA-Z.+_]+@[-0-9a-zA-Z.+_]+\\.[a-zA-Z]{2,4}";
            this.txtEmail.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtEmail.Size = new System.Drawing.Size(244, 22);
            this.txtEmail.TabIndex = 11;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Location = new System.Drawing.Point(37, 270);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(32, 16);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Email";
            // 
            // txtKhoangCach
            // 
            this.txtKhoangCach.Location = new System.Drawing.Point(505, 265);
            this.txtKhoangCach.Name = "txtKhoangCach";
            this.txtKhoangCach.Properties.Mask.EditMask = "f";
            this.txtKhoangCach.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtKhoangCach.Size = new System.Drawing.Size(48, 22);
            this.txtKhoangCach.TabIndex = 15;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl8.Location = new System.Drawing.Point(407, 269);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(89, 17);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "Khoảng cách";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl9.Location = new System.Drawing.Point(37, 323);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(95, 17);
            this.labelControl9.TabIndex = 16;
            this.labelControl9.Text = "Hỗ trợ đầu tư";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl10.Location = new System.Drawing.Point(37, 443);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(46, 16);
            this.labelControl10.TabIndex = 18;
            this.labelControl10.Text = "Ghi chú";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl11.Location = new System.Drawing.Point(636, 268);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(91, 17);
            this.labelControl11.TabIndex = 20;
            this.labelControl11.Text = "Đang quản lý";
            // 
            // chkDangQuanLy
            // 
            this.chkDangQuanLy.EditValue = true;
            this.chkDangQuanLy.Location = new System.Drawing.Point(733, 268);
            this.chkDangQuanLy.Name = "chkDangQuanLy";
            this.chkDangQuanLy.Properties.Caption = "";
            this.chkDangQuanLy.Size = new System.Drawing.Size(18, 19);
            this.chkDangQuanLy.TabIndex = 21;
            // 
            // mmoHoTroDauTu
            // 
            this.mmoHoTroDauTu.Location = new System.Drawing.Point(157, 321);
            this.mmoHoTroDauTu.Name = "mmoHoTroDauTu";
            this.mmoHoTroDauTu.Size = new System.Drawing.Size(421, 114);
            this.mmoHoTroDauTu.TabIndex = 22;
            // 
            // mmoGhiChu
            // 
            this.mmoGhiChu.Location = new System.Drawing.Point(157, 441);
            this.mmoGhiChu.Name = "mmoGhiChu";
            this.mmoGhiChu.Size = new System.Drawing.Size(421, 115);
            this.mmoGhiChu.TabIndex = 23;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Location = new System.Drawing.Point(559, 270);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(19, 16);
            this.labelControl7.TabIndex = 24;
            this.labelControl7.Text = "Km";
            // 
            // picAnh
            // 
            this.picAnh.Location = new System.Drawing.Point(584, 321);
            this.picAnh.Name = "picAnh";
            this.picAnh.Properties.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picAnh.Properties.ErrorImage")));
            this.picAnh.Properties.InitialImage = ((System.Drawing.Image)(resources.GetObject("picAnh.Properties.InitialImage")));
            this.picAnh.Properties.ReadOnly = true;
            this.picAnh.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picAnh.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.picAnh.Size = new System.Drawing.Size(192, 191);
            this.picAnh.TabIndex = 25;
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(584, 571);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(93, 38);
            this.btnLuu.TabIndex = 26;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(683, 571);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(93, 38);
            this.btnHuy.TabIndex = 27;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lueNhomKhachHang
            // 
            this.lueNhomKhachHang.Location = new System.Drawing.Point(157, 22);
            this.lueNhomKhachHang.Name = "lueNhomKhachHang";
            this.lueNhomKhachHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueNhomKhachHang.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ma", "Mã nhóm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten", "Tên nhóm")});
            this.lueNhomKhachHang.Properties.DisplayMember = "Ten";
            this.lueNhomKhachHang.Properties.ValueMember = "Ma";
            this.lueNhomKhachHang.Size = new System.Drawing.Size(206, 22);
            this.lueNhomKhachHang.TabIndex = 28;
            // 
            // btnThemAnh
            // 
            this.btnThemAnh.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnThemAnh.Appearance.Options.UseFont = true;
            this.btnThemAnh.Image = ((System.Drawing.Image)(resources.GetObject("btnThemAnh.Image")));
            this.btnThemAnh.Location = new System.Drawing.Point(584, 518);
            this.btnThemAnh.Name = "btnThemAnh";
            this.btnThemAnh.Size = new System.Drawing.Size(192, 38);
            this.btnThemAnh.TabIndex = 29;
            this.btnThemAnh.Text = "Thêm ảnh";
            this.btnThemAnh.Click += new System.EventHandler(this.btnThemAnh_Click);
            // 
            // btnThemNhomKhachHang
            // 
            this.btnThemNhomKhachHang.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnThemNhomKhachHang.Appearance.Options.UseFont = true;
            this.btnThemNhomKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNhomKhachHang.Image")));
            this.btnThemNhomKhachHang.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnThemNhomKhachHang.Location = new System.Drawing.Point(369, 20);
            this.btnThemNhomKhachHang.Name = "btnThemNhomKhachHang";
            this.btnThemNhomKhachHang.Size = new System.Drawing.Size(32, 25);
            this.btnThemNhomKhachHang.TabIndex = 30;
            this.btnThemNhomKhachHang.Click += new System.EventHandler(this.btnThemNhomKhachHang_Click);
            // 
            // grdThemKhachHang
            // 
            this.grdThemKhachHang.Location = new System.Drawing.Point(407, 20);
            this.grdThemKhachHang.MainView = this.grvThemKhachHang;
            this.grdThemKhachHang.Name = "grdThemKhachHang";
            this.grdThemKhachHang.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnXoa});
            this.grdThemKhachHang.Size = new System.Drawing.Size(369, 220);
            this.grdThemKhachHang.TabIndex = 31;
            this.grdThemKhachHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvThemKhachHang});
            // 
            // grvThemKhachHang
            // 
            this.grvThemKhachHang.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.grvThemKhachHang.Appearance.HeaderPanel.Options.UseFont = true;
            this.grvThemKhachHang.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.grvThemKhachHang.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grvThemKhachHang.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.grvThemKhachHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMa,
            this.colTen,
            this.colXoa});
            this.grvThemKhachHang.GridControl = this.grdThemKhachHang;
            this.grvThemKhachHang.Name = "grvThemKhachHang";
            this.grvThemKhachHang.OptionsView.EnableAppearanceEvenRow = true;
            this.grvThemKhachHang.OptionsView.ShowGroupPanel = false;
            this.grvThemKhachHang.OptionsView.ShowIndicator = false;
            // 
            // colMa
            // 
            this.colMa.Caption = "Mã nhóm";
            this.colMa.FieldName = "Ma";
            this.colMa.Name = "colMa";
            this.colMa.OptionsColumn.ReadOnly = true;
            this.colMa.Visible = true;
            this.colMa.VisibleIndex = 0;
            this.colMa.Width = 98;
            // 
            // colTen
            // 
            this.colTen.Caption = "Tên nhóm";
            this.colTen.FieldName = "Ten";
            this.colTen.Name = "colTen";
            this.colTen.OptionsColumn.ReadOnly = true;
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 1;
            this.colTen.Width = 201;
            // 
            // colXoa
            // 
            this.colXoa.Caption = "Xóa";
            this.colXoa.ColumnEdit = this.btnXoa;
            this.colXoa.Name = "colXoa";
            this.colXoa.Visible = true;
            this.colXoa.VisibleIndex = 2;
            this.colXoa.Width = 50;
            // 
            // btnXoa
            // 
            this.btnXoa.AutoHeight = false;
            this.btnXoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnXoa.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnXoa.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnXoa_ButtonClick);
            // 
            // frmThemKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 621);
            this.Controls.Add(this.grdThemKhachHang);
            this.Controls.Add(this.btnThemNhomKhachHang);
            this.Controls.Add(this.btnThemAnh);
            this.Controls.Add(this.lueNhomKhachHang);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.picAnh);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.mmoGhiChu);
            this.Controls.Add(this.mmoHoTroDauTu);
            this.Controls.Add(this.chkDangQuanLy);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.txtKhoangCach);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtChuCuaHang);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThemKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm mới khách hàng";
            this.Load += new System.EventHandler(this.frmThemKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChuCuaHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDienThoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoangCach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDangQuanLy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmoHoTroDauTu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmoGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueNhomKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdThemKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvThemKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtChuCuaHang;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtSoDienThoai;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtKhoangCach;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.CheckEdit chkDangQuanLy;
        private DevExpress.XtraEditors.MemoEdit mmoHoTroDauTu;
        private DevExpress.XtraEditors.MemoEdit mmoGhiChu;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.PictureEdit picAnh;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.LookUpEdit lueNhomKhachHang;
        private DevExpress.XtraEditors.SimpleButton btnThemAnh;
        private DevExpress.XtraEditors.SimpleButton btnThemNhomKhachHang;
        private DevExpress.XtraGrid.GridControl grdThemKhachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView grvThemKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn colMa;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraGrid.Columns.GridColumn colXoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnXoa;
    }
}