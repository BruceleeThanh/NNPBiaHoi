using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BussinessLogic;
using DataAccess;

namespace NPPBiaHoi.ucSanPham
{
    public partial class frmSuaSanPham : DevExpress.XtraEditors.XtraForm
    {

        private string fileName = null;
        private SanPham aSanPham = null;
        private ConvertImage aConvertImage;
        private ucSanPham aucSanPham = null;
        private SanPhamBO aSanPhamBO = new SanPhamBO();

        public frmSuaSanPham(int ma, ucSanPham aucSanPham)
        {
            InitializeComponent();
            this.aSanPham = aSanPhamBO.Select_ByMa(ma);
            this.aucSanPham = aucSanPham;
            this.frmSuaSanPham_Load();
        }

        public void frmSuaSanPham_Load() {
            aConvertImage = new ConvertImage();
            txtTenSanPham.Text = aSanPham.Ten;
            txtDungTich.Text = aSanPham.DungTich.ToString();
            rdoLoai.EditValue = aSanPham.Loai;
            mmoMieuTa.Text = aSanPham.MieuTa;
            if(aSanPham.KichHoat == 1) {
                chkDangQuanLy.Checked = true;
            }
            else {
                chkDangQuanLy.Checked = false;
            }
            if(aSanPham.HinhAnh != null) {
                picAnh.Image = aConvertImage.ConvertByteToImage(aSanPham.HinhAnh);
            }
        }

        private void btnThemAnh_Click(object sender, EventArgs e) {
            try {
                OpenFileDialog fileDiaLog = new OpenFileDialog();
                fileDiaLog.Title = "Chọn ảnh sản phẩm";
                fileDiaLog.Filter = "JPG|*.jpg|PNG|*.png|GIF|*.gif";
                fileDiaLog.Multiselect = false;
                if(fileDiaLog.ShowDialog() == DialogResult.OK) {
                    fileName = fileDiaLog.FileName;
                    picAnh.Image = Image.FromFile(fileDiaLog.FileName);
                }
            }
            catch(Exception ex) {
                MessageBox.Show("frmSuaSanPham.btnThemAnh_Click: " + ex.ToString());
            }
        }

        private void btnLuu_Click(object sender, EventArgs e) {
            try {
                if(string.IsNullOrEmpty(txtTenSanPham.Text)) {
                    MessageBox.Show("Tên sản phẩm không được để trống.", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                if(string.IsNullOrEmpty(txtDungTich.Text) && rdoLoai.SelectedIndex == 0) {
                    MessageBox.Show("Dung tích sản phẩm không được để trống", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                aSanPhamBO = new SanPhamBO();
                ConvertImage aConvertImage = new ConvertImage();
                aSanPham.Ten = txtTenSanPham.Text;
                aSanPham.DungTich = Double.Parse(txtDungTich.Text);
                aSanPham.Loai = (byte?)(rdoLoai.SelectedIndex + 1);
                aSanPham.MieuTa = mmoMieuTa.Text;
                if(fileName != null) {
                    aSanPham.HinhAnh = aConvertImage.ConvertImagePathToByte(fileName);
                }
                if(chkDangQuanLy.Checked == true) {
                    aSanPham.KichHoat = 1;
                }
                else {
                    aSanPham.KichHoat = 0;
                }
                if(aSanPhamBO.Update(aSanPham) == true) {
                    MessageBox.Show("Sửa sản phẩm thành công.", "Sửa sản phẩm", MessageBoxButtons.OK);
                    aucSanPham.ucSanPham_Load();
                    this.Dispose();
                }
                else {
                    MessageBox.Show("Không thành công.", "Sửa sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex) {
                MessageBox.Show("frmSuaSanPham.btnLuu_Click: " + ex.ToString());
            }
        }

        private void btnHuy_Click(object sender, EventArgs e) {
            try {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn huỷ sửa sản phẩm này?", "Sửa sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dialogResult == DialogResult.Yes) {
                    this.Dispose();
                }
            }
            catch(Exception ex) {
                MessageBox.Show("frmSuaSanPham.btnHuy_Click: " + ex.ToString());
            }
        }


    }
}