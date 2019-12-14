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
    public partial class Confirm : Form
    {
        NhapHang nh;
        DL_KiemKho s = new DL_KiemKho();
        public Confirm()
        {
            InitializeComponent();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Confirm_Load(object sender, EventArgs e)
        {
            button3.FlatAppearance.BorderSize = 0;
            nh = (NhapHang)this.Tag;
            txtID.Text = nh.MaDon;
            txtEmpID.Text = nh.NguoiLap;
            txtSup.Text = nh.NCC;
            LoadData();
        }
        public void LoadData()
        {          
            dataGridView1.Rows.Clear();
            nh.Tong = 0;
            foreach (ChiTietNH b in nh.ctnhs)
            {
                dataGridView1.Rows.Add(b.MaSach.MaSach.ToString(), b.MaSach.Ten.ToString(), b.SoLuong.ToString(), b.ThanhTien.ToString());
                nh.Tong += b.ThanhTien;
            }
            txtTotal.Text = nh.Tong.ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            s.ThemNH(nh);
            this.Dispose();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "quantity")
            {
                MessageBox.Show(dataGridView1[0, e.RowIndex].Value.ToString());
                foreach (ChiTietNH b in nh.ctnhs)
                {
                    if (b.MaSach.MaSach.ToString() == dataGridView1[0, e.RowIndex].Value.ToString())
                    {
                        b.SoLuong = Convert.ToInt32(dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString());
                        b.ThanhTien = b.SoLuong * b.MaSach.GiaBan;
                    }
                }
                LoadData();
            }
        }
        private void Confirm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
