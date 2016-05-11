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

namespace NPPBiaHoi.ucKhachHang
{
    public partial class ucKhachHang : DevExpress.XtraEditors.XtraUserControl
    {
        List<KhachHang> aListKhachHang = new List<KhachHang>(); 
        public ucKhachHang()
        {

            InitializeComponent();
            ucKhachHang_Load(null, null);
        }
        

        private void grvKhachHang_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        public void ucKhachHang_Load(object sender, EventArgs e)
        {
            try
            {
                KhachHangBO aKhachHangBO = new KhachHangBO();
                aListKhachHang = aKhachHangBO.SelectAll();
                grdKhachHang.DataSource = aListKhachHang;
            }
            catch (Exception ex)
            {
                throw new Exception("ucKhachHang_Load: " + ex.ToString());
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                frmThemKhachHang afrmThemKhachHang = new frmThemKhachHang(this);
                afrmThemKhachHang.ShowDialog();
            }
            catch (Exception ex)
            {
                throw new Exception("btnThem_Click: " + ex.ToString());
            }
           
        }

        private void btnChiTiet_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                int Ma = int.Parse(grvKhachHang.GetFocusedRowCellValue("Ma").ToString());
                frmChiTietKhachHang afrmChiTietKhachHang = new frmChiTietKhachHang(Ma);
                afrmChiTietKhachHang.ShowDialog();
            }
            catch (Exception ex)
            {
                throw new Exception("btnChiTiet_ButtonClick: " + ex.ToString());
            }
        }

        private void btnSua_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                int Ma = int.Parse(grvKhachHang.GetFocusedRowCellValue("Ma").ToString());
                frmSuaKhachHang afrmSuaKhachHang = new frmSuaKhachHang(Ma,this);
                afrmSuaKhachHang.ShowDialog();
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
                if (MessageBox.Show("Bạn chắc chắn muốn xóa khách hàng này không?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int Ma = int.Parse(grvKhachHang.GetFocusedRowCellValue("Ma").ToString());
                    KhachHangBO aKhachHangBO = new KhachHangBO();
                    aKhachHangBO.Delete(Ma);
                    this.ucKhachHang_Load(null, null);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("btnXoa_ButtonClick: " + ex.ToString());
            }
           
        }
    }
}
