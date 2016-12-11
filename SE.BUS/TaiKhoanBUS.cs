namespace SE.BUS
{
    using SE.DAO;
    using SE.DTO;

    public class TaiKhoanBUS
    {
        private TaiKhoanDAO taikhoanDAO;

        public TaiKhoanBUS()
        {
            this.taikhoanDAO = new TaiKhoanDAO();
        }

        public TaiKhoanDTO GetTaiKhoan(int masoNV)
        {
            TaiKhoan result = this.taikhoanDAO.GetTaiKhoan(masoNV);
            return new TaiKhoanDTO
            {
                Username = result.Username,
                Password = result.Password
            };
        }

        public TaiKhoanDTO GetTaiKhoan(string username)
        {
            TaiKhoan result = this.taikhoanDAO.GetTaiKhoan(username);
            return new TaiKhoanDTO
            {
                Username = result.Username,
                Password = result.Password
            };
        }

        public bool TonTaiTaiKhoan(string username)
        {
            return this.taikhoanDAO.TonTaiTaiKhoan(username);
        }

        public void AddTaiKhoan(TaiKhoanDTO taikhoan)
        {
            this.taikhoanDAO.AddTaiKhoan(new TaiKhoan
            {
                Username = taikhoan.Username,
                Password = taikhoan.Password,
                MaNV = taikhoan.MaNV
            });
        }

        public void DeleteTaiKhoan(string username)
        {
            this.taikhoanDAO.DeleteTaiKhoan(username);
        }
    }
}
