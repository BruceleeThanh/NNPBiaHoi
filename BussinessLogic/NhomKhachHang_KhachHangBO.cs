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

        public NhomKhachHang_KhachHang Select_ByMaKhachHang_ByMaNhomKhachHang(int maKhachHang, int maNhomKhachHang) {
            try {
                return aDatabaseDA.NhomKhachHang_KhachHang.Where(b => b.MaKhachHang == maKhachHang && b.MaNhomKhachHang == maNhomKhachHang && b.ThungRac == 1).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("NhomKhachHang_KhachHangBO.Select_ByMaKhachHang_ByMaNhomKhachHang:" + ex.ToString());
            }
        }

        // Quan hệ nhiều nhiều. Truy vấn dữ liệu: danh sách Khách Hàng theo Mã Nhóm khách hàng.
        public List<KhachHang> SelectKhachHang_ByMaNhomKhachHang(int maNhomKhachHang) {
            try {
                //aDatabaseDA.NhomKhachHang_KhachHang.Where(b => b.MaNhomKhachHang == maNhomKhachHang).Select(c => c.MaKhachHang);
                return aDatabaseDA.KhachHang.Where(a => a.NhomKhachHang_KhachHang.Any(b => b.MaNhomKhachHang == maNhomKhachHang)).ToList();
            }
            catch(Exception ex) {
                throw new Exception("NhomKhachHang_KhachHangBO.SelectKhachHang_ByMaNhomKhachHang:" + ex.ToString());
            }
        }

        // Quan hệ nhiều nhiều. Truy vấn dữ liệu: danh sách Nhóm Khách Hàng theo Mã Khách Hàng.
        public List<NhomKhachHang> SelectNhomKhachHang_ByMaKhachHang(int maKhachHang) {
            try {
                return aDatabaseDA.NhomKhachHang.Where(a => a.NhomKhachHang_KhachHang.Any(b => b.MaKhachHang == maKhachHang)).ToList();
            }
            catch(Exception ex) {
                throw new Exception("NhomKhachHang_KhachHangBO.SelectNhomKhachHang_ByMaKhachHang:" + ex.ToString());
            }
        }

        public NhomKhachHang_KhachHang Select_ByMaKhachHang_ByMaNhomKhachHang_Hidden(int maKhachHang, int maNhomKhachHang) {
            try {
                return aDatabaseDA.NhomKhachHang_KhachHang.Where(b => b.MaKhachHang == maKhachHang && b.MaNhomKhachHang == maNhomKhachHang && b.ThungRac == 2).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("NhomKhachHang_KhachHangBO.Select_ByMaKhachHang_ByMaNhomKhachHang_Hidden:" + ex.ToString());
            }
        }

        public bool Insert(NhomKhachHang_KhachHang aNhomKhachHang_KhachHang) {
            try {
                aNhomKhachHang_KhachHang.ThungRac = 1;
                aDatabaseDA.NhomKhachHang_KhachHang.Add(aNhomKhachHang_KhachHang);
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("NhomKhachHang_KhachHangBO.Insert: " + ex.ToString());
            }
        }

        public bool Update(NhomKhachHang_KhachHang aNhomKhachHang_KhachHang) {
            try {
                aDatabaseDA.NhomKhachHang_KhachHang.AddOrUpdate(aNhomKhachHang_KhachHang);
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("NhomKhachHang_KhachHangBO.Update: " + ex.ToString());
            }
        }

        public bool Delete(int maKhachHang, int maNhomKhachHang) {
            try {
                NhomKhachHang_KhachHang aNhomKhachHang_KhachHang = this.Select_ByMaKhachHang_ByMaNhomKhachHang(maKhachHang, maNhomKhachHang);
                aNhomKhachHang_KhachHang.ThungRac = 2;
                return this.Update(aNhomKhachHang_KhachHang);
            }
            catch(Exception ex) {
                return false;
                throw new Exception("NhomKhachHang_KhachHangBO.Delete: " + ex.ToString());
            }
        }
    }
}
