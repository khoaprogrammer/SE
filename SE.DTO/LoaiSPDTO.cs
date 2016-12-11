namespace SE.DTO
{
    public class LoaiSPDTO
    {
        public int MaLoai { get; set; }

        public string TenLoai { get; set; }

        public override string ToString()
        {
            return this.MaLoai + " - " + this.TenLoai;
        }
    }
}
