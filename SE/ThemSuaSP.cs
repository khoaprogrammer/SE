using SE.TAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using SE.DAO;
using SE.BUS;

namespace SE
{
    enum FormType
    {
        ADD, EDIT
    }

    public partial class ThemSuaSP : Form
    {
        private FormType type;
        private SanPham sanpham;
        private SanPhamDAO spDAO;
        private ChiTietSanPhamDAO ctDAO;
        private ThongTinSanPhamDAO ttDAO;
        private LoaiSanPhamDAO loaiDAO;
        private SanPhamBUS spBUS;
        public ThemSuaSP()
        {
            InitializeComponent();
            this.sanpham = new SanPham();
            this.type = FormType.ADD;
            this.loaiDAO = new LoaiSanPhamDAO();
            this.spDAO = new SanPhamDAO();
        }

        public ThemSuaSP(SanPham sp)
        {
            InitializeComponent();
            this.type = FormType.EDIT;
            this.sanpham = sp;
            this.ctDAO = new ChiTietSanPhamDAO();
            this.ttDAO = new ThongTinSanPhamDAO();
            this.loaiDAO = new LoaiSanPhamDAO();
            this.spBUS = new SanPhamBUS();
            this.spDAO = new SanPhamDAO();
        }

        private void ThemSuaSP_Load(object sender, EventArgs e)
        {
            cbxLoaiSanPham.Items.AddRange(this.loaiDAO.GetDSLoaiSP().ToArray());
            if (this.type == FormType.EDIT)
            {
                lstvDSChiTiet.SetObjects(this.sanpham.ThongTinSanPhams);
                tbxMaSanPham.Text = this.sanpham.MaSP.ToString();
                tbxSoLuongTon.Text = this.sanpham.SoLuongTon.ToString();
                tbxTenSanPham.Text = this.sanpham.TenSP;
                int index = this.loaiDAO.GetDSLoaiSP().FindIndex(x => x.MaLoai == this.sanpham.MaLoai);
                cbxLoaiSanPham.SelectedIndex = index;
                btnHuy.Visible = false;
                btnLuu.Location = btnHuy.Location;
            }
            else
            {
                tbxMaSanPham.Text = (this.spDAO.GetDSSanPham().Count() + 1).ToString();
                tbxSoLuongTon.Text = "0";
                lstvDSChiTiet.SetObjects(null);
                groupChiTietSP.Enabled = false;
            }
        }

