using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace NPPBiaHoi.ucHoaDon
{
    public partial class frmSuaHoaDonBanLe : DevExpress.XtraEditors.XtraForm
    {
        ucHoaDonBanLe aucHoaDonBanLe = null;
        public frmSuaHoaDonBanLe()
        {
            InitializeComponent();
        }

        public frmSuaHoaDonBanLe(ucHoaDonBanLe auc)
        {
            this.aucHoaDonBanLe = auc;
            InitializeComponent();
        }
    }
}