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
    public partial class PhuongTienDiGiaoHangBO {

        private DatabaseDA aDatabaseDA = new DatabaseDA();

        public List<PhuongTienDiGiaoHang> SelectAll() {
            try {
                return aDatabaseDA.PhuongTienDiGiaoHang.Where(c => c.ThungRac == 1).OrderByDescending(b => b.MaHoaDon).ToList();
            }
            catch(Exception ex) {
                throw new Exception("PhuongTienDiGiaoHangBO.Select_All:" + ex.ToString());
            }
        }

        public List<PhuongTienDiGiaoHang> Select_ByMaHoaDon(int maHoaDon) {
            try {
                return aDatabaseDA.PhuongTienDiGiaoHang.Where(b => b.MaHoaDon == maHoaDon && b.ThungRac == 1).ToList();
            }
            catch(Exception ex) {
                throw new Exception("PhuongTienDiGiaoHangBO.Select_ByMaHoaDon:" + ex.ToString());
            }
        }

        public List<PhuongTienDiGiaoHang> Select_ByMaPhuongTien(int maPhuongTien) {
            try {
                return aDatabaseDA.PhuongTienDiGiaoHang.Where(b => b.MaPhuongTien == maPhuongTien && b.ThungRac == 1).ToList();
            }
            catch(Exception ex) {
                throw new Exception("PhuongTienDiGiaoHangBO.Select_ByMaPhuongTien:" + ex.ToString());
            }
        }

        public List<PhuongTienDiGiaoHang> Select_ByMaNhanVien(int maNhanVien) {
            try {
                return aDatabaseDA.PhuongTienDiGiaoHang.Where(b => b.MaNhanVien == maNhanVien && b.ThungRac == 1).ToList();
            }
            catch(Exception ex) {
                throw new Exception("PhuongTienDiGiaoHangBO.Select_ByMaNhanVien:" + ex.ToString());
            }
        }

        public PhuongTienDiGiaoHang Select_ByMaHoaDon_ByMaPhuongTien_ByMaNhanVien(int maHoaDon, int maPhuongTien, int maNhanVien) {
            try {
                return aDatabaseDA.PhuongTienDiGiaoHang.Where(b => b.MaHoaDon == maHoaDon && b.MaPhuongTien == maPhuongTien && b.MaNhanVien == maNhanVien && b.ThungRac == 1).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("PhuongTienDiGiaoHangBO.Select_ByMaHoaDon_ByMaPhuongTien_ByMaNhanVien:" + ex.ToString());
            }
        }

        public List<PhuongTienDiGiaoHang> SelectAll_Hidden() {
            try {
                return aDatabaseDA.PhuongTienDiGiaoHang.Where(c => c.ThungRac == 2).OrderByDescending(b => b.MaHoaDon).ToList();
            }
            catch(Exception ex) {
                throw new Exception("PhuongTienDiGiaoHangBO.SelectAll_Hidden:" + ex.ToString());
            }
        }

        public List<PhuongTienDiGiaoHang> Select_ByMaHoaDon_Hidden(int maHoaDon) {
            try {
                return aDatabaseDA.PhuongTienDiGiaoHang.Where(b => b.MaHoaDon == maHoaDon && b.ThungRac == 2).ToList();
            }
            catch(Exception ex) {
                throw new Exception("PhuongTienDiGiaoHangBO.Select_ByMaHoaDon_Hidden:" + ex.ToString());
            }
        }

        public List<PhuongTienDiGiaoHang> Select_ByMaPhuongTien_Hidden(int maPhuongTien) {
            try {
                return aDatabaseDA.PhuongTienDiGiaoHang.Where(b => b.MaPhuongTien == maPhuongTien && b.ThungRac == 2).ToList();
            }
            catch(Exception ex) {
                throw new Exception("PhuongTienDiGiaoHangBO.Select_ByMaPhuongTien_Hidden:" + ex.ToString());
            }
        }

        public List<PhuongTienDiGiaoHang> Select_ByMaNhanVien_Hidden(int maNhanVien) {
            try {
                return aDatabaseDA.PhuongTienDiGiaoHang.Where(b => b.MaNhanVien == maNhanVien && b.ThungRac == 2).ToList();
            }
            catch(Exception ex) {
                throw new Exception("PhuongTienDiGiaoHangBO.Select_ByMaNhanVien_Hidden:" + ex.ToString());
            }
        }

        public PhuongTienDiGiaoHang Select_ByMaHoaDon_ByMaPhuongTien_ByMaNhanVien_Hidden(int maHoaDon, int maPhuongTien, int maNhanVien) {
            try {
                return aDatabaseDA.PhuongTienDiGiaoHang.Where(b => b.MaHoaDon == maHoaDon && b.MaPhuongTien == maPhuongTien && b.MaNhanVien == maNhanVien && b.ThungRac == 2).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("PhuongTienDiGiaoHangBO.Select_ByMaHoaDon_ByMaPhuongTien_ByMaNhanVien_Hidden:" + ex.ToString());
            }
        }

        public bool Insert(PhuongTienDiGiaoHang aPhuongTienDiGiaoHang) {
            try {
                aPhuongTienDiGiaoHang.ThungRac = 1;
                aDatabaseDA.PhuongTienDiGiaoHang.Add(aPhuongTienDiGiaoHang);
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("PhuongTienDiGiaoHangBO.Insert: " + ex.ToString());
            }
        }

        public bool Update(PhuongTienDiGiaoHang aPhuongTienDiGiaoHang) {
            try {
                aDatabaseDA.PhuongTienDiGiaoHang.AddOrUpdate(aPhuongTienDiGiaoHang);
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("PhuongTienDiGiaoHangBO.Update: " + ex.ToString());
            }
        }

        public bool Delete(int maHoaDon, int maPhuongTien, int maNhanVien) {
            try {
                PhuongTienDiGiaoHang aPhuongTienDiGiaoHang = this.Select_ByMaHoaDon_ByMaPhuongTien_ByMaNhanVien(maHoaDon, maPhuongTien, maNhanVien);
                aPhuongTienDiGiaoHang.ThungRac = 2;
                return this.Update(aPhuongTienDiGiaoHang);
            }
            catch(Exception ex) {
                return false;
                throw new Exception("PhuongTienDiGiaoHangBO.Delete: " + ex.ToString());
            }
        }
    }
}
