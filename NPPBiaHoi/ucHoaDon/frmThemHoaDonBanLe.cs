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
    public partial class frmThemHoaDonBanLe : DevExpress.XtraEditors.XtraForm
    {
        ucHoaDonBanLe aucHoaDonBanLe=null;
        public frmThemHoaDonBanLe()
        {
            InitializeComponent();
        }
        public frmThemHoaDonBanLe(ucHoaDonBanLe aucHoaDonBanLe)
        {
            try
            {
                this.aucHoaDonBanLe = aucHoaDonBanLe;
                InitializeComponent();
            }
            catch (Exception ex)
            {
                throw new Exception("frmThemHoaDonBanLe: " +ex.ToString());
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (aucHoaDonBanLe != null)
                {
                    aucHoaDonBanLe.Refresh();
                }
                this.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("btnLuu_Click: " + ex.ToString());
            }
        }
    }
}