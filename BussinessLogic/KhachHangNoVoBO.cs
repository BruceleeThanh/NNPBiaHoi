using System;
using System.Collections.Generic;
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
    public partial class KhachHangNoVoBO {

        private DatabaseDA aDatabaseDA = new DatabaseDA();

        public List<KhachHangNoVo> SelectAll() {
            try {
                return aDatabaseDA.KhachHangNoVo.Where(c => c.ThungRac == 1).OrderByDescending(b => b.Ma).ToList();
            }
            catch(Exception ex) {
                throw new Exception("KhachHangNoVoBO.Select_All:" + ex.ToString());
            }
        }

        public KhachHangNoVo Select_ByMa(int ma) {
            try {
                return aDatabaseDA.KhachHangNoVo.Where(b => b.Ma == ma && b.ThungRac == 1).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("KhachHangNoVoBO.Select_ByMa:" + ex.ToString());
            }
        }

        public List<KhachHangNoVo> Select_ByMaKhachHang(int maKhachHang) {
            try {
                return aDatabaseDA.KhachHangNoVo.Where(b => b.MaKhachHang == maKhachHang && b.ThungRac == 1).ToList();
            }
            catch(Exception ex) {
                throw new Exception("KhachHangNoVoBO.Select_ByMaKhachHang:" + ex.ToString());
            }
        }

        public List<KhachHangNoVo> Select_ByMaSanPham(int maSanPham) {
            try {
                return aDatabaseDA.KhachHangNoVo.Where(b => b.MaSanPham == maSanPham && b.ThungRac == 1).ToList();
            }
            catch(Exception ex) {
                throw new Exception("KhachHangNoVoBO.Select_ByMaSanPham:" + ex.ToString());
            }
        }

        public KhachHangNoVo Select_ByMaKhachHang_ByMaSanPham(int maKhachHang, int maSanPham) {
            try {
                return aDatabaseDA.KhachHangNoVo.Where(b => b.MaKhachHang == maKhachHang && b.MaSanPham == maSanPham && b.ThungRac == 1).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("KhachHangNoVoBO.Select_ByMaKhachHang_ByMaSanPham:" + ex.ToString());
            }
        }

        public List<KhachHangNoVo> SelectAll_Hidden() {
            try {
                return aDatabaseDA.KhachHangNoVo.Where(c => c.ThungRac == 2).OrderByDescending(b => b.Ma).ToList();
            }
            catch(Exception ex) {
                throw new Exception("KhachHangNoVoBO.SelectAll_Hidden:" + ex.ToString());
            }
        }

        public KhachHangNoVo Select_ByMa_Hidden(int ma) {
            try {
                return aDatabaseDA.KhachHangNoVo.Where(b => b.Ma == ma && b.ThungRac == 2).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("KhachHangNoVoBO.Select_ByMa_Hidden:" + ex.ToString());
            }
        }

        public List<KhachHangNoVo> Select_ByMaKhachHang_Hidden(int maKhachHang) {
            try {
                return aDatabaseDA.KhachHangNoVo.Where(b => b.MaKhachHang == maKhachHang && b.ThungRac == 2).ToList();
            }
            catch(Exception ex) {
                throw new Exception("KhachHangNoVoBO.Select_ByMaKhachHang_Hidden:" + ex.ToString());
            }
        }

        public List<KhachHangNoVo> Select_ByMaSanPham_Hidden(int maSanPham) {
            try {
                return aDatabaseDA.KhachHangNoVo.Where(b => b.MaSanPham == maSanPham && b.ThungRac == 2).ToList();
            }
            catch(Exception ex) {
                throw new Exception("KhachHangNoVoBO.Select_ByMaSanPham_Hidden:" + ex.ToString());
            }
        }

        public KhachHangNoVo Select_ByMaKhachHang_ByMaSanPham_Hidden(int maKhachHang, int maSanPham) {
            try {
                return aDatabaseDA.KhachHangNoVo.Where(b => b.MaKhachHang == maKhachHang && b.MaSanPham == maSanPham && b.ThungRac == 2).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("KhachHangNoVoBO.Select_ByMaKhachHang_ByMaSanPham_Hidden:" + ex.ToString());
            }
        }

        public bool Insert(KhachHangNoVo aKhachHangNoVo) {
            try {
                aKhachHangNoVo.ThungRac = 1;
                aDatabaseDA.KhachHangNoVo.Add(aKhachHangNoVo);
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("KhachHangNoVoBO.Insert: " + ex.ToString());
            }
        }

        public bool Update(KhachHangNoVo aKhachHangNoVo) {
            try {
                aDatabaseDA.KhachHangNoVo.AddOrUpdate(aKhachHangNoVo);
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("KhachHangNoVoBO.Update: " + ex.ToString());
            }
        }

        public bool Delete(int ma) {
            try {
                KhachHangNoVo aKhachHangNoVo = this.Select_ByMa(ma);
                aKhachHangNoVo.ThungRac = 2;
                return this.Update(aKhachHangNoVo);
            }
            catch(Exception ex) {
                return false;
                throw new Exception("KhachHangNoVoBO.Delete: " + ex.ToString());
            }
        }
    }
}
