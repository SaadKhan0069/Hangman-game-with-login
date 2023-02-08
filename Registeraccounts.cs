using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Login_System
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            username.Text = "";
            password.Text = "";
            repeatedpassword.Text = "";
            username.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(username.Text == "" && password.Text == "" && repeatedpassword.Text == "")
            {
                MessageBox.Show("Username and password cannot be left blank!","Cannot register account!",MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (password.Text==repeatedpassword.Text)
            {
                con.Open();
                string register = "INSERT INTO tbl_users VALUES ('" + username.Text + "','" + password.Text + "')";
                cmd = new OleDbCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();
                username.Text = "";
                password.Text = "";
                repeatedpassword.Text = "";
                MessageBox.Show("Your account has been created.", "Registration Succesful.",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The passwords do not match.Enter password again.", "Cannot register account!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                password.Text = "";
                repeatedpassword.Text = "";
                password.Focus();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                password.PasswordChar = '\0';
                repeatedpassword.PasswordChar = '\0';
            }
            else
            {
                password.PasswordChar = '*';
                repeatedpassword.PasswordChar = '*';
            }
        }
    }
}
