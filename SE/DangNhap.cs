namespace SE
{
    using System;
    using System.Windows.Forms;
    using BUS;
    using DTO;

    public partial class DangNhap : Form
    {
        private NhanVienBUS nhanvienBUS;

        public DangNhap()
        {
            this.InitializeComponent();
            this.nhanvienBUS = new NhanVienBUS();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            this.tbxTenDangNhap.Focus();
        }

        private void ButtonDangNhap_Click(object sender, EventArgs e)
        {
            if (this.tbxTenDangNhap.Text.Equals(string.Empty) || this.tbxMatKhau.Text.Equals(string.Empty))
            {
                this.lbeError.Text = "Vui lòng nhập đủ thông tin!";
                this.lbeError.Visible = true;
                return;
            }

            NhanVienDTO nhanvien = this.nhanvienBUS.GetNhanVien(this.tbxTenDangNhap.Text, this.tbxMatKhau.Text);
            if (nhanvien == null)
            {
                this.lbeError.Text = "Sai tên đăng nhập hoặc mật khẩu!";
                this.lbeError.Visible = true;
                return;
            }

            Global.NguoiSuDung = nhanvien;
            this.Close();
        }

        private void DangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ButtonDangNhap_Click(null, EventArgs.Empty);
                e.SuppressKeyPress = true;
            }
        }
    }
}