        private void lstvDSChiTiet_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ThongTinSanPham selected = lstvDSChiTiet.SelectedObject as ThongTinSanPham;
                tbxKichThuoc.Text = selected.KichThuoc;
                tbxMauSac.Text = selected.MauSac;
                tbxDonGia.Text = selected.DonGia.ToString();
                tbxSoLuongTon_CT.Text = selected.SoLuongTon.ToString();
            } catch (Exception)
            {

            }
        }

        private void btnThemChiTiet_Click(object sender, EventArgs e)
        {
            if (tbxKichThuoc.Text == "" || tbxMauSac.Text == "" || tbxDonGia.Text == "" || tbxSoLuongTon_CT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            

            SanPham updateSanPham = spDAO.GetSanPham(int.Parse(tbxMaSanPham.Text));
            ThongTinSanPham thongtin = spDAO.GetThongTinSP(updateSanPham, tbxMauSac.Text, tbxKichThuoc.Text);
            if (thongtin != null)
            {
                var result = MessageBox.Show("Chi tiết này đã tồn tại, bạn có muốn cập nhật số lượng không?", "Thêm chi tiết", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    thongtin.SoLuongTon += int.Parse(tbxSoLuongTon_CT.Text);
                    spDAO.SubmitChanges();
                }
            }
            else
            {
                thongtin = new ThongTinSanPham();
                thongtin.ChiTietSanPham = ctDAO.GetChiTietSP(tbxMauSac.Text, tbxKichThuoc.Text);
                thongtin.SoLuongTon = int.Parse(tbxSoLuongTon_CT.Text);
                thongtin.DonGia = decimal.Parse(tbxDonGia.Text);
                thongtin.SanPham = updateSanPham;
                ttDAO.AddThongTinSP(thongtin);
                ttDAO.SubmitChanges();
            }
            this.lstvDSChiTiet.SetObjects(spDAO.GetDSThongTinSP(updateSanPham));
            spBUS.UpdateSoLuongTon(updateSanPham);
            tbxSoLuongTon.Text = updateSanPham.SoLuongTon.ToString();
            lstvDSChiTiet.Focus();
            lstvDSChiTiet.SelectedIndex = 0;
        }

        private void btnSuaChiTiet_Click(object sender, EventArgs e)
        {
            if (tbxKichThuoc.Text == "" || tbxMauSac.Text == "" || tbxDonGia.Text == "" || tbxSoLuongTon_CT.Text == "")
            {
                return;
            }
            if (this.lstvDSChiTiet.SelectedObject == null)
            {
                return;
            }
            ThongTinSanPham selected = this.lstvDSChiTiet.SelectedObject as ThongTinSanPham;
            SanPham updateSanPham = this.spDAO.GetSanPham(this.sanpham.MaSP);
            bool keyChanged = (selected.MauSac != tbxMauSac.Text) || (selected.KichThuoc != tbxKichThuoc.Text);
            if (keyChanged)
            {
                MessageBox.Show("Không được sửa màu sắc, kích thước!");
                return;
            }
            ThongTinSanPham updateThongtin = this.spDAO.GetThongTinSP(updateSanPham, selected.MauSac, selected.KichThuoc);
            updateThongtin.DonGia = decimal.Parse(tbxDonGia.Text);
            updateThongtin.SoLuongTon = int.Parse(tbxSoLuongTon_CT.Text);
            this.spDAO.SubmitChanges();
            this.spBUS.UpdateSoLuongTon(updateSanPham);
            this.spDAO.SubmitChanges();
            this.tbxSoLuongTon.Text = this.sanpham.SoLuongTon.ToString();
            this.lstvDSChiTiet.SetObjects(updateSanPham.ThongTinSanPhams.ToList());
        }

        private void btnXoaChiTiet_Click(object sender, EventArgs e)
        {
            if (lstvDSChiTiet.SelectedIndex < 0)
            {
                return;
            }
            ThongTinSanPham selected = this.lstvDSChiTiet.SelectedObject as ThongTinSanPham;
            SanPham updateSanPham = this.spDAO.GetSanPham(this.sanpham.MaSP);
            var result = MessageBox.Show("Bạn có muốn xóa chi tiết này?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ThongTinSanPham deleteThongTin = this.spDAO.GetThongTinSP(updateSanPham, selected.MauSac, selected.KichThuoc);
                this.ttDAO.DeleteThongTinSP(deleteThongTin);
                this.ttDAO.SubmitChanges();
            }
            this.spBUS.UpdateSoLuongTon(updateSanPham);
            this.spDAO.SubmitChanges();
            this.tbxSoLuongTon.Text = this.sanpham.SoLuongTon.ToString();
            this.lstvDSChiTiet.SetObjects(updateSanPham.ThongTinSanPhams.ToList());
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThemSuaSP_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            LoaiSanPham selected = cbxLoaiSanPham.SelectedItem as LoaiSanPham;
            if (this.type == FormType.ADD)
            {
                this.sanpham.MaSP = int.Parse(tbxMaSanPham.Text);
                this.sanpham.TenSP = tbxTenSanPham.Text;
                this.sanpham.SoLuongTon = int.Parse(tbxSoLuongTon.Text);
                this.sanpham.LoaiSanPham = this.loaiDAO.GetLoaiSP(selected.MaLoai);
                this.spDAO.AddSanPham(this.sanpham);
                this.spDAO.SubmitChanges();
            }
            else
            {
                SanPham updateSanPham = this.spDAO.GetSanPham(this.sanpham.MaSP);
                updateSanPham.TenSP = tbxTenSanPham.Text;
                updateSanPham.SoLuongTon = int.Parse(tbxSoLuongTon.Text);
                updateSanPham.LoaiSanPham = this.loaiDAO.GetLoaiSP(selected.MaLoai);
                this.spDAO.SubmitChanges();
            }
            this.Close();
        }
    }
}
