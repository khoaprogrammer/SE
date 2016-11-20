using SE.TAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE.DAO
{
    public class ThongTinSanPhamDAO
    {
        private SEDataContext context;

        public ThongTinSanPhamDAO()
        {
            this.context = Global.DataContext;
        }

        public ThongTinSanPham GetThongTinSP(int maSP, string mausac, string kichthuoc)
        {
            return this.context.ThongTinSanPhams.First(x => x.MaSanPham == maSP && x.MauSac.Equals(mausac) && x.KichThuoc.Equals(kichthuoc));
        }

        public void AddThongTinSP(ThongTinSanPham tt)
        {
            this.context.ThongTinSanPhams.InsertOnSubmit(tt);
        }

        public void DeleteThongTinSP(ThongTinSanPham tt)
        {
            this.context.ThongTinSanPhams.DeleteOnSubmit(tt);
        }

        public void SubmitChanges()
        {
            this.context.SubmitChanges();
        }
    }
}
