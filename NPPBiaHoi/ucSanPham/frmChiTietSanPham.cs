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
    public partial class frmChiTietSanPham : DevExpress.XtraEditors.XtraForm
    {
        private SanPham aSanPham = null;
        private SanPhamBO aSanPhamBO;

        public frmChiTietSanPham(int ma)
        {
            InitializeComponent();
            aSanPhamBO = new SanPhamBO();
            aSanPham = aSanPhamBO.Select_ByMa(ma);
            this.frmChiTietSanPham_Load();
        }

        public void frmChiTietSanPham_Load() {
            ConvertImage aConvertImage = new ConvertImage();
            txtTenSanPham.Text = aSanPham.Ten;
            txtDungTich.Text = aSanPham.DungTich.ToString();
            txtSoLuongSanPham.Text = aSanPham.SoLuongSanPham.ToString();
            txtSoLuongVo.Text = aSanPham.SoLuongVo.ToString();
            mmoMieuTa.Text = aSanPham.MieuTa;
            rdoLoai.EditValue = aSanPham.Loai;
            if(aSanPham.KichHoat == 1) {
                chkDangQuanLy.Checked = true;
            }
            else {
                chkDangQuanLy.Checked = false;
            }
            picAnh.Image = aConvertImage.ConvertByteToImage(aSanPham.HinhAnh);
        }
    }
}