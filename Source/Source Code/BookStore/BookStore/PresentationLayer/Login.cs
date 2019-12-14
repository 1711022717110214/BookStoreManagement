using BookStore.BLLayer;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        BL_NhanVien nv = new BL_NhanVien();
        private void Login_Load(object sender, EventArgs e)
        {
            var src = new AutoCompleteStringCollection();
            src.AddRange(nv.GetAutoCompleteDataSource().ToArray());
            txtUser.AutoCompleteCustomSource = src;
            btnLogin.Enabled = false;
        }
        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Username")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.White;
            }
        }
        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Username";
                txtUser.ForeColor = Color.LightGray;
            }
        }
        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Password")
            {
                txtPass.UseSystemPasswordChar = true;
                txtPass.Text = "";
                txtPass.ForeColor = Color.White;
            }
        }
        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.UseSystemPasswordChar = false;
                txtPass.Text = "Password";
                txtPass.ForeColor = Color.LightGray;
            }
        }
        private void txtPass_MouseLeave(object sender, EventArgs e)
        {
            if (txtPass.Text != "" && txtPass.Text != "Password"
                && txtUser.Text != "" && txtUser.Text != "Username") btnLogin.Enabled = true;
            else btnLogin.Enabled = false;
        }
        private void txtUser_MouseLeave(object sender, EventArgs e)
        {
            if (txtPass.Text != "" && txtPass.Text != "Password"
                && txtUser.Text != "" && txtUser.Text != "Username") btnLogin.Enabled = true;
            else btnLogin.Enabled = false;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            int dn = nv.LogIn(txtUser.Text, txtPass.Text);
            if (dn == 1)
            {
                this.Hide();
                Manager m = new Manager();
                m.Text = txtUser.Text;
                m.ShowDialog();
                this.Close();
            }
            else if (dn == 2)
            {
                this.Hide();
                Cashier m = new Cashier();
                m.Text = txtUser.Text;
                m.ShowDialog();
                this.Close();
            }
            else if (dn == 3)
            {
                this.Hide();
                StoreKeeper m = new StoreKeeper();
                m.Text = txtUser.Text;
                m.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid user!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUser.ResetText();
                txtUser.Focus();
                txtPass.ResetText();
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(null, null);
        }
    }
}
