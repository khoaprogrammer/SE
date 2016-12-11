namespace SE.DAO
{
    using System.Collections.Generic;
    using System.Linq;
    using DTO;

    public class SanPhamDAO
    {
        private SEDataContext context;
        private ThongTinSanPhamDAO thongtinDAO;

        public SanPhamDAO()
        {
            this.context = new SEDataContext(Global.ConnectionString);
            this.thongtinDAO = new ThongTinSanPhamDAO();
        }

        public List<SanPham> GetDSSanPham()
        {
            return this.context.SanPhams.ToList();
        }

        public SanPham GetSanPham(int masoSP)
        {
            return this.context.SanPhams.FirstOrDefault(x => x.MaSP == masoSP);
        }

        public void AddSanPham(SanPham sp)
        {
            this.context.SanPhams.InsertOnSubmit(sp);
            this.context.SubmitChanges();
        }

        public void AddThongTinSP(int masoSP, ThongTinSanPham tt)
        {
            SanPham sp = this.GetSanPham(masoSP);
            sp.ThongTinSanPhams.Add(tt);
            this.context.SubmitChanges();
        }

        public ThongTinSanPham GetThongTinSP(int masoSP, string mausac, string kichthuoc)
        {
            SanPham sp = this.context.SanPhams.First(x => x.MaSP == masoSP);
            return sp.ThongTinSanPhams.FirstOrDefault(x => x.MauSac.Equals(mausac) && x.KichThuoc.Equals(kichthuoc));
        }

        public List<ThongTinSanPham> GetDSThongTinSP(int masoSP)
        {
            SanPham sp = this.context.SanPhams.First(x => x.MaSP == masoSP);
            return sp.ThongTinSanPhams.ToList();
        }

        public void DeleteSanPham(int masoSP)
        {
            SanPham sp = this.context.SanPhams.First(x => x.MaSP == masoSP);
            this.context.SanPhams.DeleteOnSubmit(sp);
            this.context.SubmitChanges();
        }

        public void TinhSoLuongTon(int masoSP)
        {
            SanPham sp = this.GetSanPham(masoSP);
            sp.SoLuongTon = (int)sp.ThongTinSanPhams.Sum(x => x.SoLuongTon);
            this.context.SubmitChanges();
        }

        public void GiamSoLuongTon(int masoSP, string mausac, string kichthuoc, int soluongGiam)
        {
            SanPham sp = this.GetSanPham(masoSP);
            ThongTinSanPham thongtin = this.GetThongTinSP(masoSP, mausac, kichthuoc);
            thongtin.SoLuongTon -= soluongGiam;
            this.TinhSoLuongTon(masoSP);
        }

        public void TangSoLuongTon(int masoSP, string mausac, string kichthuoc, int soluongTang)
        {
            ThongTinSanPham thongtin = this.GetThongTinSP(masoSP, mausac, kichthuoc);
            thongtin.SoLuongTon += soluongTang;
            this.TinhSoLuongTon(masoSP);
        }

        public void EditThongTinSP(int masoSP, ThongTinSanPham thongtin)
        {
            ThongTinSanPham tt = this.GetThongTinSP(masoSP, thongtin.MauSac, thongtin.KichThuoc);
            tt.DonGia = thongtin.DonGia;
            tt.SoLuongTon = thongtin.SoLuongTon;
            this.context.SubmitChanges();
            this.TinhSoLuongTon(masoSP);
        }

        public void DeleteThongTinSanPham(int masoSP, string mausac, string kichthuoc)
        {
            SanPham sp = this.GetSanPham(masoSP);
            ThongTinSanPham thongtin = sp.ThongTinSanPhams.First(x => x.MauSac.Equals(mausac) && x.KichThuoc.Equals(kichthuoc));
            sp.ThongTinSanPhams.Remove(thongtin);
            this.context.SubmitChanges();
            this.TinhSoLuongTon(masoSP);
        }

        public void EditSanPham(SanPham sanPham)
        {
            SanPham sp = this.GetSanPham(sanPham.MaSP);
            sp.MaLoai = sanPham.MaLoai;
            sp.TenSP = sanPham.TenSP;
            sp.SoLuongTon = sanPham.SoLuongTon;
            this.context.SubmitChanges();
        }

        public void RefreshSanPham()
        {
            this.context = new SEDataContext(Global.ConnectionString);
        }
    }
}
