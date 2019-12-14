using BookStore.BLLayer;
using BookStore.Objects;
using BookStore.Properties;
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
    public partial class AddPublisher : Form
    {
        public AddPublisher()
        {
            InitializeComponent();
        }
        BL_NhaCC dbNXB = new BL_NhaCC();
        List<Ncc> nxbs = new List<Ncc>();
        bool submit = false;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            txtMaNXB.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            txtTenNXB.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
            txtSoDT.Text = dataGridView1.Rows[r].Cells[2].Value.ToString();
            txtDC.Text = dataGridView1.Rows[r].Cells[3].Value.ToString();
        }
        public void Reload()
        {
            nxbs = dbNXB.LayNCC();
            dataGridView1.Rows.Clear();
            FilldgvNV(nxbs);
        }
        public void FilldgvNV(List<Ncc> nccs)
        {
            foreach (Ncc b in nccs)
                dataGridView1.Rows.Add(b.MaNcc, b.TenNcc, b.SDT, b.DiaChi);
        }
        private void btnNewS_Click(object sender, EventArgs e)
        {
            if (submit == false)
            {
                submit = true;
                txtMaNXB.Enabled = true;
                btnNewS.Image = (Image)Resources.ResourceManager.GetObject("check_mark");
                btnNewS.Text = "Submit";
            }
            else if (submit)
            {
                
                if (txtMaNXB.Text != "" && txtTenNXB.Text != "")
                {
                    dbNXB.ThemNhaCC(txtMaNXB.Text, txtTenNXB.Text, txtSoDT.Text, txtDC.Text);
                    txtMaNXB.Enabled = false;
                    btnNewS.Text = "New";
                    btnNewS.Image = (Image)Resources.ResourceManager.GetObject("plus");
                    submit = false;
                    Reload();
                }
                else MessageBox.Show("You need to fill all the information out!", "Cannot add new employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void AddPublisher_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            Reload();
        }

        private void btnEditS_Click(object sender, EventArgs e)
        {
            Ncc nxb = new Ncc();
            nxb.MaNcc = txtMaNXB.Text;
            nxb.TenNcc = txtTenNXB.Text;
            nxb.SDT = txtSoDT.Text;
            nxb.DiaChi = txtDC.Text;
            dbNXB.SuaNhaCC(nxb);
            Reload();
        }
        private void btnDelS_Click(object sender, EventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            string manxb = dataGridView1.Rows[r].Cells[0].Value.ToString();
            dbNXB.XoaNhaCC(manxb);
            Reload();
        }
    }
}
