using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using DataAccess;

namespace BussinessLogic {
    public partial class NhomKhachHang_KhachHangBO {

        private DatabaseDA aDatabaseDA = new DatabaseDA();

        // Quan hệ nhiều nhiều. Truy vấn dữ liệu: danh sách Khách Hàng theo Mã Nhóm khách hàng.
        public List<KhachHang> SelectKhachHang_ByMaNhomKhachHang(int maNhomKhachHang) {
            try {
                return aDatabaseDA.KhachHang.Where(a => a.NhomKhachHang.Any(b => b.Ma == maNhomKhachHang)).ToList();
            }
            catch(Exception ex) {
                throw new Exception("NhomKhachHang_KhachHangBO.SelectKhachHang_ByMaNhomKhachHang:" + ex.ToString());
            }
        }

        // Quan hệ nhiều nhiều. Truy vấn dữ liệu: danh sách Nhóm Khách Hàng theo Mã Khách Hàng.
        public List<NhomKhachHang> SelectNhomKhachHang_ByMaKhachHang(int maKhachHang) {
            try {
                return aDatabaseDA.NhomKhachHang.Where(a => a.KhachHang.Any(b => b.Ma == maKhachHang)).ToList();
            }
            catch(Exception ex) {
                throw new Exception("NhomKhachHang_KhachHangBO.SelectNhomKhachHang_ByMaKhachHang:" + ex.ToString());
            }
        }

        //public bool Insert(int maNhomKhachHang, int maKhachHang) {
        //    try {
        //        aDatabaseDA.NhomKhachHang.Add(aNhomKhachHang);
        //        aDatabaseDA.SaveChanges();
        //        return true;
        //    }
        //    catch(Exception ex) {
        //        return false;
        //        throw new Exception("NhomKhachHangBO.Insert: " + ex.ToString());
        //    }
        //}
    }
}
