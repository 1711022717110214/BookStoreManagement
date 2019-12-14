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
    public partial class Customers : Form
    {
        DL_KH bs;
        List<KhachHang> khs;
        public Customers()
        {
            InitializeComponent();
        }
        public void Reload()
        {
            khs = bs.LayKH();
            dataGridView1.Rows.Clear();
            foreach (KhachHang b in khs)
                dataGridView1.Rows.Add(b.MaKH, b.TenKH, b.DiemTich.ToString());
        }
        private void Customers_Load(object sender, EventArgs e)
        {
            bs = new DL_KH();
            Reload();
        }
        private void btnNewC_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" && txtN.Text != "") bs.ThemKH(txtID.Text, txtN.Text);
            else MessageBox.Show("You need to fill in all the information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            txtID.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            txtN.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
            txtP.Text = dataGridView1.Rows[r].Cells[2].Value.ToString();
        }
        private void btnEditC_Click(object sender, EventArgs e)
        {
            bs.SuaKH(txtID.Text, txtN.Text, Convert.ToInt32(txtP.Text));
        }
        private void btnDelC_Click(object sender, EventArgs e)
        {
            bs.XoaKH(txtID.Text);
        }
    }
}
