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
    public partial class Analytics : Form
    {
        public Analytics()
        {
            InitializeComponent();
        }
        DL_TinhTien bs = new DL_TinhTien();
        List<NhapHang> nhs;
        private void cbM_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = bs.LayTienNH(Convert.ToInt32(cbM.Text), DateTime.Now.Date.Year).ToString();
        }
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
    }
}
