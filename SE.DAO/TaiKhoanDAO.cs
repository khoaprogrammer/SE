using SE.TAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE.DAO
{
    public class TaiKhoanDAO
    {
        private SEDataContext context;

        public TaiKhoanDAO()
        {
            this.context = Global.DataContext;
        }

        public List<TaiKhoan> GetDSTaiKhoan()
        {
            return this.context.TaiKhoans.ToList();
        }

        public TaiKhoan GetTaiKhoan(string username)
        {
            return this.context.TaiKhoans.FirstOrDefault(x => x.Username.Equals(username));
        }

        public void AddTaiKhoan(TaiKhoan tk)
        {
            this.context.TaiKhoans.InsertOnSubmit(tk);
        }

        public void DeleteTaiKhoan(TaiKhoan tk)
        {
            this.context.TaiKhoans.DeleteOnSubmit(tk);
        }

        public void SubmitChanges()
        {
            this.context.SubmitChanges();
        }
    }
}
