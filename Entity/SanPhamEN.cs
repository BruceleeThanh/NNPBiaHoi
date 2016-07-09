using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity {
    public partial class SanPhamEN : SanPham{
        public string sLoai { get; set; }

        public SanPhamEN(SanPham aSanPham) {
            this.Ma = aSanPham.Ma;
            this.Ten = aSanPham.Ten;
            this.SoLuongSanPham = aSanPham.SoLuongSanPham;
            this.SoLuongVo = aSanPham.SoLuongVo;
            this.DungTich = aSanPham.DungTich;
            this.MieuTa = aSanPham.MieuTa;
            this.HinhAnh = aSanPham.HinhAnh;
            this.Loai = aSanPham.Loai;
            this.KichHoat = aSanPham.KichHoat;
            if(Loai == 1) {
                sLoai = "Keg";
            }
            else {
                if(Loai == 2) {
                    sLoai = "Sọt";
                }
            }
        }
    }
}
