namespace Library_Management_System
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            menuStrip1 = new MenuStrip();
            booksToolStripMenuItem = new ToolStripMenuItem();
            addNewBookToolStripMenuItem = new ToolStripMenuItem();
            addAToolStripMenuItem = new ToolStripMenuItem();
            studentToolStripMenuItem = new ToolStripMenuItem();
            addNewStudentToolStripMenuItem = new ToolStripMenuItem();
            viewStudentInfoToolStripMenuItem = new ToolStripMenuItem();
            issueBooksToolStripMenuItem = new ToolStripMenuItem();
            returnBooksToolStripMenuItem = new ToolStripMenuItem();
            completeBookDetailsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(255, 224, 192);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { booksToolStripMenuItem, studentToolStripMenuItem, issueBooksToolStripMenuItem, returnBooksToolStripMenuItem, completeBookDetailsToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1244, 108);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // booksToolStripMenuItem
            // 
            booksToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewBookToolStripMenuItem, addAToolStripMenuItem });
            booksToolStripMenuItem.Image = (Image)resources.GetObject("booksToolStripMenuItem.Image");
            booksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            booksToolStripMenuItem.Size = new Size(113, 104);
            booksToolStripMenuItem.Text = "Books";
            // 
            // addNewBookToolStripMenuItem
            // 
            addNewBookToolStripMenuItem.Image = (Image)resources.GetObject("addNewBookToolStripMenuItem.Image");
            addNewBookToolStripMenuItem.Name = "addNewBookToolStripMenuItem";
            addNewBookToolStripMenuItem.Size = new Size(224, 26);
            addNewBookToolStripMenuItem.Text = "View Books";
            addNewBookToolStripMenuItem.Click += addNewBookToolStripMenuItem_Click;
            // 
            // addAToolStripMenuItem
            // 
            addAToolStripMenuItem.Image = (Image)resources.GetObject("addAToolStripMenuItem.Image");
            addAToolStripMenuItem.Name = "addAToolStripMenuItem";
            addAToolStripMenuItem.Size = new Size(224, 26);
            addAToolStripMenuItem.Text = "Add a Book";
            addAToolStripMenuItem.Click += addAToolStripMenuItem_Click;
            // 
            // studentToolStripMenuItem
            // 
            studentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewStudentToolStripMenuItem, viewStudentInfoToolStripMenuItem });
            studentToolStripMenuItem.Image = (Image)resources.GetObject("studentToolStripMenuItem.Image");
            studentToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            studentToolStripMenuItem.Size = new Size(174, 104);
            studentToolStripMenuItem.Text = "Student";
            // 
            // addNewStudentToolStripMenuItem
            // 
            addNewStudentToolStripMenuItem.Image = (Image)resources.GetObject("addNewStudentToolStripMenuItem.Image");
            addNewStudentToolStripMenuItem.Name = "addNewStudentToolStripMenuItem";
            addNewStudentToolStripMenuItem.Size = new Size(209, 26);
            addNewStudentToolStripMenuItem.Text = "Add new Student";
            // 
            // viewStudentInfoToolStripMenuItem
            // 
            viewStudentInfoToolStripMenuItem.Image = (Image)resources.GetObject("viewStudentInfoToolStripMenuItem.Image");
            viewStudentInfoToolStripMenuItem.Name = "viewStudentInfoToolStripMenuItem";
            viewStudentInfoToolStripMenuItem.Size = new Size(209, 26);
            viewStudentInfoToolStripMenuItem.Text = "View Student Info";
            // 
            // issueBooksToolStripMenuItem
            // 
            issueBooksToolStripMenuItem.Image = (Image)resources.GetObject("issueBooksToolStripMenuItem.Image");
            issueBooksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            issueBooksToolStripMenuItem.Name = "issueBooksToolStripMenuItem";
            issueBooksToolStripMenuItem.Size = new Size(149, 104);
            issueBooksToolStripMenuItem.Text = "Issue Books";
            // 
            // returnBooksToolStripMenuItem
            // 
            returnBooksToolStripMenuItem.Image = (Image)resources.GetObject("returnBooksToolStripMenuItem.Image");
            returnBooksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            returnBooksToolStripMenuItem.Name = "returnBooksToolStripMenuItem";
            returnBooksToolStripMenuItem.Size = new Size(174, 104);
            returnBooksToolStripMenuItem.Text = "Return Books";
            // 
            // completeBookDetailsToolStripMenuItem
            // 
            completeBookDetailsToolStripMenuItem.Image = (Image)resources.GetObject("completeBookDetailsToolStripMenuItem.Image");
            completeBookDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            completeBookDetailsToolStripMenuItem.Name = "completeBookDetailsToolStripMenuItem";
            completeBookDetailsToolStripMenuItem.Size = new Size(226, 104);
            completeBookDetailsToolStripMenuItem.Text = "Complete Book Details";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Image = (Image)resources.GetObject("exitToolStripMenuItem.Image");
            exitToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(97, 104);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1244, 620);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            Text = "DashBoard";
            WindowState = FormWindowState.Maximized;
            Load += Form2_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem booksToolStripMenuItem;
        private ToolStripMenuItem addNewBookToolStripMenuItem;
        private ToolStripMenuItem studentToolStripMenuItem;
        private ToolStripMenuItem addNewStudentToolStripMenuItem;
        private ToolStripMenuItem viewStudentInfoToolStripMenuItem;
        private ToolStripMenuItem issueBooksToolStripMenuItem;
        private ToolStripMenuItem returnBooksToolStripMenuItem;
        private ToolStripMenuItem completeBookDetailsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem addAToolStripMenuItem;
    }
}