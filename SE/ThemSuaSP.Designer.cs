namespace SE
{
    public partial class ThemSuaSP
    {
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxLoaiSanPham;
        private System.Windows.Forms.TextBox tbxSoLuongTon;
        private System.Windows.Forms.TextBox tbxTenSanPham;
        private System.Windows.Forms.TextBox tbxMaSanPham;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList imgIcon;
        private System.Windows.Forms.GroupBox groupChiTietSP;
        private System.Windows.Forms.Button btnXoaChiTiet;
        private System.Windows.Forms.Button btnThemChiTiet;
        private System.Windows.Forms.TextBox tbxSoLuongTonCT;
        private System.Windows.Forms.TextBox tbxKichThuoc;
        private System.Windows.Forms.TextBox tbxMauSac;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSuaChiTiet;
        private BrightIdeasSoftware.FastObjectListView lstvDSChiTiet;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button button6;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private System.Windows.Forms.TextBox tbxDonGia;
        private System.Windows.Forms.Label label8;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.cbxLoaiSanPham = new System.Windows.Forms.ComboBox();
            this.tbxSoLuongTon = new System.Windows.Forms.TextBox();
            this.tbxTenSanPham = new System.Windows.Forms.TextBox();
            this.tbxMaSanPham = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imgIcon = new System.Windows.Forms.ImageList(this.components);
            this.groupChiTietSP = new System.Windows.Forms.GroupBox();
            this.btnSuaChiTiet = new System.Windows.Forms.Button();
            this.btnXoaChiTiet = new System.Windows.Forms.Button();
            this.btnThemChiTiet = new System.Windows.Forms.Button();
            this.tbxDonGia = new System.Windows.Forms.TextBox();
            this.tbxSoLuongTonCT = new System.Windows.Forms.TextBox();
            this.tbxKichThuoc = new System.Windows.Forms.TextBox();
            this.tbxMauSac = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstvDSChiTiet = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupChiTietSP.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstvDSChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.cbxLoaiSanPham);
            this.groupBox1.Controls.Add(this.tbxSoLuongTon);
            this.groupBox1.Controls.Add(this.tbxTenSanPham);
            this.groupBox1.Controls.Add(this.tbxMaSanPham);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(230, 28);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(34, 21);
            this.button6.TabIndex = 3;
            this.button6.Text = "...";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // cbxLoaiSanPham
            // 
            this.cbxLoaiSanPham.FormattingEnabled = true;
            this.cbxLoaiSanPham.Location = new System.Drawing.Point(99, 28);
            this.cbxLoaiSanPham.Name = "cbxLoaiSanPham";
            this.cbxLoaiSanPham.Size = new System.Drawing.Size(125, 21);
            this.cbxLoaiSanPham.TabIndex = 2;
            // 
            // tbxSoLuongTon
            // 
            this.tbxSoLuongTon.BackColor = System.Drawing.SystemColors.Info;
            this.tbxSoLuongTon.Location = new System.Drawing.Point(99, 107);
            this.tbxSoLuongTon.Name = "tbxSoLuongTon";
            this.tbxSoLuongTon.ReadOnly = true;
            this.tbxSoLuongTon.Size = new System.Drawing.Size(165, 20);
            this.tbxSoLuongTon.TabIndex = 1;
            // 
            // tbxTenSanPham
            // 
            this.tbxTenSanPham.Location = new System.Drawing.Point(99, 81);
            this.tbxTenSanPham.Name = "tbxTenSanPham";
            this.tbxTenSanPham.Size = new System.Drawing.Size(165, 20);
            this.tbxTenSanPham.TabIndex = 1;
            // 
            // tbxMaSanPham
            // 
            this.tbxMaSanPham.BackColor = System.Drawing.SystemColors.Info;
            this.tbxMaSanPham.Location = new System.Drawing.Point(99, 55);
            this.tbxMaSanPham.Name = "tbxMaSanPham";
            this.tbxMaSanPham.ReadOnly = true;
            this.tbxMaSanPham.Size = new System.Drawing.Size(165, 20);
            this.tbxMaSanPham.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số lượng tồn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên sản phẩm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Loại sản phẩm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sản phẩm:";
            // 
            // imgIcon
            // 
            this.imgIcon.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgIcon.ImageSize = new System.Drawing.Size(16, 16);
            this.imgIcon.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupChiTietSP
            // 
            this.groupChiTietSP.Controls.Add(this.btnSuaChiTiet);
            this.groupChiTietSP.Controls.Add(this.btnXoaChiTiet);
            this.groupChiTietSP.Controls.Add(this.btnThemChiTiet);
            this.groupChiTietSP.Controls.Add(this.tbxDonGia);
            this.groupChiTietSP.Controls.Add(this.tbxSoLuongTonCT);
            this.groupChiTietSP.Controls.Add(this.tbxKichThuoc);
            this.groupChiTietSP.Controls.Add(this.tbxMauSac);
            this.groupChiTietSP.Controls.Add(this.label8);
            this.groupChiTietSP.Controls.Add(this.label7);
            this.groupChiTietSP.Controls.Add(this.label6);
            this.groupChiTietSP.Controls.Add(this.label5);
            this.groupChiTietSP.Location = new System.Drawing.Point(288, 14);
            this.groupChiTietSP.Name = "groupChiTietSP";
            this.groupChiTietSP.Size = new System.Drawing.Size(247, 138);
            this.groupChiTietSP.TabIndex = 1;
            this.groupChiTietSP.TabStop = false;
            this.groupChiTietSP.Text = "Chi tiết sản phẩm";
            // 
            // btnSuaChiTiet
            // 
            this.btnSuaChiTiet.Location = new System.Drawing.Point(180, 56);
            this.btnSuaChiTiet.Name = "btnSuaChiTiet";
            this.btnSuaChiTiet.Size = new System.Drawing.Size(61, 33);
            this.btnSuaChiTiet.TabIndex = 2;
            this.btnSuaChiTiet.Text = "Sửa";
            this.btnSuaChiTiet.UseVisualStyleBackColor = true;
            this.btnSuaChiTiet.Click += new System.EventHandler(this.ButtonSuaChiTiet_Click);
            // 
            // btnXoaChiTiet
            // 
            this.btnXoaChiTiet.Location = new System.Drawing.Point(180, 95);
            this.btnXoaChiTiet.Name = "btnXoaChiTiet";
            this.btnXoaChiTiet.Size = new System.Drawing.Size(61, 33);
            this.btnXoaChiTiet.TabIndex = 2;
            this.btnXoaChiTiet.Text = "Xóa";
            this.btnXoaChiTiet.UseVisualStyleBackColor = true;
            this.btnXoaChiTiet.Click += new System.EventHandler(this.ButtonXoaChiTiet_Click);
            // 
            // btnThemChiTiet
            // 
            this.btnThemChiTiet.Location = new System.Drawing.Point(180, 17);
            this.btnThemChiTiet.Name = "btnThemChiTiet";
            this.btnThemChiTiet.Size = new System.Drawing.Size(61, 33);
            this.btnThemChiTiet.TabIndex = 2;
            this.btnThemChiTiet.Text = "Thêm";
            this.btnThemChiTiet.UseVisualStyleBackColor = true;
            this.btnThemChiTiet.Click += new System.EventHandler(this.ButtonThemChiTiet_Click);
            // 
            // tbxDonGia
            // 
            this.tbxDonGia.Location = new System.Drawing.Point(82, 79);
            this.tbxDonGia.Name = "tbxDonGia";
            this.tbxDonGia.Size = new System.Drawing.Size(92, 20);
            this.tbxDonGia.TabIndex = 1;
            // 
            // tbxSoLuongTon_CT
            // 
            this.tbxSoLuongTonCT.Location = new System.Drawing.Point(82, 105);
            this.tbxSoLuongTonCT.Name = "tbxSoLuongTon_CT";
            this.tbxSoLuongTonCT.Size = new System.Drawing.Size(92, 20);
            this.tbxSoLuongTonCT.TabIndex = 1;
            // 
            // tbxKichThuoc
            // 
            this.tbxKichThuoc.Location = new System.Drawing.Point(82, 53);
            this.tbxKichThuoc.Name = "tbxKichThuoc";
            this.tbxKichThuoc.Size = new System.Drawing.Size(92, 20);
            this.tbxKichThuoc.TabIndex = 1;
            // 
            // tbxMauSac
            // 
            this.tbxMauSac.Location = new System.Drawing.Point(82, 26);
            this.tbxMauSac.Name = "tbxMauSac";
            this.tbxMauSac.Size = new System.Drawing.Size(92, 20);
            this.tbxMauSac.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Đơn giá:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số lượng tồn:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kích thước:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Màu sắc:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstvDSChiTiet);
            this.groupBox3.Location = new System.Drawing.Point(12, 158);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(393, 131);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách chi tiết";
            // 
            // lstvDSChiTiet
            // 
            this.lstvDSChiTiet.AllColumns.Add(this.olvColumn1);
            this.lstvDSChiTiet.AllColumns.Add(this.olvColumn2);
            this.lstvDSChiTiet.AllColumns.Add(this.olvColumn3);
            this.lstvDSChiTiet.AllColumns.Add(this.olvColumn4);
            this.lstvDSChiTiet.CellEditUseWholeCell = false;
            this.lstvDSChiTiet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn3,
            this.olvColumn4});
            this.lstvDSChiTiet.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstvDSChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvDSChiTiet.FullRowSelect = true;
            this.lstvDSChiTiet.Location = new System.Drawing.Point(3, 16);
            this.lstvDSChiTiet.Name = "lstvDSChiTiet";
            this.lstvDSChiTiet.ShowGroups = false;
            this.lstvDSChiTiet.Size = new System.Drawing.Size(387, 112);
            this.lstvDSChiTiet.TabIndex = 0;
            this.lstvDSChiTiet.UseCompatibleStateImageBehavior = false;
            this.lstvDSChiTiet.View = System.Windows.Forms.View.Details;
            this.lstvDSChiTiet.VirtualMode = true;
            this.lstvDSChiTiet.SelectedIndexChanged += new System.EventHandler(this.ListDSChiTiet_SelectedIndexChanged);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "MauSac";
            this.olvColumn1.Text = "Màu sắc";
            this.olvColumn1.Width = 69;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "KichThuoc";
            this.olvColumn2.Text = "Kích thước";
            this.olvColumn2.Width = 83;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "DonGia";
            this.olvColumn3.AspectToStringFormat = "{0: #,#}";
            this.olvColumn3.Text = "Đơn giá";
            this.olvColumn3.Width = 77;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "SoLuongTon";
            this.olvColumn4.Text = "Số lượng tồn";
            this.olvColumn4.Width = 93;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(411, 218);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(124, 31);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.ButtonLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(411, 255);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(124, 31);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.ButtonHuy_Click);
            // 
            // ThemSuaSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 301);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupChiTietSP);
            this.Controls.Add(this.groupBox1);
            this.Name = "ThemSuaSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý sản phẩm";
            this.Load += new System.EventHandler(this.ThemSuaSP_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupChiTietSP.ResumeLayout(false);
            this.groupChiTietSP.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstvDSChiTiet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}