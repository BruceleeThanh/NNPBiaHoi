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
                timeThoiGian.DateTime = Convert.ToDateTime(aChiPhiPhuongTien.ThoiGian);

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
                if (string.IsNullOrEmpty(txtTen.Text))
                {
                    MessageBox.Show("Tên chi phí không được để trống", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                if (string.IsNullOrEmpty(txtSoTien.Text))
                {
                    MessageBox.Show("Tiền phí không được để trống", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                aChiPhiPhuongTien.Ten = txtTen.Text;
                aChiPhiPhuongTien.TienPhi = float.Parse(txtSoTien.Text);
                aChiPhiPhuongTien.MieuTa = mmoMieuTa.Text;
                aChiPhiPhuongTien.ThoiGian = timeThoiGian.DateTime;

                aChiPhiPhuongTien.MaPhuongTien = int.Parse(luePhuongTien.GetColumnValue("Ma").ToString());

                if (aChiPhiPhuongTienBO.Update(aChiPhiPhuongTien) == true)
                {
                    MessageBox.Show("Sửa chi phí phương tiện thành công.", "Sửa chi phí phương tiện", MessageBoxButtons.OK);
                    aucChiPhiPhuongTien.ucChiPhiPhuongTien_Load();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Không thành công.", "Sửa chi phí phương tiện", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

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