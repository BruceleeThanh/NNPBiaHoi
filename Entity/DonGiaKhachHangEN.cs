using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using BussinessLogic;

namespace Entity
{
     public class DonGiaKhachHangEN: DonGiaKhachHang
    {
        private KhachHangBO aKhachHangBO = new KhachHangBO();
        private SanPhamBO aSanPhamBO = new SanPhamBO();
        public string TenKhachHang { get; set; }
        public string TenSanPham { get; set; }

        public DonGiaKhachHangEN(DonGiaKhachHang aDonGiaKhachHang)
        {
            this.Ma = aDonGiaKhachHang.Ma;
            this.MaKhachHang = aDonGiaKhachHang.MaKhachHang;
            this.MaSanPham = aDonGiaKhachHang.MaSanPham;
            this.DonGia = aDonGiaKhachHang.DonGia;
            this.ThoiGianCapNhat = aDonGiaKhachHang.ThoiGianCapNhat;
            TenKhachHang = aKhachHangBO.Select_ByMa(aDonGiaKhachHang.MaKhachHang).Ten;
            TenSanPham = aSanPhamBO.Select_ByMa(aDonGiaKhachHang.MaSanPham).Ten;
        }

        public DonGiaKhachHangEN(int MaDonGia)
        {
            this.Ma = MaDonGia;
            DonGiaKhachHang aDonGiaKhachHang = new DonGiaKhachHang();
            DonGiaKhachHangBO aDonGiaKhachHangBO = new DonGiaKhachHangBO();
            aDonGiaKhachHang = aDonGiaKhachHangBO.Select_ByMa(MaDonGia);
            this.MaKhachHang = aDonGiaKhachHang.MaKhachHang;
            this.MaSanPham = aDonGiaKhachHang.MaSanPham;
            this.DonGia = aDonGiaKhachHang.DonGia;
            this.ThoiGianCapNhat = aDonGiaKhachHang.ThoiGianCapNhat;
            TenKhachHang = aKhachHangBO.Select_ByMa(aDonGiaKhachHang.MaKhachHang).Ten;
            TenSanPham = aSanPhamBO.Select_ByMa(aDonGiaKhachHang.MaSanPham).Ten;
        }
    }
}
