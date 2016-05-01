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
    public partial class LichSuKhachHangTraNoTienBO {

        private DatabaseDA aDatabaseDA = new DatabaseDA();

        public List<LichSuKhachHangTraNoTien> SelectAll() {
            try {
                return aDatabaseDA.LichSuKhachHangTraNoTien.OrderByDescending(b => b.Ma).ToList();
            }
            catch(Exception ex) {
                throw new Exception("LichSuKhachHangTraNoTienBO.Select_All:" + ex.ToString());
            }
        }

        public LichSuKhachHangTraNoTien Select_ByMa(int ma) {
            try {
                return aDatabaseDA.LichSuKhachHangTraNoTien.Where(b => b.Ma == ma).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("LichSuKhachHangTraNoTienBO.Select_ByMaKhachHang:" + ex.ToString());
            }
        }

        public List<LichSuKhachHangTraNoTien> Select_ByMaKhachHang(int maKhachHang) {
            try {
                return aDatabaseDA.LichSuKhachHangTraNoTien.Where(b => b.MaKhachHang == maKhachHang).ToList();
            }
            catch(Exception ex) {
                throw new Exception("LichSuKhachHangTraNoTienBO.Select_ByMaKhachHang:" + ex.ToString());
            }
        }

        //public List<LichSuKhachHangTraNoTien> Select_ByThoiGian(DateTime thoiGian);

        public bool Insert(LichSuKhachHangTraNoTien aLichSuKhachHangTraNoTien) {
            try {
                aDatabaseDA.LichSuKhachHangTraNoTien.Add(aLichSuKhachHangTraNoTien);
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("LichSuKhachHangTraNoTienBO.Insert: " + ex.ToString());
            }
        }

        public bool Update(LichSuKhachHangTraNoTien aLichSuKhachHangTraNoTien) {
            try {
                aDatabaseDA.LichSuKhachHangTraNoTien.AddOrUpdate(aLichSuKhachHangTraNoTien);
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("LichSuKhachHangTraNoTienBO.Update: " + ex.ToString());
            }
        }

        public bool Delete(int ma) {
            try {
                aDatabaseDA.LichSuKhachHangTraNoTien.Remove(this.Select_ByMa(ma));
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("LichSuKhachHangTraNoTienBO.Delete: " + ex.ToString());
            }
        }
    }
}
