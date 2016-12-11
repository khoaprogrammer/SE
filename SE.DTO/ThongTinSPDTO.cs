namespace SE.DTO
{
    public class ThongTinSPDTO
    {
        public string KichThuoc { get; set; }

        public string MauSac { get; set; }

        public int SoLuongTon { get; set; }

        public decimal DonGia { get; set; }

        public override string ToString()
        {
            return this.KichThuoc + " - " + this.MauSac + " - " + this.SoLuongTon;
        }
    }
}
