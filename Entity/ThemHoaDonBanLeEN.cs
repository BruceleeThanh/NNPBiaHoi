using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using BussinessLogic;

namespace Entity
{
    public partial class ThemHoaDonBanLeEN : HoaDonBanLe
    {
        public string TenSP { set; get; }
        
        public ThemHoaDonBanLeEN(HoaDonBanLe aHoaDonBanLe)
        {
            this.Ma = aHoaDonBanLe.Ma;
            this.MaSanPham = aHoaDonBanLe.MaSanPham;
            this.SoLuong = aHoaDonBanLe.SoLuong;
            this.ThoiGian = aHoaDonBanLe.ThoiGian;
            this.GhiChu = aHoaDonBanLe.GhiChu;
            this.ThungRac = aHoaDonBanLe.ThungRac;

            SanPhamBO aSanPhamBO = new SanPhamBO();
            SanPham aSanPham = aSanPhamBO.Select_ByMa(aHoaDonBanLe.MaSanPham);
            this.TenSP = aSanPham.Ten;
        }
    }
}
