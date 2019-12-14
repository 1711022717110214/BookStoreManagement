using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
namespace BookStore.Model
{
    public class NhanVien
    {
        public string MaNV;
        public string HoTen;
        public string SoDT;
        public string CongViec;
        public string DiaChi;
        public string Password;
        public string Hinh;
        public Image GetImage()
        {
            string path = "";
            string src = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Resources";
            if (Hinh != null) path = Path.Combine(src, Hinh);
            if (File.Exists(path)) return Image.FromFile(path);
            return null;
        }
    }
}
