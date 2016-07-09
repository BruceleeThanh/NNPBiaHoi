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
    public partial class HoaDonBanLeBO {
        DatabaseDA aDatabaseDA = new DatabaseDA();

        public List<HoaDonBanLe> Select_All() {
            try {
                return aDatabaseDA.HoaDonBanLe.Where(c=>c.ThungRac == 1).OrderByDescending(b => b.Ma).ToList();
            }
            catch(Exception ex) {
                throw new Exception("HoaDonBanLeBO.Select_All: " + ex.ToString());
            }
        }

        public HoaDonBanLe Select_ByMa(int ma) {
            try {
                return aDatabaseDA.HoaDonBanLe.Where(b => b.Ma == ma && b.ThungRac == 1).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("HoaDonBanLeBO.Select_ByMa: " + ex.ToString());
            }
        }

        public List<HoaDonBanLe> Select_ByMaSanPham(int maSanPham) {
            try {
                return aDatabaseDA.HoaDonBanLe.Where(b => b.MaSanPham == maSanPham && b.ThungRac == 1).ToList();
            }
            catch(Exception ex) {
                throw new Exception("HoaDonBanLeBO.Select_ByMaSanPham: " + ex.ToString());
            }
        }

        public List<HoaDonBanLe> Select_All_Hidden() {
            try {
                return aDatabaseDA.HoaDonBanLe.Where(c => c.ThungRac == 2).OrderByDescending(b => b.Ma).ToList();
            }
            catch(Exception ex) {
                throw new Exception("HoaDonBanLeBO.Select_All_Hidden: " + ex.ToString());
            }
        }

        public HoaDonBanLe Select_ByMa_Hidden(int ma) {
            try {
                return aDatabaseDA.HoaDonBanLe.Where(b => b.Ma == ma && b.ThungRac == 2).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("HoaDonBanLeBO.Select_ByMa_Hidden: " + ex.ToString());
            }
        }

        public List<HoaDonBanLe> Select_ByMaSanPham_Hidden(int maSanPham) {
            try {
                return aDatabaseDA.HoaDonBanLe.Where(b => b.MaSanPham == maSanPham && b.ThungRac == 2).ToList();
            }
            catch(Exception ex) {
                throw new Exception("HoaDonBanLeBO.Select_ByMaSanPham_Hidden: " + ex.ToString());
            }
        }

        //public List<HoaDonBanLe> Select_ByThoiGian(DateTime thoiGian) {
        //    try {

        //    }
        //    catch(Exception ex) {
        //        throw new Exception("HoaDonBanLeBO.Select_ByThoiGian: " + ex.ToString());
        //    }
        //}

        public bool Insert(HoaDonBanLe aHoaDonBanLe) {
            try {
                aHoaDonBanLe.ThungRac = 1;
                aDatabaseDA.HoaDonBanLe.Add(aHoaDonBanLe);
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("HoaDonBanLeBO.Insert: " + ex.ToString());
            }
        }

        public bool Update(HoaDonBanLe aHoaDonBanLe) {
            try {
                aDatabaseDA.HoaDonBanLe.AddOrUpdate(aHoaDonBanLe);
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("HoaDonBanLeBO.Update: " + ex.ToString());
            }
        }

        public bool Delete(int ma) {
            try {
                HoaDonBanLe aHoaDonBanLe = this.Select_ByMa(ma);
                aHoaDonBanLe.ThungRac = 2;
                return this.Update(aHoaDonBanLe);
            }
            catch(Exception ex) {
                return false;
                throw new Exception("HoaDonBanLeBO.Delete: " + ex.ToString());
            }
        }

    }
}
