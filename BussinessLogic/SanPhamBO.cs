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
                return aDatabaseDA.SanPham.Where(c => c.ThungRac == 1).OrderByDescending(b => b.Ma).ToList();
            }
            catch(Exception ex) {
                throw new Exception("SanPhamBO.Select_All:" + ex.ToString());
            }
        }

        public SanPham Select_ByMa(int ma) {
            try {
                return aDatabaseDA.SanPham.Where(b => b.Ma == ma && b.ThungRac == 1).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("SanPhamBO.Select_ByMa:" + ex.ToString());
            }
        }

        public SanPham Select_ByLoai(int loai) {
            try {
                return aDatabaseDA.SanPham.Where(b => b.Loai == loai && b.ThungRac == 1).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("SanPhamBO.Select_ByLoai:" + ex.ToString());
            }
        }

        public SanPham Select_ByKichHoat(int kichHoat) {
            try {
                return aDatabaseDA.SanPham.Where(b => b.KichHoat == kichHoat && b.ThungRac == 1).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("SanPhamBO.Select_ByKichHoat:" + ex.ToString());
            }
        }

        public List<SanPham> SelectAll_Hidden() {
            try {
                return aDatabaseDA.SanPham.Where(c => c.ThungRac == 2).OrderByDescending(b => b.Ma).ToList();
            }
            catch(Exception ex) {
                throw new Exception("SanPhamBO.SelectAll_Hidden:" + ex.ToString());
            }
        }

        public SanPham Select_ByMa_Hidden(int ma) {
            try {
                return aDatabaseDA.SanPham.Where(b => b.Ma == ma && b.ThungRac == 2).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("SanPhamBO.Select_ByMa_Hidden:" + ex.ToString());
            }
        }

        public SanPham Select_ByLoai_Hidden(int loai) {
            try {
                return aDatabaseDA.SanPham.Where(b => b.Loai == loai && b.ThungRac == 2).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("SanPhamBO.Select_ByLoai_Hidden:" + ex.ToString());
            }
        }

        public SanPham Select_ByKichHoat_Hidden(int kichHoat) {
            try {
                return aDatabaseDA.SanPham.Where(b => b.KichHoat == kichHoat && b.ThungRac == 2).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("SanPhamBO.Select_ByKichHoat_Hidden:" + ex.ToString());
            }
        }

        public bool Insert(SanPham aSanPham) {
            try {
                aSanPham.ThungRac = 1;
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
                SanPham aSanPham = this.Select_ByMa(ma);
                aSanPham.ThungRac = 2;
                return this.Update(aSanPham);
            }
            catch(Exception ex) {
                return false;
                throw new Exception("SanPhamBO.Delete: " + ex.ToString());
            }
        }
    }
}
