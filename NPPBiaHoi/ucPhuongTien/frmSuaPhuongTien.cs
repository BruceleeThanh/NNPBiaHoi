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

namespace NPPBiaHoi.ucPhuongTien
{
    public partial class frmSuaPhuongTien : DevExpress.XtraEditors.XtraForm
    {
        public ucPhuongTien aucPhuongTien;
        PhuongTien aPhuongTien;
        PhuongTienBO aPhuongTienBO;
        public frmSuaPhuongTien(int ma, ucPhuongTien aucPhuongTien)
        {
            InitializeComponent();
            frmSuaPhuongTien_Load(ma);
        }

        public void frmSuaPhuongTien_Load(int ma)
        {
            try
            {
                aPhuongTienBO = new PhuongTienBO();
                aPhuongTien = aPhuongTienBO.Select_ByMa(ma);
                txtTen.Text = aPhuongTien.Ten;
                txtTaiTrong.Text = aPhuongTien.TaiTrong.ToString();
                txtBienSo.Text = aPhuongTien.BienSo;
                mmoMieuTa.Text = aPhuongTien.MieuTa;
                if (aPhuongTien.Loai == 1)
                {
                    rdoLoai.EditValue = 1;
                }
                else
                {
                    rdoLoai.EditValue = 0;
                }
                if (aPhuongTien.KichHoat == 1)
                    chkDangHoatDong.Checked = true;
                else
                    chkDangHoatDong.Checked = false;
            }
            catch (Exception ex)
            {
                throw new Exception("frmSuaPhuongTien_Load" + ex.ToString());
            }
        }

        private void btnThemAnh_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                aPhuongTien = new PhuongTien();
                aPhuongTien.Ten = txtTen.Text;
                aPhuongTien.TaiTrong = int.Parse(txtTaiTrong.Text);
                aPhuongTien.BienSo = txtBienSo.Text;
                aPhuongTien.MieuTa = mmoMieuTa.Text;
                if (rdoLoai.EditValue.ToString() == "1")
                {
                    aPhuongTien.Loai = 1;
                }
                else
                {
                    aPhuongTien.Loai = 0;
                }
                if (chkDangHoatDong.Checked == true)
                {
                    aPhuongTien.KichHoat = 1;
                }
                else
                {
                    aPhuongTien.KichHoat = 0;
                }
                if (string.IsNullOrEmpty(txtTen.Text))
                    return;
                aPhuongTienBO = new PhuongTienBO();
                aPhuongTienBO.Update(aPhuongTien);
                aucPhuongTien.ucPhuongTien_Load();
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