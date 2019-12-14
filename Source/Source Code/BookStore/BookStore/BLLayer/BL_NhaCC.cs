using BookStore.DataLayer;
using BookStore.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BLLayer
{
    public class BL_NhaCC
    {
        DL_NhaCC Nxb = new DL_NhaCC();
        public List<Ncc> LayNCC()
        {
            return Nxb.LayNCC();
        }
        public void ThemNhaCC(string mancc, string tenncc, string sdt, string dc)
        {
            Ncc nxb = new Ncc();
            nxb.MaNcc = mancc;
            nxb.TenNcc = tenncc;
            nxb.SDT = sdt;
            nxb.DiaChi = dc;
            Nxb.ThemNhaCC(nxb);
        }
        public void XoaNhaCC(string manxb)
        {
            Nxb.XoaNhaCC(manxb);
        }
        public void SuaNhaCC(Ncc n)
        {
            Nxb.SuaNhaCC(n);
        }
    }
}
