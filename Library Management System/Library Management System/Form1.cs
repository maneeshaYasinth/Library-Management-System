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

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUser.Text == "Username")
            {
                txtUser.Clear();
            }
        }

        private void txtPsswrd_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPsswrd.Text == "Password")
            {
                txtPsswrd.Clear(); 
                txtPsswrd.PasswordChar = '*';
            }
        }
    }
}