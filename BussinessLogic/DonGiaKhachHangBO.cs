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
                return aDatabaseDA.DonGiaKhachHang.OrderByDescending(b => b.Ma).ToList();
            }
            catch(Exception ex) {
                throw new Exception("DonGiaKhachHangBO.Select_All: " + ex.ToString());
            }
        }

        public DonGiaKhachHang Select_ByMa(int ma) {
            try {
                return aDatabaseDA.DonGiaKhachHang.Where(b => b.Ma == ma).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("DonGiaKhachHangBO.Select_ByMa: " + ex.ToString());
            }
        }

        public List<DonGiaKhachHang> Select_ByMaKhachHang(int maKhachHang) {
            try {
                return aDatabaseDA.DonGiaKhachHang.Where(b => b.MaKhachHang == maKhachHang).ToList();
            }
            catch(Exception ex) {
                throw new Exception("DonGiaKhachHangBO.Select_ByMaKhachHang: " + ex.ToString());
            }
        }

        public List<DonGiaKhachHang> Select_ByMaSanPham(int maSanPham) {
            try {
                return aDatabaseDA.DonGiaKhachHang.Where(b => b.MaSanPham == maSanPham).ToList();
            }
            catch(Exception ex) {
                throw new Exception("DonGiaKhachHangBO.Select_ByMaSanPham: " + ex.ToString());
            }
        }

        public bool Insert(DonGiaKhachHang aDonGiaKhachHang) {
            try {
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
                aDatabaseDA.DonGiaKhachHang.Remove(this.Select_ByMa(ma));
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("DonGiaKhachHangBO.Delete: " + ex.ToString());
            }
        }

    }
}
