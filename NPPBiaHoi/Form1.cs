using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BussinessLogic;
using DataAccess;

using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using DevExpress.XtraEditors;

using NPPBiaHoi.ucNhanVien;
using NPPBiaHoi.ucSanPham;
using NPPBiaHoi.ucKhachHang;
using NPPBiaHoi.ucPhuongTien;
using Entity;

namespace NPPBiaHoi {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

        private void tabMain_CloseButtonClick(object sender, EventArgs e) {
            int selectedIndex = tabMain.SelectedTabPageIndex;
            tabMain.TabPages.RemoveAt(selectedIndex);
            tabMain.SelectedTabPageIndex = selectedIndex - 1;
        }

        private void tabMain_ControlAdded(object sender, ControlEventArgs e) {
            tabMain.SelectedTabPageIndex = tabMain.TabPages.Count() - 1;
        }

        private void btnQuanLyThongTinKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            ucKhachHang.ucKhachHang aucKhachHang = new ucKhachHang.ucKhachHang();
            XuLyTabPageEN aXuLyTabPageEN = new XuLyTabPageEN();
            aXuLyTabPageEN.ThemTabPage(tabMain, aucKhachHang, "Quản lý thông tin khách hàng");
        }

        private void btnQuanLyTuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            ucNhomKhachHang aucNhomKhachHang = new ucNhomKhachHang();
            XuLyTabPageEN aXuLyTabPageEN = new XuLyTabPageEN();
            aXuLyTabPageEN.ThemTabPage(tabMain, aucNhomKhachHang, "Quản lý tuyến");
        }

        private void btnQuanLyDonGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            ucDonGiaKhachHang aucDonGiaKhachHang = new ucDonGiaKhachHang();
            XuLyTabPageEN aXuLyTabPageEN = new XuLyTabPageEN();
            aXuLyTabPageEN.ThemTabPage(tabMain, aucDonGiaKhachHang, "Quản lý đơn giá");
        }

        private void btnQuanLyThongTinSanPham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            ucSanPham.ucSanPham aucSanPham = new ucSanPham.ucSanPham();
            XuLyTabPageEN aXuLyTabPageEN = new XuLyTabPageEN();
            aXuLyTabPageEN.ThemTabPage(tabMain, aucSanPham, "Quản lý thông tin sản phẩm");
        }

        private void btnQuanLyThongTinNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            ucNhanVien.ucNhanVien aucNhanVien = new ucNhanVien.ucNhanVien();
            XuLyTabPageEN aXuLyTabPageEN = new XuLyTabPageEN();
            aXuLyTabPageEN.ThemTabPage(tabMain, aucNhanVien, "Quản lý thông tin nhân viên");
        }

        private void btnQuanLyThongTinPhuongTien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            ucPhuongTien.ucPhuongTien aucPhuongTien = new ucPhuongTien.ucPhuongTien();
            XuLyTabPageEN aXuLyTabPageEN = new XuLyTabPageEN();
            aXuLyTabPageEN.ThemTabPage(tabMain, aucPhuongTien, "Quản lý thông tin phương tiện");
        }

        private void btnChiPhiPhatSinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            ucChiPhiPhuongTien aucChiPhiPhuongTien = new ucChiPhiPhuongTien();
            XuLyTabPageEN aXuLyTabPageEN = new XuLyTabPageEN();
            aXuLyTabPageEN.ThemTabPage(tabMain, aucChiPhiPhuongTien, "Chi phí phương tiên");
        }
    }
}
