namespace Library_Management_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            txtUser = new TextBox();
            txtPsswrd = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            btnLog = new Button();
            btnSignup = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(147, 29);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(83, 173);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.InitialImage = (Image)resources.GetObject("pictureBox3.InitialImage");
            pictureBox3.Location = new Point(83, 218);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 26);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.RoyalBlue;
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Font = new Font("Sitka Subheading", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUser.Location = new Point(147, 178);
            txtUser.Margin = new Padding(3, 2, 3, 2);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(158, 18);
            txtUser.TabIndex = 3;
            txtUser.Text = "  Username";
            txtUser.MouseClick += txtUser_MouseClick;
            txtUser.TextChanged += txtUser_TextChanged;
            txtUser.MouseEnter += txtUser_MouseEnter;
            // 
            // txtPsswrd
            // 
            txtPsswrd.BackColor = Color.RoyalBlue;
            txtPsswrd.BorderStyle = BorderStyle.None;
            txtPsswrd.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPsswrd.Location = new Point(147, 225);
            txtPsswrd.Margin = new Padding(3, 2, 3, 2);
            txtPsswrd.Name = "txtPsswrd";
            txtPsswrd.Size = new Size(158, 19);
            txtPsswrd.TabIndex = 4;
            txtPsswrd.Text = "   Password";
            txtPsswrd.MouseClick += txtPsswrd_MouseClick;
            txtPsswrd.MouseEnter += txtPsswrd_MouseEnter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(147, 195);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(158, 2);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(147, 242);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(158, 2);
            panel2.TabIndex = 6;
            // 
            // btnLog
            // 
            btnLog.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLog.Location = new Point(164, 268);
            btnLog.Margin = new Padding(3, 2, 3, 2);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(82, 22);
            btnLog.TabIndex = 7;
            btnLog.Text = "Login";
            btnLog.UseVisualStyleBackColor = true;
            // 
            // btnSignup
            // 
            btnSignup.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignup.Location = new Point(164, 311);
            btnSignup.Margin = new Padding(3, 2, 3, 2);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(82, 22);
            btnSignup.TabIndex = 8;
            btnSignup.Text = "Sign Up";
            btnSignup.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(414, 400);
            Controls.Add(btnSignup);
            Controls.Add(btnLog);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtPsswrd);
            Controls.Add(txtUser);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Library Management System";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox txtUser;
        private TextBox txtPsswrd;
        private Panel panel1;
        private Panel panel2;
        private Button btnLog;
        private Button btnSignup;
    }
}
