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
        private string fileName = null;
        private ConvertImage aConvertImage;
        public ucPhuongTien aucPhuongTien;
        private PhuongTien aPhuongTien;
        PhuongTienBO aPhuongTienBO;
        public frmSuaPhuongTien(int ma, ucPhuongTien aucPhuongTien)
        {
            InitializeComponent();
            this.aucPhuongTien = aucPhuongTien;
            frmSuaPhuongTien_Load(ma);
        }

        public void frmSuaPhuongTien_Load(int ma)
        {
            try
            {
                aConvertImage = new ConvertImage();
                aPhuongTienBO = new PhuongTienBO();
                aPhuongTien = aPhuongTienBO.Select_ByMa(ma);
                txtTen.Text = aPhuongTien.Ten;
                txtTaiTrong.Text = aPhuongTien.TaiTrong.ToString();
                txtBienSo.Text = aPhuongTien.BienSo;
                mmoMieuTa.Text = aPhuongTien.MieuTa;
                if (aPhuongTien.HinhAnh != null)
                {
                    picAnh.Image = aConvertImage.ConvertByteToImage(aPhuongTien.HinhAnh);
                }
                rdoLoai.SelectedIndex = (int)(aPhuongTien.Loai - 1);
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
                MessageBox.Show("frmSuaPhuongTien.btnThemAnh_Click: " + ex.ToString());
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTen.Text))
                {
                    MessageBox.Show("Tên phương tiện không được để trống", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                ConvertImage aConvertImage = new ConvertImage();
                aPhuongTien.Ten = txtTen.Text;
                aPhuongTien.TaiTrong = float.Parse(txtTaiTrong.Text);
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