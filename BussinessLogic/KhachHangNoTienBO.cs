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
    public partial class KhachHangNoTienBO {

        private DatabaseDA aDatabaseDA = new DatabaseDA();

        public List<KhachHangNoTien> SelectAll() {
            try {
                return aDatabaseDA.KhachHangNoTien.OrderByDescending(b => b.MaKhachHang).ToList();
            }
            catch(Exception ex) {
                throw new Exception("KhachHangNoTienBO.Select_All:" + ex.ToString());
            }
        }

        public KhachHangNoTien Select_ByMaKhachHang(int maKhachHang) {
            try {
                return aDatabaseDA.KhachHangNoTien.Where(b => b.MaKhachHang == maKhachHang).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("KhachHangNoTienBO.Select_All:" + ex.ToString());
            }
        }

        public bool Insert(KhachHangNoTien aKhachHangNoTien) {
            try {
                aDatabaseDA.KhachHangNoTien.Add(aKhachHangNoTien);
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("KhachHangNoTienBO.Insert: " + ex.ToString());
            }
        }

        public bool Update(KhachHangNoTien aKhachHangNoTien) {
            try {
                aDatabaseDA.KhachHangNoTien.AddOrUpdate(aKhachHangNoTien);
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("KhachHangNoTienBO.Update: " + ex.ToString());
            }
        }

        public bool Delete(int maKhachHang) {
            try {
                aDatabaseDA.KhachHangNoTien.Remove(this.Select_ByMaKhachHang(maKhachHang));
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("KhachHangNoTienBO.Delete: " + ex.ToString());
            }
        }
    }
}
