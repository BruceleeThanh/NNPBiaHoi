using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BussinessLogic;
using DataAccess;

namespace NPPBiaHoi.ucSanPham
{
    public partial class ucSanPham : DevExpress.XtraEditors.XtraUserControl
    {
        private SanPhamBO aSanPhamBO;
        private List<SanPham> aListSanPham;

        public ucSanPham()
        {
            InitializeComponent();
            this.ucSanPham_Load();
        }

        public void ucSanPham_Load() {
            aListSanPham = new List<SanPham>();
            aSanPhamBO = new SanPhamBO();
            aListSanPham = aSanPhamBO.SelectAll();
            grdSanPham.DataSource = aListSanPham;
        }

        private void grvSanPham_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void btnThemSanPham_Click(object sender, EventArgs e) {
            frmThemSanPham afrmThemSanPham = new frmThemSanPham(this);
            afrmThemSanPham.ShowDialog();
        }

        private void btnChiTiet_Click(object sender, EventArgs e) {
            frmChiTietSanPham afrmChiTietSanPham = new frmChiTietSanPham(int.Parse(grvSanPham.GetFocusedRowCellValue("Ma").ToString()));
            afrmChiTietSanPham.ShowDialog();
        }

        
    }
}
