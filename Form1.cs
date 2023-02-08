using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Hangman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public static int choice = 0;
        private void nlvl_1_Click(object sender, EventArgs e)
        {
            choice = 1;
            GAME form = new GAME();
            form.Show();
            this.Hide();
        }

        private void nlvl_2_Click(object sender, EventArgs e)
        {
            choice = 2;
            GAME form = new GAME();
            form.Show();
            this.Hide();
        }

        private void nlvl_3_Click(object sender, EventArgs e)
        {
            choice = 3;
            GAME form = new GAME();
            form.Show();
            this.Hide();
        }

    }
}
