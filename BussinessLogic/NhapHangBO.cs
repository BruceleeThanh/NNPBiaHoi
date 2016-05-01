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
    public partial class NhapHangBO {

        private DatabaseDA aDatabaseDA = new DatabaseDA();

        public List<NhapHang> SelectAll() {
            try {
                return aDatabaseDA.NhapHang.OrderByDescending(b => b.Ma).ToList();
            }
            catch(Exception ex) {
                throw new Exception("NhanHangBO.Select_All:" + ex.ToString());
            }
        }

        public NhapHang Select_ByMa(int ma) {
            try {
                return aDatabaseDA.NhapHang.Where(b => b.Ma == ma).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("NhanHangBO.Select_ByMa:" + ex.ToString());
            }
        }

        //public List<NhapHang> Select_ByThoiGian(DateTime thoiGian);

        public bool Insert(NhapHang aNhapHang) {
            try {
                aDatabaseDA.NhapHang.Add(aNhapHang);
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("NhanVienBO.Insert: " + ex.ToString());
            }
        }

        public bool Update(NhapHang aNhapHang) {
            try {
                aDatabaseDA.NhapHang.AddOrUpdate(aNhapHang);
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("NhanVienBO.Update: " + ex.ToString());
            }
        }

        public bool Delete(int ma) {
            try {
                aDatabaseDA.NhapHang.Remove(this.Select_ByMa(ma));
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("NhanVienBO.Delete: " + ex.ToString());
            }
        }
    }
}
