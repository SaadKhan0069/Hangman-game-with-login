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
    public partial class GAME : Form
    {
        int life = 5;
        int lvl = 0;
        int opt = 0;
        string lvl1 = "GHOUL";
        string lvl2 = "HUGEST";
        string lvl3 = "TRASHED";
        char c1, c2, c3, c4, c5, c6, c7;
        bool c1guess = false, c2guess = false, c3guess = false, c4guess = false, c5guess = false, c6guess = false, c7guess = false, won = false, lose = false;

        public GAME()
        {
            InitializeComponent();
            lvl = Form1.choice;
        }

        private void GAME_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Login_System.Properties.Resources._1;
            if (lvl == 1)
            {
                n6.Text = "";
                n7.Text = "";
            }
            if (lvl == 2)
            {
                n7.Text = "";
            }
        }

        private void nGuess_Click(object sender, EventArgs e)
        {
            comm.Text = "";
            switch (lvl)
            {
                case 1:
                    opt++;
                    c1 = lvl1[0];
                    c2 = lvl1[1];
                    c3 = lvl1[2];
                    c4 = lvl1[3];
                    c5 = lvl1[4];
                    break;

                case 2:
                    opt++;
                    c1 = lvl2[0];
                    c2 = lvl2[1];
                    c3 = lvl2[2];
                    c4 = lvl2[3];
                    c5 = lvl2[4];
                    c6 = lvl2[5];
                    break;

                case 3:
                    opt++;
                    c1 = lvl3[0];
                    c2 = lvl3[1];
                    c3 = lvl3[2];
                    c4 = lvl3[3];
                    c5 = lvl3[4];
                    c6 = lvl3[5];
                    c7 = lvl3[6];
                    break;
            }

            switch (lvl)
            {
                case 1:
                    if (textBox1.Text.Length > 1)
                    {
                        comm.Text = "Too large";
                    }
                    else
                    {
                        if (lvl1.Contains(textBox1.Text.ToUpper()))
                        {

                            if (textBox1.Text.ToUpper() == c1.ToString())
                            {
                                n1.Text = c1.ToString();
                                c1guess = true;

                            }
                            if (textBox1.Text.ToUpper() == c2.ToString())
                            {
                                c2guess = true;
                                n2.Text = c2.ToString();
                            }
                            if (textBox1.Text.ToUpper() == c3.ToString())
                            {
                                c3guess = true;
                                n3.Text = c3.ToString();
                            }
                            if (textBox1.Text.ToUpper() == c4.ToString())
                            {
                                c4guess = true;
                                n4.Text = c4.ToString();
                            }
                            if (textBox1.Text.ToUpper() == c5.ToString())
                            {
                                c5guess = true;
                                n5.Text = c5.ToString();
                            }
                            comm.Text = "Right Guess!";
                        }
                        else
                        {
                            life--;
                            comm.Text = "Wrong Guess!";
                            label3.Text = life.ToString();
                        }
                        switch (life)
                        {
                            case 5:
                                pictureBox1.Image = Login_System.Properties.Resources._1;
                                break;
                            case 4:
                                pictureBox1.Image = Login_System.Properties.Resources._2;
                                break;
                            case 3:
                                pictureBox1.Image = Login_System.Properties.Resources._3;
                                break;
                            case 2:
                                pictureBox1.Image = Login_System.Properties.Resources._4;
                                break;
                            case 1:
                                pictureBox1.Image = Login_System.Properties.Resources._5;
                                break;
                            case 0:
                                pictureBox1.Image = Login_System.Properties.Resources._6;
                                break;
                        }
                        if (c1guess && c2guess && c3guess && c4guess && c5guess && life != 0)
                        {
                            won = true;
                        }
                        else if (life == 0)
                        {
                            lose = true;
                        }
                        if (won)
                        {
                            MessageBox.Show("CONGRATULATIONS!!");
                        }
                        else if (lose)
                        {
                            MessageBox.Show("GAME OVER");
                        }
                    }
                    break;

                case 2:
                    if (textBox1.Text.Length > 1)
                    {
                        comm.Text = "Too large";
                    }
                    else
                    {
                        if (lvl2.Contains(textBox1.Text.ToUpper()))
                        {

                            if (textBox1.Text.ToUpper() == c1.ToString())
                            {
                                n1.Text = c1.ToString();
                                c1guess = true;

                            }
                            if (textBox1.Text.ToUpper() == c2.ToString())
                            {
                                c2guess = true;
                                n2.Text = c2.ToString();
                            }
                            if (textBox1.Text.ToUpper() == c3.ToString())
                            {
                                c3guess = true;
                                n3.Text = c3.ToString();
                            }
                            if (textBox1.Text.ToUpper() == c4.ToString())
                            {
                                c4guess = true;
                                n4.Text = c4.ToString();
                            }
                            if (textBox1.Text.ToUpper() == c5.ToString())
                            {
                                c5guess = true;
                                n5.Text = c5.ToString();
                            }
                            if (textBox1.Text.ToUpper() == c6.ToString())
                            {
                                c6guess = true;
                                n6.Text = c6.ToString();
                            }
                            if (textBox1.Text.ToUpper() == c7.ToString())
                            {
                                c7guess = true;
                                n7.Text = c7.ToString();
                            }
                            comm.Text = "Right Guess!";
                        }
                        else
                        {
                            life--;
                            comm.Text = "Wrong Guess!";
                            label3.Text = life.ToString();
                        }
                        switch (life)
                        {
                            case 5:
                                pictureBox1.Image = Login_System.Properties.Resources._1;
                                break;
                            case 4:
                                pictureBox1.Image = Login_System.Properties.Resources._2;
                                break;
                            case 3:
                                pictureBox1.Image = Login_System.Properties.Resources._3;
                                break;
                            case 2:
                                pictureBox1.Image = Login_System.Properties.Resources._4;
                                break;
                            case 1:
                                pictureBox1.Image = Login_System.Properties.Resources._5;
                                break;
                            case 0:
                                pictureBox1.Image = Login_System.Properties.Resources._6;
                                break;
                        }
                        if (c1guess && c2guess && c3guess && c4guess && c5guess && c6guess && life != 0)
                        {
                            won = true;
                        }
                        else if (life == 0)
                        {
                            lose = true;
                        }
                        if (won)
                        {
                            MessageBox.Show("CONGRATULATIONS!!");
                        }
                        else if (lose)
                        {
                            MessageBox.Show("GAME OVER");
                        }
                    }
                    break;

                case 3:
                    if (textBox1.Text.Length > 1)
                    {
                        comm.Text = "Too large";
                    }
                    else
                    {
                        if (lvl3.Contains(textBox1.Text.ToUpper()))
                        {

                            if (textBox1.Text.ToUpper() == c1.ToString())
                            {
                                n1.Text = c1.ToString();
                                c1guess = true;

                            }
                            if (textBox1.Text.ToUpper() == c2.ToString())
                            {
                                c2guess = true;
                                n2.Text = c2.ToString();
                            }
                            if (textBox1.Text.ToUpper() == c3.ToString())
                            {
                                c3guess = true;
                                n3.Text = c3.ToString();
                            }
                            if (textBox1.Text.ToUpper() == c4.ToString())
                            {
                                c4guess = true;
                                n4.Text = c4.ToString();
                            }
                            if (textBox1.Text.ToUpper() == c5.ToString())
                            {
                                c5guess = true;
                                n5.Text = c5.ToString();
                            }
                            if (textBox1.Text.ToUpper() == c6.ToString())
                            {
                                c6guess = true;
                                n6.Text = c6.ToString();
                            }
                            if (textBox1.Text.ToUpper() == c7.ToString())
                            {
                                c7guess = true;
                                n7.Text = c7.ToString();
                            }
                            comm.Text = "Right Guess!";
                        }
                        else
                        {
                            life--;
                            comm.Text = "Wrong Guess!";
                            label3.Text = life.ToString();
                        }
                        switch (life)
                        {
                            case 5:
                                pictureBox1.Image = Login_System.Properties.Resources._1;
                                break;
                            case 4:
                                pictureBox1.Image = Login_System.Properties.Resources._2;
                                break;
                            case 3:
                                pictureBox1.Image = Login_System.Properties.Resources._3;
                                break;
                            case 2:
                                pictureBox1.Image = Login_System.Properties.Resources._4;
                                break;
                            case 1:
                                pictureBox1.Image = Login_System.Properties.Resources._5;
                                break;
                            case 0:
                                pictureBox1.Image = Login_System.Properties.Resources._6;
                                break;
                        }
                        if (c1guess && c2guess && c3guess && c4guess && c5guess && c6guess && c7guess && life != 0)
                        {
                            won = true;
                        }
                        else if (life == 0)
                        {
                            lose = true;
                        }
                        if (won)
                        {
                            MessageBox.Show("CONGRATULATIONS!!");
                        }
                        else if (lose)
                        {
                            MessageBox.Show("GAME OVER");
                        }
                    }
                    break;

            }
            if (won || lose)
            {
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
        }

    }
}

