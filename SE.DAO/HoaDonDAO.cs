namespace SE.DAO
{
    using System.Collections.Generic;
    using System.Linq;
    using DTO;

    public class HoaDonDAO
    {
        private SEDataContext context;

        public HoaDonDAO()
        {
            this.context = new SEDataContext(Global.ConnectionString);
        }

        public void XuatHoaDon(HoaDon hoadon)
        {
            this.context.HoaDons.InsertOnSubmit(hoadon);
            this.context.SubmitChanges();
        }

        public List<HoaDon> GetDSHoaDon()
        {
            return this.context.HoaDons.ToList();
        }

        public HoaDon GetHoaDon(int masoHD)
        {
            return this.context.HoaDons.FirstOrDefault(x => x.MaHD == masoHD);
        }

        public int GetSLHoaDon()
        {
            return this.context.HoaDons.Count();
        }

        public void SubmitChanges()
        {
            this.context.SubmitChanges();
        }
    }
}
