using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using System.Security.Cryptography;
using DataAccess;

namespace BussinessLogic {
    public partial class TaiKhoanDangNhapBO {

        private DatabaseDA aDatabaseDA = new DatabaseDA();

        public List<TaiKhoanDangNhap> SelectAll() {
            try {
                return aDatabaseDA.TaiKhoanDangNhap.Where(c => c.ThungRac == 1).OrderByDescending(b => b.Ma).ToList();
            }
            catch(Exception ex) {
                throw new Exception("TaiKhoanDangNhapBO.Select_All:" + ex.ToString());
            }
        }

        public TaiKhoanDangNhap Select_ByMa(int ma) {
            try {
                return aDatabaseDA.TaiKhoanDangNhap.Where(b => b.Ma == ma && b.ThungRac == 1).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("TaiKhoanDangNhapBO.Select_ByMa:" + ex.ToString());
            }
        }

        // Hàm này dùng để check Đăng nhập - trả về bool
        public bool Select_ByTenDangNhap_ByMatKhau(string tenDangNhap, string matKhau) {
            try {
                string maHoaMatKhau = this.ToSHA1(matKhau);
                if(aDatabaseDA.TaiKhoanDangNhap.Where(b => b.TenDangNhap == tenDangNhap && b.MatKhau == maHoaMatKhau && b.ThungRac == 1).Any()) {
                    return true;
                }
                else {
                    return false;
                }
            }
            catch(Exception ex) {
                throw new Exception("TaiKhoanDangNhapBO.Select_ByTenDangNhap_ByMatKhau:" + ex.ToString());
            }
        }

        public List<TaiKhoanDangNhap> SelectAll_Hidden() {
            try {
                return aDatabaseDA.TaiKhoanDangNhap.Where(c => c.ThungRac == 2).OrderByDescending(b => b.Ma).ToList();
            }
            catch(Exception ex) {
                throw new Exception("TaiKhoanDangNhapBO.SelectAll_Hidden:" + ex.ToString());
            }
        }

        public TaiKhoanDangNhap Select_ByMa_Hidden(int ma) {
            try {
                return aDatabaseDA.TaiKhoanDangNhap.Where(b => b.Ma == ma && b.ThungRac == 2).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("TaiKhoanDangNhapBO.Select_ByMa_Hidden:" + ex.ToString());
            }
        }

        public bool Insert(TaiKhoanDangNhap aTaiKhoanDangNhap) {
            try {
                aTaiKhoanDangNhap.ThungRac = 1;
                aTaiKhoanDangNhap.MatKhau = this.ToSHA1(aTaiKhoanDangNhap.MatKhau);
                aDatabaseDA.TaiKhoanDangNhap.Add(aTaiKhoanDangNhap);
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("TaiKhoanDangNhapBO.Insert: " + ex.ToString());
            }
        }

        public bool Update(TaiKhoanDangNhap aTaiKhoanDangNhap) {
            try {
                aTaiKhoanDangNhap.MatKhau = this.ToSHA1(aTaiKhoanDangNhap.MatKhau);
                aDatabaseDA.TaiKhoanDangNhap.AddOrUpdate(aTaiKhoanDangNhap);
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("TaiKhoanDangNhapBO.Update: " + ex.ToString());
            }
        }

        public bool Delete(int ma) {
            try {
                TaiKhoanDangNhap aTaiKhoanDangNhap = this.Select_ByMa(ma);
                aTaiKhoanDangNhap.ThungRac = 2;
                return this.Update(aTaiKhoanDangNhap);
            }
            catch(Exception ex) {
                return false;
                throw new Exception("TaiKhoanDangNhapBO.Delete: " + ex.ToString());
            }
        }

        private string ToSHA1(string passWord) {
            passWord += "MadeByTLUer@Ti26";
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(passWord);
            bs = sha1.ComputeHash(bs);
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            foreach(byte b in bs) {
                s.Append(b.ToString("x1").ToLower());
            }
            passWord = s.ToString();
            return passWord;
        }
    }
}
