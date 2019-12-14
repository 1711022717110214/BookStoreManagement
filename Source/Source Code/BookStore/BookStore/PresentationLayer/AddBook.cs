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
using System.IO;
using System.Reflection;
namespace BookStore.PresentationLayer
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }
        BL_Sach s = new BL_Sach();
        string path = "";
        string name = "";
        List<Ncc> NCCs = new List<Ncc>();
        List<string> Codes = new List<string>();
        private void cbNXB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTenSach_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTacGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbNgonNgu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cbTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtKeSach_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtKeSach.Text, "[^0-9]"))
            {
                errorProvider4.SetError(txtKeSach, "Chỉ được nhập số nguyên!");
                btnAddB.Enabled = false;
            }
            else
            {
                errorProvider4.Clear();
                btnAddB.Enabled = true;
            }
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtGiaGoc_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtGiaGoc.Text, "[^0-9]"))
            {
                errorProvider1.SetError(txtGiaGoc, "Chỉ được nhập số nguyên!");
                btnAddB.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                btnAddB.Enabled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pbThemNXB_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtGiaBan_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtGiaBan.Text, "[^0-9]"))
            {
                errorProvider2.SetError(txtGiaBan, "Chỉ được nhập số nguyên!");
                btnAddB.Enabled = false;
            }
            else
            {
                errorProvider2.Clear();
                btnAddB.Enabled = true;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtKho_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtKho.Text, "[^0-9]"))
            {
                errorProvider3.SetError(txtKho, "Chỉ được nhập số nguyên!");
                btnAddB.Enabled = false;
            }
            else
            {
                errorProvider3.Clear();
                btnAddB.Enabled = true;
            }
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            button2.FlatAppearance.BorderSize = 0;
            toolTip1.SetToolTip(pictureBox1, "Browse image here");
            Reload();       
        }
        public void Reload()
        {
            var src1 = new AutoCompleteStringCollection();
            src1.AddRange(s.GetAuthorAutoCompleteDataSource().ToArray());
            txtTacGia.AutoCompleteCustomSource = src1;
            List<string> cbNXBdatasrc = new List<string>();
            NCCs = s.LayNCC();
            foreach (Ncc n in NCCs)
                cbNXBdatasrc.Add(n.MaNcc);
            cbNXB.DataSource = cbNXBdatasrc;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string src = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Resources";
                name = Path.GetFileName(openFileDialog1.FileName);
                path = Path.Combine(src, name);
                if (!File.Exists(Path.Combine(src,name)))
                     File.Copy(openFileDialog1.FileName, path);
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
        private void btnAddB_Click(object sender, EventArgs e)
        {
            if (txtTenSach.Text != "" && txtTacGia.Text != "" && cbNgonNgu.Text != "" && cbNXB.Text != "" && cbDongSach.Text != ""
                && txtKeSach.Text != "" && txtGiaGoc.Text != "" && txtGiaBan.Text != "" && txtKho.Text != "")
            {
                Sach sobj = new Sach();
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
                sobj.LuotMua = 0;
                sobj.Hinh = name;
                s.ThemSach(sobj);
            }
        }

        private void AddBook_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
