using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookStore.Model;

namespace BookStore.PresentationLayer
{
    public partial class InvoiceView : UserControl
    {
        public string ImagePath = "";
        public InvoiceView()
        {
            InitializeComponent();
            ct = new ChiTietHD();
        }
        ChiTietHD ct;
        public InvoiceView(string ten, string sl, string dg, string path)
        {
            InitializeComponent();
            lblTen.Text = ten;
            lblDonGia.Text = dg;
            lblSoL.Text = sl;
            ImagePath = path;
        }
        private void InvoiceView_Load(object sender, EventArgs e)
        {
            ct = (ChiTietHD)this.Tag;
            lblTen.Text += ct.b.Ten;
            lblDonGia.Text += ct.b.GiaBan.ToString();
            lblSoL.Text += ct.SoLuong.ToString();
            if (ct.b.GetImage() != null)
            {
                Image virtuali = ct.b.GetImage();
                if (virtuali != null) pictureBox1.Image = virtuali;
            }
            else pictureBox1.Image = Properties.Resources.noimages;
        }
    }
}
