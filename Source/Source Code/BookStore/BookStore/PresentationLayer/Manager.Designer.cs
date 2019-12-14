namespace BookStore.PresentationLayer
{
    partial class Manager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.button10 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRe = new System.Windows.Forms.Button();
            this.btnCoupons = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSup = new System.Windows.Forms.Button();
            this.btnAcc = new System.Windows.Forms.Button();
            this.btnEmp = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(109)))));
            this.panel3.Controls.Add(this.labelTime);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox6);
            this.panel3.Controls.Add(this.button10);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1069, 53);
            this.panel3.TabIndex = 3;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(826, 20);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(161, 32);
            this.labelTime.TabIndex = 16;
            this.labelTime.Text = "HH:MM:SS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(78, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 38);
            this.label1.TabIndex = 15;
            this.label1.Text = "Manager Dashboard";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(12, 9);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(44, 38);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 14;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Right;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.Location = new System.Drawing.Point(1019, 0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(50, 53);
            this.button10.TabIndex = 12;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(109)))));
            this.panel1.Controls.Add(this.btnRe);
            this.panel1.Controls.Add(this.btnCoupons);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnSup);
            this.panel1.Controls.Add(this.btnAcc);
            this.panel1.Controls.Add(this.btnEmp);
            this.panel1.Controls.Add(this.btnB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 599);
            this.panel1.TabIndex = 4;
            // 
            // btnRe
            // 
            this.btnRe.BackColor = System.Drawing.Color.Transparent;
            this.btnRe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRe.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRe.Image = ((System.Drawing.Image)(resources.GetObject("btnRe.Image")));
            this.btnRe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRe.Location = new System.Drawing.Point(0, 497);
            this.btnRe.Name = "btnRe";
            this.btnRe.Size = new System.Drawing.Size(188, 56);
            this.btnRe.TabIndex = 8;
            this.btnRe.Text = "     Revenue";
            this.btnRe.UseVisualStyleBackColor = false;
            this.btnRe.Click += new System.EventHandler(this.btnRe_Click);
            // 
            // btnCoupons
            // 
            this.btnCoupons.BackColor = System.Drawing.Color.Transparent;
            this.btnCoupons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoupons.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoupons.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCoupons.Image = ((System.Drawing.Image)(resources.GetObject("btnCoupons.Image")));
            this.btnCoupons.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCoupons.Location = new System.Drawing.Point(0, 422);
            this.btnCoupons.Name = "btnCoupons";
            this.btnCoupons.Size = new System.Drawing.Size(188, 56);
            this.btnCoupons.TabIndex = 7;
            this.btnCoupons.Text = "     Coupons";
            this.btnCoupons.UseVisualStyleBackColor = false;
            this.btnCoupons.Click += new System.EventHandler(this.btnCoupons_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 52);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(188, 56);
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "        Home page";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnSup
            // 
            this.btnSup.BackColor = System.Drawing.Color.Transparent;
            this.btnSup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSup.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSup.Image = ((System.Drawing.Image)(resources.GetObject("btnSup.Image")));
            this.btnSup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSup.Location = new System.Drawing.Point(0, 196);
            this.btnSup.Name = "btnSup";
            this.btnSup.Size = new System.Drawing.Size(188, 56);
            this.btnSup.TabIndex = 4;
            this.btnSup.Text = "       Suppliers";
            this.btnSup.UseVisualStyleBackColor = false;
            this.btnSup.Click += new System.EventHandler(this.btnSup_Click);
            // 
            // btnAcc
            // 
            this.btnAcc.BackColor = System.Drawing.Color.Transparent;
            this.btnAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcc.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAcc.Image = ((System.Drawing.Image)(resources.GetObject("btnAcc.Image")));
            this.btnAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcc.Location = new System.Drawing.Point(0, 347);
            this.btnAcc.Name = "btnAcc";
            this.btnAcc.Size = new System.Drawing.Size(188, 56);
            this.btnAcc.TabIndex = 3;
            this.btnAcc.Text = "       Account settings";
            this.btnAcc.UseVisualStyleBackColor = false;
            this.btnAcc.Click += new System.EventHandler(this.btnAcc_Click);
            // 
            // btnEmp
            // 
            this.btnEmp.BackColor = System.Drawing.Color.Transparent;
            this.btnEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmp.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEmp.Image = ((System.Drawing.Image)(resources.GetObject("btnEmp.Image")));
            this.btnEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmp.Location = new System.Drawing.Point(0, 269);
            this.btnEmp.Name = "btnEmp";
            this.btnEmp.Size = new System.Drawing.Size(188, 56);
            this.btnEmp.TabIndex = 1;
            this.btnEmp.Text = "      Personnels";
            this.btnEmp.UseVisualStyleBackColor = false;
            this.btnEmp.Click += new System.EventHandler(this.btnEmp_Click);
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.Color.Transparent;
            this.btnB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnB.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnB.Image = ((System.Drawing.Image)(resources.GetObject("btnB.Image")));
            this.btnB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnB.Location = new System.Drawing.Point(0, 123);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(188, 56);
            this.btnB.TabIndex = 0;
            this.btnB.Text = "     Books";
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(80)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(188, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(881, 599);
            this.panel2.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Manager
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1069, 652);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manager";
            this.Text = "ManagerDashboard";
            this.Load += new System.EventHandler(this.ManagerDashboard_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSup;
        private System.Windows.Forms.Button btnAcc;
        private System.Windows.Forms.Button btnEmp;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnCoupons;
        private System.Windows.Forms.Button btnRe;
    }
}