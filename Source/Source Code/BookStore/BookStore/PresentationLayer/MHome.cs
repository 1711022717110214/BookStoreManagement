using BookStore.BLLayer;
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
    public partial class MHome : Form
    {
        DL_Sach s = new DL_Sach();
        DL_TinhTien bs = new DL_TinhTien();
        List<DoanhThu> dts = new List<DoanhThu>();
        public MHome()
        {
            InitializeComponent();
        }
        public void FillCategoriesChart()
        {
            this.vLiteraryLinesTableAdapter.Fill(this.bookstoreDataSet2.vLiteraryLines);
            chart1.Series["Categories"].XValueMember = "KhuVuc";
            chart1.Series["Categories"].YValueMembers = "SoSach";
        }
        private void MHome_Load(object sender, EventArgs e)
        {
            FillCategoriesChart();
            lbB.Text = s.SoSach().ToString();
            lbCus.Text = s.SoKH().ToString();
            lbE.Text = s.SoNV().ToString();
        }
    }
}
