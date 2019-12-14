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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void ManagerDashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            panel1.Width = 55;
            btnHome.FlatAppearance.BorderSize = 0;
            btnAcc.FlatAppearance.BorderSize = 0;
            btnB.FlatAppearance.BorderSize = 0;
            btnSup.FlatAppearance.BorderSize = 0;
            btnEmp.FlatAppearance.BorderSize = 0;
            btnCoupons.FlatAppearance.BorderSize = 0;
            btnRe.FlatAppearance.BorderSize = 0;
            btnHome_Click(null, null);
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 188) panel1.Width = 55;
            else panel1.Width = 188;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            MHome empinfo = new MHome();
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

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Books empinfo = new Books();
            empinfo.Text = this.Text;
            empinfo.TopLevel = false;
            empinfo.AutoScroll = true;
            empinfo.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(empinfo);
            empinfo.Show();
        }
        private void btnSup_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            AddPublisher empinfo = new AddPublisher();
            empinfo.Text = this.Text;
            empinfo.TopLevel = false;
            empinfo.AutoScroll = true;
            empinfo.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(empinfo);
            empinfo.Show();
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            EmpManagement empinfo = new EmpManagement();
            empinfo.TopLevel = false;
            empinfo.AutoScroll = true;
            empinfo.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(empinfo);
            empinfo.Show();
        }
        private void btnAcc_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            EmpInfo empinfo = new EmpInfo();
            empinfo.Text = this.Text;
            empinfo.TopLevel = false;
            empinfo.AutoScroll = true;
            empinfo.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(empinfo);
            empinfo.Show();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            labelTime.Text = d.ToString("HH:MM:ss");
        }

        private void btnCoupons_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Coupons empinfo = new Coupons();
            empinfo.Text = this.Text;
            empinfo.TopLevel = false;
            empinfo.AutoScroll = true;
            empinfo.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(empinfo);
            empinfo.Show();
        }

        private void btnRe_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Revenue empinfo = new Revenue();
            empinfo.Text = this.Text;
            empinfo.TopLevel = false;
            empinfo.AutoScroll = true;
            empinfo.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(empinfo);
            empinfo.Show();
        }
    }
}
