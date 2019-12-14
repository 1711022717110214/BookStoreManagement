using BookStore.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataLayer
{
    public class DL_NhaCC
    {
        dbBookStoreDataContext ds;
        public DL_NhaCC()
        {
            ds = new dbBookStoreDataContext();
        }
        public List<Ncc> LayNCC()
        {
            List<Ncc> listb = new List<Ncc>();
            var lstb = ds.spLayNCC().ToList();
            foreach (var n in lstb)
            {
                Ncc nxb = new Ncc() { MaNcc = n.MaNCC, TenNcc = n.TenNCC, SDT = n.SDT, DiaChi = n.DiaChi };
                listb.Add(nxb);
            }
            return listb;
        }
        public void ThemNhaCC(Ncc n)
        {
            ds.spThemNCC(n.MaNcc, n.TenNcc, n.SDT, n.DiaChi);
        }
        public void XoaNhaCC(string manxb)
        {
            ds.spXoaNCC(manxb);

        }
        public void SuaNhaCC(Ncc n)
        {
            ds.spSuaNCC(n.MaNcc, n.TenNcc, n.SDT, n.DiaChi);
        }
    }
}
