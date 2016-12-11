namespace SE.BUS
{
    using SE.DAO;

    public class ChiTietSanPhamBUS
    {
        private ChiTietSanPhamDAO chitietDAO;

        public ChiTietSanPhamBUS()
        {
            this.chitietDAO = new ChiTietSanPhamDAO();
        }

        public bool TonTaiChiTiet(string mausac, string kichthuoc)
        {
            return this.chitietDAO.TonTaiChiTiet(mausac, kichthuoc);
        }

        public void AddChiTietSP(string mausac, string kichthuoc)
        {
            this.chitietDAO.AddChiTietSP(mausac, kichthuoc);
        }
    }
}
