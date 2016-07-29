using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using BussinessLogic;

namespace Entity
{
    public partial class ChiPhiPhuongTienEN : ChiPhiPhuongTien
    {
        public string sTen { set; get; }
        public ChiPhiPhuongTienEN(ChiPhiPhuongTien aChiPhiPhuongTien)
        {
            this.Ma = aChiPhiPhuongTien.Ma;
            this.Ten = aChiPhiPhuongTien.Ten;
            this.ThoiGian = aChiPhiPhuongTien.ThoiGian;
            this.TienPhi = aChiPhiPhuongTien.TienPhi;
            this.MieuTa = aChiPhiPhuongTien.MieuTa;
            this.MaPhuongTien = aChiPhiPhuongTien.MaPhuongTien;
            this.ThungRac = aChiPhiPhuongTien.ThungRac;

            PhuongTienBO aPhuongTienBO = new PhuongTienBO();
            PhuongTien aPhuongTien = aPhuongTienBO.Select_ByMa(aChiPhiPhuongTien.MaPhuongTien);
            this.sTen = aPhuongTien.Ten;
            
        }
    }
}
