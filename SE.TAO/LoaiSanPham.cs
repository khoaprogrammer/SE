using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE.TAO
{
    public partial class LoaiSanPham
    {

        public Image GetImage()
        {
            if (!File.Exists(Path.Combine(Environment.CurrentDirectory, "imgs/loaisp", this._MaLoai.ToString() + ".png")))
            {
                return null;
            }
            Image img;
            using (var bmpTemp = new Bitmap(Path.Combine(Environment.CurrentDirectory, "imgs/loaisp", this._MaLoai.ToString() + ".png")))
            {
                img = new Bitmap(bmpTemp);
            }
            return img;
        }

        public override string ToString()
        {
            return this.MaLoai + " - " + this.TenLoai;
        }
    }
}
