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
                return aDatabaseDA.NhomKhachHang.OrderByDescending(b => b.Ma).ToList();
            }
            catch(Exception ex) {
                throw new Exception("NhomKhachHangBO.Select_All:" + ex.ToString());
            }
        }

        public NhomKhachHang Select_ByMa(int ma) {
            try {
                return aDatabaseDA.NhomKhachHang.Where(b => b.Ma == ma).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("NhomKhachHangBO.Select_ByMa:" + ex.ToString());
            }
        }

        public bool Insert(NhomKhachHang aNhomKhachHang) {
            try {
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
                aDatabaseDA.NhomKhachHang.Remove(this.Select_ByMa(ma));
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("NhomKhachHangBO.Delete: " + ex.ToString());
            }
        }
    }
}
