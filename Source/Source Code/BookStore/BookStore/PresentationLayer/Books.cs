using BookStore.BLLayer;
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
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
        }
        BL_Sach s = new BL_Sach();
        List<Sach> Saches = new List<Sach>();
        int r;
        string MaS;
        public Image EditImageSize(Image i)
        {
            return (Image)(new Bitmap(i, new Size(100, 150)));
        }
        public void FilldgvSach(List<Sach> Saches)
        {
            foreach (Sach b in Saches)
            {
                Image virtuali = b.GetImage();
                if (virtuali != null) dataGridView1.Rows.Add(b.MaSach.ToString(), b.Ten.ToString(), EditImageSize(virtuali), b.TacGia.ToString(), b.NhaCC.MaNcc.ToString(), b.NgonNgu.ToString(), b.DongSach.ToString(), b.TheLoai.ToString(), b.KeSach.ToString(), b.GiaGoc.ToString(), b.GiaBan.ToString(), b.MaGiamGia.MaGiamGia.ToString(), b.TonKho.ToString(), b.LuotMua.ToString());
                else dataGridView1.Rows.Add(b.MaSach.ToString(), b.Ten.ToString(), null, b.TacGia.ToString(), b.NhaCC.MaNcc.ToString(), b.NgonNgu.ToString(), b.DongSach.ToString(), b.TheLoai.ToString(), b.KeSach.ToString(), b.GiaGoc.ToString(), b.GiaBan.ToString(), b.MaGiamGia.MaGiamGia.ToString(), b.TonKho.ToString(), b.LuotMua.ToString());
            }
        }
        public void Reload()
        {
            btnEditB.Enabled = false;
            var src1 = new AutoCompleteStringCollection();
            src1.AddRange(s.GetBookAutoCompleteDataSource().ToArray());
            txtSearch.AutoCompleteCustomSource = src1;
            Saches.Clear();
            dataGridView1.Rows.Clear();
            Saches = s.LaySach();
            FilldgvSach(Saches);
        }
        private void Books_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            Saches = s.LaySachTheoTen(txtSearch.Text);
            FilldgvSach(Saches);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditB.Enabled = true;
            r = dataGridView1.CurrentCell.RowIndex;
            MaS = dataGridView1.Rows[r].Cells[0].Value.ToString();
        }
        private void btnEditB_Click(object sender, EventArgs e)
        {
            EditBook eb = new EditBook();
            eb.Text = MaS;
            eb.ShowDialog();
        }

        private void btnNewB_Click(object sender, EventArgs e)
        {
            AddBook eb = new AddBook();
            eb.Text = MaS;
            eb.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reload();
        }
    }
}
