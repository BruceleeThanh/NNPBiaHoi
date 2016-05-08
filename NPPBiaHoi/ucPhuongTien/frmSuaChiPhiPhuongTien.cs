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
    public partial class frmSuaChiPhiPhuongTien : DevExpress.XtraEditors.XtraForm
    {
        ucChiPhiPhuongTien aucChiPhiPhuongTien;
        ChiPhiPhuongTien aChiPhiPhuongTien;
        ChiPhiPhuongTienBO aChiPhiPhuongTienBO;
        List<PhuongTien> aListPhuongTien = new List<PhuongTien>();
        public frmSuaChiPhiPhuongTien(int ma, ucChiPhiPhuongTien aucChiPhiPhuongTien)
        {
            InitializeComponent();
            this.aucChiPhiPhuongTien = aucChiPhiPhuongTien;
            DanhSachTenPhuongTien_Load();
            frmSuaChiPhiPhuongTien_Load(ma);
        }

        public void DanhSachTenPhuongTien_Load()
        {
            PhuongTienBO aPhuongTienBO = new PhuongTienBO();
            aListPhuongTien = aPhuongTienBO.SelectAll();
            luePhuongTien.Properties.DataSource = aListPhuongTien;
            luePhuongTien.Properties.ValueMember = "Ten";
            luePhuongTien.Properties.DisplayMember = "Ten";
        }

        public void frmSuaChiPhiPhuongTien_Load(int ma)
        {
            try
            {
                aChiPhiPhuongTienBO = new ChiPhiPhuongTienBO();
                aChiPhiPhuongTien = aChiPhiPhuongTienBO.Select_ByMa(ma);
                txtTen.Text = aChiPhiPhuongTien.Ten;
                txtSoTien.Text = aChiPhiPhuongTien.TienPhi.ToString();
                mmoMieuTa.Text = aChiPhiPhuongTien.MieuTa;
                //timeThoiGian.DateTime = Convert.ToDateTime(aChiPhiPhuongTien.ThoiGian.ToString());

                PhuongTien aPhuongTien = new PhuongTien();
                PhuongTienBO aPhuongTienBO = new PhuongTienBO();
                aPhuongTien = aPhuongTienBO.Select_ByMa(aChiPhiPhuongTien.MaPhuongTien);
                luePhuongTien.EditValue = aPhuongTien.Ten;

            }
            catch (Exception ex)
            {
                throw new Exception("frmSuaChiPhiPhuongTien_Load" + ex.ToString());
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                ChiPhiPhuongTien aChiPhiPhuongTien = new ChiPhiPhuongTien();
                aChiPhiPhuongTien.Ten = txtTen.Text;
                aChiPhiPhuongTien.TienPhi = int.Parse(txtSoTien.Text);
                aChiPhiPhuongTien.MieuTa = mmoMieuTa.Text;
                //aChiPhiPhuongTien.ThoiGian = int.Parse(timeThoiGian.DateTime.ToString());

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