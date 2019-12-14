using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.DataLayer;
using BookStore.Model;
namespace BookStore.BLLayer
{
    public class BL_NhanVien
    {
        DL_NhanVien nv;
        public BL_NhanVien()
        {
            nv = new DL_NhanVien();
        }   
        public List<string> GetAutoCompleteDataSource()
        {
            return nv.GetAutoCompleteDataSource();
        }
        public int LogIn(string MaNV, string Pass)
        {
            string chucvu = nv.LogIn(MaNV, Pass);
            if (chucvu == "Quản lí") return 1;
            else if (chucvu == "Nhân viên thu ngân") return 2;
            else if (chucvu == "Nhân viên kiểm kho") return 3;
            return -1;
        }
        public NhanVien LayInfo(string MaNV)
        {
            return nv.LayInfo(MaNV);
        }
        public void SuaNV(NhanVien emp)
        {
            nv.SuaNV(emp);
        }
        public string LayTenNV (string manv)
        {
            return nv.LayTenNV(manv);
        }
        public void ThemNV (string manv, string hoten, string sdt, string cv, string dc, string path)
        {
            NhanVien e = new NhanVien();
            e.MaNV = manv;
            e.HoTen = hoten;
            e.SoDT = sdt;
            e.CongViec = cv;
            e.DiaChi = dc;
            e.Hinh = path;
            nv.ThemNV(e);
        }
        public List<NhanVien> LayNV()
        {
            return nv.LayNV();
        }
        public void XoaNV(string manv)
        {
            nv.XoaNV(manv);
        }
        public List<string> LayCV()
        {
            List<string> pos = new List<string>();
            List<ChucVu> cv = new List<ChucVu>();
            cv = nv.LayChucVu();
            foreach (ChucVu n in cv) pos.Add(n.CongViec);
            return pos;
        }
    }
}
