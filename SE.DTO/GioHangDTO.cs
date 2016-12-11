namespace SE.DTO
{
    using System.Collections.Generic;

    public class GioHangDTO
    {
        public GioHangDTO()
        {
            this.DSChiTiet = new List<ChiTietHoaDonDTO>();
        }

        public List<ChiTietHoaDonDTO> DSChiTiet { get; set; }
    }
}
