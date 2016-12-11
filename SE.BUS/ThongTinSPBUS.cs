namespace SE.BUS
{
    using DAO;
    using DTO;

    public class ThongTinSPBUS
    {
        private ThongTinSanPhamDAO ttspDAO;

        public ThongTinSPBUS()
        {
            this.ttspDAO = new ThongTinSanPhamDAO();
        }

        public ThongTinSPDTO ChuyenDTO(ThongTinSanPham thongtin)
        {
            return new ThongTinSPDTO
            {
                MauSac = thongtin.MauSac,
                KichThuoc = thongtin.KichThuoc,
                DonGia = (decimal)thongtin.DonGia,
                SoLuongTon = (int)thongtin.SoLuongTon
            };
        }

        public ThongTinSanPham ChuyenDAO(ThongTinSPDTO thongtin)
        {
            return new ThongTinSanPham
            {
                MauSac = thongtin.MauSac,
                KichThuoc = thongtin.KichThuoc,
                SoLuongTon = thongtin.SoLuongTon,
                DonGia = thongtin.DonGia,
            };
        }

        public void DeleteThongTinSP(int masoSP, string mausac, string kichthuoc)
        {
            this.ttspDAO.DeleteThongTinSP(masoSP, mausac, kichthuoc);
        }
    }
}
