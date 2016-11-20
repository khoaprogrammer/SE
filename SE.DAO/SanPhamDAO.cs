using SE.TAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE.DAO
{
    public class SanPhamDAO
    {
        private SEDataContext context;

        public SanPhamDAO()
        {
            this.context = Global.DataContext;
        }

        public List<SanPham> GetDSSanPham()
        {
            return this.context.SanPhams.ToList();
        }

        public SanPham GetSanPham(int maSP)
        {
            return this.context.SanPhams.FirstOrDefault(x => x.MaSP == maSP);
        }

        public void AddSanPham(SanPham sp)
        {
            this.context.SanPhams.InsertOnSubmit(sp);
        }

        public void AddThongTinSP(SanPham sp, ThongTinSanPham tt)
        {
            sp.ThongTinSanPhams.Add(tt);
        }

        public ThongTinSanPham GetThongTinSP(SanPham sp, string mausac, string kichthuoc)
        {
            return sp.ThongTinSanPhams.FirstOrDefault(x => x.MauSac.Equals(mausac) && x.KichThuoc.Equals(kichthuoc));
        }

        public List<ThongTinSanPham> GetDSThongTinSP(SanPham sp)
        {
            return sp.ThongTinSanPhams.ToList();
        }

        public void DeleteSanPham(SanPham sp)
        {
            this.context.SanPhams.DeleteOnSubmit(sp);
        }

        public void SubmitChanges()
        {
            this.context.SubmitChanges();
        }
    }
}
