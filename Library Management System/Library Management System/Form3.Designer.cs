namespace Library_Management_System
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label7 = new Label();
            panel2 = new Panel();
            bName = new Label();
            label2 = new Label();
            publication = new Label();
            pdate = new Label();
            bPrice = new Label();
            bQty = new Label();
            bookName = new TextBox();
            athrName = new TextBox();
            pblicton = new TextBox();
            txtPrice = new TextBox();
            txtQty = new TextBox();
            phrseDate = new DateTimePicker();
            btnSave = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 75);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(396, 376);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cornsilk;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(2, 1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(915, 75);
            panel1.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Heading", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(332, 24);
            label7.Name = "label7";
            label7.Size = new Size(162, 43);
            label7.TabIndex = 3;
            label7.Text = "ADD BOOK";
            // 
            // panel2
            // 
            panel2.Location = new Point(392, 74);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(523, 374);
            panel2.TabIndex = 2;
            // 
            // bName
            // 
            bName.AutoSize = true;
            bName.Font = new Font("Dubai Medium", 10.2F, FontStyle.Bold);
            bName.Location = new Point(437, 104);
            bName.Name = "bName";
            bName.Size = new Size(82, 24);
            bName.TabIndex = 2;
            bName.Text = "BookName";
            bName.Click += bName_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Dubai Medium", 10.2F, FontStyle.Bold);
            label2.Location = new Point(437, 146);
            label2.Name = "label2";
            label2.Size = new Size(110, 24);
            label2.TabIndex = 3;
            label2.Text = "Author's Name";
            label2.Click += label2_Click;
            // 
            // publication
            // 
            publication.AutoSize = true;
            publication.Font = new Font("Dubai Medium", 10.2F, FontStyle.Bold);
            publication.Location = new Point(437, 190);
            publication.Name = "publication";
            publication.Size = new Size(121, 24);
            publication.TabIndex = 4;
            publication.Text = "Book Publication";
            // 
            // pdate
            // 
            pdate.AutoSize = true;
            pdate.Font = new Font("Dubai Medium", 10.2F, FontStyle.Bold);
            pdate.Location = new Point(437, 232);
            pdate.Name = "pdate";
            pdate.Size = new Size(148, 24);
            pdate.TabIndex = 5;
            pdate.Text = "Book Purchase Date ";
            // 
            // bPrice
            // 
            bPrice.AutoSize = true;
            bPrice.Font = new Font("Dubai Medium", 10.2F, FontStyle.Bold);
            bPrice.Location = new Point(437, 287);
            bPrice.Name = "bPrice";
            bPrice.Size = new Size(85, 24);
            bPrice.TabIndex = 6;
            bPrice.Text = "Book Price ";
            // 
            // bQty
            // 
            bQty.AutoSize = true;
            bQty.Font = new Font("Dubai Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bQty.Location = new Point(437, 337);
            bQty.Name = "bQty";
            bQty.Size = new Size(105, 24);
            bQty.TabIndex = 7;
            bQty.Text = "Book Quantity";
            // 
            // bookName
            // 
            bookName.Location = new Point(648, 104);
            bookName.Margin = new Padding(3, 2, 3, 2);
            bookName.Name = "bookName";
            bookName.Size = new Size(219, 23);
            bookName.TabIndex = 8;
            // 
            // athrName
            // 
            athrName.Location = new Point(648, 146);
            athrName.Margin = new Padding(3, 2, 3, 2);
            athrName.Name = "athrName";
            athrName.Size = new Size(219, 23);
            athrName.TabIndex = 9;
            athrName.TextChanged += athrName_TextChanged;
            // 
            // pblicton
            // 
            pblicton.Location = new Point(648, 182);
            pblicton.Margin = new Padding(3, 2, 3, 2);
            pblicton.Name = "pblicton";
            pblicton.Size = new Size(219, 23);
            pblicton.TabIndex = 10;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(648, 287);
            txtPrice.Margin = new Padding(3, 2, 3, 2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(219, 23);
            txtPrice.TabIndex = 12;
            // 
            // txtQty
            // 
            txtQty.Location = new Point(648, 337);
            txtQty.Margin = new Padding(3, 2, 3, 2);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(219, 23);
            txtQty.TabIndex = 13;
            // 
            // phrseDate
            // 
            phrseDate.Location = new Point(648, 230);
            phrseDate.Margin = new Padding(3, 2, 3, 2);
            phrseDate.Name = "phrseDate";
            phrseDate.Size = new Size(219, 23);
            phrseDate.TabIndex = 14;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Location = new Point(545, 396);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 22);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += button1_Click;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Location = new Point(698, 396);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(82, 22);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(915, 448);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(phrseDate);
            Controls.Add(txtQty);
            Controls.Add(txtPrice);
            Controls.Add(pblicton);
            Controls.Add(athrName);
            Controls.Add(bookName);
            Controls.Add(bQty);
            Controls.Add(bPrice);
            Controls.Add(pdate);
            Controls.Add(publication);
            Controls.Add(label2);
            Controls.Add(bName);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form3";
            Text = "AddBook";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Label bName;
        private Label label2;
        private Label publication;
        private Label pdate;
        private Label bPrice;
        private Label bQty;
        private TextBox bookName;
        private TextBox athrName;
        private TextBox pblicton;
        private TextBox txtPrice;
        private TextBox txtQty;
        private DateTimePicker phrseDate;
        private Label label7;
        private Button btnSave;
        private Button btnCancel;
    }
}