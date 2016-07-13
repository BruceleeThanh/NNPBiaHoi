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
using Entity;

namespace NPPBiaHoi.ucSanPham
{
    public partial class ucSanPham : DevExpress.XtraEditors.XtraUserControl
    {
        private SanPhamBO aSanPhamBO;
        private List<SanPhamEN> aListSanPhamEN;

        public ucSanPham()
        {
            InitializeComponent();
            this.ucSanPham_Load();
        }

        public void ucSanPham_Load() {
            aListSanPhamEN = new List<SanPhamEN>();
            aSanPhamBO = new SanPhamBO();
            List<SanPham> aListSanPham = new List<SanPham>();
            aListSanPham = aSanPhamBO.SelectAll();
            foreach(SanPham temp in aListSanPham) {
                aListSanPhamEN.Add(new SanPhamEN(temp));
            }
            grdSanPham.DataSource = aListSanPhamEN;
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

        private void btnSua_Click(object sender, EventArgs e) {
            frmSuaSanPham afrmSuaSanPham = new frmSuaSanPham(int.Parse(grvSanPham.GetFocusedRowCellValue("Ma").ToString()), this);
            afrmSuaSanPham.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá sản phẩm này.", "Xoá sản phẩm", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes) {

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            frmThemSanPhamDoiDoiTra temp = new frmThemSanPhamDoiDoiTra();
            temp.ShowDialog();
        }

        
    }
}
