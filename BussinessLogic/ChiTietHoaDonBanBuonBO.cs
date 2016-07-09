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
    public partial class ChiTietHoaDonBanBuonBO {
        DatabaseDA aDatabaseDA = new DatabaseDA();

        public List<ChiTietHoaDonBanBuon> Select_All() {
            try {
                return aDatabaseDA.ChiTietHoaDonBanBuon.Where(c => c.ThungRac == 1).OrderByDescending(b => b.MaHoaDonBanBuon).ToList();
            }
            catch(Exception ex) {
                throw new Exception("ChiTietHoaDonBanBuonBO.Select_All" + ex.ToString());
            }
        }

        public List<ChiTietHoaDonBanBuon> Select_ByMaHoaDonBanBuon(int maHoaDonBanBuon) {
            try {
                return aDatabaseDA.ChiTietHoaDonBanBuon.Where(b => b.MaHoaDonBanBuon == maHoaDonBanBuon && b.ThungRac == 1).ToList();
            }
            catch(Exception ex) {
                throw new Exception("ChiTietHoaDonBanBuonBO.Select_ByMaHoaDonBanBuon" + ex.ToString());
            }
        }

        public List<ChiTietHoaDonBanBuon> Select_ByMaSanPham(int maSanPham) {
            try {
                return aDatabaseDA.ChiTietHoaDonBanBuon.Where(b => b.MaSanPham == maSanPham && b.ThungRac == 1).ToList();
            }
            catch(Exception ex) {
                throw new Exception("ChiTietHoaDonBanBuonBO.Select_ByMaSanPham" + ex.ToString());
            }
        }

        public ChiTietHoaDonBanBuon Select_ByMaHoaDonBanBuon_ByMaSanPham(int maHoaDonBanBuon, int maSanPham) {
            try {
                return aDatabaseDA.ChiTietHoaDonBanBuon.Where(b => b.MaHoaDonBanBuon == maHoaDonBanBuon && b.MaSanPham == maSanPham && b.ThungRac == 1).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("ChiTietHoaDonBanBuonBO.Select_ByMaHoaDonBanBuon_ByMaSanPham" + ex.ToString());
            }
        }

        public List<ChiTietHoaDonBanBuon> Select_All_Hidden() {
            try {
                return aDatabaseDA.ChiTietHoaDonBanBuon.Where(c => c.ThungRac == 2).OrderByDescending(b => b.MaHoaDonBanBuon).ToList();
            }
            catch(Exception ex) {
                throw new Exception("ChiTietHoaDonBanBuonBO.Select_All_Hidden" + ex.ToString());
            }
        }

        public List<ChiTietHoaDonBanBuon> Select_ByMaHoaDonBanBuon_Hidden(int maHoaDonBanBuon) {
            try {
                return aDatabaseDA.ChiTietHoaDonBanBuon.Where(b => b.MaHoaDonBanBuon == maHoaDonBanBuon && b.ThungRac == 2).ToList();
            }
            catch(Exception ex) {
                throw new Exception("ChiTietHoaDonBanBuonBO.Select_ByMaHoaDonBanBuon_Hidden" + ex.ToString());
            }
        }

        public List<ChiTietHoaDonBanBuon> Select_ByMaSanPham_Hidden(int maSanPham) {
            try {
                return aDatabaseDA.ChiTietHoaDonBanBuon.Where(b => b.MaSanPham == maSanPham && b.ThungRac == 2).ToList();
            }
            catch(Exception ex) {
                throw new Exception("ChiTietHoaDonBanBuonBO.Select_ByMaSanPham_Hidden" + ex.ToString());
            }
        }

        public ChiTietHoaDonBanBuon Select_ByMaHoaDonBanBuon_ByMaSanPham_Hidden(int maHoaDonBanBuon, int maSanPham) {
            try {
                return aDatabaseDA.ChiTietHoaDonBanBuon.Where(b => b.MaHoaDonBanBuon == maHoaDonBanBuon && b.MaSanPham == maSanPham && b.ThungRac == 2).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("ChiTietHoaDonBanBuonBO.Select_ByMaHoaDonBanBuon_ByMaSanPham_Hidden" + ex.ToString());
            }
        }

        public bool Insert(ChiTietHoaDonBanBuon aChiTietHoaDonBanBuon) {
            try {
                aChiTietHoaDonBanBuon.ThungRac = 1;
                aDatabaseDA.ChiTietHoaDonBanBuon.Add(aChiTietHoaDonBanBuon);
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("ChiTietHoaDonBanBuonBO.Insert: " + ex.ToString());
            }
        }

        public bool Update(ChiTietHoaDonBanBuon aChiTietHoaDonBanBuon) {
            try {
                aDatabaseDA.ChiTietHoaDonBanBuon.AddOrUpdate(aChiTietHoaDonBanBuon);
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("ChiTietHoaDonBanBuonBO.Update: " + ex.ToString());
            }
        }

        public bool Delete(int maHoaDonBanBuon, int maSanPham) {
            try {
                ChiTietHoaDonBanBuon aChiTietHoaDonBanBuon = this.Select_ByMaHoaDonBanBuon_ByMaSanPham(maHoaDonBanBuon, maSanPham);
                aChiTietHoaDonBanBuon.ThungRac = 2;
                return this.Update(aChiTietHoaDonBanBuon);
            }
            catch(Exception ex) {
                return false;
                throw new Exception("ChiTietHoaDonBanBuonBO.Delete: " + ex.ToString());
            }
        }
    }
}
