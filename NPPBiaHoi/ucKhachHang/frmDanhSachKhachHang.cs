using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BussinessLogic;
using DataAccess;

namespace NPPBiaHoi.ucKhachHang
{
    public partial class frmDanhSachKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public frmDanhSachKhachHang(int ma)
        {
            InitializeComponent();
            List<KhachHang> aListKhachHang = new List<KhachHang>();
            KhachHangBO aKhachHangBO = new KhachHangBO();
            NhomKhachHang_KhachHangBO aNhomKhachHang_KhachHangBO = new NhomKhachHang_KhachHangBO();
            aListKhachHang = aNhomKhachHang_KhachHangBO.SelectKhachHang_ByMaNhomKhachHang(ma);
            grdDanhSachKhachHang.DataSource = aListKhachHang;

        }
    }
}