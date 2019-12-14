using BookStore.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.PresentationLayer
{
    public partial class OrderDetails : Form
    {
        public OrderDetails()
        {
            InitializeComponent();
        }
        NhapHang nh = new NhapHang();
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void OrderDetails_Load(object sender, EventArgs e)
        {
            button3.FlatAppearance.BorderSize = 0;
            nh = (NhapHang)this.Tag;
            txtID.Text = nh.MaDon;
            txtEmpID.Text = nh.NguoiLap;
            txtPaid.Text = nh.NguoiNhan;
            txtRd.Text = nh.NgayNhan.ToString();
            txtTotal.Text = nh.Tong.ToString();
            foreach (ChiTietNH b in nh.ctnhs)
                dataGridView1.Rows.Add(b.MaSach.MaSach.ToString(), b.MaSach.Ten.ToString(), b.SoLuong.ToString(), b.ThanhTien.ToString());
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void OrderDetails_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
