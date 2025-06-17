using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bName_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bookName.Text != "" && athrName.Text != "" && pblicton.Text != "" && txtPrice.Text != "" && txtQty.Text != "")
            {

                String bname = bookName.Text;
                String bAuthor = athrName.Text;
                String publication = pblicton.Text;
                String pdate = phrseDate.Text;
                Int64 bPrice = Int64.Parse(txtPrice.Text);
                Int64 bQty = Int64.Parse(txtQty.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=DESKTOP-F7UNBMT\\SQLEXPRESS01; database = library; integrated security = true";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into NewBook (bName,bAuthor,bPubl,bPDate,bPrice,bQuan) values('" + bName + "','" + bAuthor + "', '" + publication + "', '" + pdate + "', " + bPrice + ", " + bQty + ")";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data Saved,", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                bookName.Clear();
                athrName.Clear();
                pblicton.Clear();
                txtPrice.Clear();
                txtQty.Clear();
            }
            else
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void athrName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        { if(MessageBox.Show("Are you sure you want to cancel?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
           
           
        }
    }
}
