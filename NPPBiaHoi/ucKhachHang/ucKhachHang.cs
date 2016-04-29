using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace NPPBiaHoi.ucKhachHang
{
    public partial class ucKhachHang : DevExpress.XtraEditors.XtraUserControl
    {
        public ucKhachHang()
        {
            InitializeComponent();
        }

        private void grvKhachHang_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }
    }
}
