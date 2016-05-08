namespace NPPBiaHoi.ucPhuongTien
{
    partial class frmSuaChiPhiPhuongTien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuaChiPhiPhuongTien));
            this.luePhuongTien = new DevExpress.XtraEditors.LookUpEdit();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.mmoMieuTa = new DevExpress.XtraEditors.MemoEdit();
            this.txtSoTien = new DevExpress.XtraEditors.TextEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.timeThoiGian = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.luePhuongTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmoMieuTa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeThoiGian.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeThoiGian.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // luePhuongTien
            // 
            this.luePhuongTien.Location = new System.Drawing.Point(100, 13);
            this.luePhuongTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.luePhuongTien.Name = "luePhuongTien";
            this.luePhuongTien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luePhuongTien.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten", "Tên phương tiện")});
            this.luePhuongTien.Size = new System.Drawing.Size(182, 20);
            this.luePhuongTien.TabIndex = 24;
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(452, 292);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(64, 23);
            this.btnHuy.TabIndex = 23;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(375, 292);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(64, 23);
            this.btnLuu.TabIndex = 22;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // mmoMieuTa
            // 
            this.mmoMieuTa.Location = new System.Drawing.Point(100, 132);
            this.mmoMieuTa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mmoMieuTa.Name = "mmoMieuTa";
            this.mmoMieuTa.Size = new System.Drawing.Size(416, 143);
            this.mmoMieuTa.TabIndex = 21;
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(100, 93);
            this.txtSoTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(416, 20);
            this.txtSoTien.TabIndex = 19;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(100, 53);
            this.txtTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(416, 20);
            this.txtTen.TabIndex = 18;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Location = new System.Drawing.Point(21, 56);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(55, 12);
            this.labelControl5.TabIndex = 17;
            this.labelControl5.Text = "Tên chi phí";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Location = new System.Drawing.Point(21, 135);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(42, 13);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "Miêu tả";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Location = new System.Drawing.Point(21, 95);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(39, 13);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "Số tiền";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(315, 15);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 13);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Thời gian";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(21, 16);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 13);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Phương tiện";
            // 
            // timeThoiGian
            // 
            this.timeThoiGian.EditValue = new System.DateTime(2016, 4, 26, 0, 0, 0, 0);
            this.timeThoiGian.Location = new System.Drawing.Point(375, 13);
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
            this.timeThoiGian.Size = new System.Drawing.Size(141, 20);
            this.timeThoiGian.TabIndex = 20;
            // 
            // frmSuaChiPhiPhuongTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 327);
            this.Controls.Add(this.luePhuongTien);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.mmoMieuTa);
            this.Controls.Add(this.txtSoTien);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.timeThoiGian);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSuaChiPhiPhuongTien";
            this.Text = "Sửa chi phí phương tiện";
            ((System.ComponentModel.ISupportInitialize)(this.luePhuongTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmoMieuTa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeThoiGian.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeThoiGian.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit luePhuongTien;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.MemoEdit mmoMieuTa;
        private DevExpress.XtraEditors.TextEdit txtSoTien;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit timeThoiGian;
    }
}