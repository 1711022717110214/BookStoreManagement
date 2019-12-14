using BookStore.Model;
using BookStore.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BookStore.DataLayer
{
    public class DL_TinhTien
    {
        private dbBookStoreDataContext bs;
        public DL_TinhTien()
        {
            bs = new dbBookStoreDataContext();
        }
        public List<string> GetCustomerAutoCompleteDataSource()
        {
            List<string> listcus = new List<string>();
            var lstcus = bs.spLayKhachHang().ToList();
            foreach (var au in lstcus) listcus.Add(au.MaKH);
            return listcus;
        }
        public void ThemHD(HoaDon hd)
        {
            if (hd.MaKH == "") bs.spThemHD(hd.MaHD, hd.NgayLap, hd.Tong, null, hd.MaNV);
            else bs.spThemHD(hd.MaHD, hd.NgayLap, hd.Tong, hd.MaKH, hd.MaNV);
            foreach (ChiTietHD ct in hd.ChiTietHDs)
            {
                bs.spThemChiTietHD(hd.MaHD, ct.b.MaSach, ct.SoLuong, ct.ThanhTien);
                bs.spThemLuotMua(ct.b.MaSach, ct.SoLuong);
            }
        }
        public List<ChiTietHD> LayChiTietHD(string mahd)
        {
            List<ChiTietHD> listhd = new List<ChiTietHD>();
            var lsthd = bs.spLayChiTietHD(mahd).ToList();
            foreach (var n in lsthd)
            {
                Sach d = new Sach();
                d.MaSach = n.MaSach;
                ChiTietHD h = new ChiTietHD() { b = d, SoLuong = n.SoLuong, ThanhTien = n.ThanhTien };
                listhd.Add(h);
            }
            return listhd;
        }
        public List<HoaDon> LayHD()
        {
            List<HoaDon> listhd = new List<HoaDon>();
            var lsthd = bs.spLayHoaDon().ToList();
            foreach (var n in lsthd)
            {
                HoaDon b = new HoaDon() { MaHD = n.MaHD, Tong = n.Tong, NgayLap = n.NgayLap, MaKH = n.MaKH, MaNV = n.MaNV };
                listhd.Add(b);
            }
            return listhd;
        }
        public List<Sach> BestSellers()
        {
            List<Sach> listsach = new List<Sach>();
            var lsts = bs.fnBestSellers().ToList();
            foreach (var n in lsts)
            {
                Sach b = new Sach() { Ten = n.Name, LuotMua = n.Purchase, Hinh = n.Path };
                listsach.Add(b);
            }
            return listsach;
        }
        public List<Sach> UnderStocks()
        {
            List<Sach> listsach = new List<Sach>();
            var lsts = bs.vUnderStocks.ToList();
            foreach (var n in lsts)
            {
                Sach b = new Sach() { MaSach = n.MaSach, Ten = n.Ten, TonKho = n.TonKho, Hinh = n.Path };
                listsach.Add(b);
            }
            return listsach;
        }
        //public void ThemDoanhThu(string thang, decimal S)
        //{
        //    bs.spThemDoanhThu(thang, S);
        //}
        public List<HoaDon> LayHDTheoThang(string month, string year)
        {
            List<HoaDon> listhd = new List<HoaDon>();
            var lsthd = bs.spLayHDTheoThang(month, year).ToList();
            foreach (var n in lsthd)
            {
                HoaDon b = new HoaDon() { MaHD = n.MaHD, Tong = n.Tong, NgayLap = n.NgayLap, MaKH = n.MaKH, MaNV = n.MaNV };
                listhd.Add(b);
            }
            return listhd;
        }
        public List<DoanhThu> LayDoanhThuTheoNam(string nam)
        {
            List<DoanhThu> listhd = new List<DoanhThu>();
            var lsthd = bs.spLayDoanhThu(nam).ToList();
            foreach (var n in lsthd)
            {
                DoanhThu b = new DoanhThu() { thang = n.Thang, Tong = n.ThuNhap };
                listhd.Add(b);
            }
            return listhd;
        }
        public List<DoanhThu> LayDoanhThu()
        {
            List<DoanhThu> listhd = new List<DoanhThu>();
            var lsthd = bs.spLayDoanhThu2().ToList();
            foreach (var n in lsthd)
            {
                DoanhThu b = new DoanhThu() { thang = n.Thang, BanHang = n.TienBanSach, NhapHang = n.TienNhapHang, Tong = n.ThuNhap };
                listhd.Add(b);
            }
            return listhd;
        }
        public void ThemDoanhThu(string thang, decimal bh, decimal nh)
        {
            bs.spThemDoanhThu(thang, bh, nh, bh - nh);
        }
        public decimal LayTienNH(int m, int y)
        {
            decimal? t = bs.fnLayTienNH(m, y);
            if (t != null) return (decimal)t;
            return 0;
        }
        public void XoaDT(string thang)
        {
            bs.spXoaDoanhThu(thang);
        }
        public void ThemLuotMua(ChiTietHD hd)
        {
            bs.spThemLuotMua(hd.b.MaSach, hd.SoLuong);
        }
        public void DieuChinhSL (ChiTietHD hd)
        {
            bs.spDieuChinhSLSach(hd.b.MaSach, hd.SoLuong);
        }
        public int KiemTraSLTonKho(int mas, int sl)
        {
            return (int)bs.fnKiemTraSL(mas, sl);
        }
    }
}
