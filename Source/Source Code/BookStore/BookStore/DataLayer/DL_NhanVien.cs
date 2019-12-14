using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BookStore.Model;
namespace BookStore.DataLayer
{
    public class DL_NhanVien
    {
        private dbBookStoreDataContext bs;
        public DL_NhanVien()
        {
            bs = new dbBookStoreDataContext();
        }
        public List<string> GetAutoCompleteDataSource()
        {
            List<string> listuser = new List<string>();
            var lstuser = bs.spLayTenDangNhap().ToList();
            foreach (var dn in lstuser) listuser.Add(dn.Username);
            return listuser;
        }
        public string LogIn(string MaNV, string Pass)
        {
            string chucvu = "";
            var lstnv = bs.spDangNhap(MaNV, Pass).ToList();
            foreach (var nv in lstnv) chucvu = nv.CongViec;
            return chucvu;
        }
        public NhanVien LayInfo(string MaNV)
        {
            NhanVien nv = new NhanVien();
            var lstuser = bs.spLayInfo(MaNV).ToList();
            foreach (var i in lstuser) nv = new NhanVien() { MaNV = i.MaNV, HoTen = i.HoTen, CongViec = i.CongViec, DiaChi = i.DiaChi, SoDT = i.SDT, Hinh = i.Path };
            return nv;
        }
        public void SuaNV(NhanVien nv)
        {
            if (nv.Password == null) bs.spSuaNV1(nv.MaNV, nv.HoTen, nv.DiaChi, nv.SoDT, nv.CongViec, nv.Hinh);
            else if (nv.Password != null) bs.spSuaNV2(nv.MaNV, nv.HoTen, nv.DiaChi, nv.SoDT, nv.CongViec, nv.Password, nv.Hinh);
        }
        public string LayTenNV (string manv)
        {
            string ten = "";
            var lstnv = bs.spLayTenNV(manv).ToList();
            foreach (var nv in lstnv) ten = nv.HoTen;
            return ten;
        }
        public void ThemNV(NhanVien e)
        {
            bs.spThemNV(e.MaNV, e.HoTen, e.DiaChi, e.SoDT, e.CongViec, e.Hinh);
        }
        public List<NhanVien> LayNV()
        {
            List<NhanVien> listemp = new List<NhanVien>();
            var lstemp = bs.spLayNV().ToList();
            foreach (var n in lstemp)
            {
                NhanVien e = new NhanVien() { MaNV = n.MaNV, HoTen = n.HoTen, DiaChi = n.DiaChi, SoDT = n.SDT, CongViec = n.CongViec, Hinh = n.Path };
                listemp.Add(e);
            }
            return listemp;
        }
        public void XoaNV (string manv)
        {
            bs.spXoaNVTheoMa(manv);
        }
        public List<ChucVu> LayChucVu()
        {
            List<ChucVu> listcv = new List<ChucVu>();
            var lstcv = bs.spLayChucVu().ToList();
            foreach (var n in lstcv)
            {
                ChucVu e = new ChucVu() { CongViec = n.CongViec};
                listcv.Add(e);
            }
            return listcv;
        }
    }
}
