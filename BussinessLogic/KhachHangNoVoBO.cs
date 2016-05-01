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
                return aDatabaseDA.KhachHangNoVo.OrderByDescending(b => b.Ma).ToList();
            }
            catch(Exception ex) {
                throw new Exception("KhachHangNoVoBO.Select_All:" + ex.ToString());
            }
        }

        public KhachHangNoVo Select_ByMa(int ma) {
            try {
                return aDatabaseDA.KhachHangNoVo.Where(b => b.Ma == ma).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("KhachHangNoVoBO.Select_ByMa:" + ex.ToString());
            }
        }

        public List<KhachHangNoVo> Select_ByMaKhachHang(int maKhachHang) {
            try {
                return aDatabaseDA.KhachHangNoVo.Where(b => b.MaKhachHang == maKhachHang).ToList();
            }
            catch(Exception ex) {
                throw new Exception("KhachHangNoVoBO.Select_ByMaKhachHang:" + ex.ToString());
            }
        }

        public List<KhachHangNoVo> Select_ByMaSanPham(int maSanPham) {
            try {
                return aDatabaseDA.KhachHangNoVo.Where(b => b.MaSanPham == maSanPham).ToList();
            }
            catch(Exception ex) {
                throw new Exception("KhachHangNoVoBO.Select_ByMaSanPham:" + ex.ToString());
            }
        }

        public KhachHangNoVo Select_ByMaKhachHang_ByMaSanPham(int maKhachHang, int maSanPham) {
            try {
                return aDatabaseDA.KhachHangNoVo.Where(b => b.MaKhachHang == maKhachHang && b.MaSanPham == maSanPham).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("KhachHangNoVoBO.Select_ByMaKhachHang:" + ex.ToString());
            }
        }

        public bool Insert(KhachHangNoVo aKhachHangNoVo) {
            try {
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
                aDatabaseDA.KhachHangNoVo.Remove(this.Select_ByMa(ma));
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("KhachHangNoVoBO.Delete: " + ex.ToString());
            }
        }
    }
}
