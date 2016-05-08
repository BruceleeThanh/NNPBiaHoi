﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DataAccess;
using BussinessLogic;

namespace NPPBiaHoi.ucPhuongTien
{
	public partial class frmThemPhuongTien: DevExpress.XtraEditors.XtraForm
	{
        ucPhuongTien aucPhuongTien;
        public frmThemPhuongTien(ucPhuongTien aucPhuongTien)
		{
            InitializeComponent();
		}

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                PhuongTien aPhuongTien = new PhuongTien();
                aPhuongTien.Ten = txtTen.Text;
                aPhuongTien.TaiTrong = int.Parse(txtTaiTrong.Text);
                aPhuongTien.BienSo = txtBienSo.Text;
                aPhuongTien.MieuTa = mmoMieuTa.Text;
                if (rdoLoai.EditValue.ToString() == "1")
                {
                    aPhuongTien.Loai = 1;
                }
                else
                {
                    aPhuongTien.Loai = 0;
                }
                if (chkDangHoatDong.Checked == true)
                {
                    aPhuongTien.KichHoat = 1;
                }
                else
                {
                    aPhuongTien.KichHoat = 0;
                }

                if (string.IsNullOrEmpty(txtTen.Text))
                    return;
                PhuongTienBO aPhuongTienBO = new PhuongTienBO();
                aPhuongTienBO.Insert(aPhuongTien);
                aucPhuongTien.ucPhuongTien_Load();
                this.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("btnLuu_Click" + ex.ToString());
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn muốn hủy!", "Thông báo..", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("btnHuy_Click" + ex.ToString());
            }
        }

        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                throw new Exception("btnThemAnh_Click" + ex.ToString());
            }
        }
    }
}