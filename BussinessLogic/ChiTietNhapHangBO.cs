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
                return aDatabaseDA.ChiTietNhapHang.Where(c => c.ThungRac == 1).OrderByDescending(b => b.MaNhapHang).ToList();
            }
            catch(Exception ex) {
                throw new Exception("ChiTietNhapHangBO.Select_All" + ex.ToString());
            }
        }

        public List<ChiTietNhapHang> Select_ByMaNhapHang(int maNhapHang) {
            try {
                return aDatabaseDA.ChiTietNhapHang.Where(b => b.MaNhapHang == maNhapHang && b.ThungRac == 1).ToList();
            }
            catch(Exception ex) {
                throw new Exception("ChiTietNhapHangBO.Select_ByMaNhapHang" + ex.ToString());
            }
        }

        public List<ChiTietNhapHang> Select_ByMaSanPham(int maSanPham) {
            try {
                return aDatabaseDA.ChiTietNhapHang.Where(b => b.MaSanPham == maSanPham && b.ThungRac == 1).ToList();
            }
            catch(Exception ex) {
                throw new Exception("ChiTietNhapHangBO.Select_ByMaSanPham" + ex.ToString());
            }
        }

        public ChiTietNhapHang Select_ByMaNhapHang_ByMaSanPham(int maNhapHang, int maSanPham) {
            try {
                return aDatabaseDA.ChiTietNhapHang.Where(b => b.MaNhapHang == maNhapHang && b.MaSanPham == maSanPham && b.ThungRac == 1).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("ChiTietNhapHangBO.Select_ByMaNhapHang_ByMaSanPham" + ex.ToString());
            }
        }

        public List<ChiTietNhapHang> Select_All_Hidden() {
            try {
                return aDatabaseDA.ChiTietNhapHang.Where(c => c.ThungRac == 2).OrderByDescending(b => b.MaNhapHang).ToList();
            }
            catch(Exception ex) {
                throw new Exception("ChiTietNhapHangBO.Select_All_Hidden" + ex.ToString());
            }
        }

        public List<ChiTietNhapHang> Select_ByMaNhapHang_Hidden(int maNhapHang) {
            try {
                return aDatabaseDA.ChiTietNhapHang.Where(b => b.MaNhapHang == maNhapHang && b.ThungRac == 2).ToList();
            }
            catch(Exception ex) {
                throw new Exception("ChiTietNhapHangBO.Select_ByMaNhapHang_Hidden" + ex.ToString());
            }
        }

        public List<ChiTietNhapHang> Select_ByMaSanPham_Hidden(int maSanPham) {
            try {
                return aDatabaseDA.ChiTietNhapHang.Where(b => b.MaSanPham == maSanPham && b.ThungRac == 2).ToList();
            }
            catch(Exception ex) {
                throw new Exception("ChiTietNhapHangBO.Select_ByMaSanPham_Hidden" + ex.ToString());
            }
        }

        public ChiTietNhapHang Select_ByMaNhapHang_ByMaSanPham_Hidden(int maNhapHang, int maSanPham) {
            try {
                return aDatabaseDA.ChiTietNhapHang.Where(b => b.MaNhapHang == maNhapHang && b.MaSanPham == maSanPham && b.ThungRac == 2).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("ChiTietNhapHangBO.Select_ByMaNhapHang_ByMaSanPham_Hidden" + ex.ToString());
            }
        }

        public bool Insert(ChiTietNhapHang aChiTietNhapHang) {
            try {
                aChiTietNhapHang.ThungRac = 1;
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
                ChiTietNhapHang aChiTietNhapHang = this.Select_ByMaNhapHang_ByMaSanPham(maNhapHang, maSanPham);
                aChiTietNhapHang.ThungRac = 2;
                return this.Update(aChiTietNhapHang);
            }
            catch(Exception ex) {
                return false;
                throw new Exception("ChiTietNhapHangBO.Delete: " + ex.ToString());
            }
        }

    }
}
