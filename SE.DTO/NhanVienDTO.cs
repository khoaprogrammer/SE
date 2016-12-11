namespace SE.DTO
{
    using System;

    public class NhanVienDTO
    {
        public int MaNV { get; set; }

        public TaiKhoanDTO TaiKhoan { get; set; }

        public string HoTen { get; set; }

        public DateTime NgaySinh { get; set; }

        public string DiaChi { get; set; }

        public string CMND { get; set; }

        public decimal LuongCoBan { get; set; }

        public DateTime NgayTuyenDung { get; set; }

        public string NoiLamViec { get; set; }

        public string ChucVu { get; set; }

        public override string ToString()
        {
            return this.HoTen;
        }
    }
}