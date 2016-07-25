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
    public partial class KhachHangBO {
        private DatabaseDA aDatabaseDA = new DatabaseDA();

        public List<KhachHang> SelectAll() {
            try {
                return aDatabaseDA.KhachHang.Where(c => c.ThungRac == 1).OrderByDescending(b => b.Ma).ToList();
            }
            catch(Exception ex) {
                throw new Exception("KhachHangBO.Select_All:" + ex.ToString());
            }
        }

        public KhachHang Select_ByMa(int ma) {
            try {
                return aDatabaseDA.KhachHang.Where(b => b.Ma == ma && b.ThungRac == 1).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("KhachHangBO.Select_ByMa:" + ex.ToString());
            }
        }

        public List<KhachHang> SelectAll_Hidden() {
            try {
                return aDatabaseDA.KhachHang.Where(c => c.ThungRac == 2).OrderByDescending(b => b.Ma).ToList();
            }
            catch(Exception ex) {
                throw new Exception("KhachHangBO.SelectAll_Hidden:" + ex.ToString());
            }
        }

        public KhachHang Select_ByMa_Hidden(int ma) {
            try {
                return aDatabaseDA.KhachHang.Where(b => b.Ma == ma && b.ThungRac == 2).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("KhachHangBO.Select_ByMa_Hidden:" + ex.ToString());
            }
        }

        public int Insert(KhachHang aKhachHang) {
            try {
                aKhachHang.ThungRac = 1;
                aDatabaseDA.KhachHang.Add(aKhachHang);
                aDatabaseDA.SaveChanges();
                return aKhachHang.Ma;
            }
            catch(Exception ex) {
                return -1;
                throw new Exception("KhachHangBO.Insert: " + ex.ToString());
            }
        }

        public int Update(KhachHang aKhachHang) {
            try {
                aDatabaseDA.KhachHang.AddOrUpdate(aKhachHang);
                aDatabaseDA.SaveChanges();
                return aKhachHang.Ma;
            }
            catch(Exception ex) {
                return -1;
                throw new Exception("KhachHangBO.Update: " + ex.ToString());
            }
        }

        public bool Delete(int ma) {
            try {
                KhachHang aKhachHang = this.Select_ByMa(ma);
                aKhachHang.ThungRac = 2;
                return this.Update(aKhachHang)!=-1;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("KhachHangBO.Delete: " + ex.ToString());
            }
        }
    }
}
