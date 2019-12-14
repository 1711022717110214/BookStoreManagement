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
    public partial class Import : Form
    {
        public Import()
        {
            InitializeComponent();
        }
        List<Ncc> NCCs = new List<Ncc>();
        BL_Sach s = new BL_Sach();
        DL_KiemKho bs = new DL_KiemKho();
        List<NhapHang> nhlist;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void Filldgv()
        {
            dataGridView1.Rows.Clear();
            foreach (NhapHang b in nhlist)
                dataGridView1.Rows.Add(b.MaDon, b.NgayLap.Date.ToString(), b.NguoiLap, b.NCC, b.Tong.ToString(), b.NgayNhan.ToString(), b.NguoiNhan, b.ViTri);
        }
        private void Import_Load(object sender, EventArgs e)
        {
            this.vNhaCungCapTableAdapter.Fill(this.bookstoreDataSet1.vNhaCungCap);
            nhlist = bs.LayNH();
            Filldgv();
        }
        private void cbNXB_TextChanged(object sender, EventArgs e)
        {
            if (cbNXB.Text != "")
            {
                if(cbNXB.SelectedValue != null) nhlist = bs.LayNHTheoNCC(cbNXB.SelectedValue.ToString());
                Filldgv();
            }
            else
            {
                nhlist = bs.LayNH();
                Filldgv();
            }
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "id")
            {
                if (e.Value != null && dataGridView1[6, e.RowIndex].Value == null)
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.BackColor = Color.Orange;
                }
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPos.ResetText();
            int r = dataGridView1.CurrentCell.RowIndex;
            txtInvoiceID.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            txtSup.Text = dataGridView1.Rows[r].Cells[3].Value.ToString();
            if(dataGridView1.Rows[r].Cells[7].Value != null) txtPos.Text = dataGridView1.Rows[r].Cells[7].Value.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (NhapHang n in nhlist)
            {
                if (n.MaDon == txtInvoiceID.Text)
                {
                    n.NgayNhan = DateTime.Now.Date;
                    n.NguoiNhan = this.Text;
                    n.ViTri = txtPos.Text;
                    bs.SuaNH(n.MaDon, DateTime.Now.Date, this.Text, txtPos.Text);
                    s.ThemSLSach(n);
                }
            }
            Filldgv();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderDetails m = new OrderDetails();
            m.Text = this.Text;
            foreach (NhapHang n in nhlist)
                if (n.MaDon == txtInvoiceID.Text)
                {
                    foreach(ChiTietNH ct in n.ctnhs)ct.MaSach = s.LaySachTheoMa(ct.MaSach.MaSach);
                    m.Tag = n;
                }
            m.ShowDialog();
        }
    }
}
