using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using BussinessLogic;

namespace Entity
{
    public partial class PhuongTienEN: PhuongTien
    {
        public string sLoai { set; get; }
        public PhuongTienEN(PhuongTien aPhuongTien)
        {
            this.Ma = aPhuongTien.Ma;
            this.Ten = aPhuongTien.Ten;
            this.BienSo = aPhuongTien.BienSo;
            this.TaiTrong = aPhuongTien.TaiTrong;
            this.MieuTa = aPhuongTien.MieuTa;
            this.HinhAnh = aPhuongTien.HinhAnh;
            this.KichHoat = aPhuongTien.KichHoat;
            if(aPhuongTien.Loai == 1)
            {
                this.sLoai = "Xe máy";
            }
            else
            {
                this.sLoai = "Ô tô";
            }
        }
    }
}
