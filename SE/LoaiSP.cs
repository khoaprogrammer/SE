using SE.TAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE
{
    public partial class LoaiSP : Form
    {
        private SEDataContext context;
        private string tmpPath;
        public LoaiSP()
        {
            InitializeComponent();
            this.context = new SEDataContext(Global.ConnectionString);
        }

        private void LoaiSP_Load(object sender, EventArgs e)
        {
            this.lstbLoaiSP.Items.AddRange(this.context.LoaiSanPhams.ToArray());
            if (this.lstbLoaiSP.Items.Count > 0)
            {
                this.lstbLoaiSP.SelectedIndex = 0;
            }
        }

        private void lstbLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoaiSanPham selected = (LoaiSanPham)this.lstbLoaiSP.SelectedItem;
            tbxMaLoai.Text = selected.MaLoai.ToString();
            tbxTenLoai.Text = selected.TenLoai;
            lbeSLSanPham.Text = selected.SanPhams.Count.ToString();
            Image img = selected.GetImage();
            picLoaiSP.Image = img;
        }

        private void picLoaiSP_Click(object sender, EventArgs e)
        {
            fileLoaiSPIcon.ShowDialog();
            tmpPath = fileLoaiSPIcon.FileName;
            if (tmpPath != null)
            {
                Image img;
                using (var bmpTemp = new Bitmap(tmpPath))
                {
                    img = new Bitmap(bmpTemp);
                }
                picLoaiSP.Image = img;
            }
            else
            {
                picLoaiSP.Image = null;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (tbxMaLoai.Text.Equals(string.Empty) || tbxTenLoai.Text.Equals(string.Empty))
            {
                return;
            }
            int maLoai;
            if (!int.TryParse(tbxMaLoai.Text, out maLoai))
            {
                MessageBox.Show("Mã loại phải là số!");
                return;
            }
            if (this.context.LoaiSanPhams.Any(x => x.MaLoai == maLoai))
            {
                MessageBox.Show("Mã loại này đã tồn tại!");
                return;
            }
            this.context.LoaiSanPhams.InsertOnSubmit(new LoaiSanPham() { MaLoai = maLoai, TenLoai = tbxTenLoai.Text });
            this.context.SubmitChanges();
            if (this.tmpPath != null)
            {
                string dirPath = Path.Combine(Environment.CurrentDirectory, "imgs/loaisp");
                if (!Directory.Exists(dirPath))
                {
                    Directory.CreateDirectory(dirPath);
                }
                File.Copy(this.tmpPath, Path.Combine(Environment.CurrentDirectory, "imgs", "loaisp", maLoai.ToString() + ".png"), true);
                this.tmpPath = null;
            }
            this.lstbLoaiSP.Items.Clear();
            this.lstbLoaiSP.Items.AddRange(this.context.LoaiSanPhams.ToArray());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (this.lstbLoaiSP.SelectedItem == null)
            {
                return;
            }
            LoaiSanPham selected = (LoaiSanPham)this.lstbLoaiSP.SelectedItem;
            var result = MessageBox.Show("Bạn có muốn xóa loại sản phẩm này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (selected.SanPhams.Count > 0)
                {
                    MessageBox.Show("Đang tồn tại sản phẩm thuộc loại này!");
                    return;
                }
                LoaiSanPham deleteLoaiSP = this.context.LoaiSanPhams.First(x => x.MaLoai == selected.MaLoai);
                this.context.LoaiSanPhams.DeleteOnSubmit(deleteLoaiSP);
                this.context.SubmitChanges();
            }
            this.lstbLoaiSP.Items.Clear();
            this.lstbLoaiSP.Items.AddRange(this.context.LoaiSanPhams.ToArray());
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (this.lstbLoaiSP.SelectedItem == null)
            {
                return;
            }
            LoaiSanPham selected = (LoaiSanPham)this.lstbLoaiSP.SelectedItem;
            if (!tbxMaLoai.Text.Equals(selected.MaLoai.ToString()))
            {
                MessageBox.Show("Không được sửa mã loại!");
                tbxMaLoai.Text = selected.MaLoai.ToString();
                return;
            }
            LoaiSanPham updateLoaiSP = this.context.LoaiSanPhams.First(x => x.MaLoai == selected.MaLoai);
            updateLoaiSP.TenLoai = tbxTenLoai.Text;
            this.context.SubmitChanges();
            if (this.tmpPath != null)
            {
                string dirPath = Path.Combine(Environment.CurrentDirectory, "imgs/loaisp");
                File.Copy(this.tmpPath, Path.Combine(dirPath, selected.MaLoai.ToString() + ".png"), true);
            }
            this.lstbLoaiSP.Items.Clear();
            this.lstbLoaiSP.Items.AddRange(this.context.LoaiSanPhams.ToArray());
            this.lstbLoaiSP.SelectedIndex = 0;
        }
    }
}
