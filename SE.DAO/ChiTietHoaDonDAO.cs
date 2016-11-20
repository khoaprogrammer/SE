using SE.TAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE.DAO
{
    public class ChiTietHoaDonDAO
    {
        public decimal GetTongTien(ChiTietHoaDon chitiet)
        {
            return chitiet.DonGia * chitiet.SoLuong;
        }
    }
}
