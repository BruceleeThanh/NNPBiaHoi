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
    public partial class CuocVoCongTyBO {
        private DatabaseDA aDatabaseDA = new DatabaseDA();

        public List<CuocVoCongTy> Select_All() {
            try {
                return aDatabaseDA.CuocVoCongTy.Where(c=>c.ThungRac == 1).OrderByDescending(b => b.Ma).ToList();
            }
            catch(Exception ex) {
                throw new Exception("CuocVoCongTyBO.Select_All:" + ex.ToString());
            }
        }

        public CuocVoCongTy Select_ByMa(int ma) {
            try {
                return aDatabaseDA.CuocVoCongTy.Where(b => b.Ma == ma && b.ThungRac == 1).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("CuocVoCongTyBO.Select_ByMa: " + ex.ToString());
            }
        }

        public List<CuocVoCongTy> Select_ByMaSanPham(int maSanPham) {
            try {
                return aDatabaseDA.CuocVoCongTy.Where(b => b.MaSanPham == maSanPham && b.ThungRac == 1).ToList();
            }
            catch(Exception ex) {
                throw new Exception("CuocVoCongTyBO.Select_ByMaSanPham: " + ex.ToString());
            }
        }

        public List<CuocVoCongTy> Select_All_Hidden() {
            try {
                return aDatabaseDA.CuocVoCongTy.Where(c => c.ThungRac == 2).OrderByDescending(b => b.Ma).ToList();
            }
            catch(Exception ex) {
                throw new Exception("CuocVoCongTyBO.Select_All_Hidden:" + ex.ToString());
            }
        }

        public CuocVoCongTy Select_ByMa_Hidden(int ma) {
            try {
                return aDatabaseDA.CuocVoCongTy.Where(b => b.Ma == ma && b.ThungRac == 2).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("CuocVoCongTyBO.Select_ByMa_Hidden: " + ex.ToString());
            }
        }

        public List<CuocVoCongTy> Select_ByMaSanPham_Hidden(int maSanPham) {
            try {
                return aDatabaseDA.CuocVoCongTy.Where(b => b.MaSanPham == maSanPham && b.ThungRac == 2).ToList();
            }
            catch(Exception ex) {
                throw new Exception("CuocVoCongTyBO.Select_ByMaSanPham_Hidden: " + ex.ToString());
            }
        }

        public bool Insert(CuocVoCongTy aCuocVoCongTy) {
            try {
                aCuocVoCongTy.ThungRac = 1;
                aDatabaseDA.CuocVoCongTy.Add(aCuocVoCongTy);
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("CuocVoCongTyBO.Insert: " + ex.ToString());
            }
        }

        public bool Update(CuocVoCongTy aCuocVoCongTy) {
            try {
                aDatabaseDA.CuocVoCongTy.AddOrUpdate(aCuocVoCongTy);
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("CuocVoCongTyBO.Update: " + ex.ToString());
            }
        }

        public bool Delete(int ma) {
            try {
                CuocVoCongTy aCuocVoCongTy = this.Select_ByMa(ma);
                aCuocVoCongTy.ThungRac = 2;
                return Update(aCuocVoCongTy);
            }
            catch(Exception ex) {
                return false;
                throw new Exception("CuocVoCongTyBO.Delete: " + ex.ToString());
            }
        }
    }
}