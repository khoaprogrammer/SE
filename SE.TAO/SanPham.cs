using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace SE.TAO
{
    public partial class SanPham
    {
        public string GetTenLoaiSP()
        {
            return this.LoaiSanPham.TenLoai;
        }

        public void TinhSoLuongTon()
        {
            this.SoLuongTon = (int)this.ThongTinSanPhams.Sum(x => x.SoLuongTon);
        }

        public override string ToString()
        {
            return this.TenSP + " - " + this.SoLuongTon;
        }
    }
}
