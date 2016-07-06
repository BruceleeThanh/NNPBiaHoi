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
    public partial class frmThemDonGiaKhachHang : DevExpress.XtraEditors.XtraForm
    {
        private ucDonGiaKhachHang aucDonGiaKhachHang;
        public frmThemDonGiaKhachHang()
        {
            InitializeComponent();
        }

        public frmThemDonGiaKhachHang(ucDonGiaKhachHang auc)
        {
            InitializeComponent();
            this.aucDonGiaKhachHang = auc;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (lueKhachHang.EditValue == null || lueSanPham.EditValue == null || txtDonGia.Text == "")
                    MessageBox.Show("Bạn chưa nhập đủ thông tin, vui lòng nhập lại.", "Thông báo..", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    DonGiaKhachHangBO aDonGiaKhachHangBO = new DonGiaKhachHangBO();
                    DonGiaKhachHang aDonGiaKhachHang = new DonGiaKhachHang();
                    aDonGiaKhachHang.MaKhachHang = int.Parse(lueKhachHang.GetColumnValue("Ma").ToString());
                    aDonGiaKhachHang.MaSanPham = int.Parse(lueSanPham.GetColumnValue("Ma").ToString());
                    aDonGiaKhachHang.DonGia = double.Parse(txtDonGia.Text);
                    aDonGiaKhachHang.ThoiGianCapNhat = timeThoiGianCapNhat.DateTime;
                    aDonGiaKhachHangBO.Insert(aDonGiaKhachHang);
                    if (aucDonGiaKhachHang != null)
                    {
                        aucDonGiaKhachHang.ucDonGiaKhachHang_Load(null, null);
                    }

                    this.Close();
                }
            }
            catch(Exception ex)
            {
                throw new Exception("btnLuu_Click: " + ex.ToString());
            }
        }

        private void frmThemDonGiaKhachHang_Load(object sender, EventArgs e)
        {
            try
            {
                SanPhamBO aSanPhamBO = new SanPhamBO();
                List<SanPham> aListSanPham = new List<SanPham>();
                aListSanPham = aSanPhamBO.SelectAll();
                lueSanPham.Properties.DataSource = aListSanPham;
                KhachHangBO aKhachHangBO = new KhachHangBO();
                List<KhachHang> aListKhachHang = new List<KhachHang>();
                aListKhachHang = aKhachHangBO.SelectAll();
                lueKhachHang.Properties.DataSource = aListKhachHang;
                timeThoiGianCapNhat.DateTime = DateTime.Now;
            }
            catch (Exception ex)
            {
                throw new Exception("frmThemDonGiaKhachHang_Load: " + ex.ToString());
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

                throw new Exception ("btnHuy_Click" + ex.ToString());
            }
        }
    }
}