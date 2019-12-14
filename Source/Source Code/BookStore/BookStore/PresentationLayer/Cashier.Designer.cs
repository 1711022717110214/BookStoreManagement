namespace BookStore.PresentationLayer
{
    partial class Cashier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cashier));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSR = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.btnAcc = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(188, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(895, 650);
            this.panel2.TabIndex = 9;
            this.panel2.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.panel2_ControlAdded);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Cashier_MouseDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(80)))));
            this.panel3.Controls.Add(this.labelTime);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox6);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1083, 53);
            this.panel3.TabIndex = 10;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Cashier_MouseDown);
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelTime.Location = new System.Drawing.Point(848, 20);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(161, 32);
            this.labelTime.TabIndex = 16;
            this.labelTime.Text = "HH:MM:SS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(78, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 38);
            this.label1.TabIndex = 15;
            this.label1.Text = "Cashier Dashboard";
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
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(1033, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 53);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.btnSR);
            this.panel1.Controls.Add(this.btnM);
            this.panel1.Controls.Add(this.btnAcc);
            this.panel1.Controls.Add(this.btnP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 650);
            this.panel1.TabIndex = 11;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Cashier_MouseDown);
            // 
            // btnSR
            // 
            this.btnSR.BackColor = System.Drawing.Color.Transparent;
            this.btnSR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSR.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSR.Image = ((System.Drawing.Image)(resources.GetObject("btnSR.Image")));
            this.btnSR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSR.Location = new System.Drawing.Point(0, 107);
            this.btnSR.Name = "btnSR";
            this.btnSR.Size = new System.Drawing.Size(188, 56);
            this.btnSR.TabIndex = 5;
            this.btnSR.Text = "       Sales register";
            this.btnSR.UseVisualStyleBackColor = false;
            this.btnSR.Click += new System.EventHandler(this.btnSR_Click);
            // 
            // btnM
            // 
            this.btnM.BackColor = System.Drawing.Color.Transparent;
            this.btnM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnM.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnM.Image = ((System.Drawing.Image)(resources.GetObject("btnM.Image")));
            this.btnM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnM.Location = new System.Drawing.Point(0, 263);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(188, 56);
            this.btnM.TabIndex = 4;
            this.btnM.Text = "       Members";
            this.btnM.UseVisualStyleBackColor = false;
            this.btnM.Click += new System.EventHandler(this.btnM_Click);
            // 
            // btnAcc
            // 
            this.btnAcc.BackColor = System.Drawing.Color.Transparent;
            this.btnAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcc.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAcc.Image = ((System.Drawing.Image)(resources.GetObject("btnAcc.Image")));
            this.btnAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcc.Location = new System.Drawing.Point(0, 345);
            this.btnAcc.Name = "btnAcc";
            this.btnAcc.Size = new System.Drawing.Size(188, 56);
            this.btnAcc.TabIndex = 3;
            this.btnAcc.Text = "       Account settings";
            this.btnAcc.UseVisualStyleBackColor = false;
            this.btnAcc.Click += new System.EventHandler(this.btnAcc_Click);
            // 
            // btnP
            // 
            this.btnP.BackColor = System.Drawing.Color.Transparent;
            this.btnP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnP.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnP.Image = ((System.Drawing.Image)(resources.GetObject("btnP.Image")));
            this.btnP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnP.Location = new System.Drawing.Point(0, 185);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(188, 56);
            this.btnP.TabIndex = 0;
            this.btnP.Text = "     Purchases";
            this.btnP.UseVisualStyleBackColor = false;
            this.btnP.Click += new System.EventHandler(this.btnP_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Cashier
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(1083, 703);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cashier";
            this.Text = "Cashier";
            this.Load += new System.EventHandler(this.Cashier_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Cashier_MouseDown);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSR;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Button btnAcc;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Timer timer1;
    }
}