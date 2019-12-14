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
namespace BookStore.PresentationLayer
{
    public partial class EmpInfo : Form
    {
        NhanVien nv = new NhanVien();
        public EmpInfo()
        {
            InitializeComponent();
        }
        BL_NhanVien emp = new BL_NhanVien();
        string path = "";
        string name = "";
        private void EmpInfo_Load(object sender, EventArgs e)
        {
            btnSubmit.FlatAppearance.BorderSize = 0;
            txtNewP.UseSystemPasswordChar = true;
            txtRetype.UseSystemPasswordChar = true;
            LayInfo();
        }
        public void LayInfo()
        {
            nv = emp.LayInfo(this.Text);
            txtMaNV.Text = nv.MaNV;
            txtTen.Text = nv.HoTen;
            txtSdt.Text = nv.SoDT;
            txtAddr.Text = nv.DiaChi;
            cbChucVu.Text = nv.CongViec;
            name = nv.Hinh;
            Image virtuali = nv.GetImage();
            if (virtuali != null) pictureBox1.Image = virtuali;
        }
        private void txtNewP_TextChanged(object sender, EventArgs e)
        {
            if (txtNewP.Text == "")
            {
                txtRetype.Enabled = false;
                btnSubmit.Enabled = true;
            }
            else
            {
                btnSubmit.Enabled = false;
                txtRetype.Enabled = true;
            }
        }
        private void txtRetype_TextChanged(object sender, EventArgs e)
        {
            if (txtRetype.TextLength == txtNewP.TextLength && txtRetype.Text != txtNewP.Text)
            {
                errorProvider1.SetError(txtRetype, "Password không trùng khớp!");
                btnSubmit.Enabled = false;
            }
            else if (txtRetype.Text == txtNewP.Text)
            {
                errorProvider1.Clear();
                btnSubmit.Enabled = true;
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            nv.MaNV = txtMaNV.Text;
            nv.HoTen = txtTen.Text;
            nv.SoDT = txtSdt.Text;
            nv.DiaChi = txtAddr.Text;
            nv.CongViec = cbChucVu.Text;
            nv.Hinh = name;
            if (txtRetype.Enabled == true) nv.Password = txtRetype.Text;
            emp.SuaNV(nv);
            MessageBox.Show("Your information has been changed successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            LayInfo();
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
    }
}
