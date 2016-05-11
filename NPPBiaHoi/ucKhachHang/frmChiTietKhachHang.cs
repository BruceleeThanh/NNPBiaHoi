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
    public partial class frmChiTietKhachHang : DevExpress.XtraEditors.XtraForm
    {
        KhachHang aKhachHang = new KhachHang();
        public frmChiTietKhachHang(int Ma)
        {
            InitializeComponent();
            KhachHangBO aKhachHangBO = new KhachHangBO();
            aKhachHang = aKhachHangBO.Select_ByMa(Ma);
            txtTen.Text = aKhachHang.Ten;
            txtChuCuaHang.Text = aKhachHang.TenChuCuaHang;
            txtDiaChi.Text = aKhachHang.DiaChi;
            txtSoDienThoai.Text = aKhachHang.SoDienThoai.ToString();
            txtEmail.Text = aKhachHang.Email;
            //picAnh.Image = Image.FromFile(aKhachHang.HinhAnh.ToString());
            txtKhoangCach.Text = aKhachHang.KhoangCach.ToString();
            mmoHoTroDauTu.Text = aKhachHang.GhiChuDauTu.ToString();
            mmoGhiChu.Text = aKhachHang.GhiChu.ToString();
            if (aKhachHang.KichHoat == 1)
            {
                chkDangQuanLy.Checked = true;
            }
            else if(aKhachHang.KichHoat == 0)
            {
                chkDangQuanLy.Checked = false;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}