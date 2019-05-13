﻿namespace P4Project.Frontend
{
    partial class SMELogInPage
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LogIn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SMEUsername = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LogIn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SMEUsername);
            this.groupBox1.Controls.Add(this.Password);
            this.groupBox1.Controls.Add(this.Username);
            this.groupBox1.Location = new System.Drawing.Point(211, 67);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(205, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // LogIn
            // 
            this.LogIn.Location = new System.Drawing.Point(70, 98);
            this.LogIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(56, 24);
            this.LogIn.TabIndex = 4;
            this.LogIn.Text = "Log In";
            this.LogIn.UseVisualStyleBackColor = true;
            this.LogIn.Click += new System.EventHandler(this.LogIn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // SMEUsername
            // 
            this.SMEUsername.AutoSize = true;
            this.SMEUsername.Location = new System.Drawing.Point(14, 31);
            this.SMEUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SMEUsername.Name = "SMEUsername";
            this.SMEUsername.Size = new System.Drawing.Size(84, 13);
            this.SMEUsername.TabIndex = 0;
            this.SMEUsername.Text = "SME Username:";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(101, 67);
            this.Password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(100, 20);
            this.Password.TabIndex = 1;
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(101, 31);
            this.Username.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(100, 20);
            this.Username.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "SME Log In";
            // 
            // SMELogInPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SMELogInPage";
            this.Text = "SMELogInPage";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button LogIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SMEUsername;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label1;
    }
}