﻿namespace SE
{
    public partial class Form1
    {
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ImageList imgNhanVien;
        private BrightIdeasSoftware.OLVColumn lstColChucVu;
        private System.Windows.Forms.ImageList imgChucVu;
        private System.Windows.Forms.ImageList imgGroup;
        private BrightIdeasSoftware.OLVColumn lstvSanPhamColLoaiSP;
        private System.Windows.Forms.ImageList imgSanPham;
        private System.Windows.Forms.ImageList imgHoaDon;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thiếtLậpToolStripMenuItem;
        private System.Windows.Forms.Timer tmrValidate;
        private System.Windows.Forms.TabPage tabBH;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbeMaHoaDon;
        private System.Windows.Forms.Label lbeNgayLap;
        private System.Windows.Forms.Label lbeNhanVienLap;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnThemGioHang;
        private System.Windows.Forms.TextBox tbxSoLuongTabBanHang;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ComboBox cbxSanPhamTabBanHang;
        private System.Windows.Forms.ComboBox cbxChiTietTabBanHang;
        private System.Windows.Forms.ComboBox cbxLoaiSPTabBanHang;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private BrightIdeasSoftware.FastObjectListView lstvGioHang;
        private BrightIdeasSoftware.OLVColumn olvColumn18;
        private BrightIdeasSoftware.OLVColumn olvColumn19;
        private BrightIdeasSoftware.OLVColumn olvColumn20;
        private BrightIdeasSoftware.OLVColumn olvColumn21;
        private BrightIdeasSoftware.OLVColumn olvColumn22;
        private BrightIdeasSoftware.OLVColumn olvColumn23;
        private BrightIdeasSoftware.OLVColumn olvColumn24;
        private BrightIdeasSoftware.OLVColumn olvColumn25;
        private BrightIdeasSoftware.OLVColumn olvColumn26;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lbeTongTienTruocThue;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label lbeTongTienThue;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label lbeTongTienSauThue;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.RichTextBox rtbxError;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnXuatHoaDon;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox tbxTenKhachHang;
        private System.Windows.Forms.TextBox tbxSDTKH;
        private System.Windows.Forms.TextBox tbxDiaChiKH;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TabPage tabQLHD;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.GroupBox groupBox6;
        private BrightIdeasSoftware.FastObjectListView lstvHoaDon;
        private BrightIdeasSoftware.OLVColumn lstvHoaDonColMaHD;
        private BrightIdeasSoftware.OLVColumn olvColumn17;
        private BrightIdeasSoftware.OLVColumn olvColumn10;
        private BrightIdeasSoftware.OLVColumn olvColumn15;
        private BrightIdeasSoftware.OLVColumn olvColumn16;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnBoLoc;
        private System.Windows.Forms.TextBox tbxTongTienNhoHon;
        private System.Windows.Forms.TextBox tbxTongTienLonHon;
        private System.Windows.Forms.ComboBox cbxNhanVienLap;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpickNgayLap;
        private System.Windows.Forms.TabPage tabQLSP;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private BrightIdeasSoftware.FastObjectListView lstvSanPham;
        private BrightIdeasSoftware.OLVColumn olvColumn8;
        private BrightIdeasSoftware.OLVColumn olvColumn9;
        private BrightIdeasSoftware.OLVColumn lstvSanPhamColTinhTrang;
        private BrightIdeasSoftware.FastObjectListView lstvChiTietSP;
        private BrightIdeasSoftware.OLVColumn olvColumn11;
        private BrightIdeasSoftware.OLVColumn olvColumn12;
        private BrightIdeasSoftware.OLVColumn olvColumn13;
        private BrightIdeasSoftware.OLVColumn olvColumn14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbxThuocTinhTim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxTimKiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnQLLoaiSP;
        private System.Windows.Forms.ComboBox cbxKichThuoc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxMauSac;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxLoaiSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnXoaSanPham;
        private System.Windows.Forms.Button btnSuaSanPham;
        private System.Windows.Forms.Button btnThemSanPham;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabPage tabQLNV;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private BrightIdeasSoftware.FastObjectListView lstvNhanVien;
        private BrightIdeasSoftware.OLVColumn lstColMaNV;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private BrightIdeasSoftware.OLVColumn olvColumn6;
        private BrightIdeasSoftware.OLVColumn olvColumn7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxChucVu;
        private System.Windows.Forms.DateTimePicker dtpickNgayTD;
        private System.Windows.Forms.DateTimePicker dtpickNgaySinh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxDiaChi;
        private System.Windows.Forms.TextBox tbxNoiLamViec;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.TextBox tbxLuongCB;
        private System.Windows.Forms.TextBox tbxCMND;
        private System.Windows.Forms.TextBox tbxHoTen;
        private System.Windows.Forms.TextBox tbxMaNV;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnXoaNhanVien;
        private System.Windows.Forms.Button btnSuaNhanVien;
        private System.Windows.Forms.Button btnThemNhanVien;
        private System.Windows.Forms.TabControl tabMain;
        private BrightIdeasSoftware.OLVColumn olvColumn27;
        private BrightIdeasSoftware.OLVColumn olvColumn28;
        private System.Windows.Forms.TextBox tbxHoTenKhachHang;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.ToolStripMenuItem tenNVToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstColChucVu = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.imgNhanVien = new System.Windows.Forms.ImageList(this.components);
            this.imgChucVu = new System.Windows.Forms.ImageList(this.components);
            this.lstvSanPhamColLoaiSP = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.imgGroup = new System.Windows.Forms.ImageList(this.components);
            this.imgSanPham = new System.Windows.Forms.ImageList(this.components);
            this.imgHoaDon = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tenNVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thiếtLậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrValidate = new System.Windows.Forms.Timer(this.components);
            this.tabBH = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbeMaHoaDon = new System.Windows.Forms.Label();
            this.lbeNgayLap = new System.Windows.Forms.Label();
            this.lbeNhanVienLap = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnThemGioHang = new System.Windows.Forms.Button();
            this.tbxSoLuongTabBanHang = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.cbxSanPhamTabBanHang = new System.Windows.Forms.ComboBox();
            this.cbxChiTietTabBanHang = new System.Windows.Forms.ComboBox();
            this.cbxLoaiSPTabBanHang = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lstvGioHang = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumn18 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn19 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn20 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn21 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn22 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn23 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn24 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn25 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn26 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.lbeTongTienTruocThue = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label28 = new System.Windows.Forms.Label();
            this.lbeTongTienThue = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label30 = new System.Windows.Forms.Label();
            this.lbeTongTienSauThue = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.rtbxError = new System.Windows.Forms.RichTextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnXuatHoaDon = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.tbxTenKhachHang = new System.Windows.Forms.TextBox();
            this.tbxSDTKH = new System.Windows.Forms.TextBox();
            this.tbxDiaChiKH = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.tabQLHD = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lstvHoaDon = new BrightIdeasSoftware.FastObjectListView();
            this.lstvHoaDonColMaHD = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn17 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn27 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn28 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn10 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn15 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn16 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnLoc = new System.Windows.Forms.Button();
            this.btnBoLoc = new System.Windows.Forms.Button();
            this.tbxHoTenKhachHang = new System.Windows.Forms.TextBox();
            this.tbxTongTienNhoHon = new System.Windows.Forms.TextBox();
            this.tbxTongTienLonHon = new System.Windows.Forms.TextBox();
            this.cbxNhanVienLap = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpickNgayLap = new System.Windows.Forms.DateTimePicker();
            this.tabQLSP = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lstvSanPham = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumn8 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn9 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.lstvSanPhamColTinhTrang = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.lstvChiTietSP = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumn11 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn12 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn13 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn14 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbxThuocTinhTim = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnQLLoaiSP = new System.Windows.Forms.Button();
            this.cbxKichThuoc = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxMauSac = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxLoaiSP = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXoaSanPham = new System.Windows.Forms.Button();
            this.btnSuaSanPham = new System.Windows.Forms.Button();
            this.btnThemSanPham = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabQLNV = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lstvNhanVien = new BrightIdeasSoftware.FastObjectListView();
            this.lstColMaNV = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn7 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxChucVu = new System.Windows.Forms.ComboBox();
            this.dtpickNgayTD = new System.Windows.Forms.DateTimePicker();
            this.dtpickNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxDiaChi = new System.Windows.Forms.TextBox();
            this.tbxNoiLamViec = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.tbxLuongCB = new System.Windows.Forms.TextBox();
            this.tbxCMND = new System.Windows.Forms.TextBox();
            this.tbxHoTen = new System.Windows.Forms.TextBox();
            this.tbxMaNV = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnXoaNhanVien = new System.Windows.Forms.Button();
            this.btnSuaNhanVien = new System.Windows.Forms.Button();
            this.btnThemNhanVien = new System.Windows.Forms.Button();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.tabBH.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstvGioHang)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tabQLHD.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstvHoaDon)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tabQLSP.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstvChiTietSP)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabQLNV.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstvNhanVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstColChucVu
            // 
            this.lstColChucVu.AspectName = "ChucVu";
            this.lstColChucVu.IsVisible = false;
            // 
            // imgNhanVien
            // 
            this.imgNhanVien.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgNhanVien.ImageStream")));
            this.imgNhanVien.TransparentColor = System.Drawing.Color.Transparent;
            this.imgNhanVien.Images.SetKeyName(0, "engineer-icon.png");
            this.imgNhanVien.Images.SetKeyName(1, "Manager-icon.png");
            // 
            // imgChucVu
            // 
            this.imgChucVu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgChucVu.ImageStream")));
            this.imgChucVu.TransparentColor = System.Drawing.Color.Transparent;
            this.imgChucVu.Images.SetKeyName(0, "add-icon.png");
            this.imgChucVu.Images.SetKeyName(1, "delete-icon.png");
            this.imgChucVu.Images.SetKeyName(2, "Settings-L-icon.png");
            // 
            // lstvSanPham_LoaiSP
            // 
            this.lstvSanPhamColLoaiSP.AspectName = "LoaiSP.TenLoai";
            this.lstvSanPhamColLoaiSP.DisplayIndex = 3;
            this.lstvSanPhamColLoaiSP.IsVisible = false;
            this.lstvSanPhamColLoaiSP.Text = "Loại SP";
            // 
            // imgGroup
            // 
            this.imgGroup.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgGroup.ImageSize = new System.Drawing.Size(40, 40);
            this.imgGroup.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imgSanPham
            // 
            this.imgSanPham.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgSanPham.ImageStream")));
            this.imgSanPham.TransparentColor = System.Drawing.Color.Transparent;
            this.imgSanPham.Images.SetKeyName(0, "available");
            this.imgSanPham.Images.SetKeyName(1, "outofstock");
            // 
            // imgHoaDon
            // 
            this.imgHoaDon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgHoaDon.ImageStream")));
            this.imgHoaDon.TransparentColor = System.Drawing.Color.Transparent;
            this.imgHoaDon.Images.SetKeyName(0, "hoadon");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.thiếtLậpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(946, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tenNVToolStripMenuItem,
            this.toolStripMenuItem1,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Image = global::SE.Properties.Resources.user_icon;
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // tenNVToolStripMenuItem
            // 
            this.tenNVToolStripMenuItem.Name = "tenNVToolStripMenuItem";
            this.tenNVToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.tenNVToolStripMenuItem.Text = "TenNV";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(124, 6);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.ĐăngXuấtToolStripMenuItem_Click);
            // 
            // thiếtLậpToolStripMenuItem
            // 
            this.thiếtLậpToolStripMenuItem.Image = global::SE.Properties.Resources.Settings_L_icon;
            this.thiếtLậpToolStripMenuItem.Name = "thiếtLậpToolStripMenuItem";
            this.thiếtLậpToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.thiếtLậpToolStripMenuItem.Text = "Thiết lập";
            // 
            // tmrValidate
            // 
            this.tmrValidate.Tick += new System.EventHandler(this.TimerValidate_Tick);
            // 
            // tabBH
            // 
            this.tabBH.Controls.Add(this.tableLayoutPanel4);
            this.tabBH.Location = new System.Drawing.Point(4, 22);
            this.tabBH.Name = "tabBH";
            this.tabBH.Size = new System.Drawing.Size(938, 438);
            this.tabBH.TabIndex = 3;
            this.tabBH.Text = "Bán hàng";
            this.tabBH.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.25702F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.74298F));
            this.tableLayoutPanel4.Controls.Add(this.groupBox4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.groupBox7, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lstvGioHang, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.panel4, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.panel5, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.panel6, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.panel7, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.groupBox8, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 6;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(938, 438);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbeMaHoaDon);
            this.groupBox4.Controls.Add(this.lbeNgayLap);
            this.groupBox4.Controls.Add(this.lbeNhanVienLap);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(352, 134);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin hóa hơn";
            // 
            // lbeMaHoaDon
            // 
            this.lbeMaHoaDon.AutoSize = true;
            this.lbeMaHoaDon.Location = new System.Drawing.Point(100, 32);
            this.lbeMaHoaDon.Name = "lbeMaHoaDon";
            this.lbeMaHoaDon.Size = new System.Drawing.Size(16, 13);
            this.lbeMaHoaDon.TabIndex = 1;
            this.lbeMaHoaDon.Text = "...";
            // 
            // lbeNgayLap
            // 
            this.lbeNgayLap.AutoSize = true;
            this.lbeNgayLap.Location = new System.Drawing.Point(100, 90);
            this.lbeNgayLap.Name = "lbeNgayLap";
            this.lbeNgayLap.Size = new System.Drawing.Size(16, 13);
            this.lbeNgayLap.TabIndex = 1;
            this.lbeNgayLap.Text = "...";
            // 
            // lbeNhanVienLap
            // 
            this.lbeNhanVienLap.AutoSize = true;
            this.lbeNhanVienLap.Location = new System.Drawing.Point(100, 61);
            this.lbeNhanVienLap.Name = "lbeNhanVienLap";
            this.lbeNhanVienLap.Size = new System.Drawing.Size(16, 13);
            this.lbeNhanVienLap.TabIndex = 1;
            this.lbeNhanVienLap.Text = "...";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(33, 88);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 15);
            this.label19.TabIndex = 0;
            this.label19.Text = "Ngày lập: ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(15, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 15);
            this.label18.TabIndex = 0;
            this.label18.Text = "Mã hóa hơn: ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 59);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 15);
            this.label17.TabIndex = 0;
            this.label17.Text = "Nhân viên lập: ";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnThemGioHang);
            this.groupBox7.Controls.Add(this.tbxSoLuongTabBanHang);
            this.groupBox7.Controls.Add(this.label32);
            this.groupBox7.Controls.Add(this.cbxSanPhamTabBanHang);
            this.groupBox7.Controls.Add(this.cbxChiTietTabBanHang);
            this.groupBox7.Controls.Add(this.cbxLoaiSPTabBanHang);
            this.groupBox7.Controls.Add(this.label20);
            this.groupBox7.Controls.Add(this.label21);
            this.groupBox7.Controls.Add(this.label23);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(361, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(574, 134);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Sản phẩm";
            // 
            // btnThemGioHang
            // 
            this.btnThemGioHang.Location = new System.Drawing.Point(293, 79);
            this.btnThemGioHang.Name = "btnThemGioHang";
            this.btnThemGioHang.Size = new System.Drawing.Size(100, 33);
            this.btnThemGioHang.TabIndex = 7;
            this.btnThemGioHang.Text = "Thêm";
            this.btnThemGioHang.UseVisualStyleBackColor = true;
            this.btnThemGioHang.Click += new System.EventHandler(this.ButtonThemGioHang_Click);
            // 
            // tbxSoLuong_BanHang
            // 
            this.tbxSoLuongTabBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSoLuongTabBanHang.Location = new System.Drawing.Point(293, 48);
            this.tbxSoLuongTabBanHang.Name = "tbxSoLuong_BanHang";
            this.tbxSoLuongTabBanHang.Size = new System.Drawing.Size(100, 21);
            this.tbxSoLuongTabBanHang.TabIndex = 6;
            this.tbxSoLuongTabBanHang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextSoLuong_BanHang_KeyPress);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(316, 30);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(59, 15);
            this.label32.TabIndex = 5;
            this.label32.Text = "Số lượng:";
            // 
            // cbxSanPham_BanHang
            // 
            this.cbxSanPhamTabBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSanPhamTabBanHang.FormattingEnabled = true;
            this.cbxSanPhamTabBanHang.Location = new System.Drawing.Point(116, 56);
            this.cbxSanPhamTabBanHang.Name = "cbxSanPham_BanHang";
            this.cbxSanPhamTabBanHang.Size = new System.Drawing.Size(154, 23);
            this.cbxSanPhamTabBanHang.TabIndex = 4;
            this.cbxSanPhamTabBanHang.SelectedIndexChanged += new System.EventHandler(this.ComboSanPham_BanHang_SelectedIndexChanged);
            // 
            // cbxChiTiet_BanHang
            // 
            this.cbxChiTietTabBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxChiTietTabBanHang.FormattingEnabled = true;
            this.cbxChiTietTabBanHang.Location = new System.Drawing.Point(116, 85);
            this.cbxChiTietTabBanHang.Name = "cbxChiTiet_BanHang";
            this.cbxChiTietTabBanHang.Size = new System.Drawing.Size(154, 23);
            this.cbxChiTietTabBanHang.TabIndex = 4;
            this.cbxChiTietTabBanHang.SelectedIndexChanged += new System.EventHandler(this.ComboChiTiet_BanHang_SelectedIndexChanged);
            // 
            // cbxLoaiSP_BanHang
            // 
            this.cbxLoaiSPTabBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLoaiSPTabBanHang.FormattingEnabled = true;
            this.cbxLoaiSPTabBanHang.Location = new System.Drawing.Point(116, 27);
            this.cbxLoaiSPTabBanHang.Name = "cbxLoaiSP_BanHang";
            this.cbxLoaiSPTabBanHang.Size = new System.Drawing.Size(154, 23);
            this.cbxLoaiSPTabBanHang.TabIndex = 4;
            this.cbxLoaiSPTabBanHang.SelectedIndexChanged += new System.EventHandler(this.ComboLoaiSP_BanHang_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(60, 88);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(50, 15);
            this.label20.TabIndex = 1;
            this.label20.Text = "Chi tiết: ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(15, 30);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(95, 15);
            this.label21.TabIndex = 2;
            this.label21.Text = "Loại sản phẩm: ";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(40, 59);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(70, 15);
            this.label23.TabIndex = 3;
            this.label23.Text = "Sản phẩm: ";
            // 
            // lstvGioHang
            // 
            this.lstvGioHang.AllColumns.Add(this.olvColumn18);
            this.lstvGioHang.AllColumns.Add(this.olvColumn19);
            this.lstvGioHang.AllColumns.Add(this.olvColumn20);
            this.lstvGioHang.AllColumns.Add(this.olvColumn21);
            this.lstvGioHang.AllColumns.Add(this.olvColumn22);
            this.lstvGioHang.AllColumns.Add(this.olvColumn23);
            this.lstvGioHang.AllColumns.Add(this.olvColumn24);
            this.lstvGioHang.AllColumns.Add(this.olvColumn25);
            this.lstvGioHang.AllColumns.Add(this.olvColumn26);
            this.lstvGioHang.CellEditUseWholeCell = false;
            this.lstvGioHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn18,
            this.olvColumn19,
            this.olvColumn20,
            this.olvColumn21,
            this.olvColumn22,
            this.olvColumn23,
            this.olvColumn24,
            this.olvColumn25,
            this.olvColumn26});
            this.tableLayoutPanel4.SetColumnSpan(this.lstvGioHang, 2);
            this.lstvGioHang.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstvGioHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvGioHang.FullRowSelect = true;
            this.lstvGioHang.Location = new System.Drawing.Point(3, 143);
            this.lstvGioHang.Name = "lstvGioHang";
            this.lstvGioHang.RowHeight = 25;
            this.lstvGioHang.ShowGroups = false;
            this.lstvGioHang.Size = new System.Drawing.Size(932, 178);
            this.lstvGioHang.TabIndex = 2;
            this.lstvGioHang.UseCompatibleStateImageBehavior = false;
            this.lstvGioHang.View = System.Windows.Forms.View.Details;
            this.lstvGioHang.VirtualMode = true;
            this.lstvGioHang.ButtonClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(this.ListGioHang_ButtonClick);
            // 
            // olvColumn18
            // 
            this.olvColumn18.AspectName = "SanPham.MaSP";
            this.olvColumn18.Text = "Mã SP";
            // 
            // olvColumn19
            // 
            this.olvColumn19.AspectName = "SanPham.TenSP";
            this.olvColumn19.Text = "Tên SP";
            this.olvColumn19.Width = 145;
            // 
            // olvColumn20
            // 
            this.olvColumn20.AspectName = "MauSac";
            this.olvColumn20.Text = "Màu sắc";
            this.olvColumn20.Width = 72;
            // 
            // olvColumn21
            // 
            this.olvColumn21.AspectName = "KichThuoc";
            this.olvColumn21.Text = "Kích thước";
            this.olvColumn21.Width = 89;
            // 
            // olvColumn22
            // 
            this.olvColumn22.AspectName = "DonGia";
            this.olvColumn22.AspectToStringFormat = "{0: #,#}";
            this.olvColumn22.Text = "Đơn giá";
            this.olvColumn22.Width = 110;
            // 
            // olvColumn23
            // 
            this.olvColumn23.AspectName = "SoLuong";
            this.olvColumn23.Text = "Số lượng";
            this.olvColumn23.Width = 93;
            // 
            // olvColumn24
            // 
            this.olvColumn24.AspectName = "SanPham.MaSP";
            this.olvColumn24.AspectToStringFormat = "{0: \"+\"}";
            this.olvColumn24.ButtonSizing = BrightIdeasSoftware.OLVColumn.ButtonSizingMode.CellBounds;
            this.olvColumn24.IsButton = true;
            this.olvColumn24.Text = string.Empty;
            this.olvColumn24.Width = 25;
            // 
            // olvColumn25
            // 
            this.olvColumn25.AspectName = "SanPham.MaSP";
            this.olvColumn25.AspectToStringFormat = "{0: \"-\"}";
            this.olvColumn25.ButtonSizing = BrightIdeasSoftware.OLVColumn.ButtonSizingMode.CellBounds;
            this.olvColumn25.IsButton = true;
            this.olvColumn25.Text = string.Empty;
            this.olvColumn25.Width = 25;
            // 
            // olvColumn26
            // 
            this.olvColumn26.AspectName = "SanPham.MaSP";
            this.olvColumn26.AspectToStringFormat = "{0: \"x\"}";
            this.olvColumn26.ButtonSizing = BrightIdeasSoftware.OLVColumn.ButtonSizingMode.CellBounds;
            this.olvColumn26.IsButton = true;
            this.olvColumn26.Text = string.Empty;
            this.olvColumn26.Width = 25;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label27);
            this.panel4.Controls.Add(this.lbeTongTienTruocThue);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(358, 324);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(580, 25);
            this.panel4.TabIndex = 3;
            // 
            // label27
            // 
            this.label27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label27.Location = new System.Drawing.Point(0, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(464, 25);
            this.label27.TabIndex = 0;
            this.label27.Text = "Tổng tiền (trước thuế): ";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbeTongTienTruocThue
            // 
            this.lbeTongTienTruocThue.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbeTongTienTruocThue.Location = new System.Drawing.Point(464, 0);
            this.lbeTongTienTruocThue.Name = "lbeTongTienTruocThue";
            this.lbeTongTienTruocThue.Size = new System.Drawing.Size(116, 25);
            this.lbeTongTienTruocThue.TabIndex = 0;
            this.lbeTongTienTruocThue.Text = "0 VNĐ";
            this.lbeTongTienTruocThue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label28);
            this.panel5.Controls.Add(this.lbeTongTienThue);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(358, 349);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(580, 27);
            this.panel5.TabIndex = 4;
            // 
            // label28
            // 
            this.label28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label28.Location = new System.Drawing.Point(0, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(464, 27);
            this.label28.TabIndex = 0;
            this.label28.Text = "Tiền thuế: ";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbeTongTienThue
            // 
            this.lbeTongTienThue.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbeTongTienThue.Location = new System.Drawing.Point(464, 0);
            this.lbeTongTienThue.Name = "lbeTongTienThue";
            this.lbeTongTienThue.Size = new System.Drawing.Size(116, 27);
            this.lbeTongTienThue.TabIndex = 1;
            this.lbeTongTienThue.Text = "0 VNĐ";
            this.lbeTongTienThue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label30);
            this.panel6.Controls.Add(this.lbeTongTienSauThue);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(358, 376);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(580, 27);
            this.panel6.TabIndex = 5;
            // 
            // label30
            // 
            this.label30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label30.Location = new System.Drawing.Point(0, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(464, 27);
            this.label30.TabIndex = 0;
            this.label30.Text = "Tổng tiền (sau thuế): ";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbeTongTienSauThue
            // 
            this.lbeTongTienSauThue.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbeTongTienSauThue.Location = new System.Drawing.Point(464, 0);
            this.lbeTongTienSauThue.Name = "lbeTongTienSauThue";
            this.lbeTongTienSauThue.Size = new System.Drawing.Size(116, 27);
            this.lbeTongTienSauThue.TabIndex = 1;
            this.lbeTongTienSauThue.Text = "0 VNĐ";
            this.lbeTongTienSauThue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.rtbxError);
            this.panel7.Controls.Add(this.btnReset);
            this.panel7.Controls.Add(this.btnXuatHoaDon);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(358, 403);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(580, 35);
            this.panel7.TabIndex = 6;
            // 
            // rtbxError
            // 
            this.rtbxError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbxError.ForeColor = System.Drawing.Color.Red;
            this.rtbxError.Location = new System.Drawing.Point(0, 0);
            this.rtbxError.Name = "rtbxError";
            this.rtbxError.Size = new System.Drawing.Size(242, 36);
            this.rtbxError.TabIndex = 1;
            this.rtbxError.Text = string.Empty;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(248, 0);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(78, 36);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // btnXuatHoaDon
            // 
            this.btnXuatHoaDon.Location = new System.Drawing.Point(332, 0);
            this.btnXuatHoaDon.Name = "btnXuatHoaDon";
            this.btnXuatHoaDon.Size = new System.Drawing.Size(87, 36);
            this.btnXuatHoaDon.TabIndex = 0;
            this.btnXuatHoaDon.Text = "Xuất hóa đơn";
            this.btnXuatHoaDon.UseVisualStyleBackColor = true;
            this.btnXuatHoaDon.Click += new System.EventHandler(this.ButtonXuatHoaDon_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.tbxTenKhachHang);
            this.groupBox8.Controls.Add(this.tbxSDTKH);
            this.groupBox8.Controls.Add(this.tbxDiaChiKH);
            this.groupBox8.Controls.Add(this.label34);
            this.groupBox8.Controls.Add(this.label33);
            this.groupBox8.Controls.Add(this.label25);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox8.Location = new System.Drawing.Point(3, 327);
            this.groupBox8.Name = "groupBox8";
            this.tableLayoutPanel4.SetRowSpan(this.groupBox8, 4);
            this.groupBox8.Size = new System.Drawing.Size(352, 108);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Thông tin khách hàng";
            // 
            // tbxTenKhachHang
            // 
            this.tbxTenKhachHang.Location = new System.Drawing.Point(102, 26);
            this.tbxTenKhachHang.Name = "tbxTenKhachHang";
            this.tbxTenKhachHang.Size = new System.Drawing.Size(146, 20);
            this.tbxTenKhachHang.TabIndex = 1;
            // 
            // tbxSDTKH
            // 
            this.tbxSDTKH.Location = new System.Drawing.Point(102, 78);
            this.tbxSDTKH.Name = "tbxSDTKH";
            this.tbxSDTKH.Size = new System.Drawing.Size(146, 20);
            this.tbxSDTKH.TabIndex = 1;
            this.tbxSDTKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextSDTKH_KeyPress);
            // 
            // tbxDiaChiKH
            // 
            this.tbxDiaChiKH.Location = new System.Drawing.Point(102, 52);
            this.tbxDiaChiKH.Name = "tbxDiaChiKH";
            this.tbxDiaChiKH.Size = new System.Drawing.Size(146, 20);
            this.tbxDiaChiKH.TabIndex = 1;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(64, 81);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(32, 13);
            this.label34.TabIndex = 0;
            this.label34.Text = "SĐT:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(53, 55);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(43, 13);
            this.label33.TabIndex = 0;
            this.label33.Text = "Địa chỉ:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(7, 29);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(89, 13);
            this.label25.TabIndex = 0;
            this.label25.Text = "Tên khách hàng:";
            // 
            // tabQLHD
            // 
            this.tabQLHD.Controls.Add(this.tableLayoutPanel5);
            this.tabQLHD.Location = new System.Drawing.Point(4, 22);
            this.tabQLHD.Name = "tabQLHD";
            this.tabQLHD.Size = new System.Drawing.Size(938, 438);
            this.tabQLHD.TabIndex = 2;
            this.tabQLHD.Text = "Quản lý hóa đơn";
            this.tabQLHD.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 741F));
            this.tableLayoutPanel5.Controls.Add(this.groupBox6, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.groupBox5, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(938, 438);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lstvHoaDon);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(203, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(735, 432);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Danh sách hóa đơn";
            // 
            // lstvHoaDon
            // 
            this.lstvHoaDon.AllColumns.Add(this.lstvHoaDonColMaHD);
            this.lstvHoaDon.AllColumns.Add(this.olvColumn17);
            this.lstvHoaDon.AllColumns.Add(this.olvColumn27);
            this.lstvHoaDon.AllColumns.Add(this.olvColumn28);
            this.lstvHoaDon.AllColumns.Add(this.olvColumn10);
            this.lstvHoaDon.AllColumns.Add(this.olvColumn15);
            this.lstvHoaDon.AllColumns.Add(this.olvColumn16);
            this.lstvHoaDon.CellEditUseWholeCell = false;
            this.lstvHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lstvHoaDonColMaHD,
            this.olvColumn17,
            this.olvColumn27,
            this.olvColumn28,
            this.olvColumn10,
            this.olvColumn15,
            this.olvColumn16});
            this.lstvHoaDon.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvHoaDon.Location = new System.Drawing.Point(3, 16);
            this.lstvHoaDon.Name = "lstvHoaDon";
            this.lstvHoaDon.ShowGroups = false;
            this.lstvHoaDon.Size = new System.Drawing.Size(729, 413);
            this.lstvHoaDon.SmallImageList = this.imgHoaDon;
            this.lstvHoaDon.TabIndex = 0;
            this.lstvHoaDon.UseCompatibleStateImageBehavior = false;
            this.lstvHoaDon.UseHyperlinks = true;
            this.lstvHoaDon.View = System.Windows.Forms.View.Details;
            this.lstvHoaDon.VirtualMode = true;
            this.lstvHoaDon.ButtonClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(this.ListHoaDon_ButtonClick);
            this.lstvHoaDon.HyperlinkClicked += new System.EventHandler<BrightIdeasSoftware.HyperlinkClickedEventArgs>(this.ListHoaDon_HyperlinkClicked);
            // 
            // lstvHoaDon_MaHD
            // 
            this.lstvHoaDonColMaHD.AspectName = "MaHD";
            this.lstvHoaDonColMaHD.Text = "Mã hóa đơn";
            this.lstvHoaDonColMaHD.Width = 80;
            // 
            // olvColumn17
            // 
            this.olvColumn17.AspectName = "NhanVien.HoTen";
            this.olvColumn17.Hyperlink = true;
            this.olvColumn17.Text = "Nhân viên";
            this.olvColumn17.Width = 120;
            // 
            // olvColumn27
            // 
            this.olvColumn27.AspectName = "TongTienTruocThue";
            this.olvColumn27.AspectToStringFormat = "{0: #,#}";
            this.olvColumn27.Text = "Trước thuế";
            this.olvColumn27.Width = 94;
            // 
            // olvColumn28
            // 
            this.olvColumn28.AspectName = "TongTienThue";
            this.olvColumn28.AspectToStringFormat = "{0: #,#}";
            this.olvColumn28.Text = "Thuế";
            this.olvColumn28.Width = 94;
            // 
            // olvColumn10
            // 
            this.olvColumn10.AspectName = "TongTienSauThue";
            this.olvColumn10.AspectToStringFormat = "{0: #,#}";
            this.olvColumn10.Text = "Tổng tiền";
            this.olvColumn10.Width = 100;
            // 
            // olvColumn15
            // 
            this.olvColumn15.AspectName = "NgayLap";
            this.olvColumn15.AspectToStringFormat = "{0: dd/MM/yyyy}";
            this.olvColumn15.Text = "Ngày lập";
            this.olvColumn15.Width = 100;
            // 
            // olvColumn16
            // 
            this.olvColumn16.AspectName = "MaHD";
            this.olvColumn16.AspectToStringFormat = "{0: \"In hóa đơn\"}";
            this.olvColumn16.ButtonSizing = BrightIdeasSoftware.OLVColumn.ButtonSizingMode.CellBounds;
            this.olvColumn16.IsButton = true;
            this.olvColumn16.Text = string.Empty;
            this.olvColumn16.Width = 100;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnLoc);
            this.groupBox5.Controls.Add(this.btnBoLoc);
            this.groupBox5.Controls.Add(this.tbxHoTenKhachHang);
            this.groupBox5.Controls.Add(this.tbxTongTienNhoHon);
            this.groupBox5.Controls.Add(this.tbxTongTienLonHon);
            this.groupBox5.Controls.Add(this.cbxNhanVienLap);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.dtpickNgayLap);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(194, 432);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tra cứu hóa đơn";
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(25, 309);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(75, 32);
            this.btnLoc.TabIndex = 5;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.ButtonLoc_Click);
            // 
            // btnBoLoc
            // 
            this.btnBoLoc.Location = new System.Drawing.Point(106, 309);
            this.btnBoLoc.Name = "btnBoLoc";
            this.btnBoLoc.Size = new System.Drawing.Size(75, 32);
            this.btnBoLoc.TabIndex = 5;
            this.btnBoLoc.Text = "Bỏ lọc";
            this.btnBoLoc.UseVisualStyleBackColor = true;
            this.btnBoLoc.Click += new System.EventHandler(this.ButtonBoLoc_Click);
            // 
            // tbxHoTenKhachHang
            // 
            this.tbxHoTenKhachHang.Location = new System.Drawing.Point(6, 273);
            this.tbxHoTenKhachHang.Name = "tbxHoTenKhachHang";
            this.tbxHoTenKhachHang.Size = new System.Drawing.Size(175, 20);
            this.tbxHoTenKhachHang.TabIndex = 4;
            // 
            // tbxTongTienNhoHon
            // 
            this.tbxTongTienNhoHon.Location = new System.Drawing.Point(6, 219);
            this.tbxTongTienNhoHon.Name = "tbxTongTienNhoHon";
            this.tbxTongTienNhoHon.Size = new System.Drawing.Size(175, 20);
            this.tbxTongTienNhoHon.TabIndex = 4;
            // 
            // tbxTongTienLonHon
            // 
            this.tbxTongTienLonHon.Location = new System.Drawing.Point(6, 161);
            this.tbxTongTienLonHon.Name = "tbxTongTienLonHon";
            this.tbxTongTienLonHon.Size = new System.Drawing.Size(175, 20);
            this.tbxTongTienLonHon.TabIndex = 3;
            // 
            // cbxNhanVienLap
            // 
            this.cbxNhanVienLap.FormattingEnabled = true;
            this.cbxNhanVienLap.Location = new System.Drawing.Point(6, 103);
            this.cbxNhanVienLap.Name = "cbxNhanVienLap";
            this.cbxNhanVienLap.Size = new System.Drawing.Size(175, 21);
            this.cbxNhanVienLap.TabIndex = 2;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 257);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(102, 13);
            this.label26.TabIndex = 1;
            this.label26.Text = "Họ tên khách hàng:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 203);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Số tiền nhỏ hơn:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 145);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Số tiền lớn hơn:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Nhân viên lập:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Ngày lập";
            // 
            // dtpickNgayLap
            // 
            this.dtpickNgayLap.CustomFormat = "dd/MM/yyyy";
            this.dtpickNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpickNgayLap.Location = new System.Drawing.Point(6, 51);
            this.dtpickNgayLap.Name = "dtpickNgayLap";
            this.dtpickNgayLap.Size = new System.Drawing.Size(175, 20);
            this.dtpickNgayLap.TabIndex = 0;
            this.dtpickNgayLap.ValueChanged += new System.EventHandler(this.DateNgayLap_ValueChanged);
            // 
            // tabQLSP
            // 
            this.tabQLSP.Controls.Add(this.tableLayoutPanel3);
            this.tabQLSP.Location = new System.Drawing.Point(4, 22);
            this.tabQLSP.Name = "tabQLSP";
            this.tabQLSP.Padding = new System.Windows.Forms.Padding(3);
            this.tabQLSP.Size = new System.Drawing.Size(938, 438);
            this.tabQLSP.TabIndex = 1;
            this.tabQLSP.Text = "Quản lý sản phẩm";
            this.tabQLSP.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.27841F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.72159F));
            this.tableLayoutPanel3.Controls.Add(this.lstvSanPham, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lstvChiTietSP, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.panel3, 1, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(932, 432);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // lstvSanPham
            // 
            this.lstvSanPham.AllColumns.Add(this.olvColumn8);
            this.lstvSanPham.AllColumns.Add(this.olvColumn9);
            this.lstvSanPham.AllColumns.Add(this.lstvSanPhamColTinhTrang);
            this.lstvSanPham.AllColumns.Add(this.lstvSanPhamColLoaiSP);
            this.lstvSanPham.CellEditUseWholeCell = false;
            this.lstvSanPham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn8,
            this.olvColumn9,
            this.lstvSanPhamColTinhTrang});
            this.lstvSanPham.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvSanPham.FullRowSelect = true;
            this.lstvSanPham.GroupImageList = this.imgGroup;
            this.lstvSanPham.LargeImageList = this.imgSanPham;
            this.lstvSanPham.Location = new System.Drawing.Point(0, 100);
            this.lstvSanPham.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lstvSanPham.MultiSelect = false;
            this.lstvSanPham.Name = "lstvSanPham";
            this.lstvSanPham.ShowGroups = false;
            this.lstvSanPham.Size = new System.Drawing.Size(474, 301);
            this.lstvSanPham.SmallImageList = this.imgSanPham;
            this.lstvSanPham.TabIndex = 0;
            this.lstvSanPham.UseCompatibleStateImageBehavior = false;
            this.lstvSanPham.View = System.Windows.Forms.View.Details;
            this.lstvSanPham.VirtualMode = true;
            this.lstvSanPham.SelectedIndexChanged += new System.EventHandler(this.ListSanPham_SelectedIndexChanged);
            // 
            // olvColumn8
            // 
            this.olvColumn8.AspectName = "MaSP";
            this.olvColumn8.Text = "Mã sản phẩm";
            this.olvColumn8.Width = 81;
            // 
            // olvColumn9
            // 
            this.olvColumn9.AspectName = "TenSP";
            this.olvColumn9.Text = "Tên sản phẩm";
            this.olvColumn9.Width = 88;
            // 
            // lstvSanPham_TinhTrang
            // 
            this.lstvSanPhamColTinhTrang.AspectName = "SoLuongTon";
            this.lstvSanPhamColTinhTrang.Text = "Tình trạng";
            this.lstvSanPhamColTinhTrang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lstvSanPhamColTinhTrang.ToolTipText = "hjkhkjhkj";
            this.lstvSanPhamColTinhTrang.Width = 81;
            // 
            // lstvChiTietSP
            // 
            this.lstvChiTietSP.AllColumns.Add(this.olvColumn11);
            this.lstvChiTietSP.AllColumns.Add(this.olvColumn12);
            this.lstvChiTietSP.AllColumns.Add(this.olvColumn13);
            this.lstvChiTietSP.AllColumns.Add(this.olvColumn14);
            this.lstvChiTietSP.CellEditUseWholeCell = false;
            this.lstvChiTietSP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn11,
            this.olvColumn12,
            this.olvColumn13,
            this.olvColumn14});
            this.lstvChiTietSP.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstvChiTietSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvChiTietSP.Location = new System.Drawing.Point(480, 100);
            this.lstvChiTietSP.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lstvChiTietSP.Name = "lstvChiTietSP";
            this.lstvChiTietSP.ShowGroups = false;
            this.lstvChiTietSP.Size = new System.Drawing.Size(452, 301);
            this.lstvChiTietSP.TabIndex = 1;
            this.lstvChiTietSP.UseCompatibleStateImageBehavior = false;
            this.lstvChiTietSP.View = System.Windows.Forms.View.Details;
            this.lstvChiTietSP.VirtualMode = true;
            // 
            // olvColumn11
            // 
            this.olvColumn11.AspectName = "MauSac";
            this.olvColumn11.Text = "Màu sắc";
            this.olvColumn11.Width = 80;
            // 
            // olvColumn12
            // 
            this.olvColumn12.AspectName = "KichThuoc";
            this.olvColumn12.Text = "Kích thước";
            this.olvColumn12.Width = 85;
            // 
            // olvColumn13
            // 
            this.olvColumn13.AspectName = "SoLuongTon";
            this.olvColumn13.Text = "Số lượng tồn";
            this.olvColumn13.Width = 82;
            // 
            // olvColumn14
            // 
            this.olvColumn14.AspectName = "DonGia";
            this.olvColumn14.AspectToStringFormat = "{0: #,#}";
            this.olvColumn14.Text = "Đơn giá";
            this.olvColumn14.Width = 89;
            // 
            // panel1
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 100);
            this.panel1.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbxThuocTinhTim);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tbxTimKiem);
            this.groupBox3.Location = new System.Drawing.Point(405, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(293, 73);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // cbxThuocTinhTim
            // 
            this.cbxThuocTinhTim.FormattingEnabled = true;
            this.cbxThuocTinhTim.Items.AddRange(new object[] {
            "Mã sản phẩm",
            "Tên sản phẩm"});
            this.cbxThuocTinhTim.Location = new System.Drawing.Point(92, 17);
            this.cbxThuocTinhTim.Name = "cbxThuocTinhTim";
            this.cbxThuocTinhTim.Size = new System.Drawing.Size(104, 21);
            this.cbxThuocTinhTim.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Thuộc tính tìm:";
            // 
            // tbxTimKiem
            // 
            this.tbxTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTimKiem.Location = new System.Drawing.Point(6, 44);
            this.tbxTimKiem.Name = "tbxTimKiem";
            this.tbxTimKiem.Size = new System.Drawing.Size(281, 21);
            this.tbxTimKiem.TabIndex = 5;
            this.tbxTimKiem.TextChanged += new System.EventHandler(this.TextTimKiem_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnQLLoaiSP);
            this.groupBox2.Controls.Add(this.cbxKichThuoc);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbxMauSac);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbxLoaiSP);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(8, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 73);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lọc";
            // 
            // btnQLLoaiSP
            // 
            this.btnQLLoaiSP.Location = new System.Drawing.Point(285, 17);
            this.btnQLLoaiSP.Name = "btnQLLoaiSP";
            this.btnQLLoaiSP.Size = new System.Drawing.Size(36, 21);
            this.btnQLLoaiSP.TabIndex = 8;
            this.btnQLLoaiSP.Text = "...";
            this.btnQLLoaiSP.UseVisualStyleBackColor = true;
            this.btnQLLoaiSP.Click += new System.EventHandler(this.ButtonQLLoaiSP_Click);
            // 
            // cbxKichThuoc
            // 
            this.cbxKichThuoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxKichThuoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxKichThuoc.FormattingEnabled = true;
            this.cbxKichThuoc.Location = new System.Drawing.Point(260, 44);
            this.cbxKichThuoc.Name = "cbxKichThuoc";
            this.cbxKichThuoc.Size = new System.Drawing.Size(120, 21);
            this.cbxKichThuoc.TabIndex = 6;
            this.cbxKichThuoc.SelectedIndexChanged += new System.EventHandler(this.ComboKichThuoc_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(187, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Kích thước:";
            // 
            // cbxMauSac
            // 
            this.cbxMauSac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxMauSac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxMauSac.FormattingEnabled = true;
            this.cbxMauSac.Location = new System.Drawing.Point(63, 44);
            this.cbxMauSac.Name = "cbxMauSac";
            this.cbxMauSac.Size = new System.Drawing.Size(116, 21);
            this.cbxMauSac.TabIndex = 7;
            this.cbxMauSac.SelectedIndexChanged += new System.EventHandler(this.ComboMauSac_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Màu sắc:";
            // 
            // cbxLoaiSP
            // 
            this.cbxLoaiSP.FormattingEnabled = true;
            this.cbxLoaiSP.Items.AddRange(new object[] {
            "(Tất cả)"});
            this.cbxLoaiSP.Location = new System.Drawing.Point(91, 17);
            this.cbxLoaiSP.Name = "cbxLoaiSP";
            this.cbxLoaiSP.Size = new System.Drawing.Size(188, 21);
            this.cbxLoaiSP.TabIndex = 3;
            this.cbxLoaiSP.Text = "chọn ...";
            this.cbxLoaiSP.SelectedIndexChanged += new System.EventHandler(this.ComboLoaiSP_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Loại sản phẩm:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnXoaSanPham);
            this.panel2.Controls.Add(this.btnSuaSanPham);
            this.panel2.Controls.Add(this.btnThemSanPham);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 401);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(477, 31);
            this.panel2.TabIndex = 3;
            // 
            // btnXoaSanPham
            // 
            this.btnXoaSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaSanPham.ImageIndex = 1;
            this.btnXoaSanPham.ImageList = this.imgChucVu;
            this.btnXoaSanPham.Location = new System.Drawing.Point(238, 0);
            this.btnXoaSanPham.Margin = new System.Windows.Forms.Padding(0);
            this.btnXoaSanPham.Name = "btnXoaSanPham";
            this.btnXoaSanPham.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnXoaSanPham.Size = new System.Drawing.Size(119, 32);
            this.btnXoaSanPham.TabIndex = 0;
            this.btnXoaSanPham.Text = "Xóa sản phẩm";
            this.btnXoaSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaSanPham.UseVisualStyleBackColor = true;
            this.btnXoaSanPham.Click += new System.EventHandler(this.ButtonXoaSanPham_Click);
            // 
            // btnSuaSanPham
            // 
            this.btnSuaSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaSanPham.ImageIndex = 2;
            this.btnSuaSanPham.ImageList = this.imgChucVu;
            this.btnSuaSanPham.Location = new System.Drawing.Point(119, 0);
            this.btnSuaSanPham.Margin = new System.Windows.Forms.Padding(0);
            this.btnSuaSanPham.Name = "btnSuaSanPham";
            this.btnSuaSanPham.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnSuaSanPham.Size = new System.Drawing.Size(119, 32);
            this.btnSuaSanPham.TabIndex = 0;
            this.btnSuaSanPham.Text = "Sửa sản phẩm";
            this.btnSuaSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaSanPham.UseVisualStyleBackColor = true;
            this.btnSuaSanPham.Click += new System.EventHandler(this.ButtonSuaSP_Click);
            // 
            // btnThemSanPham
            // 
            this.btnThemSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemSanPham.ImageIndex = 0;
            this.btnThemSanPham.ImageList = this.imgChucVu;
            this.btnThemSanPham.Location = new System.Drawing.Point(0, 0);
            this.btnThemSanPham.Margin = new System.Windows.Forms.Padding(0);
            this.btnThemSanPham.Name = "btnThemSanPham";
            this.btnThemSanPham.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnThemSanPham.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnThemSanPham.Size = new System.Drawing.Size(119, 32);
            this.btnThemSanPham.TabIndex = 0;
            this.btnThemSanPham.Text = "Thêm sản phẩm";
            this.btnThemSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemSanPham.UseVisualStyleBackColor = true;
            this.btnThemSanPham.Click += new System.EventHandler(this.ButtonThemSanPham_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(477, 401);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(455, 31);
            this.panel3.TabIndex = 4;
            // 
            // tabQLNV
            // 
            this.tabQLNV.Controls.Add(this.tableLayoutPanel1);
            this.tabQLNV.Location = new System.Drawing.Point(4, 22);
            this.tabQLNV.Name = "tabQLNV";
            this.tabQLNV.Padding = new System.Windows.Forms.Padding(3);
            this.tabQLNV.Size = new System.Drawing.Size(938, 438);
            this.tabQLNV.TabIndex = 0;
            this.tabQLNV.Text = "Quản lý nhân viên";
            this.tabQLNV.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Controls.Add(this.lstvNhanVien, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.04984F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.95017F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(932, 432);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lstvNhanVien
            // 
            this.lstvNhanVien.AllColumns.Add(this.lstColMaNV);
            this.lstvNhanVien.AllColumns.Add(this.olvColumn1);
            this.lstvNhanVien.AllColumns.Add(this.olvColumn2);
            this.lstvNhanVien.AllColumns.Add(this.olvColumn3);
            this.lstvNhanVien.AllColumns.Add(this.olvColumn4);
            this.lstvNhanVien.AllColumns.Add(this.olvColumn5);
            this.lstvNhanVien.AllColumns.Add(this.olvColumn6);
            this.lstvNhanVien.AllColumns.Add(this.olvColumn7);
            this.lstvNhanVien.AllColumns.Add(this.lstColChucVu);
            this.lstvNhanVien.CellEditUseWholeCell = false;
            this.lstvNhanVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lstColMaNV,
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn3,
            this.olvColumn4,
            this.olvColumn5,
            this.olvColumn6,
            this.olvColumn7});
            this.lstvNhanVien.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvNhanVien.FullRowSelect = true;
            this.lstvNhanVien.Location = new System.Drawing.Point(329, 3);
            this.lstvNhanVien.MultiSelect = false;
            this.lstvNhanVien.Name = "lstvNhanVien";
            this.tableLayoutPanel1.SetRowSpan(this.lstvNhanVien, 2);
            this.lstvNhanVien.ShowGroups = false;
            this.lstvNhanVien.Size = new System.Drawing.Size(600, 426);
            this.lstvNhanVien.SmallImageList = this.imgNhanVien;
            this.lstvNhanVien.TabIndex = 0;
            this.lstvNhanVien.UseCompatibleStateImageBehavior = false;
            this.lstvNhanVien.View = System.Windows.Forms.View.Details;
            this.lstvNhanVien.VirtualMode = true;
            this.lstvNhanVien.SelectedIndexChanged += new System.EventHandler(this.ListNhanVien_SelectedIndexChanged);
            // 
            // lstColMaNV
            // 
            this.lstColMaNV.AspectName = "MaNV";
            this.lstColMaNV.Text = "Mã nhân viên";
            this.lstColMaNV.Width = 90;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "HoTen";
            this.olvColumn1.Text = "Họ tên";
            this.olvColumn1.Width = 95;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "NgaySinh";
            this.olvColumn2.AspectToStringFormat = "{0:dd/MM/yyyy}";
            this.olvColumn2.Text = "Ngày sinh";
            this.olvColumn2.Width = 100;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "DiaChi";
            this.olvColumn3.Text = "Địa chỉ";
            this.olvColumn3.Width = 200;
            this.olvColumn3.WordWrap = true;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "CMND";
            this.olvColumn4.Text = "CMND";
            this.olvColumn4.Width = 80;
            this.olvColumn4.WordWrap = true;
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "LuongCoBan";
            this.olvColumn5.AspectToStringFormat = "{0: #,#}";
            this.olvColumn5.Text = "Lương cơ bản";
            this.olvColumn5.Width = 100;
            this.olvColumn5.WordWrap = true;
            // 
            // olvColumn6
            // 
            this.olvColumn6.AspectName = "NgayTuyenDung";
            this.olvColumn6.AspectToStringFormat = "{0:dd/MM/yyyy}";
            this.olvColumn6.Text = "Ngày tuyển dụng";
            this.olvColumn6.Width = 100;
            this.olvColumn6.WordWrap = true;
            // 
            // olvColumn7
            // 
            this.olvColumn7.AspectName = "NoiLamViec";
            this.olvColumn7.Text = "Nơi làm việc";
            this.olvColumn7.Width = 150;
            this.olvColumn7.WordWrap = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxChucVu);
            this.groupBox1.Controls.Add(this.dtpickNgayTD);
            this.groupBox1.Controls.Add(this.dtpickNgaySinh);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxDiaChi);
            this.groupBox1.Controls.Add(this.tbxNoiLamViec);
            this.groupBox1.Controls.Add(this.tbxPassword);
            this.groupBox1.Controls.Add(this.tbxUsername);
            this.groupBox1.Controls.Add(this.tbxLuongCB);
            this.groupBox1.Controls.Add(this.tbxCMND);
            this.groupBox1.Controls.Add(this.tbxHoTen);
            this.groupBox1.Controls.Add(this.tbxMaNV);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 361);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // cbxChucVu
            // 
            this.cbxChucVu.FormattingEnabled = true;
            this.cbxChucVu.Items.AddRange(new object[] {
            "Quản lý",
            "Nhân viên"});
            this.cbxChucVu.Location = new System.Drawing.Point(105, 48);
            this.cbxChucVu.Name = "cbxChucVu";
            this.cbxChucVu.Size = new System.Drawing.Size(165, 21);
            this.cbxChucVu.TabIndex = 1;
            // 
            // dtpickNgayTD
            // 
            this.dtpickNgayTD.CustomFormat = "dd/MM/yyyy";
            this.dtpickNgayTD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpickNgayTD.Location = new System.Drawing.Point(105, 228);
            this.dtpickNgayTD.Name = "dtpickNgayTD";
            this.dtpickNgayTD.Size = new System.Drawing.Size(165, 20);
            this.dtpickNgayTD.TabIndex = 7;
            // 
            // dtpickNgaySinh
            // 
            this.dtpickNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpickNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpickNgaySinh.Location = new System.Drawing.Point(105, 101);
            this.dtpickNgaySinh.Name = "dtpickNgaySinh";
            this.dtpickNgaySinh.Size = new System.Drawing.Size(165, 20);
            this.dtpickNgaySinh.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 26);
            this.label9.TabIndex = 1;
            this.label9.Text = "Nơi làm việc \r\nchính:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(8, 230);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(91, 13);
            this.label.TabIndex = 1;
            this.label.Text = "Ngày tuyển dụng:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(44, 328);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(55, 13);
            this.label24.TabIndex = 1;
            this.label24.Text = "Mật khẩu:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Lương cơ bản:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(41, 302);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(58, 13);
            this.label22.TabIndex = 1;
            this.label22.Text = "Username:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(57, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "CMND:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày sinh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(49, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Chức vụ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã nhân viên:";
            // 
            // tbxDiaChi
            // 
            this.tbxDiaChi.Location = new System.Drawing.Point(105, 127);
            this.tbxDiaChi.Multiline = true;
            this.tbxDiaChi.Name = "tbxDiaChi";
            this.tbxDiaChi.Size = new System.Drawing.Size(165, 43);
            this.tbxDiaChi.TabIndex = 4;
            // 
            // tbxNoiLamViec
            // 
            this.tbxNoiLamViec.Location = new System.Drawing.Point(105, 254);
            this.tbxNoiLamViec.Multiline = true;
            this.tbxNoiLamViec.Name = "tbxNoiLamViec";
            this.tbxNoiLamViec.Size = new System.Drawing.Size(165, 39);
            this.tbxNoiLamViec.TabIndex = 8;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(105, 325);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(165, 20);
            this.tbxPassword.TabIndex = 10;
            this.tbxPassword.UseSystemPasswordChar = true;
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(105, 299);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(165, 20);
            this.tbxUsername.TabIndex = 9;
            // 
            // tbxLuongCB
            // 
            this.tbxLuongCB.Location = new System.Drawing.Point(105, 202);
            this.tbxLuongCB.Name = "tbxLuongCB";
            this.tbxLuongCB.Size = new System.Drawing.Size(165, 20);
            this.tbxLuongCB.TabIndex = 6;
            // 
            // tbxCMND
            // 
            this.tbxCMND.Location = new System.Drawing.Point(105, 176);
            this.tbxCMND.Name = "tbxCMND";
            this.tbxCMND.Size = new System.Drawing.Size(165, 20);
            this.tbxCMND.TabIndex = 5;
            // 
            // tbxHoTen
            // 
            this.tbxHoTen.Location = new System.Drawing.Point(105, 75);
            this.tbxHoTen.Name = "tbxHoTen";
            this.tbxHoTen.Size = new System.Drawing.Size(165, 20);
            this.tbxHoTen.TabIndex = 2;
            // 
            // tbxMaNV
            // 
            this.tbxMaNV.BackColor = System.Drawing.SystemColors.Info;
            this.tbxMaNV.Location = new System.Drawing.Point(105, 22);
            this.tbxMaNV.Name = "tbxMaNV";
            this.tbxMaNV.ReadOnly = true;
            this.tbxMaNV.Size = new System.Drawing.Size(84, 20);
            this.tbxMaNV.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.btnXoaNhanVien, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSuaNhanVien, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnThemNhanVien, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 370);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(320, 59);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btnXoaNhanVien
            // 
            this.btnXoaNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXoaNhanVien.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoaNhanVien.ImageIndex = 1;
            this.btnXoaNhanVien.ImageList = this.imgChucVu;
            this.btnXoaNhanVien.Location = new System.Drawing.Point(212, 0);
            this.btnXoaNhanVien.Margin = new System.Windows.Forms.Padding(0);
            this.btnXoaNhanVien.Name = "btnXoaNhanVien";
            this.btnXoaNhanVien.Size = new System.Drawing.Size(108, 59);
            this.btnXoaNhanVien.TabIndex = 13;
            this.btnXoaNhanVien.Text = "Xóa nhân viên";
            this.btnXoaNhanVien.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoaNhanVien.UseVisualStyleBackColor = true;
            this.btnXoaNhanVien.Click += new System.EventHandler(this.ButtonXoaNhanVien_Click);
            // 
            // btnSuaNhanVien
            // 
            this.btnSuaNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSuaNhanVien.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSuaNhanVien.ImageIndex = 2;
            this.btnSuaNhanVien.ImageList = this.imgChucVu;
            this.btnSuaNhanVien.Location = new System.Drawing.Point(106, 0);
            this.btnSuaNhanVien.Margin = new System.Windows.Forms.Padding(0);
            this.btnSuaNhanVien.Name = "btnSuaNhanVien";
            this.btnSuaNhanVien.Size = new System.Drawing.Size(106, 59);
            this.btnSuaNhanVien.TabIndex = 12;
            this.btnSuaNhanVien.Text = "Sửa nhân viên";
            this.btnSuaNhanVien.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSuaNhanVien.UseVisualStyleBackColor = true;
            this.btnSuaNhanVien.Click += new System.EventHandler(this.ButtonSuaNhanVien_Click);
            // 
            // btnThemNhanVien
            // 
            this.btnThemNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThemNhanVien.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThemNhanVien.ImageIndex = 0;
            this.btnThemNhanVien.ImageList = this.imgChucVu;
            this.btnThemNhanVien.Location = new System.Drawing.Point(0, 0);
            this.btnThemNhanVien.Margin = new System.Windows.Forms.Padding(0);
            this.btnThemNhanVien.Name = "btnThemNhanVien";
            this.btnThemNhanVien.Size = new System.Drawing.Size(106, 59);
            this.btnThemNhanVien.TabIndex = 11;
            this.btnThemNhanVien.Text = "Thêm nhân viên";
            this.btnThemNhanVien.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThemNhanVien.UseVisualStyleBackColor = true;
            this.btnThemNhanVien.Click += new System.EventHandler(this.ButtonThemNhanVien_Click);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabQLNV);
            this.tabMain.Controls.Add(this.tabQLSP);
            this.tabMain.Controls.Add(this.tabQLHD);
            this.tabMain.Controls.Add(this.tabBH);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 24);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(946, 464);
            this.tabMain.TabIndex = 13;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.TabMain_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 488);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bán hàng";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabBH.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstvGioHang)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.tabQLHD.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstvHoaDon)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabQLSP.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstvChiTietSP)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabQLNV.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstvNhanVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}