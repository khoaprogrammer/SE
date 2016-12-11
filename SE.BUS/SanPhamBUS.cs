namespace SE.BUS
{
    using System.Collections.Generic;
    using System.Linq;
    using DAO;
    using DTO;

    public class SanPhamBUS
    {
        private SanPhamDAO sanphamDAO;
        private LoaiSPBUS loaiBUS;
        private ThongTinSPBUS ttspBUS;

        public SanPhamBUS()
        {
            this.sanphamDAO = new SanPhamDAO();
            this.loaiBUS = new LoaiSPBUS();
            this.ttspBUS = new ThongTinSPBUS();
        }

        public SanPhamDTO ChuyenDTO(SanPham sanpham)
        {
            return new SanPhamDTO
            {
                MaSP = sanpham.MaSP,
                LoaiSP = this.loaiBUS.GetLoaiSP(sanpham.MaLoai),
                SoLuongTon = sanpham.SoLuongTon,
                TenSP = sanpham.TenSP,
                DSThongTin = this.GetDSThongTinSP(sanpham.MaSP)
            };
        }

        public SanPham ChuyenDAO(SanPhamDTO sanpham)
        {
            return new SanPham
            {
                MaSP = sanpham.MaSP,
                MaLoai = sanpham.LoaiSP.MaLoai,
                SoLuongTon = sanpham.SoLuongTon,
                TenSP = sanpham.TenSP,
            };
        }

        public SanPhamDTO GetSanPham(int masoSP)
        {
            SanPham result = this.sanphamDAO.GetSanPham(masoSP);
            return this.ChuyenDTO(result);
        }

        public List<ThongTinSPDTO> GetDSThongTinSP(int masoSP)
        {
            return this.sanphamDAO.GetDSThongTinSP(masoSP).Select(x => new ThongTinSPDTO
            {
                DonGia = (decimal)x.DonGia,
                KichThuoc = x.KichThuoc,
                MauSac = x.MauSac,
                SoLuongTon = (int)x.SoLuongTon
            }).ToList();
        }

        public List<ThongTinSPDTO> GetDSThongTinSPConHang(int masoSP)
        {
            return this.GetDSThongTinSP(masoSP).Where(x => x.SoLuongTon > 0).ToList();
        }

        public List<SanPhamDTO> GetDSSanPham()
        {
            return this.sanphamDAO.GetDSSanPham().Select(x => new SanPhamDTO
            {
                MaSP = x.MaSP,
                TenSP = x.TenSP,
                SoLuongTon = x.SoLuongTon,
                LoaiSP = new LoaiSPDTO
                {
                    MaLoai = x.LoaiSanPham.MaLoai,
                    TenLoai = x.LoaiSanPham.TenLoai
                }
            }).ToList();
        }

        public bool TonTaiThongTinSP(int masoSP)
        {
            return this.GetSanPham(masoSP).DSThongTin.Count > 0;
        }

        public bool TonTaiThongTinSPKichThuoc(int masoSP, string kichthuoc)
        {
            SanPhamDTO sp = this.GetSanPham(masoSP);
            return sp.DSThongTin.Any(x => x.KichThuoc.Equals(kichthuoc));
        }

        public bool TonTaiThongTinSPMau(int masoSP, string mausac)
        {
            SanPhamDTO sp = this.GetSanPham(masoSP);
            return sp.DSThongTin.Any(x => x.MauSac.Equals(mausac));
        }

        public void DeleteSanPham(int masoSP)
        {
            this.sanphamDAO.DeleteSanPham(masoSP);
        }
        
        public List<string> GetDSMau(int masoSP)
        {
            return this.GetDSThongTinSP(masoSP).Select(x => x.MauSac).ToList();
        }

        public List<string> GetDSKichThuoc(int masoSP)
        {
            return this.GetDSThongTinSP(masoSP).Select(x => x.KichThuoc).ToList();
        }

        public void GiamSoLuongTon(int masoSP, string mausac, string kichthuoc, int soluongGiam)
        {
            this.sanphamDAO.GiamSoLuongTon(masoSP, mausac, kichthuoc, soluongGiam);
        }

        public void TangSoLuongTon(int masoSP, string mausac, string kichthuoc, int soluongTang)
        {
            this.sanphamDAO.TangSoLuongTon(masoSP, mausac, kichthuoc, soluongTang);
        }

        public int GetMaSPMax()
        {
            return this.GetDSSanPham().Max(x => x.MaSP);
        }

        public ThongTinSPDTO GetThongTinSP(int masoSP, string mausac, string kichthuoc)
        {
            ThongTinSanPham result = this.sanphamDAO.GetThongTinSP(masoSP, mausac, kichthuoc);
            if (result == null)
            {
                return null;
            }

            return this.ttspBUS.ChuyenDTO(result);
        }

        public void AddThongTinSanPham(int masoSP, ThongTinSPDTO thongtin)
        {
            this.sanphamDAO.AddThongTinSP(masoSP, this.ttspBUS.ChuyenDAO(thongtin));
        }

        public void EditThongTinSanPham(int masoSP, ThongTinSPDTO thongtin)
        {
            this.sanphamDAO.EditThongTinSP(masoSP, this.ttspBUS.ChuyenDAO(thongtin));
        }

        public void DeleteThongTinSanPham(int masoSP, string mausac, string kichthuoc)
        {
            this.sanphamDAO.DeleteThongTinSanPham(masoSP, mausac, kichthuoc);
        }

        public void AddSanPham(SanPhamDTO sp)
        {
            this.sanphamDAO.AddSanPham(this.ChuyenDAO(sp));
        }

        public void EditSanPham(SanPhamDTO sp)
        {
            this.sanphamDAO.EditSanPham(this.ChuyenDAO(sp));
        }
        
        public void TinhSoLuongTon(int masoSP)
        {
            this.sanphamDAO.TinhSoLuongTon(masoSP);
        }

        public void RefreshSanPham()
        {
            this.sanphamDAO.RefreshSanPham();
        }
    }
}
