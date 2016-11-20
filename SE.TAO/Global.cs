using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE.TAO
{
    public class Global
    {
        public static string ConnectionString = @"Data Source=DESKTOP-UUV7A6H\SQLEXPRESS;Initial Catalog=SE;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static SEDataContext DataContext = new SEDataContext(ConnectionString);
        public static List<LoaiSanPham> dsLoaiSP;
        public static List<SanPham> dsSanPham;
        public static List<NhanVien> dsNhanVien;
        public static List<HoaDon> dsHoaDon;
        public static List<TaiKhoan> dsTaiKhoan;

        public static NhanVien nguoiSuDung;
        public static int Thue;

    }
}
