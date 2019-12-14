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
    public partial class StoreKeeper : Form
    {
        public StoreKeeper()
        {
            InitializeComponent();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void StockKeeper_Load(object sender, EventArgs e)
        {
            panel1.Width = 55;
            btnHome.FlatAppearance.BorderSize = 0;
            btnAcc.FlatAppearance.BorderSize = 0;
            btnRep.FlatAppearance.BorderSize = 0;
            btnImp.FlatAppearance.BorderSize = 0;
            btnHome_Click(null, null);
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 188) panel1.Width = 55;
            else panel1.Width = 188;
        }
        private void btnInvoice_Click(object sender, EventArgs e)
        {
            GoodsInvoice empinfo = new GoodsInvoice();
            panel2.Controls.Clear();
            empinfo.Text = this.Text;
            empinfo.TopLevel = false;
            empinfo.AutoScroll = true;
            empinfo.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(empinfo);
            empinfo.Show();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.ShowDialog();
            this.Close();
        }
        private void btnImp_Click(object sender, EventArgs e)
        {
            Import empinfo = new Import();
            panel2.Controls.Clear();
            empinfo.Text = this.Text;
            empinfo.TopLevel = false;
            empinfo.AutoScroll = true;
            empinfo.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(empinfo);
            empinfo.Show();
        }

        private void btnAcc_Click(object sender, EventArgs e)
        {
            EmpInfo empinfo = new EmpInfo();
            panel2.Controls.Clear();
            empinfo.Text = this.Text;
            empinfo.TopLevel = false;
            empinfo.AutoScroll = true;
            this.panel2.Controls.Add(empinfo);
            empinfo.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            GoodsInvoice empinfo = new GoodsInvoice();
            panel2.Controls.Clear();
            empinfo.Text = this.Text;
            empinfo.TopLevel = false;
            empinfo.AutoScroll = true;
            empinfo.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(empinfo);
            empinfo.Show();
        }

        private void btnRep_Click(object sender, EventArgs e)
        {
            Analytics empinfo = new Analytics();
            panel2.Controls.Clear();
            empinfo.Text = this.Text;
            empinfo.TopLevel = false;
            empinfo.AutoScroll = true;
            empinfo.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(empinfo);
            empinfo.Show();
        }

        private void StoreKeeper_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
