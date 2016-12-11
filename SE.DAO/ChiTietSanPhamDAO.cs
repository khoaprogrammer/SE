namespace SE.DAO
{
    using System.Linq;
    using SE.DTO;

    public class ChiTietSanPhamDAO
    {
        private SEDataContext context;

        public ChiTietSanPhamDAO()
        {
            this.context = new SEDataContext(Global.ConnectionString);
        }

        public bool TonTaiChiTiet(string mausac, string kichthuoc)
        {
            return this.context.ChiTietSanPhams.Any(x => x.MauSac.Equals(mausac) && x.KichThuoc.Equals(kichthuoc));
        }

        public void AddChiTietSP(string mausac, string kichthuoc)
        {
            this.context.ChiTietSanPhams.InsertOnSubmit(new ChiTietSanPham() { MauSac = mausac, KichThuoc = kichthuoc });
            this.context.SubmitChanges();
        }

        public void SubmitChanges()
        {
            this.context.SubmitChanges();
        }
    }
}
