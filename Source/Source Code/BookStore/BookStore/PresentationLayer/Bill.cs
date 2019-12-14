using BookStore.BLLayer;
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
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }
        BL_TinhTien s = new BL_TinhTien();
        DL_KH kh = new DL_KH();
        List<HoaDon> hds = new List<HoaDon>();
        HoaDon hd;
        int stt = 0;
        string mahd = "";
        KhachHang diem;
        public void FillInvoice()
        {
            hds.Clear();
            dataGridView1.Rows.Clear();
            hds = s.LayHD();
            foreach (HoaDon hd in hds)
                dataGridView1.Rows.Add(hd.MaHD, hd.NgayLap.ToString(), hd.Tong.ToString(), hd.MaKH, hd.MaNV);
        }
        public void Bill_Load(object sender, EventArgs e)
        {
            var src1 = new AutoCompleteStringCollection();
            src1.AddRange(s.GetCustomerAutoCompleteDataSource().ToArray());
            txtCus.AutoCompleteCustomSource = src1;
            FillInvoice();
        }
        private void btnNewI_Click(object sender, EventArgs e)
        {
            hd = new HoaDon();
            groupBox1.Enabled = true;
            btnPrintR.Enabled = true;
            btnNewI.Enabled = false;
            btnAddI.Enabled = true;
            flowLayoutPanel1.Controls.Clear();
        }
        private void btnAddI_Click(object sender, EventArgs e)
        {
            stt++;
            ChiTietHD cthd = new ChiTietHD();
            cthd = s.LayChiTietHD(Int32.Parse(txtBookID.Text), Int32.Parse(txtq.Text));
            if (stt == 1)
            {
                hd.MaHD = txtInvoiceID.Text;
                hd.NgayLap = DateTime.Now.Date;
                hd.MaKH = txtCus.Text;
                hd.MaNV = this.Text;
                txtInvoiceID.Enabled = false;
            }
            hd.ChiTietHDs.Add(cthd);
            addInvoiceView(cthd);
            btnAddI.Enabled = false;
            txtBookID.ResetText();
            txtq.ResetText();
        }
        private void addInvoiceView(ChiTietHD cthd)
        {
            InvoiceView i = new InvoiceView();
            i.Tag = cthd;
            flowLayoutPanel1.Controls.Add(i);
        }
        private void btnPrintR_Click(object sender, EventArgs e)
        {
            stt = 0;
            hds.Add(hd);
            decimal S = 0;
            foreach (ChiTietHD ct in hd.ChiTietHDs)
            {
                s.DieuChinhSL(ct);
                S += ct.ThanhTien;
            }
            if (txtCus.Text != "")
            {
                diem = new KhachHang();
                diem = kh.LayKHTheoMa(txtCus.Text);
                if (diem.DiemTich >= 200)
                {
                    S = S * (decimal)0.9;
                    diem.DiemTich -= 200;
                }
                diem.DiemTich = (int)S / 10000;
                kh.SuaKH(diem.MaKH, diem.TenKH, diem.DiemTich);
            }
            hd.Tong = S;
            s.ThemHD(hd);
            FillInvoice();
            txtBookID.ResetText();
            txtq.ResetText();
            txtCus.ResetText();
            txtInvoiceID.ResetText();
            txtInvoiceID.Enabled = true;
            btnAddI.Enabled = false;
            groupBox1.Enabled = false;
            btnPrintR.Enabled = false;
            btnNewI.Enabled = true;
            flowLayoutPanel1.Controls.Clear();
        }
        private void txtBookID_TextChanged(object sender, EventArgs e)
        {
            if (txtBookID.Text != "" && txtq.Text != "") btnAddI.Enabled = true;
        }
        private void txtq_TextChanged(object sender, EventArgs e)
        {
            if (txtBookID.Text != "" && txtq.Text != "") btnAddI.Enabled = true;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            int r = dataGridView1.CurrentCell.RowIndex;
            if (dataGridView1.Rows[r].Cells[3].Value != null) txtCus.Text = dataGridView1.Rows[r].Cells[3].Value.ToString();
            txtInvoiceID.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            mahd = dataGridView1.Rows[r].Cells[0].Value.ToString();
            foreach (HoaDon i in hds)
            {
                if (i.MaHD == mahd)
                    foreach (ChiTietHD cthd in i.ChiTietHDs) addInvoiceView(cthd);
            }
        }
    }
}
