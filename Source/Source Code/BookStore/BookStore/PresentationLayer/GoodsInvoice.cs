using BookStore.BLLayer;
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
    public partial class GoodsInvoice : Form
    {
        public GoodsInvoice()
        {
            InitializeComponent();
        }
        BL_Sach s = new BL_Sach();
        BL_KiemKho k = new BL_KiemKho();
        List<Ncc> NCCs = new List<Ncc>();
        List<Sach> b = new List<Sach>();
        NhapHang nh;
        public void FilldgvSach(List<Sach> Saches)
        {
            dataGridView1.Rows.Clear();
            foreach (Sach b in Saches)
                dataGridView1.Rows.Add(b.MaSach.ToString(), b.Ten.ToString(), b.LuotMua.ToString(), b.TonKho.ToString(), b.NhaCC.MaNcc.ToString());
        }
        private void Import_Load(object sender, EventArgs e)
        {
            btnNewE.FlatAppearance.BorderSize = 0;
            List<string> cbNXBdatasrc = new List<string>();
            NCCs = s.LayNCC();
            foreach (Ncc n in NCCs)
            {
                cbNXBdatasrc.Add(n.MaNcc);
            }
            cbNXB.DataSource = cbNXBdatasrc;
            b = s.LaySach();
            FilldgvSach(b);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            txtid.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
        }
        private void btnNewE_Click(object sender, EventArgs e)
        {
            btnNewE.Enabled = false;
            txtInvoiceID.Enabled = true;
            cbNXB.Enabled = false;
            nh = new NhapHang();
            nh.NguoiLap = this.Text;
            nh.NgayLap = DateTime.Now.Date;
            nh.MaDon = k.LayMaNH();
            txtInvoiceID.Text = nh.MaDon;
            nh.NCC = cbNXB.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ChiTietNH lst = new ChiTietNH();
            lst.MaSach = s.LaySachTheoMa(Convert.ToInt32(txtid.Text));
            lst.SoLuong = Convert.ToInt32(txtq.Text);
            lst.ThanhTien = lst.MaSach.GiaGoc * lst.SoLuong;
            nh.ctnhs.Add(lst);
            txtid.ResetText();
            txtq.ResetText();
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "stock")
            {
                if (e.Value != null && Convert.ToInt32(e.Value)  <= 5)
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.BackColor = Color.Orange;
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            btnNewE.Enabled = true;
            txtInvoiceID.Enabled = true;
            cbNXB.Enabled = true;
            Confirm m = new Confirm();
            m.Tag = nh;
            m.ShowDialog();
        }

        private void cbNXB_TextChanged(object sender, EventArgs e)
        {
            if (cbNXB.Text != "")
            {
                b = s.LaySachTheoNCC(cbNXB.SelectedItem.ToString());
                FilldgvSach(b);
            }
            else
            {
                b = s.LaySach();
                FilldgvSach(b);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
