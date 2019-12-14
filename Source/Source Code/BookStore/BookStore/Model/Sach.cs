using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using BookStore.Model;
namespace BookStore.Objects
{
    public class Sach
    {
        public Sach()
        {
            NhaCC = new Ncc();
            MaGiamGia = new GiamGia();
        }
        public int MaSach;
        public string Ten;
        public string Hinh;
        public string TacGia;
        public string NgonNgu;
        public Ncc NhaCC;
        public string DongSach;
        public string TheLoai;
        public int KeSach;
        public decimal GiaGoc;
        public decimal GiaBan;
        public GiamGia MaGiamGia;
        public int TonKho;
        public int? LuotMua;
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
