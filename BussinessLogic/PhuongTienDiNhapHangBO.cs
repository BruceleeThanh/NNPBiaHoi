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
    public partial class PhuongTienDiNhapHangBO {
        private DatabaseDA aDatabaseDA = new DatabaseDA();

        public List<PhuongTienDiNhapHang> SelectAll() {
            try {
                return aDatabaseDA.PhuongTienDiNhapHang.OrderByDescending(b => b.MaNhapHang).ToList();
            }
            catch(Exception ex) {
                throw new Exception("PhuongTienDiNhapHangBO.Select_All:" + ex.ToString());
            }
        }

        public List<PhuongTienDiNhapHang> Select_ByMaNhapHang(int maNhapHang) {
            try {
                return aDatabaseDA.PhuongTienDiNhapHang.Where(b => b.MaNhapHang == maNhapHang).ToList();
            }
            catch(Exception ex) {
                throw new Exception("PhuongTienDiNhapHangBO.Select_ByMaNhapHang:" + ex.ToString());
            }
        }

        public List<PhuongTienDiNhapHang> Select_ByMaPhuongTien(int maPhuongTien) {
            try {
                return aDatabaseDA.PhuongTienDiNhapHang.Where(b => b.MaPhuongTien == maPhuongTien).ToList();
            }
            catch(Exception ex) {
                throw new Exception("PhuongTienDiNhapHangBO.Select_ByMaPhuongTien:" + ex.ToString());
            }
        }

        public List<PhuongTienDiNhapHang> Select_ByMaNhanVien(int maNhanVien) {
            try {
                return aDatabaseDA.PhuongTienDiNhapHang.Where(b => b.MaNhanVien == maNhanVien).ToList();
            }
            catch(Exception ex) {
                throw new Exception("PhuongTienDiNhapHangBO.Select_ByMaNhanVien:" + ex.ToString());
            }
        }

        public PhuongTienDiNhapHang Select_ByMaNhapHang_ByMaPhuongTien_ByMaNhanVien(int maNhapHang, int maPhuongTien, int maNhanVien) {
            try {
                return aDatabaseDA.PhuongTienDiNhapHang.Where(b => b.MaNhapHang == maNhapHang && b.MaPhuongTien == maPhuongTien && b.MaNhanVien == maNhanVien).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("PhuongTienDiNhapHangBO.Select_ByMaNhapHang_ByMaPhuongTien_ByMaNhanVien:" + ex.ToString());
            }
        }

        public bool Insert(PhuongTienDiNhapHang aPhuongTienDiNhapHang) {
            try {
                aDatabaseDA.PhuongTienDiNhapHang.Add(aPhuongTienDiNhapHang);
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("PhuongTienDiNhapHangBO.Insert: " + ex.ToString());
            }
        }

        public bool Update(PhuongTienDiNhapHang aPhuongTienDiNhapHang) {
            try {
                aDatabaseDA.PhuongTienDiNhapHang.AddOrUpdate(aPhuongTienDiNhapHang);
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("PhuongTienDiNhapHangBO.Update: " + ex.ToString());
            }
        }

        public bool Delete(int maHoaDon, int maPhuongTien, int maNhanVien) {
            try {
                aDatabaseDA.PhuongTienDiNhapHang.Remove(this.Select_ByMaNhapHang_ByMaPhuongTien_ByMaNhanVien(maHoaDon, maPhuongTien, maNhanVien));
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("PhuongTienDiNhapHangBO.Delete: " + ex.ToString());
            }
        }
    }
}
