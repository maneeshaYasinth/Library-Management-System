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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            bookName = new TextBox();
            athrName = new TextBox();
            pblicton = new TextBox();
            txtPrice = new TextBox();
            txtQtty = new TextBox();
            phrseDate = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(452, 501);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cornsilk;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1046, 100);
            panel1.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Heading", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(380, 32);
            label7.Name = "label7";
            label7.Size = new Size(203, 53);
            label7.TabIndex = 3;
            label7.Text = "ADD BOOK";
            // 
            // panel2
            // 
            panel2.Location = new Point(448, 99);
            panel2.Name = "panel2";
            panel2.Size = new Size(598, 498);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Dubai Medium", 10.2F, FontStyle.Bold);
            label1.Location = new Point(499, 139);
            label1.Name = "label1";
            label1.Size = new Size(103, 29);
            label1.TabIndex = 2;
            label1.Text = "Book Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Dubai Medium", 10.2F, FontStyle.Bold);
            label2.Location = new Point(499, 194);
            label2.Name = "label2";
            label2.Size = new Size(132, 29);
            label2.TabIndex = 3;
            label2.Text = "Author's Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Dubai Medium", 10.2F, FontStyle.Bold);
            label3.Location = new Point(499, 253);
            label3.Name = "label3";
            label3.Size = new Size(148, 29);
            label3.TabIndex = 4;
            label3.Text = "Book Publication";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Dubai Medium", 10.2F, FontStyle.Bold);
            label4.Location = new Point(499, 309);
            label4.Name = "label4";
            label4.Size = new Size(177, 29);
            label4.TabIndex = 5;
            label4.Text = "Book Purchase Date ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Dubai Medium", 10.2F, FontStyle.Bold);
            label5.Location = new Point(499, 383);
            label5.Name = "label5";
            label5.Size = new Size(103, 29);
            label5.TabIndex = 6;
            label5.Text = "Book Price ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Dubai Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(499, 449);
            label6.Name = "label6";
            label6.Size = new Size(128, 29);
            label6.TabIndex = 7;
            label6.Text = "Book Quantity";
            // 
            // bookName
            // 
            bookName.Location = new Point(740, 139);
            bookName.Name = "bookName";
            bookName.Size = new Size(250, 27);
            bookName.TabIndex = 8;
            // 
            // athrName
            // 
            athrName.Location = new Point(740, 194);
            athrName.Name = "athrName";
            athrName.Size = new Size(250, 27);
            athrName.TabIndex = 9;
            // 
            // pblicton
            // 
            pblicton.Location = new Point(740, 243);
            pblicton.Name = "pblicton";
            pblicton.Size = new Size(250, 27);
            pblicton.TabIndex = 10;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(740, 383);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(250, 27);
            txtPrice.TabIndex = 12;
            // 
            // txtQtty
            // 
            txtQtty.Location = new Point(740, 449);
            txtQtty.Name = "txtQtty";
            txtQtty.Size = new Size(250, 27);
            txtQtty.TabIndex = 13;
            // 
            // phrseDate
            // 
            phrseDate.Location = new Point(740, 307);
            phrseDate.Name = "phrseDate";
            phrseDate.Size = new Size(250, 27);
            phrseDate.TabIndex = 14;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(623, 528);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 15;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(798, 528);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 16;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(1046, 598);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(phrseDate);
            Controls.Add(txtQtty);
            Controls.Add(txtPrice);
            Controls.Add(pblicton);
            Controls.Add(athrName);
            Controls.Add(bookName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox bookName;
        private TextBox athrName;
        private TextBox pblicton;
        private TextBox txtPrice;
        private TextBox txtQtty;
        private DateTimePicker phrseDate;
        private Label label7;
        private Button button1;
        private Button button2;
    }
}