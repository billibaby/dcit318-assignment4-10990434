﻿namespace Question1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Username = new TextBox();
            Password = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // Username
            // 
            Username.Location = new Point(254, 94);
            Username.Name = "Username";
            Username.PlaceholderText = "Enter Username";
            Username.Size = new Size(296, 31);
            Username.TabIndex = 0;
            // 
            // Password
            // 
            Password.Location = new Point(254, 156);
            Password.Name = "Password";
            Password.PlaceholderText = "Enter Password";
            Password.Size = new Size(296, 31);
            Password.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Location = new Point(312, 211);
            button1.Name = "button1";
            button1.Size = new Size(147, 46);
            button1.TabIndex = 2;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(252, 66);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 3;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(254, 128);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 4;
            label2.Text = "password";
            label2.Click += label2_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(0, 192, 0);
            textBox3.Location = new Point(1, 1);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(798, 31);
            textBox3.TabIndex = 5;
            textBox3.Text = "User Login Form";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(Password);
            Controls.Add(Username);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Username;
        private TextBox Password;
        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox3;
    }
}
