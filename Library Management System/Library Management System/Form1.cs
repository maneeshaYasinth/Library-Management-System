using System.Data;
using System.Data.SqlClient;

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

        private void btnLog_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-F7UNBMT\\SQLEXPRESS01 ; database=library;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from users where username = '" + txtUser.Text + "' and pass ='" + txtPsswrd.Text + "' ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                this.Hide();
                Form1 dsa = new Form1();
                dsa.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
