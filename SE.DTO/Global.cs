namespace SE.DTO
{
    using System.Collections.Generic;

    public class Global
    {
        public static string ConnectionString { get; set; } = @"Data Source=DESKTOP-UUV7A6H\SQLEXPRESS;Initial Catalog=SE;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static NhanVienDTO NguoiSuDung { get; set; }

        public static int Thue { get; set; }
    }
}
