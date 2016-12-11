namespace SE
{
    using System;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;
    using BUS;
    using DTO;

    public partial class LoaiSP : Form
    {
        private string tmpPath;
        private LoaiSPBUS loaiBUS;

        public LoaiSP()
        {
            this.InitializeComponent();
            this.loaiBUS = new LoaiSPBUS();
        }

        private void LoaiSP_Load(object sender, EventArgs e)
        {
            this.lstbLoaiSP.Items.AddRange(this.loaiBUS.GetDSLoaiSP().ToArray());
            if (this.lstbLoaiSP.Items.Count > 0)
            {
                this.lstbLoaiSP.SelectedIndex = 0;
            }
        }

        private void ListLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoaiSPDTO selected = (LoaiSPDTO)this.lstbLoaiSP.SelectedItem;
            this.tbxMaLoai.Text = selected.MaLoai.ToString();
            this.tbxTenLoai.Text = selected.TenLoai;
            this.lbeSLSanPham.Text = this.loaiBUS.GetDSSanPham(selected.MaLoai).Count.ToString();
            Image img = this.loaiBUS.GetImage(selected.MaLoai);
            this.picLoaiSP.Image = img;
        }

        private void PictureLoaiSP_Click(object sender, EventArgs e)
        {
            this.fileLoaiSPIcon.ShowDialog();
            this.tmpPath = this.fileLoaiSPIcon.FileName;
            if (this.tmpPath != string.Empty)
            {
                Image img;
                using (var bmpTemp = new Bitmap(this.tmpPath))
                {
                    img = new Bitmap(bmpTemp);
                }

                this.picLoaiSP.Image = img;
            }
            else
            {
                this.picLoaiSP.Image = null;
            }
        }

        private void ButtonThem_Click(object sender, EventArgs e)
        {
            if (this.tbxMaLoai.Text.Equals(string.Empty) || this.tbxTenLoai.Text.Equals(string.Empty))
            {
                return;
            }

            int masoLoai;
            if (!int.TryParse(this.tbxMaLoai.Text, out masoLoai))
            {
                MessageBox.Show("Mã loại phải là số!");
                return;
            }

            if (this.loaiBUS.TonTaiLoaiSP(int.Parse(this.tbxMaLoai.Text)))
            {
                MessageBox.Show("Mã loại này đã tồn tại!");
                return;
            }

            this.loaiBUS.AddLoaiSP(new LoaiSPDTO() { MaLoai = masoLoai, TenLoai = this.tbxTenLoai.Text });
            if (this.tmpPath != null)
            {
                string dirPath = Path.Combine(Environment.CurrentDirectory, "imgs/loaisp");
                if (!Directory.Exists(dirPath))
                {
                    Directory.CreateDirectory(dirPath);
                }

                File.Copy(this.tmpPath, Path.Combine(Environment.CurrentDirectory, "imgs", "loaisp", masoLoai.ToString() + ".png"), true);
                this.tmpPath = null;
            }

            this.lstbLoaiSP.Items.Clear();
            this.lstbLoaiSP.Items.AddRange(this.loaiBUS.GetDSLoaiSP().ToArray());
        }

        private void ButtonXoa_Click(object sender, EventArgs e)
        {
            if (this.lstbLoaiSP.SelectedItem == null)
            {
                return;
            }

            LoaiSPDTO selected = (LoaiSPDTO)this.lstbLoaiSP.SelectedItem;
            var result = MessageBox.Show("Bạn có muốn xóa loại sản phẩm này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (this.loaiBUS.GetDSSanPham(selected.MaLoai).Count > 0)
                {
                    MessageBox.Show("Đang tồn tại sản phẩm thuộc loại này!");
                    return;
                }

                this.loaiBUS.DeleteLoaiSP(int.Parse(this.tbxMaLoai.Text));
            }

            this.lstbLoaiSP.Items.Clear();
            this.lstbLoaiSP.Items.AddRange(this.loaiBUS.GetDSLoaiSP().ToArray());
        }

        private void ButtonSua_Click(object sender, EventArgs e)
        {
            if (this.lstbLoaiSP.SelectedItem == null)
            {
                return;
            }

            LoaiSPDTO selected = (LoaiSPDTO)this.lstbLoaiSP.SelectedItem;
            if (!this.tbxMaLoai.Text.Equals(selected.MaLoai.ToString()))
            {
                MessageBox.Show("Không được sửa mã loại!");
                this.tbxMaLoai.Text = selected.MaLoai.ToString();
                return;
            }

            this.loaiBUS.EditLoaiSP(selected.MaLoai, this.tbxTenLoai.Text);
            if (this.tmpPath != null)
            {
                string dirPath = Path.Combine(Environment.CurrentDirectory, "imgs/loaisp");
                File.Copy(this.tmpPath, Path.Combine(dirPath, selected.MaLoai.ToString() + ".png"), true);
            }

            this.lstbLoaiSP.Items.Clear();
            this.lstbLoaiSP.Items.AddRange(this.loaiBUS.GetDSLoaiSP().ToArray());
            this.lstbLoaiSP.SelectedIndex = 0;
        }
    }
}
