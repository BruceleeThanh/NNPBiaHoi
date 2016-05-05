using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BussinessLogic;
using DataAccess;
using NPPBiaHoi.ucNhanVien;

namespace NPPBiaHoi {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucNhanVien.ucNhanVien aNhanVien = new ucNhanVien.ucNhanVien();
            aNhanVien.Dock = DockStyle.Bottom;
            this.Controls.Add(aNhanVien);
        }
    }
}
