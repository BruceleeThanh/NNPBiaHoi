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

namespace NPPBiaHoi.ucPhuongTien
{
    public partial class ucChiPhiPhuongTien : DevExpress.XtraEditors.XtraUserControl
    {
        List<ChiPhiPhuongTien> alistChiPhiPhuongTien;
        public ucChiPhiPhuongTien()
        {
            InitializeComponent();
            ucChiPhiPhuongTien_Load();
        }

        public void ucChiPhiPhuongTien_Load()
        {
            try
            {
                ChiPhiPhuongTienBO aChiPhiPhuongTienBO = new ChiPhiPhuongTienBO();
                alistChiPhiPhuongTien = new List<ChiPhiPhuongTien>();
                alistChiPhiPhuongTien = aChiPhiPhuongTienBO.Select_All();
                grdChiPhiPhuongTien.DataSource = alistChiPhiPhuongTien;
            }
            catch (Exception ex)
            {
                throw new Exception("ucChiPhiPhuongTien_Load" + ex.ToString());
            }
        }

        private void grvChiPhiPhuongTien_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
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
                frmThemChiPhiPhuongTien afrmThemChiPhiPhuongTien = new frmThemChiPhiPhuongTien(this);
                afrmThemChiPhiPhuongTien.ShowDialog();
            }
            catch (Exception ex)
            {
                throw new Exception("btnThemChiPhiPhuongTien_click" + ex.ToString());
            }
        }

        private void btnSua_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                int ma = int.Parse(grvChiPhiPhuongTien.GetFocusedRowCellValue("Ma").ToString());
                frmSuaChiPhiPhuongTien afrmSuaNhanVien = new frmSuaChiPhiPhuongTien(ma, this);
                afrmSuaNhanVien.ShowDialog();
            }
            catch (Exception ex)
            {
                throw new Exception("btnSua_ButtonClick" + ex.ToString());
            }
        }

        private void btnXoa_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                int ma = int.Parse(grvChiPhiPhuongTien.GetFocusedRowCellValue("Ma").ToString());
                ChiPhiPhuongTienBO aChiPhiPhuongTienBO = new ChiPhiPhuongTienBO();
                if (MessageBox.Show("Bạn muốn xóa!", "Thông báo..", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    aChiPhiPhuongTienBO.Delete(ma);
                    ucChiPhiPhuongTien_Load();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("btnXoa_ButtonClick" + ex.ToString());
            }
        }
    }
}
