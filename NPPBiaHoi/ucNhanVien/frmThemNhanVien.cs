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
        public ucNhanVien bucNhanVien;
        public frmThemNhanVien(ucNhanVien aucNhanVien)
        {
            InitializeComponent();
            bucNhanVien = aucNhanVien;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTenNhanVien.Text))
                {
                    MessageBox.Show("Tên nhân viên không được để trống", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                if (string.IsNullOrEmpty(txtSoDienThoai.Text))
                {
                    MessageBox.Show("Số điện thoại không được để trống", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
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
                if (aNhanVienBO.Insert(aNhanVien) == true)
                {
                    MessageBox.Show("Thêm nhân viên thành công.", "Thêm nhân viên", MessageBoxButtons.OK);
                    bucNhanVien.ucNhanVien_Load();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Không thành công.", "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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