using SE.TAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace SE.DAO
{
    public class NhanVienDAO
    {
        private SEDataContext context;

        public NhanVienDAO()
        {
            this.context = Global.DataContext;
        }

        public List<NhanVien> GetDSNhanVien()
        {
            return this.context.NhanViens.ToList();
        }

        public NhanVien GetNhanVien(int maNV)
        {
            return this.context.NhanViens.FirstOrDefault(x => x.MaNV == maNV);
        }

        public void AddNhanVien(NhanVien nv)
        {
            this.context.NhanViens.InsertOnSubmit(nv);
        }

        public void DeleteNhanVien(NhanVien nv)
        {
            this.context.NhanViens.DeleteOnSubmit(nv);
        }

        public void SubmitChanges()
        {
            this.context.SubmitChanges();
        }
    }
}
