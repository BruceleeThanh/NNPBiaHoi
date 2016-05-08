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

namespace NPPBiaHoi.ucNhanVien
{
    public partial class ucNhanVien : DevExpress.XtraEditors.XtraUserControl
    {
        List<NhanVien> aListNhanVien = new List<NhanVien>();
        public ucNhanVien()
        {
            InitializeComponent();
            ucNhanVien_Load();
        }

        public void ucNhanVien_Load()
        {
            try
            {
                NhanVienBO aNhanVienBO = new NhanVienBO();
                aListNhanVien = aNhanVienBO.SelectAll();
                grdNhanVien.DataSource = aListNhanVien;
            }
            catch (Exception ex)
            {
                throw new Exception("ucNhanVien_Load" + ex.ToString());
            }
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                frmThemNhanVien afrmThemNhanVien = new frmThemNhanVien(this);
                afrmThemNhanVien.ShowDialog();
            }
            catch (Exception ex)
            {
                throw new Exception("btnThemNhanVien_click" + ex.ToString());
            }
        }

        private void btnSua_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                int ma = int.Parse(grvNhanVien.GetFocusedRowCellValue("Ma").ToString());
                frmSuaNhanVien afrmSuaNhanVien = new frmSuaNhanVien(ma , this);
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
                int ma = int.Parse(grvNhanVien.GetFocusedRowCellValue("Ma").ToString());
                NhanVienBO aNhanVienBO = new NhanVienBO();
                if (MessageBox.Show("Bạn muốn xóa!", "Thông báo..", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    aNhanVienBO.Delete(ma);
                    ucNhanVien_Load();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("btnXoa_ButtonClick" + ex.ToString());
            }
        }

    }
}
