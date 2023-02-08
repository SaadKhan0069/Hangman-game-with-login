namespace Project_Hangman
{
    partial class Form1
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
            this.nlvl_1 = new System.Windows.Forms.Button();
            this.nlvl_2 = new System.Windows.Forms.Button();
            this.nlvl_3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To Hangman Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select a level";
            // 
            // nlvl_1
            // 
            this.nlvl_1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.nlvl_1.Font = new System.Drawing.Font("Wide Latin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nlvl_1.Location = new System.Drawing.Point(161, 159);
            this.nlvl_1.Name = "nlvl_1";
            this.nlvl_1.Size = new System.Drawing.Size(152, 41);
            this.nlvl_1.TabIndex = 2;
            this.nlvl_1.Text = "Level 1";
            this.nlvl_1.UseVisualStyleBackColor = true;
            this.nlvl_1.Click += new System.EventHandler(this.nlvl_1_Click);
            // 
            // nlvl_2
            // 
            this.nlvl_2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.nlvl_2.Font = new System.Drawing.Font("Wide Latin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nlvl_2.Location = new System.Drawing.Point(161, 221);
            this.nlvl_2.Name = "nlvl_2";
            this.nlvl_2.Size = new System.Drawing.Size(152, 41);
            this.nlvl_2.TabIndex = 3;
            this.nlvl_2.Text = "Level 2";
            this.nlvl_2.UseVisualStyleBackColor = true;
            this.nlvl_2.Click += new System.EventHandler(this.nlvl_2_Click);
            // 
            // nlvl_3
            // 
            this.nlvl_3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.nlvl_3.Font = new System.Drawing.Font("Wide Latin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nlvl_3.Location = new System.Drawing.Point(161, 282);
            this.nlvl_3.Name = "nlvl_3";
            this.nlvl_3.Size = new System.Drawing.Size(152, 41);
            this.nlvl_3.TabIndex = 4;
            this.nlvl_3.Text = "Level 3";
            this.nlvl_3.UseVisualStyleBackColor = true;
            this.nlvl_3.Click += new System.EventHandler(this.nlvl_3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(492, 366);
            this.Controls.Add(this.nlvl_3);
            this.Controls.Add(this.nlvl_2);
            this.Controls.Add(this.nlvl_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button nlvl_1;
        private System.Windows.Forms.Button nlvl_2;
        private System.Windows.Forms.Button nlvl_3;

    }
}

