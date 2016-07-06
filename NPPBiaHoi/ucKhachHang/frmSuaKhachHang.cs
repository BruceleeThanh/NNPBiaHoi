using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DataAccess;
using BussinessLogic;

namespace NPPBiaHoi.ucKhachHang
{
    public partial class frmSuaKhachHang : DevExpress.XtraEditors.XtraForm
    {

        private KhachHang aKhachHang = null;
        private KhachHangBO aKhachHangBO;
        private ucKhachHang aucKhachHang;
        private string fileName = null;

        public frmSuaKhachHang(int Ma)
        {
            InitializeComponent();
            aKhachHangBO = new KhachHangBO();
            aKhachHang = aKhachHangBO.Select_ByMa(Ma);
            frmSuaKhachHang_Load(null, null);
        }

        public frmSuaKhachHang(int Ma, ucKhachHang auc)
        {
            InitializeComponent();
            aucKhachHang = auc;
            aKhachHangBO = new KhachHangBO();
            aKhachHang = aKhachHangBO.Select_ByMa(Ma);
            frmSuaKhachHang_Load(null, null);
        }
        public void frmSuaKhachHang_Load(object sender, EventArgs e)
        {
            try
            {
                ConvertImage aConvertImage = new ConvertImage();
                txtTen.Text = aKhachHang.Ten;
                txtSoDienThoai.Text = aKhachHang.SoDienThoai;
                txtKhoangCach.Text = aKhachHang.KhoangCach.ToString();
                txtChuCuaHang.Text = aKhachHang.TenChuCuaHang;
                txtDiaChi.Text = aKhachHang.DiaChi;
                txtEmail.Text = aKhachHang.Email;
                mmoHoTroDauTu.Text = aKhachHang.GhiChuDauTu;
                mmoGhiChu.Text = aKhachHang.GhiChu;
                if (aKhachHang.HinhAnh != null)
                {
                    picAnh.Image = aConvertImage.ConvertByteToImage(aKhachHang.HinhAnh);
                }
                if (aKhachHang.KichHoat == 1)
                {
                    chkDangQuanLy.Checked = true;
                }
                else
                {
                    chkDangQuanLy.Checked = false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("frmSuaKhachHang_Load: " + ex.ToString());
            }
        }

        private void btnThemNhomKhachHang_Click(object sender, EventArgs e)
        {
            try
            {
                frmThemNhomKhachHang afrmThemKhachHang = new frmThemNhomKhachHang(this);
                afrmThemKhachHang.ShowDialog();
            }
            catch (Exception ex)
            {
                throw new Exception("btnThemNhomKhachHang_Click" + ex.ToString());
            }
        }

        private void chkDangQuanLy_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTen.Text))
                {
                    MessageBox.Show("Bắt buộc Bạn phải nhập tên khách hàng, vui lòng nhập lại.", "Thông báo..", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {
                    ConvertImage aConvertImage = new ConvertImage();
                    aKhachHang.Ten = txtTen.Text;
                    aKhachHang.TenChuCuaHang = txtChuCuaHang.Text;
                    aKhachHang.SoDienThoai = txtSoDienThoai.Text;
                    aKhachHang.DiaChi = txtDiaChi.Text;
                    aKhachHang.Email = txtEmail.Text;
                    // aKhachHang.HinhAnh = "";// picAnh.Text;   //chua biet dau ra la kieu gi
                    aKhachHang.KhoangCach = !string.IsNullOrEmpty(txtKhoangCach.Text) ? double.Parse(txtKhoangCach.Text.ToString()) : 0;
                    aKhachHang.GhiChuDauTu = mmoHoTroDauTu.Text;
                    aKhachHang.GhiChu = mmoGhiChu.Text;
                    if (fileName != null)
                    {
                        aKhachHang.HinhAnh = aConvertImage.ConvertImagePathToByte(fileName);
                    }
                    if (chkDangQuanLy.Checked == true)
                        aKhachHang.KichHoat = 1;
                    else {
                        aKhachHang.KichHoat = 0;
                    }
                    if(aKhachHangBO.Update(aKhachHang)== true)
                    {
                        MessageBox.Show("Cập nhật khách hàng thành công.", "Cập nhật khách hàng", MessageBoxButtons.OK);
                        aucKhachHang.ucKhachHang_Load(null, null);
                        this.Close();
                    }
                    else {
                        MessageBox.Show("Không thành công.", "Cập nhật khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.Close();
                    if (aucKhachHang != null)
                    {
                        aucKhachHang.ucKhachHang_Load(null, null);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("btnLuu_Click: " + ex.ToString());
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("btnHuy_Click: " + ex.ToString());
            }
        }

        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fileDiaLog = new OpenFileDialog();
                fileDiaLog.Title = "Chọn ảnh sản phẩm";
                fileDiaLog.Filter = "JPG|*.jpg|PNG|*.png|GIF|*.gif";
                fileDiaLog.Multiselect = false;
                if (fileDiaLog.ShowDialog() == DialogResult.OK)
                {
                    fileName = fileDiaLog.FileName;
                    picAnh.Image = Image.FromFile(fileDiaLog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("frmSuaSanPham.btnThemAnh_Click: " + ex.ToString());
            }
        }
    }
}