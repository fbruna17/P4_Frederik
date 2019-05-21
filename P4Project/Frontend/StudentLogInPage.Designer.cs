namespace P4Project.Frontend
{
    partial class StudentLogInPage
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
            this.StudentLogIn = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LogIn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.StudentUsername = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentLogIn
            // 
            this.StudentLogIn.AutoSize = true;
            this.StudentLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentLogIn.Location = new System.Drawing.Point(47, 29);
            this.StudentLogIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StudentLogIn.Name = "StudentLogIn";
            this.StudentLogIn.Size = new System.Drawing.Size(129, 20);
            this.StudentLogIn.TabIndex = 5;
            this.StudentLogIn.Text = "Student Log In";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StudentLogIn);
            this.groupBox1.Controls.Add(this.LogIn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.StudentUsername);
            this.groupBox1.Controls.Add(this.Password);
            this.groupBox1.Controls.Add(this.Username);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(215, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // LogIn
            // 
            this.LogIn.Location = new System.Drawing.Point(71, 129);
            this.LogIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(56, 24);
            this.LogIn.TabIndex = 3;
            this.LogIn.Text = "Log In";
            this.LogIn.UseVisualStyleBackColor = true;
            this.LogIn.Click += new System.EventHandler(this.LogIn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // StudentUsername
            // 
            this.StudentUsername.AutoSize = true;
            this.StudentUsername.Location = new System.Drawing.Point(15, 62);
            this.StudentUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StudentUsername.Name = "StudentUsername";
            this.StudentUsername.Size = new System.Drawing.Size(58, 13);
            this.StudentUsername.TabIndex = 0;
            this.StudentUsername.Text = "Username:";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(77, 98);
            this.Password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(125, 20);
            this.Password.TabIndex = 2;
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(77, 62);
            this.Username.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(125, 20);
            this.Username.TabIndex = 1;
            // 
            // StudentLogInPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 176);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StudentLogInPage";
            this.Text = "StudentLogInPage";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label StudentLogIn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button LogIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label StudentUsername;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Username;
    }
}