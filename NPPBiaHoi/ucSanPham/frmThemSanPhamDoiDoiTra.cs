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

namespace NPPBiaHoi.ucSanPham
{
    public partial class frmThemSanPhamDoiDoiTra : DevExpress.XtraEditors.XtraForm
    {
        List<SanPham> aListSanPham = new List<SanPham>();

        public frmThemSanPhamDoiDoiTra()
        {
            InitializeComponent();
            this.frmThemSanPhamDoiDoiTra_Load();
        }

        public void frmThemSanPhamDoiDoiTra_Load() {
            SanPhamBO aSanPhamBO = new SanPhamBO();
            aListSanPham = aSanPhamBO.SelectAll();
            lueTenSanPham.Properties.DataSource = aListSanPham;
            lueTenSanPham.Properties.ValueMember = "Ma";
            lueTenSanPham.Properties.DisplayMember = "Ten";
            dateThoiGianDemDi.DateTime = DateTime.Now;
            dateThoiGianNhanLai.DateTime = DateTime.Now;
        }
    }
}