using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 abs = new Form3();
            abs.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 abs = new Form4();
            abs.Show();
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 abs = new Form5();
            abs.Show();
        }

        private void viewStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 abs = new Form6();
            abs.Show();
        }
    }
}
