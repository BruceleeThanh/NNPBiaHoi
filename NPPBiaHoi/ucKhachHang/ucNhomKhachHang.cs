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
    public partial class ucNhomKhachHang : DevExpress.XtraEditors.XtraUserControl
    {
        List<NhomKhachHang> aListNhomKhachHang = new List<NhomKhachHang>();
        
        public ucNhomKhachHang()
        {
            InitializeComponent();
            ucNhomKhachHang_Load(null, null);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                frmThemNhomKhachHang afrmThemNhomKhachHang = new frmThemNhomKhachHang(this);
                afrmThemNhomKhachHang.ShowDialog();
            }
            catch (Exception ex)
            {
               throw new Exception("btnThem_Click: " + ex.ToString());
            }
        }

        public void ucNhomKhachHang_Load(object sender, EventArgs e)
        {
            try
            {
                NhomKhachHangBO aNhomKhachHangBO = new NhomKhachHangBO();
                aListNhomKhachHang = aNhomKhachHangBO.SelectAll();
                grdNhomKhachHang.DataSource = aListNhomKhachHang;
            }
            catch( Exception ex)
            {
                throw new Exception("ucNhomKhachHang_Load" + ex.ToString());
            }
        }

        private void btnSua_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                int Ma = int.Parse(grvNhomKhachHang.GetFocusedRowCellValue("Ma").ToString());
                frmSuaNhomKhachHang afrmSuaNhomKhachHang = new frmSuaNhomKhachHang(Ma, this);
                afrmSuaNhomKhachHang.ShowDialog();
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
                if (MessageBox.Show("Bạn chắc chắn muốn xóa nhóm khách hàng này không?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    NhomKhachHangBO aNhomKhachHangBO = new NhomKhachHangBO();
                    int Ma = int.Parse(grvNhomKhachHang.GetFocusedRowCellValue("Ma").ToString());      
                    aNhomKhachHangBO.Delete(Ma);
                    this.ucNhomKhachHang_Load(null, null);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("btnXoa_ButtonClick: " + ex.ToString());
            }
        }

        private void grvNhomKhachHang_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }
    }
}
