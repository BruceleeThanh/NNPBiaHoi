﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BussinessLogic;
using DataAccess;

namespace NPPBiaHoi.ucSanPham
{
    public partial class frmThemSanPham : DevExpress.XtraEditors.XtraForm
    {
        private ucSanPham aucSanPham = null;
        private string fileName = null;

        public frmThemSanPham(ucSanPham aucSanPham)
        {
            InitializeComponent();
            this.frmThemSanPham_Load(aucSanPham);
        }

        public void frmThemSanPham_Load(ucSanPham aucSanPham) {
            this.aucSanPham = aucSanPham;
            rdoLoai.SelectedIndex = 0;
        }

        private void btnThemAnh_Click(object sender, EventArgs e) {
            try {
                OpenFileDialog fileDiaLog = new OpenFileDialog();
                fileDiaLog.Title = "Chọn ảnh sản phẩm";
                fileDiaLog.Filter = "JPG|*.jpg|PNG|*.png|GIF|*.gif";
                fileDiaLog.Multiselect = false;
                if(fileDiaLog.ShowDialog() == DialogResult.OK) {
                    fileName = fileDiaLog.FileName;
                    picAnh.Image = Image.FromFile(fileDiaLog.FileName);
                }
            }
            catch(Exception ex) {
                MessageBox.Show("frmThemSanPham.btnThemAnh_Click: " + ex.ToString());
            }
        }

        private void btnLuu_Click(object sender, EventArgs e) {
            try {
                if(string.IsNullOrEmpty(txtTenSanPham.Text)) {
                    MessageBox.Show("Tên sản phẩm không được để trống.", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                if(string.IsNullOrEmpty(txtDungTich.Text) && rdoLoai.SelectedIndex == 0) {
                    MessageBox.Show("Dung tích sản phẩm không được để trống", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                SanPham aSanPham = new SanPham();
                SanPhamBO aSanPhamBO = new SanPhamBO();
                ConvertImage aConvertImage = new ConvertImage();
                aSanPham.Ten = txtTenSanPham.Text;
                if(rdoLoai.SelectedIndex == 1) {
                    aSanPham.DungTich = 0;
                }
                else {
                    aSanPham.DungTich = Double.Parse(txtDungTich.Text);
                }
                aSanPham.Loai = (byte?)(rdoLoai.SelectedIndex + 1);
                aSanPham.MieuTa = mmoMieuTa.Text;
                if(fileName != null) {
                    aSanPham.HinhAnh = aConvertImage.ConvertImagePathToByte(fileName);
                }
                if(chkDangQuanLy.Checked == true) {
                    aSanPham.KichHoat = 1;
                }
                else {
                    aSanPham.KichHoat = 0;
                }
                if(aSanPhamBO.Insert(aSanPham) == true) {
                    MessageBox.Show("Thêm sản phẩm thành công.", "Thêm sản phẩm", MessageBoxButtons.OK);
                    aucSanPham.ucSanPham_Load();
                    this.Dispose();
                }
                else {
                    MessageBox.Show("Không thành công.", "Thêm sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex) {
                MessageBox.Show("frmThemSanPham.btnLuu_Click: " + ex.ToString());
            }
        }

        private void btnHuy_Click(object sender, EventArgs e) {
            try {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn huỷ thêm sản phẩm này?", "Thêm sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dialogResult == DialogResult.Yes) {
                    this.Dispose();
                }
            }
            catch(Exception ex) {
                MessageBox.Show("frmThemSanPham.btnHuy_Click: " + ex.ToString());
            }
        }

        


    }
}