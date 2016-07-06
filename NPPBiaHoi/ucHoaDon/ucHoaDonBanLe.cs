using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DataAccess;
using BussinessLogic;

namespace NPPBiaHoi.ucHoaDon
{
    public partial class ucHoaDonBanLe : DevExpress.XtraEditors.XtraUserControl
    {
        HoaDonBanLeBO aHoaDonBanLeBO;
        List<HoaDonBanLe> aListHoaDonBanLe = new List<HoaDonBanLe>();
        public ucHoaDonBanLe()
        {
            InitializeComponent();
        }

        private void grvHoaDonBanLe_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                frmThemHoaDonBanLe afrmThemHoaDonBanLe = new frmThemHoaDonBanLe(this);
                afrmThemHoaDonBanLe.ShowDialog();
            }
            catch (Exception ex)
            {
                throw new Exception("btnThem_Click: " + ex.ToString());
            }
        }

        private void btnSua_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                frmSuaHoaDonBanLe afrmSuaHoaDonBanLe = new frmSuaHoaDonBanLe(this);
                afrmSuaHoaDonBanLe.ShowDialog();
            }
            catch (Exception ex)
            {
                throw new Exception("btnSua_ButtonClick: " + ex.ToString());
            }
        }

        private void btnXoa_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa hóa đơn bán lẻ này không?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int Ma = int.Parse(grvHoaDonBanLe.GetFocusedRowCellValue("Ma").ToString());
                    aHoaDonBanLeBO = new HoaDonBanLeBO();
                     

                    if (aHoaDonBanLeBO.Delete(Ma) == true)
                    {
                        MessageBox.Show("Xóa hóa đơn bán lẻ thành công.", "Xóa hóa đơn", MessageBoxButtons.OK);
                        this.ucHoaDonBanLe_Load(null, null);
                    }
                    else {
                        MessageBox.Show("Không thành công.", "Xóa hóa đơn bán lẻ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception("btnXoa_ButtonClick: " + ex.ToString());
            }
        }

        public void ucHoaDonBanLe_Load(object sender, EventArgs e)
        {
            try
            {
                aHoaDonBanLeBO = new HoaDonBanLeBO();
                aListHoaDonBanLe = aHoaDonBanLeBO.Select_All();
                //grdKhachHang.DataSource = aListKhachHang;
            }
            catch (Exception ex)
            {
                throw new Exception("ucKhachHang_Load: " + ex.ToString());
            }
        }
    }
}
