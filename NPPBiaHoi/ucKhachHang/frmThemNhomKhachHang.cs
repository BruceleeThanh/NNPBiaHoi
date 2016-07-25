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
    public partial class frmThemNhomKhachHang : DevExpress.XtraEditors.XtraForm
    {
       // private NhomKhachHang aNhomKhachHang = new NhomKhachHang();
        private ucNhomKhachHang aucNhomKhachHang;
        public frmThemNhomKhachHang()
        {
            InitializeComponent();
        }
        public frmThemNhomKhachHang(ucNhomKhachHang auc)
        {
            aucNhomKhachHang = auc;
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                NhomKhachHang aNhomKhachHang = new NhomKhachHang();
                NhomKhachHangBO aNhomKhachHangBO = new NhomKhachHangBO();
                aNhomKhachHang.Ten = txtTen.Text;
                aNhomKhachHang.MieuTa = mmoMoTa.Text.ToString();
                if (chkDangQuanLy.Checked == true)
                {
                    aNhomKhachHang.KichHoat = 1;
                } else if (chkDangQuanLy.Checked == false)
                {
                    aNhomKhachHang.KichHoat = 0;
                }
                aNhomKhachHangBO.Insert(aNhomKhachHang);
                
                if (aucNhomKhachHang != null)
                {
                    aucNhomKhachHang.ucNhomKhachHang_Load(null, null);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("btnLuu_Click: " + ex.ToString());
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