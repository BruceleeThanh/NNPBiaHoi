using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DataAccess;
using BussinessLogic;

namespace NPPBiaHoi.ucNhanVien
{
    public partial class ucNhanVien : DevExpress.XtraEditors.XtraUserControl
    {
        List<NhanVien> aListNhanVien = new List<NhanVien>();
        public ucNhanVien()
        {
            InitializeComponent();
        }

        public void ucNhanVien_Load()
        {
            NhanVienBO aNhanVienBO = new NhanVienBO();
            aListNhanVien = aNhanVienBO.SelectAll();
            grdNhanVien.DataSource = aListNhanVien;
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            frmThemNhanVien afrmThemNhanVien = new frmThemNhanVien();
            afrmThemNhanVien.ShowDialog();
        }
    }
}
