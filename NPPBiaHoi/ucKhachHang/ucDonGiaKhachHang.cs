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
        List<DonGiaKhachHangEN> aListDonGiaKhachHangEN = new List<DonGiaKhachHangEN>();
        public ucDonGiaKhachHang()
        {
            InitializeComponent();
        }

        public void ucDonGiaKhachHang_Load(object sender, EventArgs e)
        {
            try
            {
                DonGiaKhachHangBO aDonGiaKhachHangBO = new DonGiaKhachHangBO();
                List<DonGiaKhachHang> aListDonGiaKhachHang = new List<DonGiaKhachHang>();
                //this.aListDonGiaKhachHangEN = new List<DonGiaKhachHangEN>();
                aListDonGiaKhachHang = aDonGiaKhachHangBO.Select_All();
               // DonGiaKhachHangEN aDonGiaKhachHangEN;
                foreach (DonGiaKhachHang temp in aListDonGiaKhachHang)
                {
                    DonGiaKhachHangEN aDonGiaKhachHangEN = new DonGiaKhachHangEN(temp);
                    this.aListDonGiaKhachHangEN.Add(aDonGiaKhachHangEN);
                }
                grdDonGiaKhachHang.DataSource = this.aListDonGiaKhachHangEN;
            }
            catch (Exception ex)
            {
                throw new Exception("ucDonGiaKhachHang_Load: " + ex.ToString());
            }
        }

        private void grvDonGiaKhachHang_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                frmThemDonGiaKhachHang afrmThemDonGiaKhachHang = new frmThemDonGiaKhachHang(this);
                afrmThemDonGiaKhachHang.ShowDialog();
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
                int MaDonGia = int.Parse(grvDonGiaKhachHang.GetFocusedRowCellValue("Ma").ToString());
                frmSuaDonGiaKhachHang afrmSuaDonGiaKhachHang = new frmSuaDonGiaKhachHang(MaDonGia, this);
                afrmSuaDonGiaKhachHang.ShowDialog();
            }
            catch (Exception ex)
            {
                throw new Exception("btnSua_ButtonClick: " + ex.ToString());
            }

        }

        private void btnLichSuDonGia_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw new Exception("btnLichSuDonGia_ButtonClick: " + ex.ToString());
            }
        }
    }
}
