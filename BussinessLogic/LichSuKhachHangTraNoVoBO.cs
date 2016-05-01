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
    public partial class LichSuKhachHangTraNoVoBO {

        private DatabaseDA aDatabaseDA = new DatabaseDA();

        public List<LichSuKhachHangTraNoVo> SelectAll() {
            try {
                return aDatabaseDA.LichSuKhachHangTraNoVo.OrderByDescending(b => b.Ma).ToList();
            }
            catch(Exception ex) {
                throw new Exception("LichSuKhachHangTraNoBO.Select_All:" + ex.ToString());
            }
        }

        public LichSuKhachHangTraNoVo Select_ByMa(int ma) {
            try {
                return aDatabaseDA.LichSuKhachHangTraNoVo.Where(b => b.Ma == ma).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("LichSuKhachHangTraNoBO.Select_ByMa:" + ex.ToString());
            }
        }

        public List<LichSuKhachHangTraNoVo> Select_ByMaKhachHangNoVo(int maKhachHangNoVo) {
            try {
                return aDatabaseDA.LichSuKhachHangTraNoVo.Where(b => b.MaKhachHangNoVo == maKhachHangNoVo).ToList();
            }
            catch(Exception ex) {
                throw new Exception("LichSuKhachHangTraNoBO.Select_ByMaKhachHangNoVo:" + ex.ToString());
            }
        }

        //public List<LichSuKhachHangTraNoVo> Select_ByThoiGian(DateTime thoiGian);

        public List<LichSuKhachHangTraNoVo> Select_ByLoai(int loai) {
            try {
                return aDatabaseDA.LichSuKhachHangTraNoVo.Where(b => b.Loai == loai).ToList();
            }
            catch(Exception ex) {
                throw new Exception("LichSuKhachHangTraNoBO.Select_ByLoai:" + ex.ToString());
            }
        }

        public bool Insert(LichSuKhachHangTraNoVo aLichSuKhachHangTraNoVo) {
            try {
                aDatabaseDA.LichSuKhachHangTraNoVo.Add(aLichSuKhachHangTraNoVo);
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("LichSuKhachHangTraNoVoBO.Insert: " + ex.ToString());
            }
        }

        public bool Update(LichSuKhachHangTraNoVo aLichSuKhachHangTraNoVo) {
            try {
                aDatabaseDA.LichSuKhachHangTraNoVo.AddOrUpdate(aLichSuKhachHangTraNoVo);
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("LichSuKhachHangTraNoVoBO.Update: " + ex.ToString());
            }
        }

        public bool Delete(int ma) {
            try {
                aDatabaseDA.LichSuKhachHangTraNoVo.Remove(this.Select_ByMa(ma));
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("LichSuKhachHangTraNoVoBO.Delete: " + ex.ToString());
            }
        }
    }
}
