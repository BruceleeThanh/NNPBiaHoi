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
    public partial class SanPhamBO {

        private DatabaseDA aDatabaseDA = new DatabaseDA();

        public List<SanPham> SelectAll() {
            try {
                return aDatabaseDA.SanPham.OrderByDescending(b => b.Ma).ToList();
            }
            catch(Exception ex) {
                throw new Exception("SanPhamBO.Select_All:" + ex.ToString());
            }
        }

        public SanPham Select_ByMa(int ma) {
            try {
                return aDatabaseDA.SanPham.Where(b => b.Ma == ma).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("SanPhamBO.Select_ByMa:" + ex.ToString());
            }
        }

        public SanPham Select_ByLoai(int loai) {
            try {
                return aDatabaseDA.SanPham.Where(b => b.Loai == loai).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("SanPhamBO.Select_ByLoai:" + ex.ToString());
            }
        }

        public SanPham Select_ByKichHoat(int kichHoat) {
            try {
                return aDatabaseDA.SanPham.Where(b => b.KichHoat == kichHoat).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("SanPhamBO.Select_ByKichHoat:" + ex.ToString());
            }
        }

        public bool Insert(SanPham aSanPham) {
            try {
                aDatabaseDA.SanPham.Add(aSanPham);
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("SanPhamBO.Insert: " + ex.ToString());
            }
        }

        public bool Update(SanPham aSanPham) {
            try {
                aDatabaseDA.SanPham.AddOrUpdate(aSanPham);
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("SanPhamBO.Update: " + ex.ToString());
            }
        }

        public bool Delete(int ma) {
            try {
                aDatabaseDA.SanPham.Remove(this.Select_ByMa(ma));
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("SanPhamBO.Delete: " + ex.ToString());
            }
        }
    }
}
