namespace SE.DTO
{
    using System.Collections.Generic;

    public class SanPhamDTO
    {
        public int MaSP { get; set; }

        public LoaiSPDTO LoaiSP { get; set; }

        public string TenSP { get; set; }

        public int SoLuongTon { get; set; }

        public List<ThongTinSPDTO> DSThongTin { get; set; }

        public override string ToString()
        {
            return this.MaSP + " - " + this.TenSP + " - " + this.SoLuongTon;
        }
    }
}