namespace SE
{
    using System;
    using System.Windows.Forms;
    using SE.BUS;
    using SE.DTO;

    public enum FormType
    {
        ADD, EDIT
    }

    public partial class ThemSuaSP : Form
    {
        private FormType type;
        private SanPhamDTO sanpham;
        private SanPhamBUS sanphamBUS;
        private LoaiSPBUS loaiBUS;
        private ChiTietSanPhamBUS ctspBUS;
        private ThongTinSPBUS ttspBUS;

        public ThemSuaSP()
        {
            this.InitializeComponent();
            this.sanpham = new SanPhamDTO();
            this.type = FormType.ADD;
            this.loaiBUS = new LoaiSPBUS();
            this.sanphamBUS = new SanPhamBUS();
        }

        public ThemSuaSP(SanPhamDTO sp)
        {
            this.InitializeComponent();
            this.type = FormType.EDIT;
            this.sanpham = sp;
            this.loaiBUS = new LoaiSPBUS();
            this.sanphamBUS = new SanPhamBUS();
            this.ctspBUS = new ChiTietSanPhamBUS();
            this.ttspBUS = new ThongTinSPBUS();
        }

        private void ThemSuaSP_Load(object sender, EventArgs e)
        {
            this.cbxLoaiSanPham.Items.AddRange(this.loaiBUS.GetDSLoaiSP().ToArray());
            if (this.type == FormType.EDIT)
            {
                this.lstvDSChiTiet.SetObjects(this.sanphamBUS.GetDSThongTinSP(this.sanpham.MaSP));
                this.tbxMaSanPham.Text = this.sanpham.MaSP.ToString();
                this.tbxSoLuongTon.Text = this.sanpham.SoLuongTon.ToString();
                this.tbxTenSanPham.Text = this.sanpham.TenSP;
                int index = this.loaiBUS.GetDSLoaiSP().FindIndex(x => x.MaLoai == this.sanpham.LoaiSP.MaLoai);
                this.cbxLoaiSanPham.SelectedIndex = index;
                this.btnHuy.Visible = false;
                this.btnLuu.Location = this.btnHuy.Location;
            }
            else
            {
                this.tbxMaSanPham.Text = (this.sanphamBUS.GetMaSPMax() + 1).ToString();
                this.tbxSoLuongTon.Text = "0";
                this.lstvDSChiTiet.SetObjects(null);
                this.groupChiTietSP.Enabled = false;
            }
        }

