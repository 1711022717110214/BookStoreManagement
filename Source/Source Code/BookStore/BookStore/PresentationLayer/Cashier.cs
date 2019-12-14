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
    public partial class Cashier : Form
    {
        public Cashier()
        {
            InitializeComponent();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bill m = new Bill();
            m.Text = this.Text;
            m.ShowDialog();
            this.Close();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmpInfo empinfo = new EmpInfo();
            empinfo.Text = this.Text;
            empinfo.ShowDialog();
            this.Close();
        }
        public void LoadForm(Form f)
        {
            panel2.Controls.Clear();
            f.Text = this.Text;
            f.TopLevel = false;
            f.AutoScroll = true;
            f.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(f);
            f.Show();
        }
        private void Cashier_Load(object sender, EventArgs e)
        {
            timer1.Start();
            panel1.Width = 55;
            btnSR.FlatAppearance.BorderSize = 0;
            btnP.FlatAppearance.BorderSize = 0;
            btnM.FlatAppearance.BorderSize = 0;
            btnAcc.FlatAppearance.BorderSize = 0;
            btnSR_Click(null, null);
        }
        private void Cashier_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        public void panel2_ControlAdded(object sender, ControlEventArgs e)
        {
            e.Control.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 188) panel1.Width = 55;
            else panel1.Width = 188;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSR_Click(object sender, EventArgs e)
        {
            Bill b = new Bill();
            LoadForm(b);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.ShowDialog();
            this.Close();
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            Purchases p = new Purchases();
            LoadForm(p);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            labelTime.Text = d.ToString("HH:MM:ss");
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            Customers c = new Customers();
            LoadForm(c);
        }

        private void btnAcc_Click(object sender, EventArgs e)
        {
            EmpInfo i = new EmpInfo();
            LoadForm(i);
        }
    }
}
