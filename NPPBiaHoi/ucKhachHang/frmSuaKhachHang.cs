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

namespace NPPBiaHoi.ucKhachHang
{
    public partial class frmSuaKhachHang : DevExpress.XtraEditors.XtraForm
    {
        List<NhomKhachHang> aListNhomKhachHang1 = new List<NhomKhachHang>();//luu tru nhom cho lue
        List<NhomKhachHang> aListNhomKhachHang2 = new List<NhomKhachHang>();//luu tru nhom cho grv
        List<NhomKhachHang> aListNhomKhachHang3 = new List<NhomKhachHang>();//luu tru nhom cho grv de hidden toàn bộ
        private NhomKhachHangBO aNhomKhachHangBO = null;
        private KhachHang aKhachHang = null;
        private KhachHangBO aKhachHangBO;
        private ucKhachHang aucKhachHang;
        private string fileName = null;

        public frmSuaKhachHang(int Ma)
        {
            try
            {
                InitializeComponent();
                aKhachHangBO = new KhachHangBO();
                aKhachHang = aKhachHangBO.Select_ByMa(Ma);
                ConvertImage aConvertImage = new ConvertImage();
                txtTen.Text = aKhachHang.Ten;
                txtSoDienThoai.Text = aKhachHang.SoDienThoai;
                txtKhoangCach.Text = aKhachHang.KhoangCach.ToString();
                txtChuCuaHang.Text = aKhachHang.TenChuCuaHang;
                txtDiaChi.Text = aKhachHang.DiaChi;
                txtEmail.Text = aKhachHang.Email;
                mmoHoTroDauTu.Text = aKhachHang.GhiChuDauTu;
                mmoGhiChu.Text = aKhachHang.GhiChu;
                if (aKhachHang.HinhAnh != null)
                {
                    picAnh.Image = aConvertImage.ConvertByteToImage(aKhachHang.HinhAnh);
                }
                if (aKhachHang.KichHoat == 1)
                {
                    chkDangQuanLy.Checked = true;
                }
                else
                {
                    chkDangQuanLy.Checked = false;
                }
                NhomKhachHang_KhachHangBO aNhomKhachHang_KhachHangBO = new NhomKhachHang_KhachHangBO();
                grdSuaKhachHang.DataSource = aNhomKhachHang_KhachHangBO.SelectNhomKhachHang_ByMaKhachHang(Ma);
            }
            catch (Exception ex)
            {
                throw new Exception("frmSuaKhachHang: " + ex.ToString());
            }
        }

        public frmSuaKhachHang(int Ma, ucKhachHang auc)
        {
            this.aucKhachHang = auc;
            InitializeComponent();
            aKhachHangBO = new KhachHangBO();
            aNhomKhachHangBO = new NhomKhachHangBO();
            aKhachHang = aKhachHangBO.Select_ByMa(Ma);
            ConvertImage aConvertImage = new ConvertImage();
            txtTen.Text = aKhachHang.Ten;
            txtSoDienThoai.Text = aKhachHang.SoDienThoai;
            txtKhoangCach.Text = aKhachHang.KhoangCach.ToString();
            txtChuCuaHang.Text = aKhachHang.TenChuCuaHang;
            txtDiaChi.Text = aKhachHang.DiaChi;
            txtEmail.Text = aKhachHang.Email;
            mmoHoTroDauTu.Text = aKhachHang.GhiChuDauTu;
            mmoGhiChu.Text = aKhachHang.GhiChu;
            if (aKhachHang.HinhAnh != null)
            {
                picAnh.Image = aConvertImage.ConvertByteToImage(aKhachHang.HinhAnh);
            }
            if (aKhachHang.KichHoat == 1)
            {
                chkDangQuanLy.Checked = true;
            }
            else
            {
                chkDangQuanLy.Checked = false;
            }
            NhomKhachHang_KhachHangBO aNhomKhachHang_KhachHangBO = new NhomKhachHang_KhachHangBO();
            aListNhomKhachHang1 = aNhomKhachHangBO.SelectAll();
            aListNhomKhachHang1.RemoveAll(r => r.KichHoat == 0);
            aListNhomKhachHang2 = aNhomKhachHang_KhachHangBO.SelectNhomKhachHang_ByMaKhachHang(Ma);
            foreach (NhomKhachHang obj in aListNhomKhachHang2)
            {
                aListNhomKhachHang1.Remove(aListNhomKhachHang1.Where(b=>b.Ma == obj.Ma).First());
                //@#bug: vẫn không remove được. @#done
            }
            grdSuaKhachHang.DataSource = aListNhomKhachHang2;
            aListNhomKhachHang3.AddRange(aListNhomKhachHang2);
            lueNhomKhachHang.Properties.DataSource = aListNhomKhachHang1;
        }
        public void frmSuaKhachHang_Load(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                throw new Exception("frmSuaKhachHang_Load: " + ex.ToString());
            }
        }

