namespace Library_Management_System
{
    partial class Form7
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
            panel1 = new Panel();
            label6 = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(label6);
            panel1.Location = new Point(-4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1055, 125);
            panel1.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Heading", 22.2F, FontStyle.Bold);
            label6.Location = new Point(414, 37);
            label6.Name = "label6";
            label6.Size = new Size(216, 53);
            label6.TabIndex = 0;
            label6.Text = "Issue Books";
            label6.Click += label6_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Location = new Point(487, 129);
            panel3.Name = "panel3";
            panel3.Size = new Size(560, 460);
            panel3.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Aquamarine;
            panel2.Font = new Font("Garamond", 10.2F, FontStyle.Bold);
            panel2.Location = new Point(-4, 126);
            panel2.Name = "panel2";
            panel2.Size = new Size(489, 469);
            panel2.TabIndex = 4;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 598);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "Form7";
            Text = "Form7";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Panel panel3;
        private Panel panel2;
    }
}