namespace SE
{
    partial class LoaiSP
    {
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
            if (disposing && (components != null))
            {
                components.Dispose();
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.lstbLoaiSP = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxTenLoai = new System.Windows.Forms.TextBox();
            this.tbxMaLoai = new System.Windows.Forms.TextBox();
            this.lbeSLSanPham = new System.Windows.Forms.Label();
            this.picLoaiSP = new System.Windows.Forms.PictureBox();
            this.fileLoaiSPIcon = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoaiSP)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 198F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lstbLoaiSP, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.52174F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.47826F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(418, 206);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.btnThem, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnXoa, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSua, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(201, 170);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(214, 33);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThem.Location = new System.Drawing.Point(0, 0);
            this.btnThem.Margin = new System.Windows.Forms.Padding(0);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(71, 33);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXoa.Location = new System.Drawing.Point(71, 0);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(0);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(71, 33);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSua.Location = new System.Drawing.Point(142, 0);
            this.btnSua.Margin = new System.Windows.Forms.Padding(0);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(72, 33);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // lstbLoaiSP
            // 
            this.lstbLoaiSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstbLoaiSP.FormattingEnabled = true;
            this.lstbLoaiSP.Location = new System.Drawing.Point(3, 3);
            this.lstbLoaiSP.Name = "lstbLoaiSP";
            this.tableLayoutPanel1.SetRowSpan(this.lstbLoaiSP, 2);
            this.lstbLoaiSP.Size = new System.Drawing.Size(192, 200);
            this.lstbLoaiSP.TabIndex = 1;
            this.lstbLoaiSP.SelectedIndexChanged += new System.EventHandler(this.lstbLoaiSP_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picLoaiSP);
            this.panel1.Controls.Add(this.lbeSLSanPham);
            this.panel1.Controls.Add(this.tbxMaLoai);
            this.panel1.Controls.Add(this.tbxTenLoai);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(201, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 161);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên loại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số lượng sản phẩm:";
            // 
            // tbxTenLoai
            // 
            this.tbxTenLoai.Location = new System.Drawing.Point(65, 40);
            this.tbxTenLoai.Name = "tbxTenLoai";
            this.tbxTenLoai.Size = new System.Drawing.Size(134, 20);
            this.tbxTenLoai.TabIndex = 1;
            // 
            // tbxMaLoai
            // 
            this.tbxMaLoai.Location = new System.Drawing.Point(65, 14);
            this.tbxMaLoai.Name = "tbxMaLoai";
            this.tbxMaLoai.Size = new System.Drawing.Size(134, 20);
            this.tbxMaLoai.TabIndex = 1;
            // 
            // lbeSLSanPham
            // 
            this.lbeSLSanPham.AutoSize = true;
            this.lbeSLSanPham.ForeColor = System.Drawing.Color.DarkRed;
            this.lbeSLSanPham.Location = new System.Drawing.Point(118, 74);
            this.lbeSLSanPham.Name = "lbeSLSanPham";
            this.lbeSLSanPham.Size = new System.Drawing.Size(35, 13);
            this.lbeSLSanPham.TabIndex = 2;
            this.lbeSLSanPham.Text = "label4";
            // 
            // picLoaiSP
            // 
            this.picLoaiSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLoaiSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLoaiSP.Location = new System.Drawing.Point(18, 99);
            this.picLoaiSP.Name = "picLoaiSP";
            this.picLoaiSP.Size = new System.Drawing.Size(50, 50);
            this.picLoaiSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLoaiSP.TabIndex = 3;
            this.picLoaiSP.TabStop = false;
            this.picLoaiSP.Click += new System.EventHandler(this.picLoaiSP_Click);
            // 
            // fileLoaiSPIcon
            // 
            this.fileLoaiSPIcon.Filter = "PNG Files|*.png";
            // 
            // LoaiSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 206);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "LoaiSP";
            this.Text = "LoaiSP";
            this.Load += new System.EventHandler(this.LoaiSP_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoaiSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ListBox lstbLoaiSP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbeSLSanPham;
        private System.Windows.Forms.TextBox tbxMaLoai;
        private System.Windows.Forms.TextBox tbxTenLoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picLoaiSP;
        private System.Windows.Forms.OpenFileDialog fileLoaiSPIcon;
    }
}