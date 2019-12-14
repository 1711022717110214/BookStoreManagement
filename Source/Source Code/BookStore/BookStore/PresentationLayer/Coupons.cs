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
    public partial class Coupons : Form
    {
        public Coupons()
        {
            InitializeComponent();
        }
        List<GiamGia> codes;
        DL_Sach bs = new DL_Sach();
        GiamGia g;
        public void Reload()
        {
            codes = bs.LayMaGG();
            dataGridView1.Rows.Clear();
            foreach (GiamGia b in codes)
                dataGridView1.Rows.Add(b.MaGiamGia, b.NgayBatDau.ToString(), b.NgayKetThuc.ToString(), b.ChiTiet, b.PhanTram.ToString());
        }
        private void Coupons_Load(object sender, EventArgs e)
        {
            Reload();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            txtID.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            dpS.Value = DateTime.Parse(dataGridView1.Rows[r].Cells[1].Value.ToString());
            dpE.Value = DateTime.Parse(dataGridView1.Rows[r].Cells[2].Value.ToString());
            txtD.Text = dataGridView1.Rows[r].Cells[3].Value.ToString();
            txtP.Text = dataGridView1.Rows[r].Cells[4].Value.ToString();
        }
        private void btnEditE_Click(object sender, EventArgs e)
        {
            g = new GiamGia();
            g.MaGiamGia = txtID.Text;
            g.NgayBatDau = dpS.Value.Date;
            g.NgayKetThuc = dpE.Value.Date;
            g.ChiTiet = txtD.Text;
            g.PhanTram = Convert.ToDecimal(txtP.Text);
            bs.SuaMGG(g);
        }
        private void btnNewE_Click(object sender, EventArgs e)
        {
            g = new GiamGia();
            g.MaGiamGia = txtID.Text;
            g.NgayBatDau = dpS.Value.Date;
            g.NgayKetThuc = dpE.Value.Date;
            g.ChiTiet = txtD.Text;
            g.PhanTram = Convert.ToDecimal(txtP.Text);
            bs.ThemGiamGia(g);
            Reload();
        }
        private void btnDelE_Click(object sender, EventArgs e)
        {
            bs.XoaMGG(txtID.Text);
            Reload();
        }
    }
}
