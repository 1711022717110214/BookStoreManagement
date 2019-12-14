using BookStore.BLLayer;
using BookStore.Model;
using BookStore.Properties;
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

namespace BookStore.PresentationLayer
{
    public partial class EmpManagement : Form
    {
        public EmpManagement()
        {
            InitializeComponent();
        }
        BL_NhanVien nv = new BL_NhanVien();
        List<NhanVien> lstemp = new List<NhanVien>();
        bool submit = false;      
        string path = "";
        string file = "";
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string src = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Resources";
                file = Path.GetFileName(openFileDialog1.FileName);
                path = Path.Combine(src, file);
                if (!File.Exists(Path.Combine(src, file)))
                    File.Copy(openFileDialog1.FileName, path);
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void EmpManagement_Load(object sender, EventArgs e)
        {
            Reload();
            btnEditE.Enabled = false;
            txtMaNV.Enabled = false;
        }
        public Image EditImageSize(Image i)
        {
            return (Image)(new Bitmap(i, new Size(100, 150)));
        }
        public void FilldgvNV(List<NhanVien> NhanViens)
        {
            foreach (NhanVien b in NhanViens)
            {
                Image virtuali = b.GetImage();
                if (virtuali != null) dataGridView1.Rows.Add(b.MaNV.ToString(), b.HoTen.ToString(), EditImageSize(virtuali), b.CongViec, b.SoDT, b.DiaChi);
                else dataGridView1.Rows.Add(b.MaNV.ToString(), b.HoTen.ToString(), null, b.CongViec, b.SoDT, b.DiaChi);
            }
        }
        private void btnEditE_Click(object sender, EventArgs e)
        {
            NhanVien emp = new NhanVien();
            emp.MaNV = txtMaNV.Text;
            emp.HoTen = txtTen.Text;
            emp.SoDT = txtSdt.Text;
            emp.DiaChi = txtAddr.Text;
            emp.CongViec = cbChucVu.Text;
            emp.Hinh = file;
            emp.Password = null;
            nv.SuaNV(emp);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditE.Enabled = true;
            int r = dataGridView1.CurrentCell.RowIndex;
            txtMaNV.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            txtTen.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
            cbChucVu.Text = dataGridView1.Rows[r].Cells[3].Value.ToString();
            txtSdt.Text = dataGridView1.Rows[r].Cells[4].Value.ToString();
            txtAddr.Text = dataGridView1.Rows[r].Cells[5].Value.ToString();
            if (dataGridView1.Rows[r].Cells[2].Value != null) pictureBox1.Image = (Image)dataGridView1.Rows[r].Cells[2].Value;
            else pictureBox1.Image = Properties.Resources.browse;
        }
        public void Reload()
        {
            cbChucVu.DataSource = nv.LayCV();
            lstemp = nv.LayNV();
            dataGridView1.Rows.Clear();
            FilldgvNV(lstemp);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Reload();
        }
        private void btnDelE_Click(object sender, EventArgs e)
        {
            nv.XoaNV(txtMaNV.Text);
            Reload();
        }

        private void btnNewE_Click_1(object sender, EventArgs e)
        {
            if (submit == false)
            {
                submit = true;
                txtMaNV.Enabled = true;
                btnNewE.Image = (Image)Resources.ResourceManager.GetObject("check_mark");
                btnNewE.Text = "Submit";
            }
            else if (submit)
            {
                if (txtMaNV.Text != "" && txtTen.Text != "" && txtSdt.Text != "" && txtAddr.Text != "")
                {
                    nv.ThemNV(txtMaNV.Text, txtTen.Text, txtSdt.Text, cbChucVu.Text, txtAddr.Text, file);
                    txtMaNV.Enabled = false;
                    btnNewE.Text = "New";
                    btnNewE.Image = (Image)Resources.ResourceManager.GetObject("plus");
                    submit = false;
                    Reload();
                }
                else MessageBox.Show("You need to fill all the information out!", "Cannot add new employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
