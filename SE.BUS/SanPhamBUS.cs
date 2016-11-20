using SE.TAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace SE.BUS
{
    public class SanPhamBUS
    {
        public void UpdateSoLuongTon(SanPham sp)
        {
            int tmp = 0;
            foreach (ThongTinSanPham thongtin in sp.ThongTinSanPhams.ToArray())
            {
                tmp += (int)thongtin.SoLuongTon;
            }
            sp.SoLuongTon = tmp;
        }
    }
}
