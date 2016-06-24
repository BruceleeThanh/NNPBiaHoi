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
        public ucNhanVien bucNhanVien;
        NhanVien aNhanVien;
        NhanVienBO aNhanVienBO;
        public frmSuaNhanVien(int ma, ucNhanVien aucNhanVien)
        {
            InitializeComponent();
            bucNhanVien = aucNhanVien;
            frmSuaNhanVien_Load(ma);
        }

        public void frmSuaNhanVien_Load(int ma)
        {
            try
            {
                aNhanVienBO = new NhanVienBO();
                aNhanVien = aNhanVienBO.Select_ByMa(ma);
                txtTenNhanVien.Text = aNhanVien.Ten;
                txtCMND.Text = aNhanVien.CMND;
                txtDiaChi.Text = aNhanVien.DiaChi;
                txtEmail.Text = aNhanVien.Email;
                txtSoDienThoai.Text = aNhanVien.SoDienThoai;
                if (aNhanVien.KichHoat == 1)
                    chkDangHoatDong.Checked = true;
                else
                    chkDangHoatDong.Checked = false;
            }
            catch (Exception ex)
            {
                throw new Exception("frmSuaNhanVien_Load" + ex.ToString());
            }
        }
        

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                aNhanVien = new NhanVien();
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
                aNhanVienBO = new NhanVienBO();
                if (aNhanVienBO.Update(aNhanVien) == true)
                {
                    MessageBox.Show("Sửa thông tin nhân viên thành công.", "Sửa thông tin nhân viên", MessageBoxButtons.OK);
                    bucNhanVien.ucNhanVien_Load();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Không thành công.", "Sửa thông tin nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
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