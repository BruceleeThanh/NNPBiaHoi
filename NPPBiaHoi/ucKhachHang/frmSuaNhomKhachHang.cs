using System;
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

namespace NPPBiaHoi.ucKhachHang
{
    public partial class frmSuaNhomKhachHang : DevExpress.XtraEditors.XtraForm
    {
        private NhomKhachHang aNhomKhachHang;
        
        private ucNhomKhachHang aucNhomKhachHang;
        public frmSuaNhomKhachHang()
        {
            InitializeComponent();
        }
        public frmSuaNhomKhachHang(int Ma, ucNhomKhachHang auc)
        {
            InitializeComponent();
            NhomKhachHangBO aNhomKhachHangBO = new NhomKhachHangBO();
            aNhomKhachHang = aNhomKhachHangBO.Select_ByMa(Ma);
            this.frmSuaNhomKhachHang_Load(null, null);
            aucNhomKhachHang = auc;
        }

        private void frmSuaNhomKhachHang_Load(object sender, EventArgs e)
        {
            try
            {
                txtTen.Text = aNhomKhachHang.Ten;
                mmoMoTa.Text = aNhomKhachHang.MieuTa;
                if (aNhomKhachHang.KichHoat == 1)
                {
                    chkDangQuanLy.Checked = true;
                } else if (aNhomKhachHang.KichHoat == 0)
                {
                    chkDangQuanLy.Checked = false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("frmSuaNhomKhachHang_Load: " + ex.ToString());
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                aNhomKhachHang.Ten = txtTen.Text;
                aNhomKhachHang.MieuTa = mmoMoTa.Text;
                if (chkDangQuanLy.Checked == true)
                {
                    aNhomKhachHang.KichHoat = 1;
                } else if (chkDangQuanLy.Checked == false)
                {
                    aNhomKhachHang.KichHoat = 0;
                }
                NhomKhachHangBO aNhomKhachHangBO = new NhomKhachHangBO();
            aNhomKhachHangBO.Update(aNhomKhachHang);
                if (aucNhomKhachHang != null)
                {
                    aucNhomKhachHang.ucNhomKhachHang_Load(null, null);
                }
                this.Close();
            }
            catch(Exception ex)
            {
                throw new Exception("btnLuu_Click:" + ex.ToString());
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("btnHuy_Click: " + ex.ToString());
            }
        }
    }
}