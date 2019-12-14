using BookStore.DataLayer;
using BookStore.Model;
using BookStore.Objects;
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
    public partial class Purchases : Form
    {
        public Purchases()
        {
            InitializeComponent();
        }
        DL_TinhTien bs = new DL_TinhTien();
        List<HoaDon> hds;
        private void addBestSellerView(Sach cthd)
        {
            PurchaseUC i = new PurchaseUC(cthd, "Best Seller");
            flowLayoutPanel1.Controls.Add(i);
        }
        private void addUnderStockView(Sach cthd)
        {
            PurchaseUC i = new PurchaseUC(cthd, "Under Stock");
            flowLayoutPanel1.Controls.Add(i);
        }
        private void cbV_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            List<Sach> s = new List<Sach>();
            if (cbV.SelectedItem.ToString() == "Best Seller")
            {               
                s = bs.BestSellers();
                foreach (Sach i in s) addBestSellerView(i);
            }
            else if (cbV.SelectedItem.ToString() == "Under Stock")
            {
                s = bs.UnderStocks();
                foreach (Sach i in s) addUnderStockView(i);
            }
        }

        private void Purchases_Load(object sender, EventArgs e)
        {

        }

        private void cbM_SelectedIndexChanged(object sender, EventArgs e)
        {
            hds = bs.LayHDTheoThang(cbM.Text, DateTime.Now.Year.ToString());
            decimal S = 0;
            foreach (HoaDon hd in hds) S += hd.Tong;
            textBox1.Text = S.ToString();
        }
    }
}
