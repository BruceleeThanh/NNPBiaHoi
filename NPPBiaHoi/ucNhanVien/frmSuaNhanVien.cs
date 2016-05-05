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

namespace NPPBiaHoi.ucNhanVien
{
    public partial class frmSuaNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmSuaNhanVien()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            NhanVien aNhanVien = new NhanVien();
            aNhanVien.Ten = txtTenNhanVien.Text;
            aNhanVien.CMND = txtCMND.Text;
            aNhanVien.DiaChi = txtDiaChi.Text;
            aNhanVien.SoDienThoai = txtSoDienThoai.Text;
            aNhanVien.Email = txtEmail.Text;
            if (chkDangHoatDong.Checked == true)
            {
                aNhanVien.KichHoat = 1;
            }
            else
            {
                aNhanVien.KichHoat = 0;
            }

            NhanVienBO aNhanVienBO = new NhanVienBO();
            aNhanVienBO.Update(aNhanVien);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn hủy!", "Thông báo..", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}