namespace SE.DAO
{
    using System.Collections.Generic;
    using System.Linq;
    using DTO;

    public class NhanVienDAO
    {
        private SEDataContext context;
        private TaiKhoanDAO taikhoanDAO;

        public NhanVienDAO()
        {
            this.context = new SEDataContext(Global.ConnectionString);
            this.taikhoanDAO = new TaiKhoanDAO();
        }

        public List<NhanVien> GetDSNhanVien()
        {
            return this.context.NhanViens.ToList();
        }

        public NhanVien GetNhanVien(int masoNV)
        {
            return this.context.NhanViens.FirstOrDefault(x => x.MaNV == masoNV);
        }

        public NhanVien GetNhanVien(string username, string password)
        {
            return this.context.NhanViens.FirstOrDefault(x => x.TaiKhoan.Username.ToString().Equals(username) && x.TaiKhoan.Password.ToString().Equals(password));
        }

        public bool TonTaiNhanVien(int masoNV)
        {
            return this.context.NhanViens.Any(x => x.MaNV == masoNV);
        }

        public void AddNhanVien(NhanVien nv)
        {
            this.context.NhanViens.InsertOnSubmit(nv);
            this.context.SubmitChanges();
        }

        public void DeleteNhanVien(int masoNV)
        {
            NhanVien delete = this.context.NhanViens.First(x => x.MaNV == masoNV);
            this.context.NhanViens.DeleteOnSubmit(delete);
            this.context.SubmitChanges();
        }

        public void SubmitChanges()
        {
            this.context.SubmitChanges();
        }

        public void ChuyenTaiKhoan(int masoNV, string username)
        {
            NhanVien nv = this.GetNhanVien(masoNV);
            TaiKhoan tk = this.taikhoanDAO.GetTaiKhoan(username);
            nv.Username = tk.Username;
            this.context.SubmitChanges();
        }

        public void DoiMatKhau(int masoNV, string password)
        {
            NhanVien nv = this.GetNhanVien(masoNV);
            nv.TaiKhoan.Password = password;
            this.context.SubmitChanges();
        }

        public void EditNhanVien(NhanVienDTO nv)
        {
            NhanVien nhanvien = this.GetNhanVien(nv.MaNV);
            nhanvien.HoTen = nv.HoTen;
            nhanvien.NgaySinh = nv.NgaySinh;
            nhanvien.NoiLamViec = nv.NoiLamViec;
            nhanvien.NgayTuyenDung = nv.NgayTuyenDung;
            nhanvien.LuongCoBan = nv.LuongCoBan;
            nhanvien.ChucVu = nv.ChucVu;
            nhanvien.CMND = nv.CMND;
            nhanvien.DiaChi = nv.DiaChi;
            this.context.SubmitChanges();
        }
    }
}
