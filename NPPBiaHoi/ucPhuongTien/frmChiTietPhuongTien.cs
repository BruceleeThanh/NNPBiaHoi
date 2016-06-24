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
    public partial class frmChiTietPhuongTien : DevExpress.XtraEditors.XtraForm
    {
        PhuongTien aPhuongTien;
        PhuongTienBO aPhuongTienBO;
        //private string fileName = null;
        private ConvertImage aConvertImage;
        public frmChiTietPhuongTien(int ma)
        {
            InitializeComponent();
            frmChiTietPhuongTien_Load(ma);
        }
        public void frmChiTietPhuongTien_Load(int ma)
        {
            try
            {
                aPhuongTienBO = new PhuongTienBO();
                aConvertImage = new ConvertImage();
                aPhuongTien = aPhuongTienBO.Select_ByMa(ma);
                txtTen.Text = aPhuongTien.Ten;
                txtTaiTrong.Text = aPhuongTien.TaiTrong.ToString();
                txtBienSo.Text = aPhuongTien.BienSo;
                mmoMieuTa.Text = aPhuongTien.MieuTa;
                if (aPhuongTien.HinhAnh != null)
                {
                    picAnh.Image = aConvertImage.ConvertByteToImage(aPhuongTien.HinhAnh);
                }
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
    }
}