using SE.TAO;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE.DAO
{
    public class LoaiSanPhamDAO
    {
        private SEDataContext context;

        public LoaiSanPhamDAO()
        {
            this.context = Global.DataContext;
        }

        public List<LoaiSanPham> GetDSLoaiSP()
        {
            return this.context.LoaiSanPhams.ToList();
        }

        public LoaiSanPham GetLoaiSP(int ma)
        {
            return this.context.LoaiSanPhams.FirstOrDefault(x => x.MaLoai == ma);
        }

        public LoaiSanPham GetLoaiSP(string ten)
        {
            return this.context.LoaiSanPhams.FirstOrDefault(x => x.TenLoai.Equals(ten));
        }

        public void Refresh()
        {
            this.context.Refresh(RefreshMode.OverwriteCurrentValues, this.context.LoaiSanPhams);
        }
    }
}
