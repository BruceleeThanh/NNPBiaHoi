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
                return aDatabaseDA.CuocVoCongTy.OrderByDescending(b => b.Ma).ToList();
            }
            catch(Exception ex) {
                throw new Exception("CuocVoCongTyBO.Select_All:" + ex.ToString());
            }
        }

        public CuocVoCongTy Select_ByMa(int ma) {
            try {
                return aDatabaseDA.CuocVoCongTy.Where(b => b.Ma == ma).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("CuocVoCongTyBO.Select_All: " + ex.ToString());
            }
        }

        public List<CuocVoCongTy> Select_ByMaSanPham(int maSanPham) {
            try {
                return aDatabaseDA.CuocVoCongTy.Where(b => b.MaSanPham == maSanPham).ToList();
            }
            catch(Exception ex) {
                throw new Exception("CuocVoCongTyBO.Select_ByMaSanPham: " + ex.ToString());
            }
        }

        public bool Insert(CuocVoCongTy aCuocVoCongTy) {
            try {
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
                aDatabaseDA.CuocVoCongTy.Remove(this.Select_ByMa(ma));
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("CuocVoCongTyBO.Delete: " + ex.ToString());
            }
        }
    }
}