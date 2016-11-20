using SE.TAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE.DAO
{
    public class HoaDonDAO
    {
        private SEDataContext context;

        public HoaDonDAO()
        {
            this.context = Global.DataContext;
        }

        public void AddHoaDon(HoaDon hoadon)
        {
            this.context.HoaDons.InsertOnSubmit(hoadon);
        }

        public List<HoaDon> GetDSHoaDon()
        {
            return this.context.HoaDons.ToList();
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
