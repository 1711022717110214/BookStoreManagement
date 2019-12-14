using BookStore.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BLLayer
{
    public class BL_KiemKho
    {
        DL_KiemKho s = new DL_KiemKho();
        public string LayMaNH()
        {
            string manh = s.LayMaNH();
            int number = Convert.ToInt32(manh.Substring(2)) + 1;
            manh = "NH" + number.ToString();
            return manh;
        }
    }
}
