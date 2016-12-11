namespace SE.BUS
{
    using System.Collections.Generic;
    using System.Linq;
    using DAO;
    using DTO;

    public class NhanVienBUS
    {
        private NhanVienDAO nhanvienDAO;
        private TaiKhoanBUS taikhoanBUS;

        public NhanVienBUS()
        {
            this.nhanvienDAO = new NhanVienDAO();
            this.taikhoanBUS = new TaiKhoanBUS();
        }

        public NhanVienDTO ChuyenDTO(NhanVien nhanvien)
        {
            return new NhanVienDTO
            {
                MaNV = nhanvien.MaNV,
                ChucVu = nhanvien.ChucVu,
                CMND = nhanvien.CMND,
                DiaChi = nhanvien.DiaChi,
                HoTen = nhanvien.HoTen,
                LuongCoBan = nhanvien.LuongCoBan,
                NgaySinh = nhanvien.NgaySinh,
                NgayTuyenDung = nhanvien.NgayTuyenDung,
                NoiLamViec = nhanvien.NoiLamViec,
                TaiKhoan = this.taikhoanBUS.GetTaiKhoan(nhanvien.MaNV)
            };
        }

        public NhanVien ChuyenDAO(NhanVienDTO nhanvien)
        {
            return new NhanVien
            {
                MaNV = nhanvien.MaNV,
                ChucVu = nhanvien.ChucVu,
                CMND = nhanvien.CMND,
                DiaChi = nhanvien.DiaChi,
                HoTen = nhanvien.HoTen,
                LuongCoBan = nhanvien.LuongCoBan,
                NgaySinh = nhanvien.NgaySinh,
                NgayTuyenDung = nhanvien.NgayTuyenDung,
                NoiLamViec = nhanvien.NoiLamViec,
                Username = nhanvien.TaiKhoan.Username
            };
        }

        public NhanVienDTO GetNhanVien(string username, string password)
        {
            NhanVien result = this.nhanvienDAO.GetNhanVien(username, password);
            if (result == null)
            {
                return null;
            }

            return this.ChuyenDTO(result);
        }

        public NhanVienDTO GetNhanVien(int masoNV)
        {
            NhanVien result = this.nhanvienDAO.GetNhanVien(masoNV);
            if (result == null)
            {
                return null;
            }

            return this.ChuyenDTO(result);
        }

        public List<NhanVienDTO> GetDSNhanVien()
        {
            return this.nhanvienDAO.GetDSNhanVien().Select(x => new NhanVienDTO
            {
                CMND = x.CMND,
                DiaChi = x.DiaChi,
                HoTen = x.HoTen,
                MaNV = x.MaNV,
                ChucVu = x.ChucVu,
                LuongCoBan = x.LuongCoBan,
                NgaySinh = x.NgaySinh,
                NgayTuyenDung = x.NgayTuyenDung,
                NoiLamViec = x.NoiLamViec,
                TaiKhoan = this.taikhoanBUS.GetTaiKhoan(x.MaNV)
            }).ToList();
        }

        public bool TonTaiNhanVien(int masoNV)
        {
            return this.nhanvienDAO.TonTaiNhanVien(masoNV);
        }

        public void AddNhanVien(NhanVienDTO nv)
        {
            this.nhanvienDAO.AddNhanVien(this.ChuyenDAO(nv));
        }

        public void DeleteNhanVien(int masoNV)
        {
            this.nhanvienDAO.DeleteNhanVien(masoNV);
        }

        public void ChuyenTaiKhoan(int masoNV, string username)
        {
            this.nhanvienDAO.ChuyenTaiKhoan(masoNV, username);
        }

        public void DoiMatKhau(int masoNV, string password)
        {
            this.nhanvienDAO.DoiMatKhau(masoNV, password);
        }

        public int GetMaNVMax()
        {
            return this.GetDSNhanVien().Max(x => x.MaNV);
        }

        public void EditNhanVien(NhanVienDTO nv)
        {
            this.nhanvienDAO.EditNhanVien(nv);
        }
    }
}
