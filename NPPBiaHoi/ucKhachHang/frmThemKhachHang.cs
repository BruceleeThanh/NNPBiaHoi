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
    public partial class frmThemKhachHang : DevExpress.XtraEditors.XtraForm
    {
        private ucKhachHang aucKhachHang;
        private string fileName = null;
        public frmThemKhachHang()
        {
            InitializeComponent();

        }

        public frmThemKhachHang(ucKhachHang auc)
        {
            aucKhachHang = auc;
            InitializeComponent();

        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("btnHuy_click" + ex.ToString());
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                KhachHangBO aKhachHangBO = new KhachHangBO();
                KhachHang aKhachHang = new KhachHang();
                ConvertImage aConvertImage = new ConvertImage();
                if (string.IsNullOrEmpty(txtTen.Text))
                {
                    MessageBox.Show("Bắt buộc Bạn phải nhập tên khách hàng, vui lòng nhập lại.", "Thông báo..", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {
                    aKhachHang.Ten = txtTen.Text;
                    aKhachHang.TenChuCuaHang = txtChuCuaHang.Text;
                    aKhachHang.SoDienThoai = txtSoDienThoai.Text;
                    aKhachHang.DiaChi = txtDiaChi.Text;
                    aKhachHang.Email = txtEmail.Text;
                    if (fileName != null)
                    {
                        aKhachHang.HinhAnh = aConvertImage.ConvertImagePathToByte(fileName);
                    }
                    aKhachHang.KhoangCach = !string.IsNullOrEmpty(txtKhoangCach.Text) ? double.Parse(txtKhoangCach.Text.ToString()) : 0;
                    aKhachHang.GhiChuDauTu = mmoHoTroDauTu.Text;
                    aKhachHang.GhiChu = mmoGhiChu.Text;
                    if (chkDangQuanLy.Checked == true)
                        aKhachHang.KichHoat = 1;
                    else {
                        aKhachHang.KichHoat = 0;
                    }

                    if (aKhachHangBO.Insert(aKhachHang) == true)
                    {
                        MessageBox.Show("Thêm khách hàng thành công.", "Thêm khách hàng", MessageBoxButtons.OK);
                        aucKhachHang.ucKhachHang_Load(null, null);
                        this.Close();
                    }
                    else {
                        MessageBox.Show("Không thành công.", "Thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (aucKhachHang != null)
                    {
                        aucKhachHang.ucKhachHang_Load(null, null);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("btnLuu_Click" + ex.ToString());
            }
        }

        public void frmThemKhachHang_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw new Exception("frmThemKhachHang_Load" + ex.ToString());
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
                MessageBox.Show("frmThemSanPham.btnThemAnh_Click: " + ex.ToString());
            }
        }
    }
}
//private void frmThemKhachHang_Load()
//{
//    try
//    {
//        picAnh.Image = Image.FromFile("D:\\default-avatar.png");
//    }
//    catch (Exception ex)
//    {
//        throw new Exception("frmThemKhachHang_Load" + ex.ToString());
//    }
//}

