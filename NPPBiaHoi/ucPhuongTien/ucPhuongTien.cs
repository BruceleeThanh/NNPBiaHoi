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
    public partial class ucPhuongTien : DevExpress.XtraEditors.XtraUserControl
    {
        public ucPhuongTien()
        {
            InitializeComponent();
            ucPhuongTien_Load();
        }

        private void grvPhuongTien_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        public void ucPhuongTien_Load()
        {
            try
            {
                PhuongTienBO aPhuongTienBO = new PhuongTienBO();
                List<PhuongTien> alistPhuongTien;
                alistPhuongTien = new List<PhuongTien>();
                alistPhuongTien = aPhuongTienBO.SelectAll();
                grdPhuongTien.DataSource = alistPhuongTien;
            }
            catch (Exception ex)
            {
                throw new Exception("ucPhuongTien_Load" + ex.ToString());
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                frmThemPhuongTien afrmThemPhuongTien = new frmThemPhuongTien(this);
                afrmThemPhuongTien.ShowDialog();
            }
            catch (Exception ex)
            {
                throw new Exception("btnThemPhuongTien_click" + ex.ToString());
            }
        }

        private void btnSua_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                int ma = int.Parse(grvPhuongTien.GetFocusedRowCellValue("Ma").ToString());
                frmSuaPhuongTien afrmSuaNhanVien = new frmSuaPhuongTien(ma, this);
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
                int ma = int.Parse(grvPhuongTien.GetFocusedRowCellValue("Ma").ToString());
                PhuongTienBO aPhuongTienBO = new PhuongTienBO();
                if (MessageBox.Show("Bạn muốn xóa!", "Thông báo..", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    aPhuongTienBO.Delete(ma);
                    ucPhuongTien_Load();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("btnXoa_ButtonClick" + ex.ToString());
            }
        }

        private void btnChiTiet_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                int ma = int.Parse(grvPhuongTien.GetFocusedRowCellValue("Ma").ToString());
                frmChiTietPhuongTien afrmSuaNhanVien = new frmChiTietPhuongTien(ma);
                afrmSuaNhanVien.ShowDialog();
            }
            catch (Exception ex)
            {
                throw new Exception("btnSua_ButtonClick" + ex.ToString());
            }
        }
    }
}
