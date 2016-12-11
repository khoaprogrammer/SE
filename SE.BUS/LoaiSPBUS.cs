namespace SE.BUS
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using DAO;
    using DTO;

    public class LoaiSPBUS
    {
        private LoaiSanPhamDAO loaiDAO;

        public LoaiSPBUS()
        {
            this.loaiDAO = new LoaiSanPhamDAO();
        }

        public LoaiSanPham ChuyenDAO(LoaiSPDTO loai)
        {
            return new LoaiSanPham
            {
                MaLoai = loai.MaLoai,
                TenLoai = loai.TenLoai
            };
        }

        public List<LoaiSPDTO> GetDSLoaiSP()
        {
            return this.loaiDAO.GetDSLoaiSP().Select(x => new LoaiSPDTO
            {
                MaLoai = x.MaLoai,
                TenLoai = x.TenLoai
            }).ToList();
        }

        public Image GetImage(int masoLoai)
        {
            if (!File.Exists(Path.Combine(Environment.CurrentDirectory, "imgs/loaisp", masoLoai.ToString() + ".png")))
            {
                return null;
            }

            Image img;
            using (var bmpTemp = new Bitmap(Path.Combine(Environment.CurrentDirectory, "imgs/loaisp", masoLoai.ToString() + ".png")))
            {
                img = new Bitmap(bmpTemp);
            }

            return img;
        }

        public LoaiSPDTO GetLoaiSP(int masoLoai)
        {
            LoaiSanPham result = this.loaiDAO.GetLoaiSP(masoLoai);
            return new LoaiSPDTO
            {
                MaLoai = result.MaLoai,
                TenLoai = result.TenLoai
            };
        }

        public LoaiSPDTO GetLoaiSP(string tenLoai)
        {
            LoaiSanPham result = this.loaiDAO.GetLoaiSP(tenLoai);
            return new LoaiSPDTO
            {
                MaLoai = result.MaLoai,
                TenLoai = result.TenLoai
            };
        }

        public List<SanPhamDTO> GetDSSanPham(int masoLoai)
        {
            return this.loaiDAO.GetDSSanPham(masoLoai).Select(x => new SanPhamDTO
            {
                MaSP = x.MaSP,
                TenSP = x.TenSP,
                LoaiSP = new LoaiSPDTO
                {
                    MaLoai = x.LoaiSanPham.MaLoai,
                    TenLoai = x.LoaiSanPham.TenLoai
                },
                SoLuongTon = x.SoLuongTon,
                DSThongTin = x.ThongTinSanPhams.Select(y => new ThongTinSPDTO
                {
                    MauSac = y.MauSac,
                    KichThuoc = y.KichThuoc,
                    DonGia = (decimal)y.DonGia,
                    SoLuongTon = (int)y.SoLuongTon
                }).ToList()
            }).ToList();
        }

        public List<SanPhamDTO> GetDSSanPhamConHang(int masoLoai)
        {
            return this.GetDSSanPham(masoLoai).Where(x => x.SoLuongTon > 0).ToList();
        }

        public bool TonTaiLoaiSP(int masoLoai)
        {
            return this.loaiDAO.TonTaiLoaiSP(masoLoai);
        }

        public void AddLoaiSP(LoaiSPDTO loai)
        {
            this.loaiDAO.AddLoaiSP(this.ChuyenDAO(loai));
        }

        public void DeleteLoaiSP(int masoLoai)
        {
            this.loaiDAO.DeleteLoaiSP(masoLoai);
        }

        public void EditLoaiSP(int masoLoai, string tenMoi)
        {
            this.loaiDAO.EditLoaiSP(masoLoai, tenMoi);
        }
    }
}
