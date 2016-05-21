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

namespace NPPBiaHoi.ucPhuongTien
{
    public partial class frmThemChiPhiPhuongTien : DevExpress.XtraEditors.XtraForm
    {
        ucChiPhiPhuongTien aucChiPhiPhuongTien;
        List<PhuongTien> aListPhuongTien = new List<PhuongTien>();
        public frmThemChiPhiPhuongTien(ucChiPhiPhuongTien aucChiPhiPhuongTien)
        {
            InitializeComponent();
            DanhSachTenPhuongTien_Load();
            this.aucChiPhiPhuongTien = aucChiPhiPhuongTien;
        }

        public void DanhSachTenPhuongTien_Load()
        {
            PhuongTienBO aPhuongTienBO = new PhuongTienBO();
            aListPhuongTien = aPhuongTienBO.SelectAll();
            luePhuongTien.Properties.DataSource = aListPhuongTien;
            luePhuongTien.Properties.ValueMember = "Ten";
            luePhuongTien.Properties.DisplayMember = "Ten";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                ChiPhiPhuongTien aChiPhiPhuongTien = new ChiPhiPhuongTien();
                aChiPhiPhuongTien.Ten = txtTen.Text;
                aChiPhiPhuongTien.TienPhi = int.Parse(txtSoTien.Text);
                aChiPhiPhuongTien.MieuTa = mmoMieuTa.Text;
                aChiPhiPhuongTien.ThoiGian = timeThoiGian.DateTime;
                
                aChiPhiPhuongTien.MaPhuongTien = int.Parse(luePhuongTien.GetColumnValue("Ma").ToString());
                
                ChiPhiPhuongTienBO aChiPhiPhuongTienBO = new ChiPhiPhuongTienBO();
                aChiPhiPhuongTienBO.Insert(aChiPhiPhuongTien);
                aucChiPhiPhuongTien.ucChiPhiPhuongTien_Load();
                this.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("btnLuu_Click" + ex.ToString());
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn muốn hủy!", "Thông báo..", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("btnHuy_Click" + ex.ToString());
            }
        }
    }
}