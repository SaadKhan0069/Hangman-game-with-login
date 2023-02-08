namespace Project_Hangman
{
    partial class GAME
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.n1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nGuess = new System.Windows.Forms.Button();
            this.comm = new System.Windows.Forms.Label();
            this.n5 = new System.Windows.Forms.Label();
            this.n4 = new System.Windows.Forms.Label();
            this.n3 = new System.Windows.Forms.Label();
            this.n2 = new System.Windows.Forms.Label();
            this.n7 = new System.Windows.Forms.Label();
            this.n6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Guess a letter:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "LIFE = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "The word:";
            // 
            // n1
            // 
            this.n1.AutoSize = true;
            this.n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n1.Location = new System.Drawing.Point(188, 252);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(25, 31);
            this.n1.TabIndex = 4;
            this.n1.Text = "*";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(235, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 45);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nGuess
            // 
            this.nGuess.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nGuess.Location = new System.Drawing.Point(274, 91);
            this.nGuess.Name = "nGuess";
            this.nGuess.Size = new System.Drawing.Size(79, 32);
            this.nGuess.TabIndex = 6;
            this.nGuess.Text = "GUESS";
            this.nGuess.UseVisualStyleBackColor = true;
            this.nGuess.Click += new System.EventHandler(this.nGuess_Click);
            // 
            // comm
            // 
            this.comm.AutoSize = true;
            this.comm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comm.Location = new System.Drawing.Point(44, 91);
            this.comm.Name = "comm";
            this.comm.Size = new System.Drawing.Size(0, 24);
            this.comm.TabIndex = 7;
            // 
            // n5
            // 
            this.n5.AutoSize = true;
            this.n5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n5.Location = new System.Drawing.Point(312, 252);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(25, 31);
            this.n5.TabIndex = 9;
            this.n5.Text = "*";
            // 
            // n4
            // 
            this.n4.AutoSize = true;
            this.n4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n4.Location = new System.Drawing.Point(281, 252);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(25, 31);
            this.n4.TabIndex = 10;
            this.n4.Text = "*";
            // 
            // n3
            // 
            this.n3.AutoSize = true;
            this.n3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n3.Location = new System.Drawing.Point(250, 252);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(25, 31);
            this.n3.TabIndex = 11;
            this.n3.Text = "*";
            // 
            // n2
            // 
            this.n2.AutoSize = true;
            this.n2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n2.Location = new System.Drawing.Point(219, 252);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(25, 31);
            this.n2.TabIndex = 12;
            this.n2.Text = "*";
            // 
            // n7
            // 
            this.n7.AutoSize = true;
            this.n7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n7.Location = new System.Drawing.Point(374, 252);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(25, 31);
            this.n7.TabIndex = 13;
            this.n7.Text = "*";
            // 
            // n6
            // 
            this.n6.AutoSize = true;
            this.n6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n6.Location = new System.Drawing.Point(343, 252);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(25, 31);
            this.n6.TabIndex = 14;
            this.n6.Text = "*";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(405, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(624, 288);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // GAME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(1034, 304);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.n6);
            this.Controls.Add(this.n7);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.comm);
            this.Controls.Add(this.nGuess);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GAME";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GAME";
            this.Load += new System.EventHandler(this.GAME_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label n1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button nGuess;
        private System.Windows.Forms.Label comm;
        private System.Windows.Forms.Label n5;
        private System.Windows.Forms.Label n4;
        private System.Windows.Forms.Label n3;
        private System.Windows.Forms.Label n2;
        private System.Windows.Forms.Label n7;
        private System.Windows.Forms.Label n6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}