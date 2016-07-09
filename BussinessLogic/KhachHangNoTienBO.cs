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
                return aDatabaseDA.KhachHangNoTien.Where(c => c.ThungRac == 1).OrderByDescending(b => b.MaKhachHang).ToList();
            }
            catch(Exception ex) {
                throw new Exception("KhachHangNoTienBO.Select_All:" + ex.ToString());
            }
        }

        public KhachHangNoTien Select_ByMaKhachHang(int maKhachHang) {
            try {
                return aDatabaseDA.KhachHangNoTien.Where(b => b.MaKhachHang == maKhachHang && b.ThungRac == 1).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("KhachHangNoTienBO.Select_ByMaKhachHang:" + ex.ToString());
            }
        }

        public List<KhachHangNoTien> SelectAll_Hidden() {
            try {
                return aDatabaseDA.KhachHangNoTien.Where(c => c.ThungRac == 2).OrderByDescending(b => b.MaKhachHang).ToList();
            }
            catch(Exception ex) {
                throw new Exception("KhachHangNoTienBO.SelectAll_Hidden:" + ex.ToString());
            }
        }

        public KhachHangNoTien Select_ByMaKhachHang_Hidden(int maKhachHang) {
            try {
                return aDatabaseDA.KhachHangNoTien.Where(b => b.MaKhachHang == maKhachHang && b.ThungRac == 2).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("KhachHangNoTienBO.Select_ByMaKhachHang_Hidden:" + ex.ToString());
            }
        }

        public bool Insert(KhachHangNoTien aKhachHangNoTien) {
            try {
                aKhachHangNoTien.ThungRac = 1;
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
                KhachHangNoTien aKhachHangNoTien = this.Select_ByMaKhachHang(maKhachHang);
                aKhachHangNoTien.ThungRac = 2;
                return this.Update(aKhachHangNoTien);
            }
            catch(Exception ex) {
                return false;
                throw new Exception("KhachHangNoTienBO.Delete: " + ex.ToString());
            }
        }
    }
}
