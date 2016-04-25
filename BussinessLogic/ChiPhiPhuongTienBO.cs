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
    public partial class ChiPhiPhuongTienBO {
        DatabaseDA aDatabaseDA = new DatabaseDA();

        public List<ChiPhiPhuongTien> Select_All() {
            try {
                return aDatabaseDA.ChiPhiPhuongTien.OrderByDescending(b=>b.Ma).ToList();
            }
            catch(Exception ex) {
                throw new Exception("ChiTietPhuongTien.Select_All" + ex.ToString());
            }
        }

        public ChiPhiPhuongTien Select_ByMa(int ma) {
            try {
                return aDatabaseDA.ChiPhiPhuongTien.Where(b => b.Ma == ma).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("ChiTietPhuongTien.Select_ByMa" + ex.ToString());
            }
        }

        public List<ChiPhiPhuongTien> Select_ByMaPhuongTien(int maPhuongTien) {
            try {
                return aDatabaseDA.ChiPhiPhuongTien.Where(b => b.MaPhuongTien == maPhuongTien).ToList();
            }
            catch(Exception ex) {
                throw new Exception("ChiTietPhuongTien.Select_ByMaPhuongTien" + ex.ToString());
            }
        }

        public bool Insert(ChiPhiPhuongTien aChiPhiPhuongTien) {
            try {
                aDatabaseDA.ChiPhiPhuongTien.Add(aChiPhiPhuongTien);
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("ChiPhiPhuongTienBO.Insert: " + ex.ToString());
            }
        }

        public bool Update(ChiPhiPhuongTien aChiPhiPhuongTien) {
            try {
                aDatabaseDA.ChiPhiPhuongTien.AddOrUpdate(aChiPhiPhuongTien);
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("ChiPhiPhuongTienBO.Update: " + ex.ToString());
            }
        }

        public bool Delete(int ma) {
            try {
                aDatabaseDA.ChiPhiPhuongTien.Remove(this.Select_ByMa(ma));
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("ChiPhiPhuongTienBO.Delete: " + ex.ToString());
            }
        }
    }
}
