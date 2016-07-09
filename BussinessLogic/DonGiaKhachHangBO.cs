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
    public partial class DonGiaKhachHangBO {
        DatabaseDA aDatabaseDA = new DatabaseDA();

        public List<DonGiaKhachHang> Select_All() {
            try {
                return aDatabaseDA.DonGiaKhachHang.Where(c => c.ThungRac == 1).OrderByDescending(b => b.Ma).ToList();
            }
            catch(Exception ex) {
                throw new Exception("DonGiaKhachHangBO.Select_All: " + ex.ToString());
            }
        }

        public DonGiaKhachHang Select_ByMa(int ma) {
            try {
                return aDatabaseDA.DonGiaKhachHang.Where(b => b.Ma == ma && b.ThungRac == 1).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("DonGiaKhachHangBO.Select_ByMa: " + ex.ToString());
            }
        }

        public List<DonGiaKhachHang> Select_ByMaKhachHang(int maKhachHang) {
            try {
                return aDatabaseDA.DonGiaKhachHang.Where(b => b.MaKhachHang == maKhachHang && b.ThungRac == 1).ToList();
            }
            catch(Exception ex) {
                throw new Exception("DonGiaKhachHangBO.Select_ByMaKhachHang: " + ex.ToString());
            }
        }

        public List<DonGiaKhachHang> Select_ByMaSanPham(int maSanPham) {
            try {
                return aDatabaseDA.DonGiaKhachHang.Where(b => b.MaSanPham == maSanPham && b.ThungRac == 1).ToList();
            }
            catch(Exception ex) {
                throw new Exception("DonGiaKhachHangBO.Select_ByMaSanPham: " + ex.ToString());
            }
        }

        public List<DonGiaKhachHang> Select_ByMaKhachHang_ByMaSanPham(int maKhachHang, int maSanPham)
        {
            try
            {
                return aDatabaseDA.DonGiaKhachHang.Where(b => b.MaKhachHang == maKhachHang && b.MaSanPham == maSanPham && b.ThungRac == 1).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("DonGiaKhachHangBO.Select_ByMaKhachHang_ByMaSanPham: " + ex.ToString());
            }
        }

        public List<DonGiaKhachHang> Select_All_Hidden() {
            try {
                return aDatabaseDA.DonGiaKhachHang.Where(c => c.ThungRac == 2).OrderByDescending(b => b.Ma).ToList();
            }
            catch(Exception ex) {
                throw new Exception("DonGiaKhachHangBO.Select_All_Hidden: " + ex.ToString());
            }
        }

        public DonGiaKhachHang Select_ByMa_Hiddden(int ma) {
            try {
                return aDatabaseDA.DonGiaKhachHang.Where(b => b.Ma == ma && b.ThungRac == 2).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("DonGiaKhachHangBO.Select_ByMa_Hiddden: " + ex.ToString());
            }
        }

        public List<DonGiaKhachHang> Select_ByMaKhachHang_Hidden(int maKhachHang) {
            try {
                return aDatabaseDA.DonGiaKhachHang.Where(b => b.MaKhachHang == maKhachHang && b.ThungRac == 2).ToList();
            }
            catch(Exception ex) {
                throw new Exception("DonGiaKhachHangBO.Select_ByMaKhachHang_Hidden: " + ex.ToString());
            }
        }

        public List<DonGiaKhachHang> Select_ByMaSanPham_Hidden(int maSanPham) {
            try {
                return aDatabaseDA.DonGiaKhachHang.Where(b => b.MaSanPham == maSanPham && b.ThungRac == 2).ToList();
            }
            catch(Exception ex) {
                throw new Exception("DonGiaKhachHangBO.Select_ByMaSanPham_Hidden: " + ex.ToString());
            }
        }

        public List<DonGiaKhachHang> Select_ByMaKhachHang_ByMaSanPham_Hidden(int maKhachHang, int maSanPham) {
            try {
                return aDatabaseDA.DonGiaKhachHang.Where(b => b.MaKhachHang == maKhachHang && b.MaSanPham == maSanPham && b.ThungRac == 2).ToList();
            }
            catch(Exception ex) {
                throw new Exception("DonGiaKhachHangBO.Select_ByMaKhachHang_ByMaSanPham_Hidden: " + ex.ToString());
            }
        }

        public bool Insert(DonGiaKhachHang aDonGiaKhachHang) {
            try {
                aDonGiaKhachHang.ThungRac = 1;
                aDatabaseDA.DonGiaKhachHang.Add(aDonGiaKhachHang);
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("DonGiaKhachHangBO.Insert: " + ex.ToString());
            }
        }

        public bool Update(DonGiaKhachHang aDonGiaKhachHang) {
            try {
                aDatabaseDA.DonGiaKhachHang.AddOrUpdate(aDonGiaKhachHang);
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("DonGiaKhachHangBO.Update: " + ex.ToString());
            }
        }

        public bool Delete(int ma) {
            try {
                DonGiaKhachHang aDonGiaKhachHang = this.Select_ByMa(ma);
                aDonGiaKhachHang.ThungRac = 2;
                return this.Update(aDonGiaKhachHang);
            }
            catch(Exception ex) {
                return false;
                throw new Exception("DonGiaKhachHangBO.Delete: " + ex.ToString());
            }
        }

    }
}
