using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookStore.Model;
using BookStore.Objects;
namespace BookStore.DataLayer
{
    public class DL_Sach
    {
        private dbBookStoreDataContext bs;
        public DL_Sach()
        {
            bs = new dbBookStoreDataContext();
        }
        public List<string> GetAuthorAutoCompleteDataSource()
        {
            List<string> listauthor = new List<string>();
            var lstau = bs.spLayTenTacGia().ToList();
            foreach (var au in lstau) listauthor.Add(au.TacGia);
            return listauthor;
        }
        public void ThemSach(Sach sobj)
        {
            bs.spThemSach(sobj.Ten, sobj.TacGia, sobj.NgonNgu, sobj.NhaCC.MaNcc, sobj.DongSach, sobj.TheLoai, sobj.KeSach, sobj.GiaGoc, sobj.GiaBan, sobj.TonKho, sobj.Hinh);
        }
        public List<Ncc> LayNCC()
        {
            List<Ncc> listNXB = new List<Ncc>();
            var lstnxb = bs.spLayNCC().ToList();
            foreach (var n in lstnxb)
            {
                Ncc nxb = new Ncc() { MaNcc = n.MaNCC, TenNcc = n.TenNCC, SDT = n.SDT, DiaChi = n.DiaChi };
                listNXB.Add(nxb);
            }
            return listNXB;
        }
        public List<Sach> LaySach()
        {
            List<Sach> listb = new List<Sach>();
            var lstb = bs.spLayChiTietSach().ToList();
            foreach (var n in lstb)
            {
                Ncc nhacc = new Ncc();
                nhacc.MaNcc = n.NCC;
                GiamGia m = new GiamGia();
                if (n.Code == null) m.MaGiamGia = "";
                else m.MaGiamGia = n.Code;
                Sach s = new Sach() { MaSach = n.MaSach, Ten = n.Ten, TacGia = n.TacGia, NgonNgu = n.NgonNgu, 
                    NhaCC = nhacc, DongSach = n.KhuVuc, TheLoai = n.TheLoai, 
                    KeSach = n.KeSach, GiaGoc = n.GiaGoc, GiaBan = n.GiaBan, MaGiamGia = m, TonKho = n.TonKho, LuotMua = n.LuotMua, Hinh = n.Path};
                listb.Add(s);
            }
            
            return listb;
        }
        public List<Sach> LaySachTheoTen(string Ten)
        {
            List<Sach> listb = new List<Sach>();
            var lstb = bs.spLaySachTheoTen(Ten).ToList();
            foreach (var n in lstb)
            {
                Ncc nhacc = new Ncc();
                nhacc.MaNcc = n.NCC;
                GiamGia m = new GiamGia();
                if (n.Code == null) m.MaGiamGia = "";
                else m.MaGiamGia = n.Code;
                Sach s = new Sach() { MaSach = n.MaSach, Ten = n.Ten, TacGia = n.TacGia, NgonNgu = n.NgonNgu, NhaCC = nhacc, DongSach = n.KhuVuc, TheLoai = n.TheLoai, KeSach = n.KeSach, GiaGoc = n.GiaGoc, GiaBan = n.GiaBan, MaGiamGia = m, TonKho = n.TonKho, LuotMua = n.LuotMua, Hinh = n.Path };
                listb.Add(s);
            }
            return listb;
        }
        public void XoaSach(int mas)
        {
            bs.spXoaSach(mas);
        }
        public void SuaSach(Sach sobj)
        {
            if (sobj.MaGiamGia.MaGiamGia == "") bs.spSuaSach(sobj.MaSach, sobj.Ten, sobj.TacGia, sobj.NgonNgu, sobj.NhaCC.MaNcc, sobj.DongSach, sobj.TheLoai, sobj.KeSach, sobj.GiaGoc, sobj.GiaBan, sobj.TonKho, null, sobj.Hinh);
            else bs.spSuaSach(sobj.MaSach, sobj.Ten, sobj.TacGia, sobj.NgonNgu, sobj.NhaCC.MaNcc, sobj.DongSach, sobj.TheLoai, sobj.KeSach, sobj.GiaGoc, sobj.GiaBan, sobj.TonKho, sobj.MaGiamGia.MaGiamGia, sobj.Hinh);
        }
        public List<string> LayMaGiamGia()
        {
            List<string> listcode = new List<string>();
            var lstc = bs.spLayMaGG().ToList();
            foreach (var c in lstc) listcode.Add(c.MaGiamGia);
            return listcode;
        }
        public List<string> GetCategoryAutoCompleteDataSource()
        {
            List<string> listcategory = new List<string>();
            var lstcategory = bs.spLayDongSach().ToList();
            foreach (var ds in lstcategory) listcategory.Add(ds.KhuVuc);
            return listcategory;
        }
        public Sach LaySachTheoMa(int MaS)
        {
            Sach b = new Sach();
            var lstb = bs.spLayChiSachTheoMa(MaS);
            foreach (var n in lstb)
            {
                Ncc nhacc = new Ncc();
                nhacc.MaNcc = n.NCC;
                GiamGia m = new GiamGia();
                if (n.Code == null) m.MaGiamGia = "";
                else m.MaGiamGia = n.Code;
                b = new Sach() { MaSach = n.MaSach, Ten = n.Ten, TacGia = n.TacGia, NgonNgu = n.NgonNgu, NhaCC = nhacc, DongSach = n.KhuVuc, TheLoai = n.TheLoai, KeSach = n.KeSach, GiaGoc = n.GiaGoc, GiaBan = n.GiaBan, MaGiamGia = m, TonKho = n.TonKho, LuotMua = n.LuotMua, Hinh = n.Path };
            }
            return b;
        }
        public void ThemMaGGTheoDongSach(string dongs, string code)
        {
            bs.spThemMaGGTheoDongSach(dongs, code);
        }
        public List<string> GetBookAutoCompleteDataSource()
        {
            List<string> listname = new List<string>();
            var lstname = bs.spLayTenSach().ToList();
            foreach (var ds in lstname) listname.Add(ds.Ten);
            return listname;
        }
        public GiamGia LayChiTietMaGG(string magg)
        {
            GiamGia b = new GiamGia();
            var lstb = bs.spLayChiTietMaGG(magg);
            foreach (var n in lstb)
                b = new GiamGia() { MaGiamGia = n.MaGiamGia, ChiTiet = n.ChiTiet, NgayBatDau = n.NgayBatDau, NgayKetThuc = n.NgayKetThuc, PhanTram = n.PhanTramGiam };
            return b;
        }
        public void GoMaGG (string magg)
        {
            bs.spGoMaGG(magg);
        }
        public List<Sach> LaySachTheoNCC(string mancc)
        {
            List<Sach> listb = new List<Sach>();
            var lstb = bs.spLaySachTheoNCC(mancc).ToList();
            foreach (var n in lstb)
            {
                Ncc nhacc = new Ncc();
                nhacc.MaNcc = n.NCC;
                GiamGia m = new GiamGia();
                if (n.Code == null) m.MaGiamGia = "";
                else m.MaGiamGia = n.Code;
                Sach b = new Sach() { MaSach = n.MaSach, Ten = n.Ten, TacGia = n.TacGia, 
                    NgonNgu = n.NgonNgu, NhaCC = nhacc, 
                    DongSach = n.KhuVuc, TheLoai = n.TheLoai, KeSach = n.KeSach, 
                    GiaGoc = n.GiaGoc, GiaBan = n.GiaBan, MaGiamGia = m, TonKho = n.TonKho, LuotMua = n.LuotMua, Hinh = n.Path };
                listb.Add(b);
            }
            return listb;
        }
        public int? SoSach()
        {
            return bs.fnSoSach();
        }
        public int? SoNV()
        {
            return bs.fnSoNV();
        }
        public int? SoKH()
        {
            return bs.fnSoKH();
        }
        public void ThemSLSach(NhapHang nh)
        {
            foreach (ChiTietNH ct in nh.ctnhs) bs.spThemSLSach(ct.MaSach.MaSach, ct.SoLuong);
        }
        public List<GiamGia> LayMaGG()
        {
            List<GiamGia> listmagg = new List<GiamGia>();
            var lstmagg = bs.spLayGG().ToList();
            foreach (var n in lstmagg)
            {
                GiamGia g = new GiamGia() { MaGiamGia = n.MaGiamGia, NgayBatDau = n.NgayBatDau, NgayKetThuc = n.NgayKetThuc, ChiTiet = n.ChiTiet, PhanTram = n.PhanTramGiam };
                listmagg.Add(g);
            }
            return listmagg;
        }
        public void ThemGiamGia(GiamGia n)
        {
            bs.spThemMGG(n.MaGiamGia, n.NgayBatDau, n.NgayKetThuc, n.ChiTiet, n.PhanTram);
        }
        public void SuaMGG(GiamGia n)
        {
            bs.spSuaMGG(n.MaGiamGia, n.NgayBatDau, n.NgayKetThuc, n.ChiTiet, n.PhanTram);
        }
        public void XoaMGG(string maGiamGia)
        {
            bs.spXoaMGG(maGiamGia);
        }
    }
}
