using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookStore.Objects;

namespace BookStore.PresentationLayer
{
    public partial class PurchaseUC : UserControl
    {
        public PurchaseUC()
        {
            InitializeComponent();
        }
        public string path = "";
        public Sach b = new Sach();
        public string mode = "";
        public PurchaseUC(Sach s, string m)
        {
            InitializeComponent();
            b = s;
            label2.Text = s.Ten;
            if (m == "Best Seller") label1.Text = s.LuotMua.ToString();
            else if (m == "Under Stock") label1.Text = s.TonKho.ToString();
            mode = m;
        }
        private void PurchaseUC_Load(object sender, EventArgs e)
        {
            label2.MaximumSize = new Size(panel1.Width, 0);
            label2.AutoSize = true;
            Image virtuali = b.GetImage();
            if (virtuali != null) pictureBox1.Image = virtuali;
            else pictureBox1.Image = Properties.Resources.noimages;
            if (mode == "Best Seller") pictureBox2.Image = Properties.Resources.buy_481;
            else if (mode == "Under Stock") pictureBox2.Image = Properties.Resources.filled_box_481;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
