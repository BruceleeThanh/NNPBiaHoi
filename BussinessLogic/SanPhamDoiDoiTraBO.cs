﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using DataAccess;


namespace BussinessLogic {
    public partial class SanPhamDoiDoiTraBO {

        private DatabaseDA aDatabaseDA = new DatabaseDA();

        public List<SanPhamDoiDoiTra> SelectAll() {
            try {
                return aDatabaseDA.SanPhamDoiDoiTra.Where(c => c.ThungRac == 1).OrderByDescending(b => b.Ma).ToList();
            }
            catch(Exception ex) {
                throw new Exception("SanPhamDoiDoiTraBO.Select_All:" + ex.ToString());
            }
        }

        public SanPhamDoiDoiTra Select_ByMa(int ma) {
            try {
                return aDatabaseDA.SanPhamDoiDoiTra.Where(b => b.Ma == ma && b.ThungRac == 1).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("SanPhamDoiDoiTraBO.Select_ByMa:" + ex.ToString());
            }
        }

        public List<SanPhamDoiDoiTra> Select_ByMaSanPham(int maSanPham) {
            try {
                return aDatabaseDA.SanPhamDoiDoiTra.Where(b => b.MaSanPham == maSanPham && b.ThungRac == 1).ToList();
            }
            catch(Exception ex) {
                throw new Exception("SanPhamDoiDoiTraBO.Select_ByMaSanPham:" + ex.ToString());
            }
        }

        public List<SanPhamDoiDoiTra> Select_ByTrangThai(int trangThai) {
            try {
                return aDatabaseDA.SanPhamDoiDoiTra.Where(b => b.TrangThai == trangThai && b.ThungRac == 1).ToList();
            }
            catch(Exception ex) {
                throw new Exception("SanPhamDoiDoiTraBO.Select_ByTrangThai:" + ex.ToString());
            }
        }

        //public List<SanPhamDoiDoiTra> Select_ByThoiGianDemDi(DateTime thoiGianDemDi)

        //public List<SanPhamDoiDoiTra> Select_ByThoiGianNhanLai(DateTime thoiGianNhanLai)

        public List<SanPhamDoiDoiTra> SelectAll_Hidden() {
            try {
                return aDatabaseDA.SanPhamDoiDoiTra.Where(c => c.ThungRac == 2).OrderByDescending(b => b.Ma).ToList();
            }
            catch(Exception ex) {
                throw new Exception("SanPhamDoiDoiTraBO.SelectAll_Hidden:" + ex.ToString());
            }
        }

        public SanPhamDoiDoiTra Select_ByMa_Hidden(int ma) {
            try {
                return aDatabaseDA.SanPhamDoiDoiTra.Where(b => b.Ma == ma && b.ThungRac == 2).FirstOrDefault();
            }
            catch(Exception ex) {
                throw new Exception("SanPhamDoiDoiTraBO.Select_ByMa_Hidden:" + ex.ToString());
            }
        }

        public List<SanPhamDoiDoiTra> Select_ByMaSanPham_Hidden(int maSanPham) {
            try {
                return aDatabaseDA.SanPhamDoiDoiTra.Where(b => b.MaSanPham == maSanPham && b.ThungRac == 2).ToList();
            }
            catch(Exception ex) {
                throw new Exception("SanPhamDoiDoiTraBO.Select_ByMaSanPham_Hidden:" + ex.ToString());
            }
        }

        public List<SanPhamDoiDoiTra> Select_ByTrangThai_Hidden(int trangThai) {
            try {
                return aDatabaseDA.SanPhamDoiDoiTra.Where(b => b.TrangThai == trangThai && b.ThungRac == 2).ToList();
            }
            catch(Exception ex) {
                throw new Exception("SanPhamDoiDoiTraBO.Select_ByTrangThai_Hidden:" + ex.ToString());
            }
        }

        public bool Insert(SanPhamDoiDoiTra aSanPhamDoiDoiTra) {
            try {
                aSanPhamDoiDoiTra.ThungRac = 1;
                aDatabaseDA.SanPhamDoiDoiTra.Add(aSanPhamDoiDoiTra);
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("SanPhamDoiDoiTraBO.Insert: " + ex.ToString());
            }
        }

        public bool Update(SanPhamDoiDoiTra aSanPhamDoiDoiTra) {
            try {
                aDatabaseDA.SanPhamDoiDoiTra.AddOrUpdate(aSanPhamDoiDoiTra);
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception("SanPhamDoiDoiTraBO.Update: " + ex.ToString());
            }
        }

        public bool Delete(int ma) {
            try {
                SanPhamDoiDoiTra aSanPhamDoiDoiTra = this.Select_ByMa(ma);
                aSanPhamDoiDoiTra.ThungRac = 2;
                return this.Update(aSanPhamDoiDoiTra);
            }
            catch(Exception ex) {
                return false;
                throw new Exception("SanPhamDoiDoiTraBO.Delete: " + ex.ToString());
            }
        }
    }
}
