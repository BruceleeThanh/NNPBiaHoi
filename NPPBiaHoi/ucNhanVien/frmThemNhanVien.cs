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
    public partial class frmThemNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public ucNhanVien aucNhanVien;
        public frmThemNhanVien(ucNhanVien aucNhanVien)
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
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

                if (string.IsNullOrEmpty(txtTenNhanVien.Text))
                    return;
                NhanVienBO aNhanVienBO = new NhanVienBO();
                aNhanVienBO.Insert(aNhanVien);
                aucNhanVien.ucNhanVien_Load();
                this.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("btnLuu_Click" + ex.ToString());
            }
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn muốn hủy!", "Thông báo..", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("btnHuy_Click" + ex.ToString());
            }
        }
    }
}