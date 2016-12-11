namespace SE.BUS
{
    using System.Linq;
    using DTO;

    public class GioHangBUS
    {
        private ChiTietHoaDonBUS cthdBUS;

        public GioHangBUS()
        {
            this.cthdBUS = new ChiTietHoaDonBUS();
        }

        public decimal TinhTongTruocThue(GioHangDTO giohang)
        {
            return giohang.DSChiTiet.Sum(x => this.cthdBUS.TinhTongTien(x));
        }

        public decimal TinhTongTienThue(GioHangDTO giohang)
        {
            return (this.TinhTongTruocThue(giohang) * Global.Thue) / 100;
        }

        public decimal TinhTongTienSauThue(GioHangDTO giohang)
        {
            return this.TinhTongTruocThue(giohang) + this.TinhTongTienThue(giohang);
        }
    }
}