        private void ListDSChiTiet_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ThongTinSPDTO selected = (ThongTinSPDTO)this.lstvDSChiTiet.SelectedObject;
                this.tbxKichThuoc.Text = selected.KichThuoc;
                this.tbxMauSac.Text = selected.MauSac;
                this.tbxDonGia.Text = selected.DonGia.ToString();
                this.tbxSoLuongTonCT.Text = selected.SoLuongTon.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void ButtonThemChiTiet_Click(object sender, EventArgs e)
        {
            if (this.tbxKichThuoc.Text == string.Empty || this.tbxMauSac.Text == string.Empty || this.tbxDonGia.Text == string.Empty || this.tbxSoLuongTonCT.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            ThongTinSPDTO thongtin = this.sanphamBUS.GetThongTinSP(this.sanpham.MaSP, this.tbxMauSac.Text, this.tbxKichThuoc.Text);
            if (thongtin != null)
            {
                var result = MessageBox.Show("Chi tiết này đã tồn tại, bạn có muốn cập nhật số lượng không?", "Thêm chi tiết", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.sanphamBUS.TangSoLuongTon(this.sanpham.MaSP, thongtin.MauSac, thongtin.KichThuoc, int.Parse(this.tbxSoLuongTonCT.Text));
                }
            }
            else
            {
                thongtin = new ThongTinSPDTO();
                thongtin.MauSac = this.tbxMauSac.Text;
                thongtin.KichThuoc = this.tbxKichThuoc.Text;
                if (!this.ctspBUS.TonTaiChiTiet(thongtin.MauSac, thongtin.KichThuoc))
                {
                    this.ctspBUS.AddChiTietSP(thongtin.MauSac, thongtin.KichThuoc);
                }

                thongtin.SoLuongTon = int.Parse(this.tbxSoLuongTonCT.Text);
                thongtin.DonGia = decimal.Parse(this.tbxDonGia.Text);
                this.sanphamBUS.AddThongTinSanPham(this.sanpham.MaSP, thongtin);
            }

            this.sanphamBUS.TinhSoLuongTon(this.sanpham.MaSP);
            this.sanpham = this.sanphamBUS.GetSanPham(this.sanpham.MaSP);
            this.lstvDSChiTiet.SetObjects(this.sanphamBUS.GetDSThongTinSP(this.sanpham.MaSP));
            this.tbxSoLuongTon.Text = this.sanpham.SoLuongTon.ToString();
            this.lstvDSChiTiet.Focus();
            this.lstvDSChiTiet.SelectedIndex = 0;
        }

        private void ButtonSuaChiTiet_Click(object sender, EventArgs e)
        {
            if (this.tbxKichThuoc.Text == string.Empty || this.tbxMauSac.Text == string.Empty || this.tbxDonGia.Text == string.Empty || this.tbxSoLuongTonCT.Text == string.Empty)
            {
                return;
            }

            if (this.lstvDSChiTiet.SelectedObject == null)
            {
                return;
            }

            ThongTinSPDTO selected = (ThongTinSPDTO)this.lstvDSChiTiet.SelectedObject;
            bool keyChanged = (selected.MauSac != this.tbxMauSac.Text) || (selected.KichThuoc != this.tbxKichThuoc.Text);
            if (keyChanged)
            {
                MessageBox.Show("Không được sửa màu sắc, kích thước!");
                return;
            }

            this.sanphamBUS.EditThongTinSanPham(
                this.sanpham.MaSP, 
                new ThongTinSPDTO
            {
                MauSac = selected.MauSac,
                KichThuoc = selected.KichThuoc,
                DonGia = decimal.Parse(this.tbxDonGia.Text),
                SoLuongTon = int.Parse(this.tbxSoLuongTonCT.Text)
            });

            this.sanphamBUS.RefreshSanPham();
            this.sanphamBUS.TinhSoLuongTon(this.sanpham.MaSP);
            this.sanpham = this.sanphamBUS.GetSanPham(this.sanpham.MaSP);
            this.tbxSoLuongTon.Text = this.sanpham.SoLuongTon.ToString();
            this.lstvDSChiTiet.SetObjects(this.sanphamBUS.GetDSThongTinSP(this.sanpham.MaSP));
        }

        private void ButtonXoaChiTiet_Click(object sender, EventArgs e)
        {
            if (this.lstvDSChiTiet.SelectedIndex < 0)
            {
                return;
            }

            ThongTinSPDTO selected = (ThongTinSPDTO)this.lstvDSChiTiet.SelectedObject;
            var result = MessageBox.Show("Bạn có muốn xóa chi tiết này?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.ttspBUS.DeleteThongTinSP(this.sanpham.MaSP, selected.MauSac, selected.KichThuoc);
            }

            this.sanphamBUS.RefreshSanPham();
            this.sanphamBUS.TinhSoLuongTon(this.sanpham.MaSP);
            this.sanpham = this.sanphamBUS.GetSanPham(this.sanpham.MaSP);
            this.tbxSoLuongTon.Text = this.sanpham.SoLuongTon.ToString();
            this.sanpham = this.sanphamBUS.GetSanPham(this.sanpham.MaSP);
            this.lstvDSChiTiet.SetObjects(this.sanpham.DSThongTin);
        }

        private void ButtonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonLuu_Click(object sender, EventArgs e)
        {
            LoaiSPDTO selected = (LoaiSPDTO)this.cbxLoaiSanPham.SelectedItem;
            if (this.type == FormType.ADD)
            {
                this.sanphamBUS.AddSanPham(new SanPhamDTO
                {
                    MaSP = int.Parse(this.tbxMaSanPham.Text),
                    TenSP = this.tbxTenSanPham.Text,
                    LoaiSP = selected,
                    SoLuongTon = int.Parse(this.tbxSoLuongTon.Text)
                });
            }
            else
            {
                this.sanphamBUS.EditSanPham(new SanPhamDTO
                {
                    MaSP = this.sanpham.MaSP,
                    LoaiSP = selected,
                    TenSP = this.tbxTenSanPham.Text,
                    SoLuongTon = int.Parse(this.tbxSoLuongTon.Text)
                });
            }

            this.Close();
        }
    }
}
