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
using Entity;

namespace NPPBiaHoi.ucKhachHang
{
    public partial class ucDonGiaKhachHang : DevExpress.XtraEditors.XtraUserControl
    {
        List<DonGiaKhachHangEN> aListDonGiaKhachHangEN;
        public ucDonGiaKhachHang()
        {
            InitializeComponent();
        }

        private void ucDonGiaKhachHang_Load(object sender, EventArgs e)
        {
            DonGiaKhachHangBO aDonGiaKhachHangBO = new DonGiaKhachHangBO();
            List<DonGiaKhachHang> aListDonGiaKhachHang = new List<DonGiaKhachHang>();
           this.aListDonGiaKhachHangEN = new List<DonGiaKhachHangEN>();
            aListDonGiaKhachHang = aDonGiaKhachHangBO.Select_All();
            DonGiaKhachHangEN aDonGiaKhachHangEN;
            foreach(DonGiaKhachHang temp in aListDonGiaKhachHang)
            {
               aDonGiaKhachHangEN = new DonGiaKhachHangEN(temp);
               this.aListDonGiaKhachHangEN.Add(aDonGiaKhachHangEN);
            }
            grdDonGiaKhachHang.DataSource = this.aListDonGiaKhachHangEN;
        }

        private void grvDonGiaKhachHang_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
    }
}
