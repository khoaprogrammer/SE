namespace SE.BUS
{
    using SE.DTO;

    public class ChiTietHoaDonBUS
    {
        public decimal TinhTongTien(ChiTietHoaDonDTO chitiet)
        {
            return chitiet.DonGia * chitiet.SoLuong;
        }
    }
}
