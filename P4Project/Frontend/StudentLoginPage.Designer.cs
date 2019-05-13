namespace P4Project.Frontend
{
    partial class StudentLoginPage
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
            this.studentLoginBtn = new System.Windows.Forms.Button();
            this.studentUsername = new System.Windows.Forms.TextBox();
            this.studentPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentLoginBtn
            // 
            this.studentLoginBtn.Location = new System.Drawing.Point(97, 142);
            this.studentLoginBtn.Name = "studentLoginBtn";
            this.studentLoginBtn.Size = new System.Drawing.Size(75, 23);
            this.studentLoginBtn.TabIndex = 0;
            this.studentLoginBtn.Text = "Login";
            this.studentLoginBtn.UseVisualStyleBackColor = true;
            this.studentLoginBtn.Click += new System.EventHandler(this.StudentLoginBtn_Click);
            // 
            // studentUsername
            // 
            this.studentUsername.Location = new System.Drawing.Point(65, 58);
            this.studentUsername.Name = "studentUsername";
            this.studentUsername.Size = new System.Drawing.Size(142, 20);
            this.studentUsername.TabIndex = 1;
            // 
            // studentPassword
            // 
            this.studentPassword.Location = new System.Drawing.Point(65, 102);
            this.studentPassword.Name = "studentPassword";
            this.studentPassword.Size = new System.Drawing.Size(142, 20);
            this.studentPassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.studentLoginBtn);
            this.groupBox1.Controls.Add(this.studentUsername);
            this.groupBox1.Controls.Add(this.studentPassword);
            this.groupBox1.Location = new System.Drawing.Point(68, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 182);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student LoginPage";
            // 
            // StudentLoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 308);
            this.Controls.Add(this.groupBox1);
            this.Name = "StudentLoginPage";
            this.Text = "StudentLoginPage";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button studentLoginBtn;
        private System.Windows.Forms.TextBox studentUsername;
        private System.Windows.Forms.TextBox studentPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}