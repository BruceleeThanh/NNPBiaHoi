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
                return aDatabaseDA.LichSuKhachHangTraNoTien.Where(c => c.ThungRac == 1).OrderByDescending(b => b.Ma).ToList();
            }
            catch(Exception ex) {
                throw new Exception("LichSuKhachHangTraNoTienBO.Select_All:" + ex.ToString());
            }
        }

        public LichSuKhachHangTraNoTien Select_ByMa(int ma) {
            try {
                return aDatabaseDA.LichSuKhachHangTraNoTien.Where(b => b.Ma == ma && b.ThungRac == 1).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("LichSuKhachHangTraNoTienBO.Select_ByMa:" + ex.ToString());
            }
        }

        public List<LichSuKhachHangTraNoTien> Select_ByMaKhachHang(int maKhachHang) {
            try {
                return aDatabaseDA.LichSuKhachHangTraNoTien.Where(b => b.MaKhachHang == maKhachHang && b.ThungRac == 1).ToList();
            }
            catch(Exception ex) {
                throw new Exception("LichSuKhachHangTraNoTienBO.Select_ByMaKhachHang:" + ex.ToString());
            }
        }

        //public List<LichSuKhachHangTraNoTien> Select_ByThoiGian(DateTime thoiGian);

        public List<LichSuKhachHangTraNoTien> SelectAll_Hidden() {
            try {
                return aDatabaseDA.LichSuKhachHangTraNoTien.Where(c => c.ThungRac == 2).OrderByDescending(b => b.Ma).ToList();
            }
            catch(Exception ex) {
                throw new Exception("LichSuKhachHangTraNoTienBO.SelectAll_Hidden:" + ex.ToString());
            }
        }

        public LichSuKhachHangTraNoTien Select_ByMa_Hidden(int ma) {
            try {
                return aDatabaseDA.LichSuKhachHangTraNoTien.Where(b => b.Ma == ma && b.ThungRac == 2).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("LichSuKhachHangTraNoTienBO.Select_ByMa_Hidden:" + ex.ToString());
            }
        }

        public List<LichSuKhachHangTraNoTien> Select_ByMaKhachHang_Hidden(int maKhachHang) {
            try {
                return aDatabaseDA.LichSuKhachHangTraNoTien.Where(b => b.MaKhachHang == maKhachHang && b.ThungRac == 2).ToList();
            }
            catch(Exception ex) {
                throw new Exception("LichSuKhachHangTraNoTienBO.Select_ByMaKhachHang_Hidden:" + ex.ToString());
            }
        }

        public bool Insert(LichSuKhachHangTraNoTien aLichSuKhachHangTraNoTien) {
            try {
                aLichSuKhachHangTraNoTien.ThungRac = 1;
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
                LichSuKhachHangTraNoTien aLichSuKhachHangNoTien = this.Select_ByMa(ma);
                aLichSuKhachHangNoTien.ThungRac = 2;
                return this.Update(aLichSuKhachHangNoTien);
            }
            catch(Exception ex) {
                return false;
                throw new Exception("LichSuKhachHangTraNoTienBO.Delete: " + ex.ToString());
            }
        }
    }
}
