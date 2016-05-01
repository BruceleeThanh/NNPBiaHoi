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
    public partial class NhanVienBO {

        private DatabaseDA aDatabaseDA = new DatabaseDA();

        public List<NhanVien> SelectAll() {
            try {
                return aDatabaseDA.NhanVien.OrderByDescending(b => b.Ma).ToList();
            }
            catch(Exception ex) {
                throw new Exception("NhanVienBO.Select_All:" + ex.ToString());
            }
        }

        public NhanVien Select_ByMa(int ma) {
            try {
                return aDatabaseDA.NhanVien.Where(b => b.Ma == ma).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("NhanVienBO.Select_ByMa:" + ex.ToString());
            }
        }

        public bool Insert(NhanVien aNhanVien) {
            try {
                aDatabaseDA.NhanVien.Add(aNhanVien);
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("NhanVienBO.Insert: " + ex.ToString());
            }
        }

        public bool Update(NhanVien aNhanVien) {
            try {
                aDatabaseDA.NhanVien.AddOrUpdate(aNhanVien);
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("NhanVienBO.Update: " + ex.ToString());
            }
        }

        public bool Delete(int ma) {
            try {
                aDatabaseDA.NhanVien.Remove(this.Select_ByMa(ma));
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("NhanVienBO.Delete: " + ex.ToString());
            }
        }
    }
}