        private void btnThemNhomKhachHang_Click(object sender, EventArgs e)
        {
            try
            {
                NhomKhachHang aNhomKhachHang = new NhomKhachHang();
                aNhomKhachHang = (NhomKhachHang)lueNhomKhachHang.GetSelectedDataRow();
                if (aNhomKhachHang == null)
                    return;
                aListNhomKhachHang1.Remove(aNhomKhachHang);
                aListNhomKhachHang2.Add(aNhomKhachHang);
                lueNhomKhachHang.Properties.DataSource = aListNhomKhachHang1;
                grdSuaKhachHang.DataSource = aListNhomKhachHang2;
                grvSuaKhachHang.RefreshData();
            }
            catch (Exception ex)
            {
                throw new Exception("btnThemNhomKhachHang_Click: " + ex.ToString());
            }
        }

        private void chkDangQuanLy_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                KhachHangBO aKhachHangBO = new KhachHangBO();
                //KhachHang aKhachHang = new KhachHang();
                ConvertImage aConvertImage = new ConvertImage();
                if (string.IsNullOrEmpty(txtTen.Text))
                {
                    MessageBox.Show("Bắt buộc Bạn phải nhập tên khách hàng, vui lòng nhập lại.", "Thông báo..", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {
                    aKhachHang.Ten = txtTen.Text;
                    aKhachHang.TenChuCuaHang = txtChuCuaHang.Text;
                    aKhachHang.SoDienThoai = txtSoDienThoai.Text;
                    aKhachHang.DiaChi = txtDiaChi.Text;
                    aKhachHang.Email = txtEmail.Text;
                    if (fileName != null)
                    {
                        aKhachHang.HinhAnh = aConvertImage.ConvertImagePathToByte(fileName);
                    }
                    aKhachHang.KhoangCach = !string.IsNullOrEmpty(txtKhoangCach.Text) ? double.Parse(txtKhoangCach.Text.ToString()) : 0;
                    aKhachHang.GhiChuDauTu = mmoHoTroDauTu.Text;
                    aKhachHang.GhiChu = mmoGhiChu.Text;
                    if (chkDangQuanLy.Checked == true)
                        aKhachHang.KichHoat = 1;
                    else {
                        aKhachHang.KichHoat = 0;
                    }
                    int MaKH = aKhachHangBO.Update(aKhachHang);
                    if (MaKH != -1)
                    {
                        NhomKhachHang_KhachHangBO aNhomKhachhang_KhachHangBO = new NhomKhachHang_KhachHangBO();
                        NhomKhachHang_KhachHang aNhomKhachHang_KhachHang = new NhomKhachHang_KhachHang();

                        // @#temp: xem xét có cần thiết phải xóa hết quan hệ trc k? @#done vì đằng nào cũng xét 2 phía
                        foreach (NhomKhachHang obj in aListNhomKhachHang3)
                        {
                            aNhomKhachHang_KhachHang = new NhomKhachHang_KhachHang();
                            aNhomKhachHang_KhachHang.MaKhachHang = MaKH;
                            aNhomKhachHang_KhachHang.MaNhomKhachHang = obj.Ma;
                            aNhomKhachHang_KhachHang.ThungRac = 2;                  // thùng rác bằng 2 để xóa quan hệ
                            
                            if (!aNhomKhachhang_KhachHangBO.Update(aNhomKhachHang_KhachHang))
                            {
                                MessageBox.Show("Có lỗi, không cập nhật được quan hệ.", "Sửa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        foreach (NhomKhachHang obj in aListNhomKhachHang2)
                        {
                            aNhomKhachHang_KhachHang = new NhomKhachHang_KhachHang();
                            aNhomKhachHang_KhachHang.MaKhachHang = MaKH;
                            aNhomKhachHang_KhachHang.MaNhomKhachHang = obj.Ma;
                            aNhomKhachHang_KhachHang.ThungRac = 1;

                            // @#temp: in ra thông báo, không cần thiết @#done
                            if (!aNhomKhachhang_KhachHangBO.Update(aNhomKhachHang_KhachHang))
                            {
                                MessageBox.Show("Có lỗi, không cập nhật được quan hệ.", "Sửa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        MessageBox.Show("Sửa khách hàng thành công.", "Sửa khách hàng", MessageBoxButtons.OK);
                        aucKhachHang.ucKhachHang_Load(null, null);
                        this.Close();
                    }
                    else {
                        MessageBox.Show("Không thành công.", "Sửa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (aucKhachHang != null)
                    {
                        aucKhachHang.ucKhachHang_Load(null, null);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("btnLuu_Click: " + ex.ToString());
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("btnHuy_Click: " + ex.ToString());
            }
        }

        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fileDiaLog = new OpenFileDialog();
                fileDiaLog.Title = "Chọn ảnh sản phẩm";
                fileDiaLog.Filter = "JPG|*.jpg|PNG|*.png|GIF|*.gif";
                fileDiaLog.Multiselect = false;
                if (fileDiaLog.ShowDialog() == DialogResult.OK)
                {
                    fileName = fileDiaLog.FileName;
                    picAnh.Image = Image.FromFile(fileDiaLog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("frmSuaSanPham.btnThemAnh_Click: " + ex.ToString());
            }
        }

        private void btnXoa_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            NhomKhachHang aNhomKhachHang = new NhomKhachHang();
            aNhomKhachHang = (NhomKhachHang)grvSuaKhachHang.GetFocusedRow();
            if (aNhomKhachHang == null)
                return;
            aListNhomKhachHang2.Remove(aNhomKhachHang);
            aListNhomKhachHang1.Add(aNhomKhachHang);
            grvSuaKhachHang.RefreshData();
        }
    }
}