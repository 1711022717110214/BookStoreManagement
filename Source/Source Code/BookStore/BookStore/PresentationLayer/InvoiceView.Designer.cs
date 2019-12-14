namespace BookStore.PresentationLayer
{
    partial class InvoiceView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblSoL = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTen.Location = new System.Drawing.Point(162, 15);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(69, 25);
            this.lblTen.TabIndex = 1;
            this.lblTen.Text = "Title: ";
            // 
            // lblSoL
            // 
            this.lblSoL.AutoSize = true;
            this.lblSoL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSoL.Location = new System.Drawing.Point(163, 63);
            this.lblSoL.Name = "lblSoL";
            this.lblSoL.Size = new System.Drawing.Size(80, 20);
            this.lblSoL.TabIndex = 2;
            this.lblSoL.Text = "Quantity: ";
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDonGia.Location = new System.Drawing.Point(163, 102);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(89, 20);
            this.lblDonGia.TabIndex = 3;
            this.lblDonGia.Text = "Unit price: ";
            // 
            // InvoiceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(80)))));
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.lblSoL);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "InvoiceView";
            this.Size = new System.Drawing.Size(540, 133);
            this.Load += new System.EventHandler(this.InvoiceView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblSoL;
        private System.Windows.Forms.Label lblDonGia;
    }
}
