using BookStore.DataLayer;
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
    public partial class Revenue : Form
    {
        public Revenue()
        {
            InitializeComponent();
        }
        DL_TinhTien bs = new DL_TinhTien();
        List<DoanhThu> dt = new List<DoanhThu>();
        List<HoaDon> hds = new List<HoaDon>();
        public void Reload()
        {
            dt = bs.LayDoanhThu();
            dataGridView1.Rows.Clear();
            foreach (DoanhThu b in dt)
                dataGridView1.Rows.Add(b.thang, b.BanHang.ToString(), b.NhapHang.ToString(), b.Tong.ToString());
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            txtS.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
            txtI.Text = dataGridView1.Rows[r].Cells[2].Value.ToString();
            int t = 0;
            t = Convert.ToInt32(dataGridView1.Rows[r].Cells[0].Value.ToString().Substring(0, 2));
            cbM.Text = t.ToString();
        }
        private void btnNewE_Click(object sender, EventArgs e)
        {
            bs.ThemDoanhThu(cbM.Text + "/" + DateTime.Now.Year.ToString(), Convert.ToDecimal(txtS.Text), Convert.ToDecimal(txtI.Text));
            Reload();
        }
        private void cbM_SelectedIndexChanged(object sender, EventArgs e)
        {
            hds = bs.LayHDTheoThang(cbM.Text, DateTime.Now.Year.ToString());
            decimal S = 0;
            foreach (HoaDon hd in hds) S += hd.Tong;
            txtS.Text = S.ToString();
            txtI.Text = bs.LayTienNH(Convert.ToInt32(cbM.Text), DateTime.Now.Year).ToString();
        }

        private void btnDelE_Click(object sender, EventArgs e)
        {
            bs.XoaDT(cbM.Text + "/" + DateTime.Now.Year.ToString());
            Reload();
        }

        private void Revenue_Load(object sender, EventArgs e)
        {
            Reload();
        }
    }
}
