﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BussinessLogic;
namespace NPPBiaHoi {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            KhachHangBO aKhachHang = new KhachHangBO();
            gridControl1.DataSource = aKhachHang.SelectAll();
        }
    }
}
