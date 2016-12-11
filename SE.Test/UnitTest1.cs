namespace SE.Test
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SE.BUS;
    using SE.DTO;

    [TestClass]
    public class SEBusTest
    {
        private ChiTietHoaDonBUS cthdBUS;
        private GioHangBUS ghgBUS;
        private ChiTietHoaDonDTO cthdDTO1, cthdDTO2;
        private GioHangDTO ghgDTO;
  
        [TestInitialize]
        public void Inits()
        {
            this.cthdBUS = new ChiTietHoaDonBUS();
            this.ghgBUS = new GioHangBUS();
            this.cthdDTO1 = new ChiTietHoaDonDTO{
                KichThuoc = "XL",
                MauSac = "Đỏ lam",
                SoLuong = 10,
                DonGia = 80
            };
            this.cthdDTO2 = new ChiTietHoaDonDTO
            {
                KichThuoc = "L",
                MauSac = "Hồng cánh sen",
                SoLuong = 10,
                DonGia = 50
            };
            this.ghgDTO = new GioHangDTO();
            this.ghgDTO.DSChiTiet.Add(this.cthdDTO1);
            this.ghgDTO.DSChiTiet.Add(this.cthdDTO2);
            Global.Thue = 10;
        }

        [TestMethod]
        public void TestTinhTongTien()
        {
            Assert.AreEqual(800, this.cthdBUS.TinhTongTien(this.cthdDTO1));
        }

        [TestMethod]
        public void TestTinhTongTruocThue()
        {
            Assert.AreEqual(1300, this.ghgBUS.TinhTongTruocThue(this.ghgDTO));
        }

        [TestMethod]
        public void TestTinhTongTienThue()
        {
            Assert.AreEqual(130, this.ghgBUS.TinhTongTienThue(this.ghgDTO));
        }

        [TestMethod]
        public void TestTinhTongTienSauThue()
        {
            Assert.AreEqual(1430, this.ghgBUS.TinhTongTienSauThue(this.ghgDTO));
        }


    }
}
