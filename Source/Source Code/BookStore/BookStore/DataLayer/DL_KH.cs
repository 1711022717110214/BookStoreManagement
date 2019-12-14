using BookStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataLayer
{
    public class DL_KH
    {
        private dbBookStoreDataContext bs;
        public DL_KH()
        {
            bs = new dbBookStoreDataContext();
        }
        public List<KhachHang> LayKH()
        {
            List<KhachHang> listmakh = new List<KhachHang>();
            var lstmakh = bs.spLayKH().ToList();
            foreach (var n in lstmakh)
            {
                KhachHang khachhang = new KhachHang() { MaKH = n.MaKH, TenKH = n.TenKH, DiemTich = n.DiemTich.Value };
                listmakh.Add(khachhang);
            }
            return listmakh;
        }
        public void ThemKH(string makh, string tenkh)
        {
            bs.spThemKh(makh, tenkh, 0);
        }
        public void SuaKH(string makh, string tenkh, int diem)
        {
            bs.spSuaKH(makh, tenkh, diem);
        }
        public void XoaKH(string makh)
        {
            bs.spXoaKH(makh);
        }
        public int DiemKH(string makh)
        {
            int? diem = bs.spLayDiemKH(makh);
            if (diem != null) return (int)diem;
            return 0;
        }
        public KhachHang LayKHTheoMa(string makh)
        {
            KhachHang kh = new KhachHang();
            var lstmakh = bs.spLayKHTheoMa(makh).ToList();
            foreach (var n in lstmakh) kh = new KhachHang() { MaKH = n.MaKH, TenKH = n.TenKH, DiemTich = n.DiemTich.Value };
            return kh;
        }
    }
}
