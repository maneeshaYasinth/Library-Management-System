namespace Library_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void txtUser_MouseEnter(object sender, EventArgs e)
        {
            if (txtUser.Text == "  Username")
            {
                txtUser.Clear();
            }
        }

        private void txtPsswrd_MouseEnter(object sender, EventArgs e)
        {
            if (txtPsswrd.Text == "   Password")
            {
                txtPsswrd.Clear();
            }
        }
    }
}