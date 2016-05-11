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
                aKhachHang.Ten = txtTen.Text;
                aKhachHang.TenChuCuaHang = txtChuCuaHang.Text;
                aKhachHang.SoDienThoai = txtSoDienThoai.Text;
                aKhachHang.DiaChi = txtDiaChi.Text;
                aKhachHang.Email = txtEmail.Text;
               // aKhachHang.HinhAnh = picAnh.Text;   //chua biet dau ra la kieu gi
                aKhachHang.KhoangCach = txtKhoangCach.Text != "" ? double.Parse(txtKhoangCach.Text.ToString()) : 0;
                aKhachHang.GhiChuDauTu = mmoHoTroDauTu.Text;
                aKhachHang.GhiChu = mmoGhiChu.Text;
                if (chkDangQuanLy.Checked == true)
                    aKhachHang.KichHoat = 1;
                else {
                    aKhachHang.KichHoat = 0;
                }
                aKhachHangBO.Insert(aKhachHang);
                if (aucKhachHang != null)
                {
                    aucKhachHang.ucKhachHang_Load(null, null);
                }
                this.Close();
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
                picAnh.Image = Image.FromFile("D:\\default-avatar.png");
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

        }

        private void picAnh_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void chkDangQuanLy_CheckedChanged(object sender, EventArgs e)
        {

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
        
