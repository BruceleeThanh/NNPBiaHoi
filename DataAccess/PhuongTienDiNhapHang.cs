//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class PhuongTienDiNhapHang
    {
        public int MaNhapHang { get; set; }
        public int MaPhuongTien { get; set; }
        public int MaNhanVien { get; set; }
    
        public virtual NhanVien NhanVien { get; set; }
        public virtual NhapHang NhapHang { get; set; }
        public virtual PhuongTien PhuongTien { get; set; }
    }
}
