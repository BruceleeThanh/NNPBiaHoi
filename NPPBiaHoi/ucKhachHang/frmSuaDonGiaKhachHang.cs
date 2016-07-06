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
using Entity;

namespace NPPBiaHoi.ucKhachHang
{
    public partial class frmSuaDonGiaKhachHang : DevExpress.XtraEditors.XtraForm
    {
        ucDonGiaKhachHang aucDonGiaKhachHang;
        DonGiaKhachHangEN aDonGiaKhachHangEN;
        public frmSuaDonGiaKhachHang()
        {
            InitializeComponent();

        }

        public frmSuaDonGiaKhachHang(ucDonGiaKhachHang auc)
        {
            InitializeComponent();
            this.aucDonGiaKhachHang = auc;
        }
        public frmSuaDonGiaKhachHang(int MaDonGia, ucDonGiaKhachHang auc)
        {
            try
            {
                InitializeComponent();
                this.aDonGiaKhachHangEN = new DonGiaKhachHangEN(MaDonGia);
                txtKhachHang.Text = aDonGiaKhachHangEN.TenKhachHang;
                txtSanPham.Text = aDonGiaKhachHangEN.TenSanPham;
                txtDonGia.Text = aDonGiaKhachHangEN.DonGia.ToString();
                timeThoiGianCapNhat.DateTime = DateTime.Now;
            }
            catch (Exception ex)
            {
                throw new Exception("frmSuaDonGiaKhachHang: " + ex.ToString());
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DonGiaKhachHangBO aDonGiaKhachHangBO = new DonGiaKhachHangBO();
                DonGiaKhachHang aDonGiaKhachHang = new DonGiaKhachHang();
                aDonGiaKhachHang.MaKhachHang = aDonGiaKhachHangEN.MaKhachHang;
                aDonGiaKhachHang.MaSanPham = aDonGiaKhachHangEN.MaSanPham;
                if (double.Parse(txtDonGia.Text) != aDonGiaKhachHangEN.DonGia)
                aDonGiaKhachHang.DonGia = double.Parse(txtDonGia.Text);
                else
                {
                    if (MessageBox.Show("Đơn giá không thay đổi, bạn có muốn đổi lại không?", "Thông báo..", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        this.Close();
                        return;
                    }
                    
                }
                aDonGiaKhachHang.ThoiGianCapNhat = timeThoiGianCapNhat.DateTime;
                aDonGiaKhachHangBO.Insert(aDonGiaKhachHang);
                if (aucDonGiaKhachHang!=null)
                {
                    aucDonGiaKhachHang.ucDonGiaKhachHang_Load(null, null);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("btnLuu_Click: " + ex.ToString());
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("btnHuy_Click: " + ex.ToString());
            }
        }
    }
}