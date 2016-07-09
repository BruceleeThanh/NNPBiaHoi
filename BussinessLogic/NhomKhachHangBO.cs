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
    public partial class NhomKhachHangBO {

        private DatabaseDA aDatabaseDA = new DatabaseDA();

        public List<NhomKhachHang> SelectAll() {
            try {
                return aDatabaseDA.NhomKhachHang.Where(c => c.ThungRac == 1).OrderByDescending(b => b.Ma).ToList();
            }
            catch(Exception ex) {
                throw new Exception("NhomKhachHangBO.Select_All:" + ex.ToString());
            }
        }

        public NhomKhachHang Select_ByMa(int ma) {
            try {
                return aDatabaseDA.NhomKhachHang.Where(b => b.Ma == ma && b.ThungRac == 1).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("NhomKhachHangBO.Select_ByMa:" + ex.ToString());
            }
        }

        public List<NhomKhachHang> SelectAll_Hidden() {
            try {
                return aDatabaseDA.NhomKhachHang.Where(c => c.ThungRac == 2).OrderByDescending(b => b.Ma).ToList();
            }
            catch(Exception ex) {
                throw new Exception("NhomKhachHangBO.SelectAll_Hidden:" + ex.ToString());
            }
        }

        public NhomKhachHang Select_ByMa_Hidden(int ma) {
            try {
                return aDatabaseDA.NhomKhachHang.Where(b => b.Ma == ma && b.ThungRac == 2).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("NhomKhachHangBO.Select_ByMa_Hidden:" + ex.ToString());
            }
        }

        public bool Insert(NhomKhachHang aNhomKhachHang) {
            try {
                aNhomKhachHang.ThungRac = 1;
                aDatabaseDA.NhomKhachHang.Add(aNhomKhachHang);
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("NhomKhachHangBO.Insert: " + ex.ToString());
            }
        }

        public bool Update(NhomKhachHang aNhomKhachHang) {
            try {
                aDatabaseDA.NhomKhachHang.AddOrUpdate(aNhomKhachHang);
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("NhomKhachHangBO.Update: " + ex.ToString());
            }
        }

        public bool Delete(int ma) {
            try {
                NhomKhachHang aNhomKhachHang = this.Select_ByMa(ma);
                aNhomKhachHang.ThungRac = 2;
                return this.Update(aNhomKhachHang);
            }
            catch(Exception ex) {
                return false;
                throw new Exception("NhomKhachHangBO.Delete: " + ex.ToString());
            }
        }
    }
}
