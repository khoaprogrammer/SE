using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE.TAO
{
    partial class ThongTinSanPham
    {
        public ThongTinSanPham(string mausac, string kichthuoc, int soluongton, decimal dongia)
        {
            this._MauSac = mausac;
            this._KichThuoc = kichthuoc;
            this._SoLuongTon = soluongton;
            this._DonGia = dongia;
        }

        public override string ToString()
        {
            return this._MauSac + " - " + this._KichThuoc + " - " + ((decimal)this.DonGia).ToString("#,#") + " - " + this._SoLuongTon;
        }
    }
}
