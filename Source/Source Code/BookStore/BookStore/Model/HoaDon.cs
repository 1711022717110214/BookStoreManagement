using BookStore.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Model
{
    public class HoaDon
    {
        public HoaDon()
        {
            ChiTietHDs = new List<ChiTietHD>();
        }
        public string MaHD;
        public List<ChiTietHD> ChiTietHDs;
        public DateTime NgayLap;
        public string MaNV;
        public string MaKH;
        public decimal Tong;
    }
    public class ChiTietHD
    {
        public ChiTietHD()
        {
            b = new Sach();
        }
        public Sach b;
        public int SoLuong;
        public decimal ThanhTien;
    }
}
