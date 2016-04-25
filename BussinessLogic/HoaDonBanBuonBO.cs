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
    public partial class HoaDonBanBuonBO {
        DatabaseDA aDatabaseDA = new DatabaseDA();

        public List<HoaDonBanBuon> Select_All() {
            try {
                return aDatabaseDA.HoaDonBanBuon.OrderByDescending(b => b.Ma).ToList();
            }
            catch(Exception ex) {
                throw new Exception("HoaDonBanBuonBO.Select_All: " + ex.ToString());
            }
        }

        public HoaDonBanBuon Select_ByMa(int ma) {
            try {
                return aDatabaseDA.HoaDonBanBuon.Where(b => b.Ma == ma).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("HoaDonBanBuonBO.Select_ByMa: " + ex.ToString());
            }
        }

        public List<HoaDonBanBuon> Select_ByMaKhachHang(int maKhachHang) {
            try {
                return aDatabaseDA.HoaDonBanBuon.Where(b => b.MaKhachHang == maKhachHang).ToList();
            }
            catch(Exception ex) {
                throw new Exception("HoaDonBanBuonBO.Select_ByMaKhachHang: " + ex.ToString());
            }
        }

        public bool Insert(HoaDonBanBuon aHoaDonBanBuon) {
            try {
                aDatabaseDA.HoaDonBanBuon.Add(aHoaDonBanBuon);
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("HoaDonBanBuonBO.Insert: " + ex.ToString());
            }
        }

        public bool Update(HoaDonBanBuon aHoaDonBanBuon) {
            try {
                aDatabaseDA.HoaDonBanBuon.AddOrUpdate(aHoaDonBanBuon);
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("HoaDonBanBuonBO.Update: " + ex.ToString());
            }
        }

        public bool Delete(int ma) {
            try {
                aDatabaseDA.HoaDonBanBuon.Remove(this.Select_ByMa(ma));
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("HoaDonBanBuonBO.Delete: " + ex.ToString());
            }
        }

    }
}
