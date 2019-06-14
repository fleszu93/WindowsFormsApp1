namespace Figura
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ver1 = new System.Windows.Forms.Label();
            this.ver2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.ver3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Fill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 546);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(857, 92);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Wybierz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ver1
            // 
            this.ver1.AutoSize = true;
            this.ver1.Location = new System.Drawing.Point(875, 62);
            this.ver1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ver1.Name = "ver1";
            this.ver1.Size = new System.Drawing.Size(56, 17);
            this.ver1.TabIndex = 3;
            this.ver1.Text = "Punkt 1";
            this.ver1.Click += new System.EventHandler(this.ver1_Click);
            // 
            // ver2
            // 
            this.ver2.AutoSize = true;
            this.ver2.Location = new System.Drawing.Point(875, 198);
            this.ver2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ver2.Name = "ver2";
            this.ver2.Size = new System.Drawing.Size(56, 17);
            this.ver2.TabIndex = 6;
            this.ver2.Text = "Punkt 2";
            this.ver2.Click += new System.EventHandler(this.ver2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(857, 229);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);

            this.button2.Text = "Wybierz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ver3
            // 
            this.ver3.AutoSize = true;
            this.ver3.Location = new System.Drawing.Point(875, 334);
            this.ver3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ver3.Name = "ver3";
            this.ver3.Size = new System.Drawing.Size(56, 17);
            this.ver3.TabIndex = 9;
            this.ver3.Text = "Punkt 3";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(857, 364);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 7;
            this.button3.Text = "Wybierz";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Fill
            // 
            this.Fill.Location = new System.Drawing.Point(857, 450);
            this.Fill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Fill.Name = "Fill";
            this.Fill.Size = new System.Drawing.Size(100, 28);
            this.Fill.TabIndex = 10;
            this.Fill.Text = "Wypełnienie";
            this.Fill.UseVisualStyleBackColor = true;
            this.Fill.Click += new System.EventHandler(this.Fill_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 576);
            this.Controls.Add(this.Fill);
            this.Controls.Add(this.ver3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ver2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ver1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label ver1;
        private System.Windows.Forms.Label ver2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label ver3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Fill;
    }
}

