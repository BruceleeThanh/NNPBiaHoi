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

        public frmSuaKhachHang(int Ma)
        {
            InitializeComponent();
            aKhachHangBO = new KhachHangBO();
            aKhachHang = aKhachHangBO.Select_ByMa(Ma);
            frmSuaKhachHang_Load(null, null);
        }

        public frmSuaKhachHang(int Ma,ucKhachHang auc)
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
                txtTen.Text = aKhachHang.Ten;
                txtSoDienThoai.Text = aKhachHang.SoDienThoai;
                txtKhoangCach.Text = aKhachHang.KhoangCach.ToString();
                txtChuCuaHang.Text = aKhachHang.TenChuCuaHang;
                txtDiaChi.Text = aKhachHang.DiaChi;
                txtEmail.Text = aKhachHang.Email;
                mmoHoTroDauTu.Text = aKhachHang.GhiChuDauTu;
                mmoGhiChu.Text = aKhachHang.GhiChu;
                if (aKhachHang.KichHoat == 1)
                {
                    chkDangQuanLy.Checked = true;
                } else
                {
                    chkDangQuanLy.Checked = false;
                }
            }
            catch(Exception ex)
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
                aKhachHang.Ten = txtTen.Text;
                aKhachHang.TenChuCuaHang = txtChuCuaHang.Text;
                aKhachHang.SoDienThoai = txtSoDienThoai.Text;
                aKhachHang.DiaChi = txtDiaChi.Text;
                aKhachHang.Email = txtEmail.Text;
               // aKhachHang.HinhAnh = "";// picAnh.Text;   //chua biet dau ra la kieu gi
                aKhachHang.KhoangCach = txtKhoangCach.Text != "" ? double.Parse(txtKhoangCach.Text.ToString()) : 0;
                aKhachHang.GhiChuDauTu = mmoHoTroDauTu.Text;
                aKhachHang.GhiChu = mmoGhiChu.Text;
                if (chkDangQuanLy.Checked == true)
                    aKhachHang.KichHoat = 1;
                else {
                    aKhachHang.KichHoat = 0;
                }
                aKhachHangBO.Update(aKhachHang);
                this.Close();
                if (aucKhachHang != null)
                {
                    aucKhachHang.ucKhachHang_Load(null, null);
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
    }
}