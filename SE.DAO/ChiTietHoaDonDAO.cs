namespace SE.DAO
{
    using DTO;

    public class ChiTietHoaDonDAO
    {
        private SEDataContext context;

        public ChiTietHoaDonDAO()
        {
            this.context = new SEDataContext(Global.ConnectionString);
        }

        public decimal GetTongTien(ChiTietHoaDon chitiet)
        {
            return chitiet.DonGia * chitiet.SoLuong;
        }

        public void AddChiTietHoaDon(ChiTietHoaDon chitiet)
        {
            this.context.ChiTietHoaDons.InsertOnSubmit(chitiet);
        }

        public void SubmitChanges()
        {
            this.context.SubmitChanges();
        }
    }
}
