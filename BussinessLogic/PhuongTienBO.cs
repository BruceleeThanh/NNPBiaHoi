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
    public partial class PhuongTienBO {

        private DatabaseDA aDatabaseDA = new DatabaseDA();

        public List<PhuongTien> SelectAll() {
            try {
                return aDatabaseDA.PhuongTien.OrderByDescending(b => b.Ma).ToList();
            }
            catch(Exception ex) {
                throw new Exception("PhuongTienBO.Select_All:" + ex.ToString());
            }
        }

        public PhuongTien Select_ByMa(int ma) {
            try {
                return aDatabaseDA.PhuongTien.Where(b => b.Ma == ma).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("PhuongTienBO.Select_ByMa:" + ex.ToString());
            }
        }

        public bool Insert(PhuongTien aPhuongTien) {
            try {
                aDatabaseDA.PhuongTien.Add(aPhuongTien);
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("PhuongTienBO.Insert: " + ex.ToString());
            }
        }

        public bool Update(PhuongTien aPhuongTien) {
            try {
                aDatabaseDA.PhuongTien.AddOrUpdate(aPhuongTien);
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("PhuongTienBO.Update: " + ex.ToString());
            }
        }

        public bool Delete(int ma) {
            try {
                aDatabaseDA.PhuongTien.Remove(this.Select_ByMa(ma));
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("PhuongTienBO.Delete: " + ex.ToString());
            }
        }
    }
}
