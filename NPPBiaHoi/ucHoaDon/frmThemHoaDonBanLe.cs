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
using Entity;

namespace NPPBiaHoi.ucHoaDon
{
    public partial class frmThemHoaDonBanLe : DevExpress.XtraEditors.XtraForm
    {
        ucHoaDonBanLe aucHoaDonBanLe = null;
        List<SanPham> aListSanPham = new List<SanPham>();
        List<ThemHoaDonBanLeEN> bListThemHoaDonBanLeEN = new List<ThemHoaDonBanLeEN>();

        public frmThemHoaDonBanLe()
        {
            InitializeComponent();
        }
        public frmThemHoaDonBanLe(ucHoaDonBanLe aucHoaDonBanLe)
        {
            try
            {
                this.aucHoaDonBanLe = aucHoaDonBanLe;
                InitializeComponent();
                this.frmThemHoaDonBanLe_Load();
            }
            catch (Exception ex)
            {
                throw new Exception("frmThemHoaDonBanLe: " + ex.ToString());
            }

        }

        public void frmThemHoaDonBanLe_Load()
        {
            SanPhamBO aSanPhamBO = new SanPhamBO();
            aListSanPham = aSanPhamBO.SelectAll();
            lueTenSanPham.Properties.DataSource = aListSanPham;
            lueTenSanPham.Properties.ValueMember = "Ma";
            lueTenSanPham.Properties.DisplayMember = "Ten";
            timeThoiGian.DateTime = DateTime.Now;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                int SoDong = grvThemHoaDonBanLe.RowCount;
                HoaDonBanLeBO aHoaDonBanLeBO = new HoaDonBanLeBO();
                for (int i = 0; i < SoDong; i++)
                {
                    HoaDonBanLe aHoaDonBanLe = new HoaDonBanLe();
                    aHoaDonBanLe.MaSanPham = int.Parse(grvThemHoaDonBanLe.GetRowCellValue(i, "MaSanPham").ToString());
                    aHoaDonBanLe.SoLuong = int.Parse(grvThemHoaDonBanLe.GetRowCellValue(i, "SoLuong").ToString());
                    aHoaDonBanLe.ThoiGian = Convert.ToDateTime(grvThemHoaDonBanLe.GetRowCellValue(i, "ThoiGian").ToString());
                    aHoaDonBanLe.GhiChu = grvThemHoaDonBanLe.GetRowCellValue(i, "GhiChu").ToString();

                    aHoaDonBanLeBO.Insert(aHoaDonBanLe);
                }
                aucHoaDonBanLe.ucHoaDonBanLe_Load();
                this.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("btnLuu_Click: " + ex.ToString());
            }
            btnLuu.Enabled = false;
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(lueTenSanPham.EditValue.ToString()))
                {
                    MessageBox.Show("Tên sản phẩm không được để trống", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                if (string.IsNullOrEmpty(spinSoLuong.Text.ToString()))
                {
                    MessageBox.Show("Số lượng không được để trống", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                HoaDonBanLe aHoaDonBanLe = new HoaDonBanLe();
                aHoaDonBanLe.MaSanPham = int.Parse(lueTenSanPham.EditValue.ToString());
                aHoaDonBanLe.SoLuong = int.Parse(spinSoLuong.Text);
                aHoaDonBanLe.ThoiGian = timeThoiGian.DateTime;
                aHoaDonBanLe.GhiChu = mmoGhiChu.Text;

                ThemHoaDonBanLeEN tThem = new ThemHoaDonBanLeEN(aHoaDonBanLe);
                bListThemHoaDonBanLeEN.Add(tThem);
                grdThemHoaDonBanLe.DataSource = bListThemHoaDonBanLeEN;
                grvThemHoaDonBanLe.RefreshData();
            }
            catch (Exception ex)
            {
                throw new Exception("btnLuu_Click: " + ex.ToString());
            }
            btnThem.Enabled = true;
        }

        private void btnXoa_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                HoaDonBanLe tam2 = new HoaDonBanLe();
                tam2.MaSanPham = int.Parse(grvThemHoaDonBanLe.GetFocusedRowCellValue("MaSanPham").ToString());
                tam2.SoLuong = int.Parse(grvThemHoaDonBanLe.GetFocusedRowCellValue("SoLuong").ToString());
                tam2.ThoiGian = Convert.ToDateTime(grvThemHoaDonBanLe.GetFocusedRowCellValue("ThoiGian").ToString());
                tam2.GhiChu = grvThemHoaDonBanLe.GetFocusedRowCellValue("GhiChu").ToString();
                
                ThemHoaDonBanLeEN tam1 = new ThemHoaDonBanLeEN(tam2);
                bListThemHoaDonBanLeEN.RemoveAt(grvThemHoaDonBanLe.GetSelectedRows()[0]);
                grdThemHoaDonBanLe.DataSource = bListThemHoaDonBanLeEN;
                grvThemHoaDonBanLe.RefreshData();
            }
            catch (Exception ex)
            {
                throw new Exception("btnXoa_ButtonClick: " + ex.ToString()); 
            }
        }
        
    }
}

