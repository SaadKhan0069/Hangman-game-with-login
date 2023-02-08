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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT username,password FROM tbl_users WHERE username = '" + username.Text+"'and password='"+password.Text+"'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if(dr.Read()==true)
            {
                //Replace this entire section with-in the curly brackets with the hangman game code.
                //I am only adding a blank form in this place to give an idea as to how to implement hangman
                //game in this login and registration system.
                Project_Hangman.Form1 Form=new Project_Hangman.Form1();
                Form.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Incorrect username or password.Re-enter the credentials","Login unsucessful",MessageBoxButtons.OK, MessageBoxIcon.Error);
                username.Text = "";
                password.Text = "";
                username.Focus();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            username.Text = "";
            password.Text = "";
            username.Focus();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                password.PasswordChar = '\0';
           
            }
            else
            {
                password.PasswordChar = '*';
                
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new Registration().Show();
            this.Hide();
        }
    }
}
