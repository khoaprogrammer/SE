namespace SE.DAO
{
    using System.Collections.Generic;
    using System.Linq;
    using DTO;

    public class TaiKhoanDAO
    {
        private SEDataContext context;

        public TaiKhoanDAO()
        {
            this.context = new SEDataContext(Global.ConnectionString);
        }

        public List<TaiKhoan> GetDSTaiKhoan()
        {
            return this.context.TaiKhoans.ToList();
        }

        public TaiKhoan GetTaiKhoan(string username)
        {
            return this.context.TaiKhoans.FirstOrDefault(x => x.Username.Equals(username));
        }

        public TaiKhoan GetTaiKhoan(int masoNV)
        {
            return this.context.TaiKhoans.First(x => x.MaNV == masoNV);
        }

        public bool TonTaiTaiKhoan(string username)
        {
            return this.context.TaiKhoans.Any(x => x.Username.ToString().Equals(username));
        }

        public void AddTaiKhoan(TaiKhoan tk)
        {
            this.context.TaiKhoans.InsertOnSubmit(tk);
            this.context.SubmitChanges();
        }

        public void DeleteTaiKhoan(string username)
        {
            TaiKhoan delete = this.context.TaiKhoans.First(x => x.Username.Equals(username));
            this.context.TaiKhoans.DeleteOnSubmit(delete);
            this.context.SubmitChanges();
        }
    }
}
