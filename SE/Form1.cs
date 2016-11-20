using BrightIdeasSoftware;
using SE.DAO;
using SE.TAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE
{
    public partial class Form1 : Form
    {
        // Declare variables
        
        private int filterStep;
        private SanPhamDAO spDAO;
        private LoaiSanPhamDAO loaiDAO;
        private TaiKhoanDAO tkDAO;
        private NhanVienDAO nvDAO;
        private HoaDonDAO hoadonDAO;
        private ChiTietHoaDonDAO ctHoaDonDAO;
        private ThongTinSanPhamDAO ttSanPhamDAO;
        private List<ChiTietHoaDon> cart;

        public Form1()
        {
            InitializeComponent();
            this.filterStep = 0;
            this.spDAO = new SanPhamDAO();
            this.loaiDAO = new LoaiSanPhamDAO();
            this.tkDAO = new TaiKhoanDAO();
            this.nvDAO = new NhanVienDAO();
            this.hoadonDAO = new HoaDonDAO();
            this.ctHoaDonDAO = new ChiTietHoaDonDAO();
            this.ttSanPhamDAO = new ThongTinSanPhamDAO();
            this.cart = new List<ChiTietHoaDon>();

            Global.dsLoaiSP = new LoaiSanPhamDAO().GetDSLoaiSP();
            Global.dsNhanVien = new NhanVienDAO().GetDSNhanVien();
            Global.dsSanPham = new SanPhamDAO().GetDSSanPham();
            Global.dsTaiKhoan = new TaiKhoanDAO().GetDSTaiKhoan();
            /*Global.dsHoaDon = new List<HoaDon>()
            {
                new HoaDon()
                {
                    MaHD = 1,
                    NhanVien = Global.dsNhanVien[1],
                    TongTien = 2300000,
                    NgayLap = DateTime.Today,
                    DSChiTietHD = new List<HoaDon_SanPham>()
                    {
                        new HoaDon_SanPham()
                        {
                            SanPham = Global.dsSanPham[0],
                            DonGia = 120000,
                            SoLuong = 5
                        },
                        new HoaDon_SanPham()
                        {
                            SanPham = Global.dsSanPham[1],
                            DonGia = 230000,
                            SoLuong = 3
                        }
                    }
                }
            };*/
            Global.nguoiSuDung = Global.dsNhanVien[0];
        }

        private object olvColImageGetter(object obj)
        {
            NhanVien nv = obj as NhanVien;
            if (nv.ChucVu == "Quản lý")
            {
                return 1;
            } else
            {
                return 0;
            }
        }

        private void getSanPhamGroupImgs()
        {
            this.imgGroup.Images.Clear();
            Image img;
            var dsLoaiSP = this.loaiDAO.GetDSLoaiSP();
            foreach (var loai in dsLoaiSP)
            {
                img = loai.GetImage();
                if (img != null)
                {
                    imgGroup.Images.Add(loai.MaLoai.ToString(), img);
                }
            }
        }

        private void tinhTongTienGioHang()
        {
            decimal tongTruocThue = this.cart.Sum(x => this.ctHoaDonDAO.GetTongTien(x));
            decimal tongThue = (tongTruocThue * Global.Thue) / 100;
            decimal tongSauThue = tongTruocThue + tongThue;
            lbeTongTienTruocThue.Text = tongTruocThue.ToString("#,#") + " VNĐ";
            lbeTongTienThue.Text = tongThue.ToString("#,#") + " VNĐ";
            lbeTongTienSauThue.Text = tongSauThue.ToString("#,#") + " VNĐ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 858;
            this.Height = 527;
            Global.Thue = 10;
            lstvNhanVien.ShowGroups = true;
            lstvNhanVien.AlwaysGroupByColumn = lstColChucVu;
            lstvNhanVien.SetObjects(Global.dsNhanVien);
            lstColMaNV.ImageGetter += new BrightIdeasSoftware.ImageGetterDelegate(olvColImageGetter);

            // QUAN LY SAN PHAM -----------------------------------------------------------------
            var arrLoaiSP = this.loaiDAO.GetDSLoaiSP().ToArray();

            cbxLoaiSP.Items.AddRange(arrLoaiSP);
            cbxLoaiSP.SelectedIndex = 0;

            this.getSanPhamGroupImgs();

            lstvSanPham.ShowGroups = true;
            lstvSanPham_LoaiSP.GroupFormatter += delegate(OLVGroup group, GroupingParameters parms)
            {
                string key = (string)group.Key;
                group.TitleImage = this.loaiDAO.GetLoaiSP(key).MaLoai.ToString();
            };
            lstvSanPham.AlwaysGroupByColumn = lstvSanPham_LoaiSP;
            lstvSanPham_TinhTrang.AspectToStringConverter = delegate (object x)
            {
                return String.Empty;
            };
            lstvSanPham.SetObjects(Global.dsSanPham);
            lstvSanPham_TinhTrang.ImageGetter = delegate(object x)
            {
                var sp = x as SanPham;
                if (sp.SoLuongTon == 0)
                {
                    return "outofstock";
                }
                else
                {
                    return "available";
                }
            };

            // QUAN LY HOA DON -----------------------------------------------------------------

            lstvHoaDon.SetObjects(Global.dsHoaDon);
            cbxNhanVienLap.Items.AddRange(Global.dsNhanVien.ToArray());
            lstvHoaDon_MaHD.ImageGetter = delegate(object x)
            {
                return "hoadon";
            };

            lstvHoaDon.CellToolTipShowing += new EventHandler<ToolTipShowingEventArgs>(delegate (object send, ToolTipShowingEventArgs args) {
            args.Title = "Danh sách sản phẩm";
            HoaDon hoadon = args.Model as HoaDon;
            args.StandardIcon = ToolTipControl.StandardIcons.Info;
            args.Font = new Font("Courier new", 8);
            StringBuilder str = new StringBuilder();
            str.AppendLine(string.Format("\n{0,-10}{1,-30}{2,-10}{3,15}", "Mã SP", "Tên SP", "Số lượng", "Đơn giá"));
            str.AppendLine("-----------------------------------------------------------------");
                foreach (var chitiet in hoadon.DSChiTietHD)
                {
                    str.AppendLine(string.Format("{0,-10}{1,-30}{2,-10}{3,15}", chitiet.SanPham.MaSP, chitiet.SanPham.TenSP, chitiet.SoLuong, chitiet.DonGia));
                }
                args.Text = str.ToString();
            });

            // BAN HANG -----------------------------------------------------------------

            lbeMaHoaDon.Text = (this.hoadonDAO.GetSLHoaDon() + 1).ToString();
            lbeNhanVienLap.Text = Global.nguoiSuDung.HoTen;
            lbeNgayLap.Text = DateTime.Today.ToString("dd/MM/yyyy");
            cbxLoaiSP_BanHang.Items.AddRange(this.loaiDAO.GetDSLoaiSP().ToArray());
        }

        private void lstvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                NhanVien selected = lstvNhanVien.SelectedObject as NhanVien;
                tbxMaNV.Text = selected.MaNV.ToString();
                if (selected.ChucVu.Equals("Quản lý"))
                {
                    cbxChucVu.SelectedIndex = 0;
                }
                else
                {
                    cbxChucVu.SelectedIndex = 1;
                }
                tbxHoTen.Text = selected.HoTen;
                tbxDiaChi.Text = selected.DiaChi;
                tbxCMND.Text = selected.CMND;
                tbxLuongCB.Text = selected.LuongCoBan.ToString("#,#");
                tbxNoiLamViec.Text = selected.NoiLamViec;
                dtpickNgaySinh.Value = selected.NgaySinh;
                dtpickNgayTD.Value = selected.NgayTuyenDung;
                tbxUsername.Text = selected.Username;
                tbxPassword.Text = this.tkDAO.GetTaiKhoan(selected.Username).Password;
            }
            catch (Exception)
            {
                
            }
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            int maNV = int.Parse(tbxMaNV.Text);
            if (Global.dsNhanVien.Any(x => x.MaNV == maNV))
            {
                MessageBox.Show("Mã nhân viên đã tồn tại trong hệ thống!");
                return;
            }
            string chucvu = cbxChucVu.SelectedItem.ToString();
            string tenNV = tbxHoTen.Text;
            DateTime ngaysinh = dtpickNgaySinh.Value;
            string diachi = tbxDiaChi.Text;
            string cmnd = tbxCMND.Text;
            decimal luongCB = decimal.Parse(tbxLuongCB.Text);
            DateTime ngayTD = dtpickNgayTD.Value;
            string noiLV = tbxNoiLamViec.Text;
            string username = tbxUsername.Text;
            string password = tbxPassword.Text;
            if (Global.dsTaiKhoan.Any(x => x.Username.Equals(username)))
            {
                MessageBox.Show("Tài khoản này đã được áp cho nhân viên khác!");
                return;
            }
            else
            {
                TaiKhoan addTaiKhoan = new TaiKhoan() { Username = username, Password = password };
                this.tkDAO.AddTaiKhoan(addTaiKhoan);
                this.tkDAO.SubmitChanges();
            }
            NhanVien addNhanVien = new NhanVien()
            {
                MaNV = maNV,
                ChucVu = chucvu,
                HoTen = tenNV,
                NgaySinh = ngaysinh,
                DiaChi = diachi,
                CMND = cmnd,
                LuongCoBan = luongCB,
                NgayTuyenDung = ngayTD,
                NoiLamViec = noiLV,
                TaiKhoan = this.tkDAO.GetTaiKhoan(username)
            };
            this.nvDAO.AddNhanVien(addNhanVien);
            this.nvDAO.SubmitChanges();
            lstvNhanVien.SetObjects(this.nvDAO.GetDSNhanVien());
        }

        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            if (this.lstvNhanVien.SelectedObject == null)
            {
                return;
            }
            NhanVien selected = (NhanVien)lstvNhanVien.SelectedObject;
            var result = MessageBox.Show(string.Format("Bạn có chắc chắn muốn xóa nhân viên\n{0}\nkhông?", "a"), "Xóa nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                NhanVien deleteNhanVien = this.nvDAO.GetNhanVien(selected.MaNV);
                this.nvDAO.DeleteNhanVien(deleteNhanVien);
                this.nvDAO.SubmitChanges();
                TaiKhoan deleteTaiKhoan = this.tkDAO.GetTaiKhoan(selected.Username);
                this.tkDAO.DeleteTaiKhoan(deleteTaiKhoan);
                this.tkDAO.SubmitChanges();
            }
            this.lstvNhanVien.SetObjects(this.nvDAO.GetDSNhanVien());
        }

        private void btnSuaNhanVien_Click(object sender, EventArgs e)
        {
            if (lstvNhanVien.SelectedObject == null)
            {
                return;
            }
            NhanVien updateNhanVien = this.nvDAO.GetNhanVien(int.Parse(tbxMaNV.Text));
            updateNhanVien.ChucVu = cbxChucVu.SelectedItem.ToString();
            updateNhanVien.HoTen = tbxHoTen.Text;
            updateNhanVien.NgaySinh = dtpickNgaySinh.Value;
            updateNhanVien.DiaChi = tbxDiaChi.Text;
            updateNhanVien.CMND = tbxCMND.Text;
            updateNhanVien.LuongCoBan = decimal.Parse(tbxLuongCB.Text);
            updateNhanVien.NgayTuyenDung = dtpickNgayTD.Value;
            updateNhanVien.NoiLamViec = tbxNoiLamViec.Text;
            if (!tbxUsername.Text.Equals(updateNhanVien.Username))
            {
                if (Global.dsTaiKhoan.Any(x => x.Username.Equals(tbxUsername.Text)))
                {
                    MessageBox.Show("Tài khoản này đã được áp cho nhân viên khác!");
                    return;
                }
                this.tkDAO.AddTaiKhoan(new TaiKhoan() { Username = tbxUsername.Text, Password = tbxPassword.Text });
                this.tkDAO.SubmitChanges();
                TaiKhoan tmpTaiKhoan = this.tkDAO.GetTaiKhoan(tbxUsername.Text);
                string oldUsername = updateNhanVien.Username;
                updateNhanVien.TaiKhoan = tmpTaiKhoan;
                tmpTaiKhoan = this.tkDAO.GetTaiKhoan(oldUsername);
                this.tkDAO.DeleteTaiKhoan(tmpTaiKhoan);
                this.tkDAO.SubmitChanges();
            }
            else
            {
                TaiKhoan updateTaiKhoan = this.tkDAO.GetTaiKhoan(tbxUsername.Text);
                updateTaiKhoan.Password = tbxPassword.Text;
                this.tkDAO.SubmitChanges();
            }

            int index = this.lstvNhanVien.SelectedIndex;
            this.lstvNhanVien.SetObjects(this.nvDAO.GetDSNhanVien());
            this.lstvNhanVien.SelectedIndex = index;
        }

        private void lstvSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selected = lstvSanPham.SelectedObject as SanPham;
                lstvChiTietSP.SetObjects(selected.ThongTinSanPhams);
            }
            catch (Exception)
            {
              
            }
        }

        private void cbxLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.filterStep = 0;
            cbxKichThuoc.Enabled = true;
            cbxKichThuoc.Text = "";
            cbxMauSac.Enabled = true;
            cbxMauSac.Text = "";
            int selectedIndex = cbxLoaiSP.SelectedIndex;
            List<SanPham> resultList;
            if (selectedIndex == 0) {
                resultList = this.spDAO.GetDSSanPham();
            }
            else
            {
                resultList = this.spDAO.GetDSSanPham().Where(x => x.LoaiSanPham.MaLoai == Global.dsLoaiSP[selectedIndex - 1].MaLoai).ToList();
            }
            var colorSet = new HashSet<string>();
            var sizeSet = new HashSet<string>();
            foreach (var product in resultList)
            {
                product.ThongTinSanPhams.Select(x => x.MauSac).ToList().ForEach(x => colorSet.Add(x));
                product.ThongTinSanPhams.Select(x => x.KichThuoc).ToList().ForEach(x => sizeSet.Add(x));
            }
            cbxMauSac.Items.Clear();
            cbxMauSac.Items.AddRange(colorSet.ToArray());
            cbxKichThuoc.Items.Clear();
            cbxKichThuoc.Items.AddRange(sizeSet.ToArray());
            lstvSanPham.SetObjects(resultList);
            this.filterStep++;
        }

        private void cbxMauSac_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentList = lstvSanPham.Objects.Cast<SanPham>().ToList();
            var resultList = new List<SanPham>();
            foreach (var sp in currentList)
            {
                if (sp.ThongTinSanPhams.Any(x => x.MauSac.Equals(cbxMauSac.SelectedItem.ToString())))
                {
                    resultList.Add(sp);
                }
            }
            lstvSanPham.SetObjects(resultList);
            if (this.filterStep == 1)
            {
                var sizeSet = new HashSet<string>(); ;
                foreach (var sp in resultList)
                {
                    sp.ThongTinSanPhams.Select(x => x.KichThuoc).ToList().ForEach(x => sizeSet.Add(x));
                }
                cbxKichThuoc.Items.Clear();
                cbxKichThuoc.Items.AddRange(sizeSet.ToArray());
            }
            cbxMauSac.Enabled = false;
            this.filterStep++;
        }

        private void cbxKichThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentList = lstvSanPham.Objects.Cast<SanPham>().ToList();
            var resultList = new List<SanPham>();
            foreach (var sp in currentList)
            {
                if (sp.ThongTinSanPhams.Any(x => x.KichThuoc.Equals(cbxKichThuoc.SelectedItem.ToString())))
                {
                    resultList.Add(sp);
                }
            }
            lstvSanPham.SetObjects(resultList);
            if (this.filterStep == 1)
            {
                var colorSet = new HashSet<string>(); ;
                foreach (var sp in resultList)
                {
                    sp.ThongTinSanPhams.Select(x => x.MauSac).ToList().ForEach(x => colorSet.Add(x));
                }
                cbxMauSac.Items.Clear();
                cbxMauSac.Items.AddRange(colorSet.ToArray());
            }
            cbxKichThuoc.Enabled = false;
            this.filterStep++;
        }

        private void tbxTimKiem_TextChanged(object sender, EventArgs e)
        {
            int searchType = cbxThuocTinhTim.SelectedIndex;
            if (searchType < 0)
            {
                MessageBox.Show("Vui lòng chọn thuộc tính tìm kiếm!");
                cbxThuocTinhTim.Focus();
                return;
            }
            List<SanPham> resultList;
            switch (searchType)
            {
                case 0:
                    resultList = this.spDAO.GetDSSanPham().Where(x => x.MaSP.ToString().ToUpper().Contains(tbxTimKiem.Text.ToUpper())).ToList();
                    break;
                case 1:
                    resultList = this.spDAO.GetDSSanPham().Where(x => x.TenSP.ToUpper().Contains(tbxTimKiem.Text.ToUpper())).ToList();
                    break;
                default:
                    resultList = new List<SanPham>();
                    break;
            }
            lstvSanPham.SetObjects(resultList);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabMain.SelectedIndex)
            {
                case 0:
                    this.Width = 858;
                    this.Height = 527;
                    break;
                case 1:
                    this.Width = 740;
                    break;
                case 2:
                    this.Width = 834;
                    break;
                case 3:
                    this.Width = 701;
                    this.Height = 458;
                    break;
                default:
                    break;
            }
        }

        private void lstvHoaDon_HyperlinkClicked(object sender, HyperlinkClickedEventArgs e)
        {
            e.Handled = true;
            tabMain.SelectedIndex = 0;
            NhanVien target = ((HoaDon)e.Model).NhanVien;
            lstvNhanVien.Select();
            lstvNhanVien.SelectObject(target);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBoLoc_Click(object sender, EventArgs e)
        {
            dtpickNgayLap.Value = DateTime.Today;
            cbxNhanVienLap.SelectedIndex = -1;
            cbxNhanVienLap.Text = string.Empty;
            tbxTongTienLonHon.Text = string.Empty;
            tbxTongTienNhoHon.Text = string.Empty;
            lstvHoaDon.SetObjects(Global.dsHoaDon);
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            var currentList = lstvHoaDon.Objects.Cast<HoaDon>().ToList();
            List<HoaDon> resultList;
            resultList = currentList.Where(x => x.NgayLap == dtpickNgayLap.Value).ToList();
            int maNV = cbxNhanVienLap.SelectedIndex >= 0? ((NhanVien)cbxNhanVienLap.SelectedItem).MaNV : -1;
            resultList = maNV >= 0 ? currentList.Where(x => x.NhanVien.MaNV == maNV).ToList() : resultList;
            decimal minCost = decimal.MaxValue;
            decimal.TryParse(tbxTongTienLonHon.Text,out minCost);
            resultList = currentList.Where(x => x.TongTien >= minCost).ToList();
            double maxCost = 0;
            double.TryParse(tbxTongTienNhoHon.Text, out maxCost);
            resultList = currentList.Where(x => x.TongTien <= minCost).ToList();
            lstvHoaDon.SetObjects(resultList);
        }

        private void cbxLoaiSP_BanHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbxSanPham_BanHang.Items.Clear();
            this.cbxChiTiet_BanHang.Items.Clear();
            LoaiSanPham selected = cbxLoaiSP_BanHang.SelectedItem as LoaiSanPham;
            LoaiSanPham loaiSP = this.loaiDAO.GetLoaiSP(selected.MaLoai);
            var dsSP = loaiSP.SanPhams;
            cbxSanPham_BanHang.Items.AddRange(dsSP.Where(x => x.SoLuongTon > 0).ToArray());
        }

        private void cbxChiTiet_BanHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            SanPham sanpham = cbxSanPham_BanHang.SelectedItem as SanPham;
            cbxChiTiet_BanHang.Items.AddRange(sanpham.ThongTinSanPhams.Where(x => x.SoLuongTon > 0).ToArray());
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            ThemSuaSP them = new ThemSuaSP();
            them.ShowDialog();
            this.lstvSanPham.SetObjects(this.spDAO.GetDSSanPham());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (lstvSanPham.SelectedObject != null)
            {
                SanPham sp = lstvSanPham.SelectedObject as SanPham;
                ThemSuaSP sua = new ThemSuaSP(sp);
                sua.ShowDialog();
                this.lstvSanPham.SetObjects(new SanPhamDAO().GetDSSanPham());
                this.lstvChiTietSP.SetObjects(null);
            }
        }

        private void btnQLLoaiSP_Click(object sender, EventArgs e)
        {
            LoaiSP loaiSP = new LoaiSP();
            loaiSP.ShowDialog();
            this.loaiDAO.Refresh();
            this.cbxLoaiSP.Items.Clear();
            this.cbxLoaiSP.Items.AddRange(this.loaiDAO.GetDSLoaiSP().ToArray());
            this.getSanPhamGroupImgs();
            this.lstvSanPham.SetObjects(this.spDAO.GetDSSanPham());
        }

        private void btnXoaSanPham_Click(object sender, EventArgs e)
        {
            if (lstvSanPham.SelectedObject == null)
            {
                return;
            }
            SanPham selected = (SanPham)this.lstvSanPham.SelectedObject;
            SanPham deleteSanPham = this.spDAO.GetSanPham(selected.MaSP);
            if (deleteSanPham.ThongTinSanPhams.Count > 0)
            {
                MessageBox.Show("Vui lòng xóa hết các chi tiết trước!", "Không thể xóa");
                return;
            }
            var result = MessageBox.Show("Bạn có muốn xóa sản phẩm này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.spDAO.DeleteSanPham(deleteSanPham);
                this.spDAO.SubmitChanges();
                this.lstvSanPham.SetObjects(this.spDAO.GetDSSanPham());
            }
        }

        private void cbxSanPham_BanHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbxChiTiet_BanHang.Items.Clear();
            SanPham selected = (SanPham)this.cbxSanPham_BanHang.SelectedItem;
            SanPham sanpham = this.spDAO.GetSanPham(selected.MaSP);
            var dsChiTiet = sanpham.ThongTinSanPhams;
            this.cbxChiTiet_BanHang.Items.AddRange(dsChiTiet.ToArray());
        }

        private void btnThemGioHang_Click(object sender, EventArgs e)
        {
            if (cbxLoaiSP_BanHang.SelectedItem == null || cbxSanPham_BanHang.SelectedItem == null || cbxChiTiet_BanHang.SelectedItem == null)
            {
                return;
            }
            if (tbxSoLuong_BanHang.Text.Equals(string.Empty))
            {
                return;
            }
            if (int.Parse(tbxSoLuong_BanHang.Text) == 0)
            {
                return;
            }
            SanPham sanpham = (SanPham)cbxSanPham_BanHang.SelectedItem;
            ThongTinSanPham thongtin = (ThongTinSanPham)cbxChiTiet_BanHang.SelectedItem;
            ChiTietHoaDon ctHoaDon = this.cart.FirstOrDefault(x => x.SanPham.MaSP == sanpham.MaSP && x.MauSac.Equals(thongtin.MauSac) && x.KichThuoc.Equals(thongtin.KichThuoc));
            if (ctHoaDon == null)
            {
                ctHoaDon = new ChiTietHoaDon();
                ctHoaDon.SanPham = sanpham;
                ctHoaDon.KichThuoc = thongtin.KichThuoc;
                ctHoaDon.MauSac = thongtin.MauSac;
                ctHoaDon.DonGia = (decimal)thongtin.DonGia;
                ctHoaDon.SoLuong = int.Parse(tbxSoLuong_BanHang.Text);
                this.cart.Add(ctHoaDon);
            }
            else
            {
                ctHoaDon.SoLuong += int.Parse(tbxSoLuong_BanHang.Text);
            }
            this.lstvGioHang.SetObjects(this.cart);
            this.tinhTongTienGioHang();
        }

        private void lstvGioHang_ButtonClick(object sender, CellClickEventArgs e)
        {
            ChiTietHoaDon selected = (ChiTietHoaDon)e.Model;
            if (e.ColumnIndex == 6)
            {
                selected.SoLuong++;
            }
            if (e.ColumnIndex == 7)
            {
                selected.SoLuong--;
                if (selected.SoLuong == 0)
                {
                    this.cart.Remove(selected);
                }
            }
            if (e.ColumnIndex == 8)
            {
                this.cart.Remove(selected);
            }
            this.lstvGioHang.SetObjects(this.cart);
            this.tinhTongTienGioHang();
        }

        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            HoaDon hoadon = new HoaDon();
            hoadon.MaHD = int.Parse(lbeMaHoaDon.Text);
            hoadon.NgayLap = DateTime.Today;
            hoadon.NhanVien = this.nvDAO.GetNhanVien(1);
            hoadon.HoTenKH = tbxTenKhachHang.Text;
            hoadon.DiaChiKH = tbxDiaChiKH.Text;
            hoadon.DienThoaiKH = tbxSDTKH.Text;

            ThongTinSanPham tmpThongTin;
            SanPham tmpSanPham;
            foreach (var chitiet in this.cart)
            {
                hoadon.ChiTietHoaDons.Add(chitiet);
                tmpSanPham = this.spDAO.GetSanPham(chitiet.SanPham.MaSP);
                tmpThongTin = this.spDAO.GetThongTinSP(tmpSanPham, chitiet.MauSac, chitiet.KichThuoc);
                tmpThongTin.SoLuongTon -= chitiet.SoLuong;
                tmpSanPham.TinhSoLuongTon();
                this.spDAO.SubmitChanges();
            }

            this.hoadonDAO.AddHoaDon(hoadon);
            this.hoadonDAO.SubmitChanges();
        }
    }
}
