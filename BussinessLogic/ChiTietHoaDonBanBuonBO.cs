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
                return aDatabaseDA.ChiTietHoaDonBanBuon.OrderByDescending(b => b.MaHoaDonBanBuon).ToList();
            }
            catch(Exception ex) {
                throw new Exception("ChiTietHoaDonBanBuonBO.Select_All" + ex.ToString());
            }
        }

        public List<ChiTietHoaDonBanBuon> Select_ByMaHoaDonBanBuon(int maHoaDonBanBuon) {
            try {
                return aDatabaseDA.ChiTietHoaDonBanBuon.Where(b => b.MaHoaDonBanBuon == maHoaDonBanBuon).ToList();
            }
            catch(Exception ex) {
                throw new Exception("ChiTietHoaDonBanBuonBO.Select_ByMaHoaDonBanBuon" + ex.ToString());
            }
        }

        public List<ChiTietHoaDonBanBuon> Select_ByMaSanPham(int maSanPham) {
            try {
                return aDatabaseDA.ChiTietHoaDonBanBuon.Where(b => b.MaSanPham == maSanPham).ToList();
            }
            catch(Exception ex) {
                throw new Exception("ChiTietHoaDonBanBuonBO.Select_ByMaSanPham" + ex.ToString());
            }
        }

        public ChiTietHoaDonBanBuon Select_ByMaHoaDonBanBuon_ByMaSanPham(int maHoaDonBanBuon, int maSanPham) {
            try {
                return aDatabaseDA.ChiTietHoaDonBanBuon.Where(b => b.MaHoaDonBanBuon == maHoaDonBanBuon && b.MaSanPham == maSanPham).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("ChiTietHoaDonBanBuonBO.Select_ByMaHoaDonBanBuon_ByMaSanPham" + ex.ToString());
            }
        }

        public bool Insert(ChiTietHoaDonBanBuon aChiTietHoaDonBanBuon) {
            try {
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
                aDatabaseDA.ChiTietHoaDonBanBuon.Remove(this.Select_ByMaHoaDonBanBuon_ByMaSanPham(maHoaDonBanBuon, maSanPham));
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("ChiTietHoaDonBanBuonBO.Delete: " + ex.ToString());
            }
        }
    }
}
