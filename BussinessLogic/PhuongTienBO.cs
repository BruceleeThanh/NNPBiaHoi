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
                return aDatabaseDA.PhuongTien.Where(c => c.ThungRac == 1).OrderByDescending(b => b.Ma).ToList();
            }
            catch(Exception ex) {
                throw new Exception("PhuongTienBO.Select_All:" + ex.ToString());
            }
        }

        public PhuongTien Select_ByMa(int ma) {
            try {
                return aDatabaseDA.PhuongTien.Where(b => b.Ma == ma && b.ThungRac == 1).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("PhuongTienBO.Select_ByMa:" + ex.ToString());
            }
        }

        public List<PhuongTien> SelectAll_Hidden() {
            try {
                return aDatabaseDA.PhuongTien.Where(c => c.ThungRac == 2).OrderByDescending(b => b.Ma).ToList();
            }
            catch(Exception ex) {
                throw new Exception("PhuongTienBO.SelectAll_Hidden:" + ex.ToString());
            }
        }

        public PhuongTien Select_ByMa_Hidden(int ma) {
            try {
                return aDatabaseDA.PhuongTien.Where(b => b.Ma == ma && b.ThungRac == 2).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("PhuongTienBO.Select_ByMa_Hidden:" + ex.ToString());
            }
        }

        public bool Insert(PhuongTien aPhuongTien) {
            try {
                aPhuongTien.ThungRac = 1;
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
                PhuongTien aPhuongTien = this.Select_ByMa(ma);
                aPhuongTien.ThungRac = 2;
                return this.Update(aPhuongTien);
            }
            catch(Exception ex) {
                return false;
                throw new Exception("PhuongTienBO.Delete: " + ex.ToString());
            }
        }
    }
}
