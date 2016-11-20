using SE.TAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE.DAO
{
    public class ChiTietSanPhamDAO
    {
        private SEDataContext context;

        public ChiTietSanPhamDAO()
        {
            this.context = Global.DataContext;
        }

        public ChiTietSanPham GetChiTietSP(string mausac, string kichthuoc)
        {
            ChiTietSanPham chitiet = this.context.ChiTietSanPhams.FirstOrDefault(x => x.MauSac.Equals(mausac) && x.KichThuoc.Equals(kichthuoc));
            if (chitiet != null)
            {
                return chitiet;
            }
            AddChiTietSP(mausac, kichthuoc);
            SubmitChanges();
            return this.context.ChiTietSanPhams.First(x => x.MauSac.Equals(mausac) && x.KichThuoc.Equals(kichthuoc));
        }

        public void AddChiTietSP(string mausac, string kichthuoc)
        {
            this.context.ChiTietSanPhams.InsertOnSubmit(new ChiTietSanPham() { MauSac = mausac, KichThuoc = kichthuoc });
        }

        public void SubmitChanges()
        {
            this.context.SubmitChanges();
        }
    }
}
