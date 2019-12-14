namespace BookStore.PresentationLayer
{
    partial class Books
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Books));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shelf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEditB = new System.Windows.Forms.Button();
            this.btnNewB = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(109)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(111)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.image,
            this.author,
            this.sup,
            this.language,
            this.area,
            this.category,
            this.shelf,
            this.ori,
            this.sale,
            this.code,
            this.stock,
            this.pur});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(22, 103);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(834, 400);
            this.dataGridView1.TabIndex = 81;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.Width = 150;
            // 
            // name
            // 
            this.name.HeaderText = "Title";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            this.name.Width = 150;
            // 
            // image
            // 
            this.image.HeaderText = "Image";
            this.image.MinimumWidth = 8;
            this.image.Name = "image";
            this.image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.image.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.image.Width = 150;
            // 
            // author
            // 
            this.author.HeaderText = "Author";
            this.author.MinimumWidth = 8;
            this.author.Name = "author";
            this.author.Visible = false;
            this.author.Width = 150;
            // 
            // sup
            // 
            this.sup.HeaderText = "Supplier";
            this.sup.MinimumWidth = 8;
            this.sup.Name = "sup";
            this.sup.Visible = false;
            this.sup.Width = 150;
            // 
            // language
            // 
            this.language.HeaderText = "Language";
            this.language.MinimumWidth = 8;
            this.language.Name = "language";
            this.language.Visible = false;
            this.language.Width = 150;
            // 
            // area
            // 
            this.area.HeaderText = "Area";
            this.area.MinimumWidth = 8;
            this.area.Name = "area";
            this.area.Visible = false;
            this.area.Width = 150;
            // 
            // category
            // 
            this.category.HeaderText = "Category";
            this.category.MinimumWidth = 8;
            this.category.Name = "category";
            this.category.Visible = false;
            this.category.Width = 150;
            // 
            // shelf
            // 
            this.shelf.HeaderText = "Shelf";
            this.shelf.MinimumWidth = 8;
            this.shelf.Name = "shelf";
            this.shelf.Visible = false;
            this.shelf.Width = 150;
            // 
            // ori
            // 
            this.ori.HeaderText = "Original Price";
            this.ori.MinimumWidth = 8;
            this.ori.Name = "ori";
            this.ori.Visible = false;
            this.ori.Width = 150;
            // 
            // sale
            // 
            this.sale.HeaderText = "Sale Price";
            this.sale.MinimumWidth = 8;
            this.sale.Name = "sale";
            this.sale.Width = 150;
            // 
            // code
            // 
            this.code.HeaderText = "Coupon";
            this.code.MinimumWidth = 8;
            this.code.Name = "code";
            this.code.Width = 150;
            // 
            // stock
            // 
            this.stock.HeaderText = "Stock";
            this.stock.MinimumWidth = 8;
            this.stock.Name = "stock";
            this.stock.Visible = false;
            this.stock.Width = 150;
            // 
            // pur
            // 
            this.pur.HeaderText = "Purchase";
            this.pur.MinimumWidth = 8;
            this.pur.Name = "pur";
            this.pur.Visible = false;
            this.pur.Width = 150;
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(80)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(401, 38);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(420, 23);
            this.txtSearch.TabIndex = 82;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(401, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 1);
            this.panel1.TabIndex = 83;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(831, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 84;
            this.pictureBox1.TabStop = false;
            // 
            // btnEditB
            // 
            this.btnEditB.BackColor = System.Drawing.Color.Transparent;
            this.btnEditB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditB.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditB.ForeColor = System.Drawing.Color.White;
            this.btnEditB.Image = ((System.Drawing.Image)(resources.GetObject("btnEditB.Image")));
            this.btnEditB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditB.Location = new System.Drawing.Point(22, 532);
            this.btnEditB.Name = "btnEditB";
            this.btnEditB.Size = new System.Drawing.Size(121, 46);
            this.btnEditB.TabIndex = 85;
            this.btnEditB.Text = "Update book";
            this.btnEditB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditB.UseVisualStyleBackColor = false;
            this.btnEditB.Click += new System.EventHandler(this.btnEditB_Click);
            // 
            // btnNewB
            // 
            this.btnNewB.BackColor = System.Drawing.Color.Transparent;
            this.btnNewB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewB.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewB.ForeColor = System.Drawing.Color.White;
            this.btnNewB.Image = ((System.Drawing.Image)(resources.GetObject("btnNewB.Image")));
            this.btnNewB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewB.Location = new System.Drawing.Point(190, 532);
            this.btnNewB.Name = "btnNewB";
            this.btnNewB.Size = new System.Drawing.Size(121, 46);
            this.btnNewB.TabIndex = 86;
            this.btnNewB.Text = "New book";
            this.btnNewB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewB.UseVisualStyleBackColor = false;
            this.btnNewB.Click += new System.EventHandler(this.btnNewB_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(360, 532);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 46);
            this.button1.TabIndex = 87;
            this.button1.Text = "Reload";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Books
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(881, 599);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNewB);
            this.Controls.Add(this.btnEditB);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Books";
            this.Text = "Books";
            this.Load += new System.EventHandler(this.Books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewImageColumn image;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn sup;
        private System.Windows.Forms.DataGridViewTextBoxColumn language;
        private System.Windows.Forms.DataGridViewTextBoxColumn area;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn shelf;
        private System.Windows.Forms.DataGridViewTextBoxColumn ori;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn pur;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEditB;
        private System.Windows.Forms.Button btnNewB;
        private System.Windows.Forms.Button button1;
    }
}