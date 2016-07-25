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
    public partial class frmThemKhachHang : DevExpress.XtraEditors.XtraForm
    {
        List<NhomKhachHang> aListNhomKhachHang1 = new List<NhomKhachHang>();//luu tru nhom cho lue
        List<NhomKhachHang> aListNhomKhachHang2 = new List<NhomKhachHang>();//luu tru nhom cho grv
        private NhomKhachHangBO aNhomKhachHangBO = null;
        private ucKhachHang aucKhachHang;
        private string fileName = null;
        public frmThemKhachHang()
        {
            InitializeComponent();

        }

        public frmThemKhachHang(ucKhachHang auc)
        {
            aucKhachHang = auc;
            InitializeComponent();
            aNhomKhachHangBO = new NhomKhachHangBO();
            aListNhomKhachHang1 = aNhomKhachHangBO.SelectAll();
            aListNhomKhachHang1.RemoveAll(r => r.KichHoat == 0);
            lueNhomKhachHang.Properties.DataSource = aListNhomKhachHang1;

        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("btnHuy_click" + ex.ToString());
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                KhachHangBO aKhachHangBO = new KhachHangBO();
                KhachHang aKhachHang = new KhachHang();
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
                    int MaKH = aKhachHangBO.Insert(aKhachHang);
                    if (MaKH != -1)
                    {
                        NhomKhachHang_KhachHangBO aNhomKhachhang_KhachHangBO = new NhomKhachHang_KhachHangBO();
                        NhomKhachHang_KhachHang aNhomKhachHang_KhachHang = new NhomKhachHang_KhachHang();
                        
                        foreach (NhomKhachHang obj in aListNhomKhachHang2)
                        {
                            aNhomKhachHang_KhachHang = new NhomKhachHang_KhachHang();
                            aNhomKhachHang_KhachHang.MaKhachHang = MaKH;
                            aNhomKhachHang_KhachHang.MaNhomKhachHang = obj.Ma;
                            if(aNhomKhachhang_KhachHangBO.Insert(aNhomKhachHang_KhachHang))
                                MessageBox.Show("Thêm khách hàng vao nhom khach hang thành công.", "Thêm khách hàng", MessageBoxButtons.OK);
                            else
                            {
                                MessageBox.Show("co gi do sai sai", "Thêm khách hàng", MessageBoxButtons.OK);
                            }
                        }
                        MessageBox.Show("Thêm khách hàng thành công.", "Thêm khách hàng", MessageBoxButtons.OK);
                        aucKhachHang.ucKhachHang_Load(null, null);
                        this.Close();
                    }
                    else {
                        MessageBox.Show("Không thành công.", "Thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (aucKhachHang != null)
                    {
                        aucKhachHang.ucKhachHang_Load(null, null);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("btnLuu_Click" + ex.ToString());
            }
        }

        public void frmThemKhachHang_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw new Exception("frmThemKhachHang_Load" + ex.ToString());
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
                grdThemKhachHang.DataSource = aListNhomKhachHang2;
                grvThemKhachHang.RefreshData();
            }
            catch (Exception ex)
            {
                throw new Exception("btnThemNhomKhachHang_Click: " + ex.ToString());
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
                MessageBox.Show("frmThemSanPham.btnThemAnh_Click: " + ex.ToString());
            }
        }

        private void btnXoa_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            NhomKhachHang aNhomKhachHang = new NhomKhachHang();
            aNhomKhachHang = (NhomKhachHang)grvThemKhachHang.GetFocusedRow();
            if (aNhomKhachHang == null)
                return;
            aListNhomKhachHang2.Remove(aNhomKhachHang);
            aListNhomKhachHang1.Add(aNhomKhachHang);
            grvThemKhachHang.RefreshData();
        }
    }
}
