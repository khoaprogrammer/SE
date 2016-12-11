namespace SE.DAO
{
    using System.Linq;
    using DTO;

    public class ThongTinSanPhamDAO
    {
        private SEDataContext context;

        public ThongTinSanPhamDAO()
        {
            this.context = new SEDataContext(Global.ConnectionString);
        }

        public ThongTinSanPham GetThongTinSP(int masoSP, string mausac, string kichthuoc)
        {
            return this.context.ThongTinSanPhams.First(x => x.MaSP == masoSP && x.MauSac.Equals(mausac) && x.KichThuoc.Equals(kichthuoc));
        }

        public void AddThongTinSP(ThongTinSanPham tt)
        {
            this.context.ThongTinSanPhams.InsertOnSubmit(tt);
            this.context.SubmitChanges();
        }

        public void DeleteThongTinSP(int masoSP, string mausac, string kichthuoc)
        {
            ThongTinSanPham tt = this.context.ThongTinSanPhams.First(x => x.MaSP == masoSP && x.MauSac.Equals(mausac) && x.KichThuoc.Equals(kichthuoc));
            this.context.ThongTinSanPhams.DeleteOnSubmit(tt);
            this.context.SubmitChanges();
        }
    }
}
