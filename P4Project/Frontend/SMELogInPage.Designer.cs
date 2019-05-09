namespace P4Project.Frontend
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
            this.Password = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SMEUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LogIn = new System.Windows.Forms.Button();
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
            this.groupBox1.Location = new System.Drawing.Point(281, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(135, 83);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(132, 22);
            this.Password.TabIndex = 1;
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(135, 38);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(132, 22);
            this.Username.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "SME Log In";
            // 
            // SMEUsername
            // 
            this.SMEUsername.AutoSize = true;
            this.SMEUsername.Location = new System.Drawing.Point(19, 38);
            this.SMEUsername.Name = "SMEUsername";
            this.SMEUsername.Size = new System.Drawing.Size(110, 17);
            this.SMEUsername.TabIndex = 0;
            this.SMEUsername.Text = "SME Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // LogIn
            // 
            this.LogIn.Location = new System.Drawing.Point(94, 121);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(75, 29);
            this.LogIn.TabIndex = 4;
            this.LogIn.Text = "Log In";
            this.LogIn.UseVisualStyleBackColor = true;
            this.LogIn.Click += new System.EventHandler(this.LogIn_Click);
            // 
            // SMELogInPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
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