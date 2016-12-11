namespace SE.DAO
{
    using System.Collections.Generic;
    using System.Data.Linq;
    using System.Linq;
    using DTO;

    public class LoaiSanPhamDAO
    {
        private SEDataContext context;

        public LoaiSanPhamDAO()
        {
            this.context = new SEDataContext(Global.ConnectionString);
        }

        public List<LoaiSanPham> GetDSLoaiSP()
        {
            return this.context.LoaiSanPhams.ToList();
        }

        public LoaiSanPham GetLoaiSP(int ma)
        {
            return this.context.LoaiSanPhams.FirstOrDefault(x => x.MaLoai == ma);
        }

        public LoaiSanPham GetLoaiSP(string ten)
        {
            return this.context.LoaiSanPhams.FirstOrDefault(x => x.TenLoai.ToString().Equals(ten));
        }

        public List<SanPham> GetDSSanPham(int masoLoai)
        {
            LoaiSanPham loai = this.context.LoaiSanPhams.First(x => x.MaLoai == masoLoai);
            return loai.SanPhams.ToList();
        }

        public void Refresh()
        {
            this.context.Refresh(RefreshMode.OverwriteCurrentValues, this.context.LoaiSanPhams);
        }

        public bool TonTaiLoaiSP(int masoLoai)
        {
            return this.context.LoaiSanPhams.Any(x => x.MaLoai == masoLoai);
        }

        public void AddLoaiSP(LoaiSanPham loaiSanPham)
        {
            this.context.LoaiSanPhams.InsertOnSubmit(loaiSanPham);
            this.context.SubmitChanges();
        }

        public void DeleteLoaiSP(int masoLoai)
        {
            LoaiSanPham loai = this.context.LoaiSanPhams.First(x => x.MaLoai == masoLoai);
            this.context.LoaiSanPhams.DeleteOnSubmit(loai);
            this.context.SubmitChanges();
        }

        public void EditLoaiSP(int masoLoai, string tenMoi)
        {
            LoaiSanPham loai = this.GetLoaiSP(masoLoai);
            loai.TenLoai = tenMoi;
            this.context.SubmitChanges();
        }
    }
}
