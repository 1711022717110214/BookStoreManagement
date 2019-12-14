using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookStore.BLLayer;
using BookStore.Model;
using BookStore.Objects;

namespace BookStore.PresentationLayer
{
    public partial class EditBook : Form
    {
        public EditBook()
        {
            InitializeComponent();
        }
        BL_Sach s = new BL_Sach();
        string path = "";
        string name = "";
        List<Ncc> NCCs = new List<Ncc>();
        List<string> Codes = new List<string>();
        public void Reload()
        {
            button2.FlatAppearance.BorderSize = 0;
            var src1 = new AutoCompleteStringCollection();
            src1.AddRange(s.GetAuthorAutoCompleteDataSource().ToArray());
            txtTacGia.AutoCompleteCustomSource = src1;
            List<string> cbNXBdatasrc = new List<string>();
            NCCs = s.LayNCC();
            foreach (Ncc n in NCCs)
                cbNXBdatasrc.Add(n.MaNcc);
            cbNXB.DataSource = cbNXBdatasrc;
            Codes = s.LayMaGiamGia();
            cbCode.DataSource = Codes;
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void EditBook_Load(object sender, EventArgs e)
        {
            Reload();
            Sach b = new Sach();
            b = s.LaySachTheoMa(Convert.ToInt32(this.Text));
            txtTenSach.Text = b.Ten;
            txtTacGia.Text = b.TacGia;
            cbNgonNgu.Text = b.NgonNgu;
            cbNXB.Text = b.NhaCC.MaNcc;
            cbDongSach.Text = b.DongSach;
            cbTheLoai.Text = b.TheLoai;
            txtKeSach.Text = b.KeSach.ToString();
            txtGiaGoc.Text = b.GiaGoc.ToString();
            txtGiaBan.Text = b.GiaBan.ToString();
            txtKho.Text = b.TonKho.ToString();
            name = b.Hinh;
            Image i = b.GetImage();
            if (i != null)
            {
                pictureBox1.Image = i;
                path = b.Hinh;
            }

        }
        private void btnEditB_Click(object sender, EventArgs e)
        {
            Sach sobj = new Sach();
            sobj.MaSach = Convert.ToInt32(this.Text);
            sobj.Ten = txtTenSach.Text;
            sobj.TacGia = txtTacGia.Text;
            sobj.NhaCC.MaNcc = cbNXB.Text;
            sobj.NgonNgu = cbNgonNgu.Text;
            sobj.DongSach = cbDongSach.Text;
            sobj.TheLoai = cbTheLoai.Text;
            sobj.KeSach = Convert.ToInt32(txtKeSach.Text);
            sobj.GiaGoc = Convert.ToDecimal(txtGiaGoc.Text);
            sobj.GiaBan = Convert.ToDecimal(txtGiaBan.Text);
            sobj.TonKho = Convert.ToInt32(txtKho.Text);
            sobj.MaGiamGia.MaGiamGia = cbCode.Text;
            sobj.Hinh = name;
            s.SuaSach(sobj);
            MessageBox.Show("Changes saved!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string src = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Resources";
                name = Path.GetFileName(openFileDialog1.FileName);
                path = Path.Combine(src, name);
                if (!File.Exists(Path.Combine(src, name)))
                    File.Copy(openFileDialog1.FileName, path);
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void cbCode_Click(object sender, EventArgs e)
        {
            cbCode.DataSource = s.LayMaGiamGia();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            s.XoaSach(Convert.ToInt32(this.Text));
            MessageBox.Show("Successfully delete this book!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void EditBook_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void cbDongSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> src = new List<string>();
            if (cbDongSach.SelectedItem.ToString() == "Văn học nước ngoài")
                src = new List<string>() { "Giả tưởng - Kì ảo", "Truyện trinh thám", "Tiểu thuyết" };
            else if (cbDongSach.SelectedItem.ToString() == "Văn học Việt Nam")
                src = new List<string>() { "Tiểu thuyết", "Thơ - ca dao - tục ngữ", "Truyện ngắn - Tản văn" };
            else if (cbDongSach.SelectedItem.ToString() == "Kinh tế")
                src = new List<string>() { "Marketing", "Kinh doanh", "Quản trị - lãnh đạo", "Làm giàu - Khởi nghiệp" };
            else if (cbDongSach.SelectedItem.ToString() == "Khám phá")
                src = new List<string>() { "Vật lý thiên văn", "Khoa học" };
            else if (cbDongSach.SelectedItem.ToString() == "Tâm lí - Kỹ năng")
                src = new List<string>() { "Tâm lí - Kỹ năng", "Kỹ năng sống", "Rèn luyện nhân cách" };
            else if (cbDongSach.SelectedItem.ToString() == "Thiếu nhi")
                src = new List<string>() { "Truyện tranh", "Tô màu", "Luyện chữ" };
            else if (cbDongSach.SelectedItem.ToString() == "Sách tiếng anh")
                src = new List<string>() { "Fantasy", "Economy", "Novel", "Dicover", "Children" };
            cbTheLoai.DataSource = src;
        }
    }
}
