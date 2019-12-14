using BookStore.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Model
{
    public class NhapHang
    {
        public string MaDon;
        public DateTime NgayLap;
        public string NguoiLap;
        public string NCC;
        public decimal Tong;
        public DateTime? NgayNhan;
        public string NguoiNhan;
        public string ViTri;
        public List<ChiTietNH> ctnhs;
        public NhapHang()
        {
            ctnhs = new List<ChiTietNH>();
        }
    }
    public class ChiTietNH
    {
        public Sach MaSach;
        public int SoLuong;
        public decimal ThanhTien;
        public ChiTietNH()
        {
            MaSach = new Sach();
        }
    }
}
