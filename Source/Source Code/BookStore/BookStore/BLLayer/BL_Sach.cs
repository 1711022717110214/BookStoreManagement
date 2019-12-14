using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.DataLayer;
using BookStore.Objects;
using System.Drawing;
using System.Windows.Forms;
using BookStore.Model;

namespace BookStore.BLLayer
{
    public class BL_Sach
    {
        DL_Sach s;
        public BL_Sach()
        {
            s = new DL_Sach();
        }
        public List<string> GetAuthorAutoCompleteDataSource()
        {
            return s.GetAuthorAutoCompleteDataSource();
        }
        public void ThemSach(Sach sobj)
        {
            s.ThemSach(sobj);
        }
        public List<Ncc> LayNCC()
        {
            return s.LayNCC();
        }
        public List<Sach> LaySach()
        {
            return s.LaySach();
        }
        public void XoaSach(int mas)
        {
            s.XoaSach(mas);
        }
        public void SuaSach(Sach obj)
        {
            s.SuaSach(obj);
        }
        public List<string> LayMaGiamGia()
        {
            return s.LayMaGiamGia();
        }
        public Sach LaySachTheoMa(int MaS)
        {
            return s.LaySachTheoMa(MaS);
        }
        public void ThemMaGGTheoDongSach(string dongsach, string code)
        {
            s.ThemMaGGTheoDongSach(dongsach, code);
        }
        public List<string> GetBookAutoCompleteDataSource()
        {
            return s.GetBookAutoCompleteDataSource();
        }
        public List<Sach> LaySachTheoTen(string ten)
        {
            string Ten = ten + "%";
            return s.LaySachTheoTen(Ten);
        }
        public List<Sach> LaySachTheoNCC(string mancc)
        {
            return s.LaySachTheoNCC(mancc);
        }
        public void ThemSLSach(NhapHang nh)
        {
            s.ThemSLSach(nh);
        }
    }
}
