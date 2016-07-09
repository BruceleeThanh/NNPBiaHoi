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
                return aDatabaseDA.NhanVien.Where(c => c.ThungRac == 1).OrderByDescending(b => b.Ma).ToList();
            }
            catch(Exception ex) {
                throw new Exception("NhanVienBO.Select_All:" + ex.ToString());
            }
        }

        public NhanVien Select_ByMa(int ma) {
            try {
                return aDatabaseDA.NhanVien.Where(b => b.Ma == ma & b.ThungRac == 1).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("NhanVienBO.Select_ByMa:" + ex.ToString());
            }
        }

        public List<NhanVien> SelectAll_Hidden() {
            try {
                return aDatabaseDA.NhanVien.Where(c => c.ThungRac == 2).OrderByDescending(b => b.Ma).ToList();
            }
            catch(Exception ex) {
                throw new Exception("NhanVienBO.SelectAll_Hidden:" + ex.ToString());
            }
        }

        public NhanVien Select_ByMa_Hidden(int ma) {
            try {
                return aDatabaseDA.NhanVien.Where(b => b.Ma == ma & b.ThungRac == 2).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("NhanVienBO.Select_ByMa_Hidden:" + ex.ToString());
            }
        }

        public bool Insert(NhanVien aNhanVien) {
            try {
                aNhanVien.ThungRac = 1;
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
                NhanVien aNhanVien = this.Select_ByMa(ma);
                aNhanVien.ThungRac = 2;
                return this.Update(aNhanVien);
            }
            catch(Exception ex) {
                return false;
                throw new Exception("NhanVienBO.Delete: " + ex.ToString());
            }
        }
    }
}
