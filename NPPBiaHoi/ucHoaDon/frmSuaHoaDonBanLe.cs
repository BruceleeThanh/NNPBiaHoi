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

namespace NPPBiaHoi.ucHoaDon
{
    public partial class frmSuaHoaDonBanLe : DevExpress.XtraEditors.XtraForm
    {
        public ucHoaDonBanLe aucHoaDonBanLe;
        List<SanPham> aListSanPham = new List<SanPham>();
        HoaDonBanLeBO aHoaDonBanLeBO;
        HoaDonBanLe aHoaDonBanLe;

        public frmSuaHoaDonBanLe()
        {
            InitializeComponent();
        }

        public frmSuaHoaDonBanLe(int ma, ucHoaDonBanLe auc)
        {
            this.aucHoaDonBanLe = auc;
            InitializeComponent();
            frmSuaHoaDonBanLe_Load(ma);
        }

        public void LookUpEditSanPham_Load()
        {
            SanPhamBO aSanPhamBO = new SanPhamBO();
            aListSanPham = aSanPhamBO.SelectAll();
            lueTenSanPham.Properties.DataSource = aListSanPham;
            lueTenSanPham.Properties.ValueMember = "Ma";
            lueTenSanPham.Properties.DisplayMember = "Ten";
        }

        public void frmSuaHoaDonBanLe_Load(int ma)
        {
            LookUpEditSanPham_Load();
            aHoaDonBanLeBO = new HoaDonBanLeBO();
            aHoaDonBanLe = aHoaDonBanLeBO.Select_ByMa(ma);
            lueTenSanPham.EditValue = aHoaDonBanLe.MaSanPham;
            timeThoiGian.DateTime = Convert.ToDateTime(aHoaDonBanLe.ThoiGian);
            spinSoLuong.EditValue = aHoaDonBanLe.SoLuong;
            mmoGhiChu.Text = aHoaDonBanLe.GhiChu;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            aHoaDonBanLe.MaSanPham = int.Parse(lueTenSanPham.EditValue.ToString());
            aHoaDonBanLe.SoLuong = int.Parse(spinSoLuong.EditValue.ToString());
            aHoaDonBanLe.ThoiGian = timeThoiGian.DateTime;
            aHoaDonBanLe.GhiChu = mmoGhiChu.Text;
            aHoaDonBanLeBO = new HoaDonBanLeBO();
            aHoaDonBanLeBO.Update(aHoaDonBanLe);
            aucHoaDonBanLe.ucHoaDonBanLe_Load();
            this.Close();
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