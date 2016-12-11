namespace SE.BUS
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using DAO;
    using DTO;

    public class HoaDonBUS
    {
        private HoaDonDAO hoadonDAO;
        private NhanVienBUS nhanvienBUS;
        private SanPhamBUS sanphamBUS;

        public HoaDonBUS()
        {
            this.hoadonDAO = new HoaDonDAO();
            this.nhanvienBUS = new NhanVienBUS();
            this.sanphamBUS = new SanPhamBUS();
        }

        public HoaDon ChuyenDAO(HoaDonDTO hoadon)
        {
            HoaDon hd = new HoaDon
            {
                MaHD = hoadon.MaHD,
                DiaChiKH = hoadon.DiaChiKH,
                DienThoaiKH = hoadon.DiaChiKH,
                HoTenKH = hoadon.HoTenKH,
                MaNV = hoadon.NhanVien.MaNV,
                NgayLap = hoadon.NgayLap,
                TongTienTruocThue = hoadon.TongTienTruocThue,
                TongTienSauThue = hoadon.TongTienSauThue,
                TongTienThue = hoadon.TongTienThue
            };

            hoadon.DSChiTiet.ForEach(x => hd.ChiTietHoaDons.Add(new ChiTietHoaDon
            {
                MaSP = x.SanPham.MaSP,
                DonGia = x.DonGia,
                MauSac = x.MauSac,
                KichThuoc = x.KichThuoc,
                SoLuong = x.SoLuong,
            }));
            return hd;
        }

        public List<HoaDonDTO> GetDSHoaDon()
        {
            return this.hoadonDAO.GetDSHoaDon().Select(x => new HoaDonDTO
            {
                MaHD = x.MaHD,
                DiaChiKH = x.DiaChiKH,
                DienThoaiKH = x.DienThoaiKH,
                HoTenKH = x.HoTenKH,
                NgayLap = x.NgayLap,
                NhanVien = this.nhanvienBUS.GetNhanVien(x.MaNV),
                TongTienTruocThue = (decimal)x.TongTienTruocThue,
                TongTienThue = (decimal)x.TongTienThue,
                TongTienSauThue = (decimal)x.TongTienSauThue,
                DSChiTiet = x.ChiTietHoaDons.Select(y => new ChiTietHoaDonDTO
                {
                    DonGia = y.DonGia,
                    KichThuoc = y.KichThuoc,
                    MauSac = y.MauSac,
                    SanPham = this.sanphamBUS.GetSanPham(y.MaSP),
                    SoLuong = y.SoLuong
                }).ToList()
            }).ToList();
        }

        public string GetToolTipText(HoaDonDTO hoadon)
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine(string.Format("\n{0,-10}{1,-30}{2,-10}{3,15}", "Mã SP", "Tên SP", "Số lượng", "Đơn giá"));
            str.AppendLine("-----------------------------------------------------------------");
            foreach (var chitiet in hoadon.DSChiTiet)
            {
                str.AppendLine(string.Format("{0,-10}{1,-30}{2,-10}{3,15:#,#} VNĐ", chitiet.SanPham.MaSP, chitiet.SanPham.TenSP, chitiet.SoLuong, chitiet.DonGia));
            }

            str.AppendLine("-----------------------------------------------------------------");
            str.AppendLine("Tên khách hàng: " + hoadon.HoTenKH);
            str.AppendLine("Địa chỉ: " + hoadon.DiaChiKH);
            str.AppendLine("SĐT: " + hoadon.DienThoaiKH);
            return str.ToString();
        }

        public int GetMaHDMax()
        {
            return this.hoadonDAO.GetDSHoaDon().Max(x => x.MaHD);
        }

        public void XuatHoaDon(HoaDonDTO hoadon)
        {
            this.hoadonDAO.XuatHoaDon(this.ChuyenDAO(hoadon));
        }
    }
}
