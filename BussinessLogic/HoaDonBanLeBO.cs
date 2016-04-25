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
    public partial class HoaDonBanLeBO {
        DatabaseDA aDatabaseDA = new DatabaseDA();

        public List<HoaDonBanLe> Select_All() {
            try {
                return aDatabaseDA.HoaDonBanLe.OrderByDescending(b => b.Ma).ToList();
            }
            catch(Exception ex) {
                throw new Exception("HoaDonBanLeBO.Select_All: " + ex.ToString());
            }
        }

        public HoaDonBanLe Select_ByMa(int ma) {
            try {
                return aDatabaseDA.HoaDonBanLe.Where(b => b.Ma == ma).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("HoaDonBanLeBO.Select_ByMa: " + ex.ToString());
            }
        }

        public List<HoaDonBanLe> Select_ByMaSanPham(int maSanPham) {
            try {
                return aDatabaseDA.HoaDonBanLe.Where(b => b.MaSanPham == maSanPham).ToList();
            }
            catch(Exception ex) {
                throw new Exception("HoaDonBanLeBO.Select_ByMaSanPham: " + ex.ToString());
            }
        }

        public List<HoaDonBanLe> Select_ByThoiGian(DateTime thoiGian) {
            try {

            }
            catch(Exception ex) {
                throw new Exception("HoaDonBanLeBO.Select_ByThoiGian: " + ex.ToString());
            }
        }

    }
}
