namespace SE
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using BrightIdeasSoftware;
    using BUS;
    using CrystalDecisions.CrystalReports.Engine;
    using DTO;

    public partial class Form1 : Form
    {
        private int filterStep;
        private bool isOK;
        private LoaiSPBUS loaiBUS;
        private GioHangBUS giohangBUS;
        private HoaDonBUS hoadonBUS;
        private NhanVienBUS nhanvienBUS;
        private TaiKhoanBUS taikhoanBUS;
        private SanPhamBUS sanphamBUS;
        private GioHangDTO giohang;

        public Form1()
        {
            this.InitializeComponent();
            this.filterStep = 0;
            this.isOK = true;
            this.loaiBUS = new LoaiSPBUS();
            this.giohangBUS = new GioHangBUS();
            this.hoadonBUS = new HoaDonBUS();
            this.nhanvienBUS = new NhanVienBUS();
            this.taikhoanBUS = new TaiKhoanBUS();
            this.sanphamBUS = new SanPhamBUS();
            this.giohang = new GioHangDTO();
        }

        private object OLVColImageGetter(object obj)
        {
            NhanVienDTO nv = (NhanVienDTO)obj;
            if (nv.ChucVu == "Quản lý")
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private void GetSanPhamGroupImgs()
        {
            this.imgGroup.Images.Clear();
            Image img;
            var danhsachLoaiSP = this.loaiBUS.GetDSLoaiSP();
            foreach (var loai in danhsachLoaiSP)
            {
                img = this.loaiBUS.GetImage(loai.MaLoai);
                if (img != null)
                {
                    this.imgGroup.Images.Add(loai.MaLoai.ToString(), img);
                }
            }
        }

        private void TinhTongTienGioHang()
        {
            decimal tongTruocThue = this.giohangBUS.TinhTongTruocThue(this.giohang);
            decimal tongThue = this.giohangBUS.TinhTongTienThue(this.giohang);
            decimal tongSauThue = this.giohangBUS.TinhTongTienSauThue(this.giohang);
            this.lbeTongTienTruocThue.Text = tongTruocThue.ToString("#,#") + " VNĐ";
            this.lbeTongTienThue.Text = tongThue.ToString("#,#") + " VNĐ";
            this.lbeTongTienSauThue.Text = tongSauThue.ToString("#,#") + " VNĐ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //// DANG NHAP -----------------------------------------------------------------
            DangNhap dangnhap = new DangNhap();
            dangnhap.ShowDialog();

            if (Global.NguoiSuDung == null)
            {
                Application.Exit();
            }

            //// PHAN QUYEN -----------------------------------------------------------------
            if (Global.NguoiSuDung.ChucVu.Equals("Nhân viên"))
            {
                this.tabMain.TabPages.Remove(this.tabMain.TabPages["tabQLNV"]);
                this.tabMain.TabPages.Remove(this.tabMain.TabPages["tabQLSP"]);
            }

            //// KHOI TAO DU LIEU -----------------------------------------------------------------
            this.Width = 858;
            this.Height = 527;
            Global.Thue = 10;
            this.tenNVToolStripMenuItem.Text = Global.NguoiSuDung.HoTen;
            this.lstvNhanVien.ShowGroups = true;
            this.lstvNhanVien.AlwaysGroupByColumn = this.lstColChucVu;
            this.lstvNhanVien.SetObjects(this.nhanvienBUS.GetDSNhanVien());
            this.lstColMaNV.ImageGetter += new BrightIdeasSoftware.ImageGetterDelegate(this.OLVColImageGetter);

            //// QUAN LY SAN PHAM -----------------------------------------------------------------
            var arrLoaiSP = this.loaiBUS.GetDSLoaiSP().ToArray();

            this.cbxLoaiSP.Items.AddRange(arrLoaiSP);
            this.cbxLoaiSP.SelectedIndex = 0;

            this.GetSanPhamGroupImgs();

            this.lstvSanPham.ShowGroups = true;
            this.lstvSanPhamColLoaiSP.GroupFormatter += delegate(OLVGroup group, GroupingParameters parms)
            {
                string key = (string)group.Key;
                group.TitleImage = this.loaiBUS.GetLoaiSP(key).MaLoai.ToString();
            };

            this.lstvSanPham.AlwaysGroupByColumn = this.lstvSanPhamColLoaiSP;
            this.lstvSanPhamColTinhTrang.AspectToStringConverter = delegate(object x)
            {
                return string.Empty;
            };

            this.lstvSanPham.SetObjects(this.sanphamBUS.GetDSSanPham());

            this.lstvSanPhamColTinhTrang.ImageGetter = delegate(object x)
            {
                var sp = (SanPhamDTO)x;
                if (sp.SoLuongTon == 0)
                {
                    return "outofstock";
                }
                else
                {
                    return "available";
                }
            };

            //// QUAN LY HOA DON -----------------------------------------------------------------

            this.lstvHoaDon.SetObjects(this.hoadonBUS.GetDSHoaDon());
            this.cbxNhanVienLap.Items.AddRange(this.nhanvienBUS.GetDSNhanVien().ToArray());
            this.lstvHoaDonColMaHD.ImageGetter = delegate(object x)
            {
                return "hoadon";
            };

            this.lstvHoaDon.CellToolTipShowing += new EventHandler<ToolTipShowingEventArgs>(delegate(object send, ToolTipShowingEventArgs args) 
            {
                args.Title = "Danh sách sản phẩm";
                HoaDonDTO hoadon = (HoaDonDTO)args.Model;
                args.StandardIcon = ToolTipControl.StandardIcons.Info;
                args.Font = new Font("Courier new", 8);
                args.Text = this.hoadonBUS.GetToolTipText(hoadon);
            });

            //// BAN HANG -----------------------------------------------------------------

            this.lbeMaHoaDon.Text = (this.hoadonBUS.GetMaHDMax() + 1).ToString();
            this.lbeNhanVienLap.Text = Global.NguoiSuDung.HoTen;
            this.lbeNgayLap.Text = DateTime.Today.ToString("dd/MM/yyyy");
            this.cbxLoaiSPTabBanHang.Items.AddRange(this.loaiBUS.GetDSLoaiSP().ToArray());
        }

        private void ListNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                NhanVienDTO selected = (NhanVienDTO)this.lstvNhanVien.SelectedObject;
                this.tbxMaNV.Text = selected.MaNV.ToString();
                if (selected.ChucVu.Equals("Quản lý"))
                {
                    this.cbxChucVu.SelectedIndex = 0;
                }
                else
                {
                    this.cbxChucVu.SelectedIndex = 1;
                }

                this.tbxHoTen.Text = selected.HoTen;
                this.tbxDiaChi.Text = selected.DiaChi;
                this.tbxCMND.Text = selected.CMND;
                this.tbxLuongCB.Text = selected.LuongCoBan.ToString("#,#");
                this.tbxNoiLamViec.Text = selected.NoiLamViec;
                this.dtpickNgaySinh.Value = selected.NgaySinh;
                this.dtpickNgayTD.Value = selected.NgayTuyenDung;
                this.tbxUsername.Text = selected.TaiKhoan.Username;
                this.tbxPassword.Text = selected.TaiKhoan.Password;
            }
            catch (Exception)
            {
            }
        }

        private void ButtonThemNhanVien_Click(object sender, EventArgs e)
        {
            int masoNV = this.nhanvienBUS.GetMaNVMax() + 1;
            string chucvu = this.cbxChucVu.SelectedItem.ToString();
            string tenNV = this.tbxHoTen.Text;
            DateTime ngaysinh = this.dtpickNgaySinh.Value;
            string diachi = this.tbxDiaChi.Text;
            string cmnd = this.tbxCMND.Text;
            decimal luongCB = decimal.Parse(this.tbxLuongCB.Text);
            DateTime ngayTD = this.dtpickNgayTD.Value;
            string noiLV = this.tbxNoiLamViec.Text;
            string username = this.tbxUsername.Text;
            string password = this.tbxPassword.Text;
            if (this.taikhoanBUS.TonTaiTaiKhoan(username))
            {
                MessageBox.Show("Tài khoản này đã được áp cho nhân viên khác!");
                return;
            }
            else
            {
                TaiKhoanDTO addTaiKhoan = new TaiKhoanDTO()
                {
                    Username = username,
                    Password = password
                };
                this.taikhoanBUS.AddTaiKhoan(addTaiKhoan);
            }

            NhanVienDTO addNhanVien = new NhanVienDTO()
            {
                MaNV = masoNV,
                ChucVu = chucvu,
                HoTen = tenNV,
                NgaySinh = ngaysinh,
                DiaChi = diachi,
                CMND = cmnd,
                LuongCoBan = luongCB,
                NgayTuyenDung = ngayTD,
                NoiLamViec = noiLV,
                TaiKhoan = new TaiKhoanDTO
                {
                    Username = username,
                    Password = password
                }
            };

            this.nhanvienBUS.AddNhanVien(addNhanVien);
            this.lstvNhanVien.SetObjects(this.nhanvienBUS.GetDSNhanVien());
        }

        private void ButtonXoaNhanVien_Click(object sender, EventArgs e)
        {
            if (this.lstvNhanVien.SelectedObject == null)
            {
                return;
            }

            NhanVienDTO selected = (NhanVienDTO)this.lstvNhanVien.SelectedObject;
            var result = MessageBox.Show(string.Format("Bạn có chắc chắn muốn xóa nhân viên\n{0}\nkhông?", selected.HoTen), "Xóa nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.nhanvienBUS.DeleteNhanVien(selected.MaNV);
                this.taikhoanBUS.DeleteTaiKhoan(selected.TaiKhoan.Username);
            }

            this.lstvNhanVien.SetObjects(this.nhanvienBUS.GetDSNhanVien());
        }

        private void ButtonSuaNhanVien_Click(object sender, EventArgs e)
        {
            if (this.lstvNhanVien.SelectedObject == null)
            {
                return;
            }

            NhanVienDTO updateNhanVien = this.nhanvienBUS.GetNhanVien(int.Parse(this.tbxMaNV.Text));
            updateNhanVien.ChucVu = this.cbxChucVu.SelectedItem.ToString();
            updateNhanVien.HoTen = this.tbxHoTen.Text;
            updateNhanVien.NgaySinh = this.dtpickNgaySinh.Value;
            updateNhanVien.DiaChi = this.tbxDiaChi.Text;
            updateNhanVien.CMND = this.tbxCMND.Text;
            updateNhanVien.LuongCoBan = decimal.Parse(this.tbxLuongCB.Text);
            updateNhanVien.NgayTuyenDung = this.dtpickNgayTD.Value;
            updateNhanVien.NoiLamViec = this.tbxNoiLamViec.Text;
            this.nhanvienBUS.EditNhanVien(updateNhanVien);
            if (!this.tbxUsername.Text.Equals(updateNhanVien.TaiKhoan.Username))
            {
                if (this.taikhoanBUS.TonTaiTaiKhoan(this.tbxUsername.Text))
                {
                    MessageBox.Show("Tài khoản này đã được áp cho nhân viên khác!");
                    return;
                }

                this.taikhoanBUS.AddTaiKhoan(new TaiKhoanDTO()
                {
                    Username = this.tbxUsername.Text,
                    Password = this.tbxPassword.Text,
                    MaNV = updateNhanVien.MaNV
                });

                string oldUsername = updateNhanVien.TaiKhoan.Username;
                this.nhanvienBUS.ChuyenTaiKhoan(updateNhanVien.MaNV, this.tbxUsername.Text);
                this.taikhoanBUS.DeleteTaiKhoan(oldUsername);
            }
            else
            {
                this.nhanvienBUS.EditNhanVien(updateNhanVien);
                this.nhanvienBUS.DoiMatKhau(updateNhanVien.MaNV, this.tbxPassword.Text);
            }

            int index = this.lstvNhanVien.SelectedIndex;
            this.lstvNhanVien.SetObjects(this.nhanvienBUS.GetDSNhanVien());
            this.lstvNhanVien.SelectedIndex = index;
        }

        private void ListSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selected = (SanPhamDTO)this.lstvSanPham.SelectedObject;
                this.lstvChiTietSP.SetObjects(this.sanphamBUS.GetDSThongTinSP(selected.MaSP));
            }
            catch (Exception)
            {
            }
        }

        private void ComboLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.filterStep = 0;
            this.cbxKichThuoc.Enabled = true;
            this.cbxKichThuoc.Text = string.Empty;
            this.cbxMauSac.Enabled = true;
            this.cbxMauSac.Text = string.Empty;
            int selectedIndex = this.cbxLoaiSP.SelectedIndex;
            List<SanPhamDTO> resultList;
            if (selectedIndex == 0)
            {
                resultList = this.sanphamBUS.GetDSSanPham();
            }
            else
            {
                LoaiSPDTO loai = (LoaiSPDTO)this.cbxLoaiSP.SelectedItem;
                resultList = this.loaiBUS.GetDSSanPham(loai.MaLoai);
            }

            var colorSet = new HashSet<string>();
            var sizeSet = new HashSet<string>();
            foreach (var product in resultList)
            {
                this.sanphamBUS.GetDSMau(product.MaSP).ForEach(x => colorSet.Add(x));
                this.sanphamBUS.GetDSKichThuoc(product.MaSP).ForEach(x => sizeSet.Add(x));
            }

            this.cbxMauSac.Items.Clear();
            this.cbxMauSac.Items.AddRange(colorSet.ToArray());
            this.cbxKichThuoc.Items.Clear();
            this.cbxKichThuoc.Items.AddRange(sizeSet.ToArray());
            this.lstvSanPham.SetObjects(resultList);
            this.filterStep++;
        }

        private void ComboMauSac_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentList = this.lstvSanPham.Objects.Cast<SanPhamDTO>().ToList();
            var resultList = new List<SanPhamDTO>();
            foreach (var sp in currentList)
            {
                if (this.sanphamBUS.TonTaiThongTinSPMau(sp.MaSP, this.cbxMauSac.SelectedItem.ToString()))
                {
                    resultList.Add(sp);
                }
            }

            this.lstvSanPham.SetObjects(resultList);
            if (this.filterStep == 1)
            {
                var sizeSet = new HashSet<string>();
                foreach (var sp in resultList)
                {
                    this.sanphamBUS.GetDSKichThuoc(sp.MaSP).ForEach(x => sizeSet.Add(x));
                }

                this.cbxKichThuoc.Items.Clear();
                this.cbxKichThuoc.Items.AddRange(sizeSet.ToArray());
            }

            this.cbxMauSac.Enabled = false;
            this.filterStep++;
        }

        private void ComboKichThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentList = this.lstvSanPham.Objects.Cast<SanPhamDTO>().ToList();
            var resultList = new List<SanPhamDTO>();
            foreach (var sp in currentList)
            {
                if (this.sanphamBUS.TonTaiThongTinSPKichThuoc(sp.MaSP, this.cbxKichThuoc.SelectedItem.ToString()))
                {
                    resultList.Add(sp);
                }
            }

            this.lstvSanPham.SetObjects(resultList);
            if (this.filterStep == 1)
            {
                var colorSet = new HashSet<string>();
                foreach (var sp in resultList)
                {
                    this.sanphamBUS.GetDSMau(sp.MaSP).ForEach(x => colorSet.Add(x));
                }

                this.cbxMauSac.Items.Clear();
                this.cbxMauSac.Items.AddRange(colorSet.ToArray());
            }

            this.cbxKichThuoc.Enabled = false;
            this.filterStep++;
        }

        private void TextTimKiem_TextChanged(object sender, EventArgs e)
        {
            int searchType = this.cbxThuocTinhTim.SelectedIndex;
            if (searchType < 0)
            {
                MessageBox.Show("Vui lòng chọn thuộc tính tìm kiếm!");
                this.cbxThuocTinhTim.Focus();
                return;
            }

            List<SanPhamDTO> resultList;
            switch (searchType)
            {
                case 0:
                    resultList = this.sanphamBUS.GetDSSanPham().Where(x => x.MaSP.ToString().ToUpper().Contains(this.tbxTimKiem.Text.ToUpper())).ToList();
                    break;
                case 1:
                    resultList = this.sanphamBUS.GetDSSanPham().Where(x => x.TenSP.ToUpper().Contains(this.tbxTimKiem.Text.ToUpper())).ToList();
                    break;
                default:
                    resultList = new List<SanPhamDTO>();
                    break;
            }

            this.lstvSanPham.SetObjects(resultList);
        }

        private void TabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabMain.SelectedTab == this.tabMain.TabPages["tabQLNV"])
            {
                this.Width = 858;
                this.Height = 527;
                this.tmrValidate.Stop();
            }

            if (this.tabMain.SelectedTab == this.tabMain.TabPages["tabQLSP"])
            {
                this.Width = 740;
                this.tmrValidate.Stop();
            }

            if (this.tabMain.SelectedTab == this.tabMain.TabPages["tabQLHD"])
            {
                this.Width = 962;
                this.tmrValidate.Stop();
            }

            if (this.tabMain.SelectedTab == this.tabMain.TabPages["tabBH"])
            {
                this.Width = 701;
                this.Height = 458;
                this.tmrValidate.Start();
            }
        }

        private void ListHoaDon_HyperlinkClicked(object sender, HyperlinkClickedEventArgs e)
        {
            e.Handled = true;
            this.tabMain.SelectedTab = this.tabMain.TabPages["tabQLNV"];
            NhanVienDTO target = ((HoaDonDTO)e.Model).NhanVien;
            this.lstvNhanVien.Select();
            NhanVienDTO select = this.lstvNhanVien.Objects.Cast<NhanVienDTO>().First(x => x.MaNV == target.MaNV);
            this.lstvNhanVien.SelectObject(select);
        }

        private void ButtonBoLoc_Click(object sender, EventArgs e)
        {
            this.dtpickNgayLap.Value = DateTime.Today;
            this.cbxNhanVienLap.SelectedIndex = -1;
            this.cbxNhanVienLap.Text = string.Empty;
            this.tbxTongTienLonHon.Text = string.Empty;
            this.tbxTongTienNhoHon.Text = string.Empty;
            this.tbxHoTenKhachHang.Text = string.Empty;
            this.lstvHoaDon.SetObjects(this.hoadonBUS.GetDSHoaDon());
        }

        private void ComboLoaiSP_BanHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbxSanPhamTabBanHang.Items.Clear();
            this.cbxChiTietTabBanHang.Items.Clear();
            LoaiSPDTO selected = (LoaiSPDTO)this.cbxLoaiSPTabBanHang.SelectedItem;
            this.cbxSanPhamTabBanHang.Items.AddRange(this.loaiBUS.GetDSSanPhamConHang(selected.MaLoai).ToArray());
        }

        private void ComboChiTiet_BanHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            SanPhamDTO sanpham = (SanPhamDTO)this.cbxSanPhamTabBanHang.SelectedItem;
            this.cbxChiTietTabBanHang.Items.AddRange(this.sanphamBUS.GetDSThongTinSPConHang(sanpham.MaSP).ToArray());
        }

        private void ButtonThemSanPham_Click(object sender, EventArgs e)
        {
            ThemSuaSP them = new ThemSuaSP();
            them.ShowDialog();
            this.lstvSanPham.SetObjects(this.sanphamBUS.GetDSSanPham());
        }

        private void ButtonSuaSP_Click(object sender, EventArgs e)
        {
            if (this.lstvSanPham.SelectedObject != null)
            {
                SanPhamDTO sp = (SanPhamDTO)this.lstvSanPham.SelectedObject;
                ThemSuaSP sua = new ThemSuaSP(sp);
                sua.ShowDialog();
                this.sanphamBUS.RefreshSanPham();
                this.lstvSanPham.SetObjects(this.sanphamBUS.GetDSSanPham());
                this.lstvChiTietSP.SetObjects(null);
            }
        }

        private void ButtonQLLoaiSP_Click(object sender, EventArgs e)
        {
            LoaiSP loaiSP = new LoaiSP();
            loaiSP.ShowDialog();
            this.cbxLoaiSP.Items.Clear();
            this.cbxLoaiSP.Items.AddRange(this.loaiBUS.GetDSLoaiSP().ToArray());
            this.GetSanPhamGroupImgs();
            this.lstvSanPham.SetObjects(this.sanphamBUS.GetDSSanPham());
        }

        private void ButtonXoaSanPham_Click(object sender, EventArgs e)
        {
            if (this.lstvSanPham.SelectedObject == null)
            {
                return;
            }

            SanPhamDTO selected = (SanPhamDTO)this.lstvSanPham.SelectedObject;
            if (this.sanphamBUS.TonTaiThongTinSP(selected.MaSP))
            {
                MessageBox.Show("Vui lòng xóa hết các chi tiết trước!", "Không thể xóa");
                return;
            }

            var result = MessageBox.Show("Bạn có muốn xóa sản phẩm này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.sanphamBUS.DeleteSanPham(selected.MaSP);
                this.lstvSanPham.SetObjects(this.sanphamBUS.GetDSSanPham());
            }
        }

        private void ComboSanPham_BanHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbxChiTietTabBanHang.Items.Clear();
            SanPhamDTO selected = (SanPhamDTO)this.cbxSanPhamTabBanHang.SelectedItem;
            var danhsachChiTiet = this.sanphamBUS.GetDSThongTinSP(selected.MaSP);
            this.cbxChiTietTabBanHang.Items.AddRange(danhsachChiTiet.ToArray());
        }

        private void ButtonThemGioHang_Click(object sender, EventArgs e)
        {
            if (this.cbxLoaiSPTabBanHang.SelectedItem == null || this.cbxSanPhamTabBanHang.SelectedItem == null || this.cbxChiTietTabBanHang.SelectedItem == null)
            {
                return;
            }

            if (this.tbxSoLuongTabBanHang.Text.Equals(string.Empty))
            {
                return;
            }

            if (int.Parse(this.tbxSoLuongTabBanHang.Text) == 0)
            {
                return;
            }

            SanPhamDTO sanpham = (SanPhamDTO)this.cbxSanPhamTabBanHang.SelectedItem;
            ThongTinSPDTO thongtin = (ThongTinSPDTO)this.cbxChiTietTabBanHang.SelectedItem;
            ChiTietHoaDonDTO chitietHoaDon = this.giohang.DSChiTiet.Count > 0 ? this.giohang.DSChiTiet.FirstOrDefault(x => x.SanPham.MaSP == sanpham.MaSP && x.MauSac.Equals(thongtin.MauSac) && x.KichThuoc.Equals(thongtin.KichThuoc)) : null;
            if (chitietHoaDon == null)
            {
                chitietHoaDon = new ChiTietHoaDonDTO();
                chitietHoaDon.SanPham = sanpham;
                chitietHoaDon.KichThuoc = thongtin.KichThuoc;
                chitietHoaDon.MauSac = thongtin.MauSac;
                chitietHoaDon.DonGia = (decimal)thongtin.DonGia;
                chitietHoaDon.SoLuong = int.Parse(this.tbxSoLuongTabBanHang.Text);
                this.giohang.DSChiTiet.Add(chitietHoaDon);
            }
            else
            {
                chitietHoaDon.SoLuong += int.Parse(this.tbxSoLuongTabBanHang.Text);
            }
            
            this.lstvGioHang.SetObjects(this.giohang.DSChiTiet);
            this.TinhTongTienGioHang();
        }

        private void ListGioHang_ButtonClick(object sender, CellClickEventArgs e)
        {
            ChiTietHoaDonDTO selected = (ChiTietHoaDonDTO)e.Model;
            if (e.ColumnIndex == 6)
            {
                selected.SoLuong++;
            }

            if (e.ColumnIndex == 7)
            {
                selected.SoLuong--;
                if (selected.SoLuong == 0)
                {
                    this.giohang.DSChiTiet.Remove(selected);
                }
            }

            if (e.ColumnIndex == 8)
            {
                this.giohang.DSChiTiet.Remove(selected);
            }

            this.lstvGioHang.SetObjects(this.giohang.DSChiTiet);
            this.TinhTongTienGioHang();
        }

        private void ButtonXuatHoaDon_Click(object sender, EventArgs e)
        {
            HoaDonDTO hoadon = new HoaDonDTO();
            hoadon.MaHD = int.Parse(this.lbeMaHoaDon.Text);
            hoadon.NgayLap = DateTime.Today;
            hoadon.NhanVien = Global.NguoiSuDung;
            hoadon.HoTenKH = this.tbxTenKhachHang.Text;
            hoadon.DiaChiKH = this.tbxDiaChiKH.Text;
            hoadon.DienThoaiKH = this.tbxSDTKH.Text;
            hoadon.TongTienTruocThue = this.giohangBUS.TinhTongTruocThue(this.giohang);
            hoadon.TongTienThue = this.giohangBUS.TinhTongTienThue(this.giohang);
            hoadon.TongTienSauThue = this.giohangBUS.TinhTongTienSauThue(this.giohang);
            hoadon.DSChiTiet = this.giohang.DSChiTiet;
            this.hoadonBUS.XuatHoaDon(hoadon);
            
            foreach (var chitiet in this.giohang.DSChiTiet)
            {
                this.sanphamBUS.GiamSoLuongTon(chitiet.SanPham.MaSP, chitiet.MauSac, chitiet.KichThuoc, chitiet.SoLuong);
            }

            HoaDonDS ds = new HoaDonDS();
            ds.ThongTin.Rows.Add(hoadon.MaHD, hoadon.NgayLap.ToString("dd/MM/yyyy"), hoadon.TongTienTruocThue.ToString("#,#"), hoadon.TongTienThue.ToString("#,#"), hoadon.TongTienSauThue.ToString("#,#"));
            ds.KhachHang.Rows.Add(hoadon.HoTenKH, hoadon.DiaChiKH, hoadon.DienThoaiKH);
            this.giohang.DSChiTiet.ForEach(x => ds.ChiTietHD.Rows.Add(x.SanPham.MaSP, x.SanPham.TenSP, x.MauSac, x.KichThuoc, x.DonGia.ToString("#,#"), x.SoLuong));
            ReportDocument doc = new HoaDonReport();
            doc.SetDataSource(ds);
            InHoaDon inHoaDon = new InHoaDon(doc);
            inHoaDon.ShowDialog();

            this.ButtonReset_Click(null, EventArgs.Empty);
            this.lstvHoaDon.SetObjects(this.hoadonBUS.GetDSHoaDon());
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            this.cbxLoaiSPTabBanHang.Items.Clear();
            this.cbxLoaiSPTabBanHang.Items.AddRange(this.loaiBUS.GetDSLoaiSP().ToArray());
            this.lbeMaHoaDon.Text = (this.hoadonBUS.GetMaHDMax() + 1).ToString();
            this.giohang = new GioHangDTO();
            this.lstvGioHang.SetObjects(this.giohang.DSChiTiet);
            this.cbxLoaiSPTabBanHang.ResetText();
            this.cbxSanPhamTabBanHang.ResetText();
            this.cbxChiTietTabBanHang.ResetText();
            this.tbxTenKhachHang.Text = string.Empty;
            this.tbxDiaChiKH.Text = string.Empty;
            this.tbxSDTKH.Text = string.Empty;
        }

        private void TimerValidate_Tick(object sender, EventArgs e)
        {
            if (!this.isOK)
            {
                this.btnXuatHoaDon.Enabled = false;
            }

            if (this.lstvGioHang.GetItemCount() < 1)
            {
                this.rtbxError.Text = "Chưa chọn sản phẩm!";
                this.isOK = false;
                return;
            }

            if (this.tbxTenKhachHang.Text.Equals(string.Empty) || this.tbxDiaChiKH.Text.Equals(string.Empty) || this.tbxSDTKH.Text.Equals(string.Empty))
            {
                this.rtbxError.Text = "Chưa nhập đủ thông tin khách hàng!";
                this.isOK = false;
                return;
            }

            this.isOK = true;
            this.rtbxError.Text = string.Empty;
            this.btnXuatHoaDon.Enabled = true;
        }

        private void TextSoLuong_BanHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TextSDTKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void DateNgayLap_ValueChanged(object sender, EventArgs e)
        {
            var currentList = this.lstvHoaDon.Objects.Cast<HoaDonDTO>();
            var resultList = currentList.Where(x => x.NgayLap.Date == this.dtpickNgayLap.Value.Date);
            this.lstvHoaDon.SetObjects(resultList);
        }

        private List<HoaDonDTO> LocHoaDon(int masoNV, decimal minTongTien, decimal maxTongTien, string tenKH)
        {
            var currentList = this.lstvHoaDon.Objects.Cast<HoaDonDTO>().ToList();
            if (masoNV > 0)
            {
                currentList = currentList.Where(x => x.NhanVien.MaNV == masoNV).ToList();
            }

            if (minTongTien > 0)
            {
                currentList = currentList.Where(x => x.TongTienSauThue > minTongTien).ToList();
            }

            if (maxTongTien > 0)
            {
                currentList = currentList.Where(x => x.TongTienTruocThue < maxTongTien).ToList();
            }

            if (tenKH != string.Empty)
            {
                currentList = currentList.Where(x => x.HoTenKH.ToUpper().Contains(tenKH.ToUpper())).ToList();
            }

            return currentList;
        }

        private void ButtonLoc_Click(object sender, EventArgs e)
        {
            int masoNV = -1;
            decimal minTongTien = -1;
            decimal maxTongTien = -1;
            string tenKH = string.Empty;
            if (this.cbxNhanVienLap.SelectedIndex > 0)
            {
                masoNV = ((NhanVienDTO)this.cbxNhanVienLap.SelectedItem).MaNV;
            }

            if (this.tbxTongTienLonHon.Text != string.Empty)
            {
                minTongTien = decimal.Parse(this.tbxTongTienLonHon.Text);
            }

            if (this.tbxTongTienNhoHon.Text != string.Empty)
            {
                maxTongTien = decimal.Parse(this.tbxTongTienNhoHon.Text);
            }

            if (this.tbxHoTenKhachHang.Text != string.Empty)
            {
                tenKH = this.tbxHoTenKhachHang.Text;
            }

            this.lstvHoaDon.SetObjects(this.LocHoaDon(masoNV, minTongTien, maxTongTien, tenKH));
        }

        private void ListHoaDon_ButtonClick(object sender, CellClickEventArgs e)
        {
            HoaDonDTO hoadon = (HoaDonDTO)e.Model;
            HoaDonDS ds = new HoaDonDS();
            ds.ThongTin.Rows.Add(hoadon.MaHD, hoadon.NgayLap.ToString("dd/MM/yyyy"), hoadon.TongTienTruocThue.ToString("#,#"), hoadon.TongTienThue.ToString("#,#"), hoadon.TongTienSauThue.ToString("#,#"));
            ds.KhachHang.Rows.Add(hoadon.HoTenKH, hoadon.DiaChiKH, hoadon.DienThoaiKH);
            hoadon.DSChiTiet.ForEach(x => ds.ChiTietHD.Rows.Add(x.SanPham.MaSP, x.SanPham.TenSP, x.MauSac, x.KichThuoc, x.DonGia.ToString("#,#"), x.SoLuong));
            ReportDocument doc = new HoaDonReport();
            doc.SetDataSource(ds);
            InHoaDon inHoaDon = new InHoaDon(doc);
            inHoaDon.ShowDialog();
        }

        private void ĐăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
