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
    public partial class ChiTietNhapHangBO {
        DatabaseDA aDatabaseDA = new DatabaseDA();

        public List<ChiTietNhapHang> Select_All() {
            try {
                return aDatabaseDA.ChiTietNhapHang.OrderByDescending(b => b.MaNhapHang).ToList();
            }
            catch(Exception ex) {
                throw new Exception("ChiTietNhapHangBO.Select_All" + ex.ToString());
            }
        }

        public List<ChiTietNhapHang> Select_ByMaNhapHang(int maNhapHang) {
            try {
                return aDatabaseDA.ChiTietNhapHang.Where(b => b.MaNhapHang == maNhapHang).ToList();
            }
            catch(Exception ex) {
                throw new Exception("ChiTietNhapHangBO.Select_ByMaNhapHang" + ex.ToString());
            }
        }

        public List<ChiTietNhapHang> Select_ByMaSanPham(int maSanPham) {
            try {
                return aDatabaseDA.ChiTietNhapHang.Where(b => b.MaSanPham == maSanPham).ToList();
            }
            catch(Exception ex) {
                throw new Exception("ChiTietNhapHangBO.Select_ByMaSanPham" + ex.ToString());
            }
        }

        public ChiTietNhapHang Select_ByMaNhapHang_ByMaSanPham(int maNhapHang, int maSanPham) {
            try {
                return aDatabaseDA.ChiTietNhapHang.Where(b => b.MaNhapHang == maNhapHang && b.MaSanPham == maSanPham).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("ChiTietNhapHangBO.Select_ByMaNhapHang_ByMaSanPham" + ex.ToString());
            }
        }

        public bool Insert(ChiTietNhapHang aChiTietNhapHang) {
            try {
                aDatabaseDA.ChiTietNhapHang.Add(aChiTietNhapHang);
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("ChiTietNhapHangBO.Insert: " + ex.ToString());
            }
        }

        public bool Update(ChiTietNhapHang aChiTietNhapHang) {
            try {
                aDatabaseDA.ChiTietNhapHang.AddOrUpdate(aChiTietNhapHang);
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("ChiTietNhapHangBO.Update: " + ex.ToString());
            }
        }

        public bool Delete(int maNhapHang, int maSanPham) {
            try {
                aDatabaseDA.ChiTietNhapHang.Remove(this.Select_ByMaNhapHang_ByMaSanPham(maNhapHang, maSanPham));
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("ChiTietNhapHangBO.Delete: " + ex.ToString());
            }
        }

    }
}
