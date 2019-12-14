using BookStore.DataLayer;
using BookStore.Model;
using BookStore.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.BLLayer
{
    public class BL_TinhTien
    {
        DL_Sach b = new DL_Sach();
        DL_TinhTien s = new DL_TinhTien();
        public List<string> GetCustomerAutoCompleteDataSource()
        {
            return s.GetCustomerAutoCompleteDataSource();
        }
        public Sach LaySachTheoMa(int MaS)
        {
            Sach book = new Sach();
            book = b.LaySachTheoMa(MaS);
            if (book.MaGiamGia.MaGiamGia != "")
            {
                book.MaGiamGia = b.LayChiTietMaGG(book.MaGiamGia.MaGiamGia);
                if (DateTime.Now.Date > book.MaGiamGia.NgayKetThuc)
                {
                    b.GoMaGG(book.MaGiamGia.MaGiamGia);
                    book.MaGiamGia.MaGiamGia = "";
                    book.MaGiamGia.PhanTram = 0;
                }
            }
            else book.MaGiamGia.PhanTram = 0;
            return book;
        }
        public ChiTietHD LayChiTietHD(int SachId, int sl)
        {
            ChiTietHD hd = new ChiTietHD();
            hd.b = LaySachTheoMa(SachId);
            hd.SoLuong = s.KiemTraSLTonKho(SachId, sl);
            hd.ThanhTien = sl * hd.b.GiaBan * (1 - hd.b.MaGiamGia.PhanTram);
            return hd;
        }
        public List<HoaDon> LayHD()
        {
            List<HoaDon> hds = new List<HoaDon>();
            hds = s.LayHD();
            foreach(HoaDon hd in hds)
            {
                hd.ChiTietHDs = s.LayChiTietHD(hd.MaHD);
                for (int i = 0; i < hd.ChiTietHDs.Count; i++)
                    hd.ChiTietHDs[i].b = LaySachTheoMa(hd.ChiTietHDs[i].b.MaSach);
            }
            return hds;
        }
        public void ThemHD(HoaDon hd)
        {
            s.ThemHD(hd);
        }
        public void ThemLuotMua(ChiTietHD hd)
        {
            s.ThemLuotMua(hd);
        }
        public void DieuChinhSL(ChiTietHD hd)
        {
            s.DieuChinhSL(hd);
        }
    }
}
