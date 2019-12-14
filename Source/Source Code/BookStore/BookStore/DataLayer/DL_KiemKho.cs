using BookStore.Model;
using BookStore.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataLayer
{
    public class DL_KiemKho
    {
        private dbBookStoreDataContext bs;
        public DL_KiemKho()
        {
            bs = new dbBookStoreDataContext();
        }
        public void ThemNH(NhapHang nh)
        {
            bs.spThemNH(nh.MaDon, nh.NgayLap, nh.NguoiLap, nh.NCC, nh.Tong);
            foreach (ChiTietNH ct in nh.ctnhs)
                bs.spThemChiTietNH(nh.MaDon, ct.MaSach.MaSach, ct.SoLuong, ct.ThanhTien);
        }
        public string LayMaNH()
        {
            return bs.fnLayMaNH();
        }
        public List<ChiTietNH> LayChiTietNH(string madon)
        {
            List<ChiTietNH> ctnh = new List<ChiTietNH>();
            var r = bs.spLayChiTietNH(madon).ToList();
            foreach (var n in r)
            {
                Sach b = new Sach();
                b.MaSach = n.MaSach;
                ChiTietNH ct = new ChiTietNH() { MaSach = b, SoLuong = n.SoLuong, ThanhTien = n.ThanhTien };
                ctnh.Add(ct);
            }
            return ctnh;
        }
        public List<NhapHang> LayNH()
        {
            List<NhapHang> nhlist = new List<NhapHang>();
            var list = bs.spLayNH().ToList();
            foreach (var n in list)
            {
                NhapHang nh = new NhapHang() { MaDon = n.MaDon, NCC = n.NCC, NgayLap = n.NgayLap, NguoiLap = n.NguoiLap, Tong = n.Tong, ViTri = n.ViTri, NgayNhan = n.NgayNhan, NguoiNhan = n.NguoiNhan };
                nh.ctnhs = LayChiTietNH(nh.MaDon);
                nhlist.Add(nh);
            }
            return nhlist;
        }
        public List<NhapHang> LayNHTheoNCC(string mancc)
        {
            List<NhapHang> nhlist = new List<NhapHang>();
            var list = bs.spLayNHTheoNCC(mancc).ToList();
            foreach (var n in list)
            {
                NhapHang nh = new NhapHang() { MaDon = n.MaDon, NgayLap = n.NgayLap, NguoiLap = n.NguoiLap, Tong = n.Tong, ViTri = n.ViTri, NgayNhan = n.NgayNhan, NguoiNhan = n.NguoiNhan, NCC = n.NCC };
                nh.ctnhs = LayChiTietNH(nh.MaDon);
                nhlist.Add(nh);
            }
            return nhlist;
        }
        public void SuaNH (string madon, DateTime d, string manv, string vitri)
        {
            bs.spSuaNH(madon, d, manv, vitri);
        }
    }
}
