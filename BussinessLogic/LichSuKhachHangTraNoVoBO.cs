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
                return aDatabaseDA.LichSuKhachHangTraNoVo.Where(c => c.ThungRac == 1).OrderByDescending(b => b.Ma).ToList();
            }
            catch(Exception ex) {
                throw new Exception("LichSuKhachHangTraNoBO.Select_All:" + ex.ToString());
            }
        }

        public LichSuKhachHangTraNoVo Select_ByMa(int ma) {
            try {
                return aDatabaseDA.LichSuKhachHangTraNoVo.Where(b => b.Ma == ma && b.ThungRac == 1).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("LichSuKhachHangTraNoBO.Select_ByMa:" + ex.ToString());
            }
        }

        public List<LichSuKhachHangTraNoVo> Select_ByMaKhachHangNoVo(int maKhachHangNoVo) {
            try {
                return aDatabaseDA.LichSuKhachHangTraNoVo.Where(b => b.MaKhachHangNoVo == maKhachHangNoVo && b.ThungRac == 1).ToList();
            }
            catch(Exception ex) {
                throw new Exception("LichSuKhachHangTraNoBO.Select_ByMaKhachHangNoVo:" + ex.ToString());
            }
        }

        //public List<LichSuKhachHangTraNoVo> Select_ByThoiGian(DateTime thoiGian);

        public List<LichSuKhachHangTraNoVo> Select_ByLoai(int loai) {
            try {
                return aDatabaseDA.LichSuKhachHangTraNoVo.Where(b => b.Loai == loai && b.ThungRac == 1).ToList();
            }
            catch(Exception ex) {
                throw new Exception("LichSuKhachHangTraNoBO.Select_ByLoai:" + ex.ToString());
            }
        }

        public List<LichSuKhachHangTraNoVo> SelectAll_Hidden() {
            try {
                return aDatabaseDA.LichSuKhachHangTraNoVo.Where(c => c.ThungRac == 2).OrderByDescending(b => b.Ma).ToList();
            }
            catch(Exception ex) {
                throw new Exception("LichSuKhachHangTraNoBO.SelectAll_Hidden:" + ex.ToString());
            }
        }

        public LichSuKhachHangTraNoVo Select_ByMa_Hidden(int ma) {
            try {
                return aDatabaseDA.LichSuKhachHangTraNoVo.Where(b => b.Ma == ma && b.ThungRac == 2).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("LichSuKhachHangTraNoBO.Select_ByMa_Hidden:" + ex.ToString());
            }
        }

        public List<LichSuKhachHangTraNoVo> Select_ByMaKhachHangNoVo_Hidden(int maKhachHangNoVo) {
            try {
                return aDatabaseDA.LichSuKhachHangTraNoVo.Where(b => b.MaKhachHangNoVo == maKhachHangNoVo && b.ThungRac == 2).ToList();
            }
            catch(Exception ex) {
                throw new Exception("LichSuKhachHangTraNoBO.Select_ByMaKhachHangNoVo_Hidden:" + ex.ToString());
            }
        }

        //public List<LichSuKhachHangTraNoVo> Select_ByThoiGian(DateTime thoiGian);

        public List<LichSuKhachHangTraNoVo> Select_ByLoai_Hidden(int loai) {
            try {
                return aDatabaseDA.LichSuKhachHangTraNoVo.Where(b => b.Loai == loai && b.ThungRac == 2).ToList();
            }
            catch(Exception ex) {
                throw new Exception("LichSuKhachHangTraNoBO.Select_ByLoai_Hidden:" + ex.ToString());
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
                LichSuKhachHangTraNoVo aLichSuKhachHangTraNoVo = this.Select_ByMa(ma);
                aLichSuKhachHangTraNoVo.ThungRac = 2;
                return this.Update(aLichSuKhachHangTraNoVo);
            }
            catch(Exception ex) {
                return false;
                throw new Exception("LichSuKhachHangTraNoVoBO.Delete: " + ex.ToString());
            }
        }
    }
}
