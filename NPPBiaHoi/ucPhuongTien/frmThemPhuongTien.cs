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
	public partial class frmThemPhuongTien: DevExpress.XtraEditors.XtraForm
	{
        ucPhuongTien aucPhuongTien;
        private string fileName = null;
        public frmThemPhuongTien(ucPhuongTien aucPhuongTien)
		{
            InitializeComponent();
            this.aucPhuongTien = aucPhuongTien;
		}

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                ConvertImage aConvertImage = new ConvertImage();
                PhuongTien aPhuongTien = new PhuongTien();
                aPhuongTien.Ten = txtTen.Text;
                aPhuongTien.TaiTrong = int.Parse(txtTaiTrong.Text);
                aPhuongTien.BienSo = txtBienSo.Text;
                aPhuongTien.MieuTa = mmoMieuTa.Text;
                if (fileName != null)
                {
                    aPhuongTien.HinhAnh = aConvertImage.ConvertImagePathToByte(fileName);
                }
                aPhuongTien.Loai = (Byte?)((rdoLoai.SelectedIndex) + 1);
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
                PhuongTienBO aPhuongTienBO = new PhuongTienBO();
                aPhuongTienBO.Insert(aPhuongTien);
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