using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;


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
            string connectionString = "Data Source = DESKTOP-F7UNBMT\\SQLEXPRESS01; Initial Catalog = library; Integrated Security = True;";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "SELECT COUNT(*) FROM Login WHERE UserName=@username AND Password=@password";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", txtUser.Text);
            cmd.Parameters.AddWithValue("@password", txtPsswrd.Text);

            int count = (int)cmd.ExecuteScalar();
            con.Close();

            if (count > 0)
            {

                //MessageBox.Show("Login Successful", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form2 abs = new Form2();
                abs.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
    }
}