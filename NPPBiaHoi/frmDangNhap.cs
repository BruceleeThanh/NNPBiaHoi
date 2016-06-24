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

namespace NPPBiaHoi {
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm {
        public frmDangNhap() {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e) {
            prgXinCho.Visible = true;
            TaiKhoanDangNhapBO aTaiKhonDangNhapBO = new TaiKhoanDangNhapBO();
            if(aTaiKhonDangNhapBO.Select_ByTenDangNhap_ByMatKhau(txtTenDangNhap.Text, txtMatKhau.Text)) {
                Form1 aForm1 = new Form1();
                aForm1.Show();
                this.Visible = false;
            }
            else {
                prgXinCho.Visible = false;
                MessageBox.Show("Sai tên đăng nhập hoặc mât khẩu.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e){
            if(e.KeyCode == Keys.Enter) {
                prgXinCho.Visible = true;
                TaiKhoanDangNhapBO aTaiKhonDangNhapBO = new TaiKhoanDangNhapBO();
                if(aTaiKhonDangNhapBO.Select_ByTenDangNhap_ByMatKhau(txtTenDangNhap.Text, txtMatKhau.Text)) {
                    Form1 aForm1 = new Form1();
                    aForm1.Show();
                    this.Visible = false;
                }
                else {
                    prgXinCho.Visible = false;
                    MessageBox.Show("Sai tên đăng nhập hoặc mât khẩu.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}