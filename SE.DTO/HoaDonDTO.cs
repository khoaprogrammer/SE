namespace SE.DTO
{
    using System;
    using System.Collections.Generic;

    public class HoaDonDTO
    {
        public HoaDonDTO()
        {
            this.DSChiTiet = new List<ChiTietHoaDonDTO>();
        }

        public int MaHD { get; set; }

        public NhanVienDTO NhanVien { get; set; }

        public DateTime NgayLap { get; set; }

        public string HoTenKH { get; set; }

        public string DiaChiKH { get; set; }

        public string DienThoaiKH { get; set; }

        public decimal TongTienTruocThue { get; set; }

        public decimal TongTienThue { get; set; }

        public decimal TongTienSauThue { get; set; }

        public List<ChiTietHoaDonDTO> DSChiTiet { get; set; }
    }
}
