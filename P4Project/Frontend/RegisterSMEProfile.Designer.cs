namespace P4Project
{
    partial class RegisterSMEProfile
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
            this.ConfirmPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RegisterSave = new System.Windows.Forms.Button();
            this.CompanyEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CompanyName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            //
            // groupBox1
            //
            this.groupBox1.Controls.Add(this.ConfirmPass);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Password);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.RegisterSave);
            this.groupBox1.Controls.Add(this.CompanyEmail);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CompanyName);
            this.groupBox1.Location = new System.Drawing.Point(199, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 211);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Register";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            //
            // ConfirmPass
            //
            this.ConfirmPass.Location = new System.Drawing.Point(158, 87);
            this.ConfirmPass.Name = "ConfirmPass";
            this.ConfirmPass.PasswordChar = '*';
            this.ConfirmPass.Size = new System.Drawing.Size(178, 22);
            this.ConfirmPass.TabIndex = 7;
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Confirm Password";
            //
            // Password
            //
            this.Password.Location = new System.Drawing.Point(158, 54);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(178, 22);
            this.Password.TabIndex = 5;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            //
            // RegisterSave
            //
            this.RegisterSave.Location = new System.Drawing.Point(261, 166);
            this.RegisterSave.Name = "RegisterSave";
            this.RegisterSave.Size = new System.Drawing.Size(75, 23);
            this.RegisterSave.TabIndex = 3;
            this.RegisterSave.Text = "Register";
            this.RegisterSave.UseVisualStyleBackColor = true;
            this.RegisterSave.Click += new System.EventHandler(this.RegisterSave_Click);
            //
            // CompanyEmail
            //
            this.CompanyEmail.Location = new System.Drawing.Point(158, 122);
            this.CompanyEmail.Name = "CompanyEmail";
            this.CompanyEmail.Size = new System.Drawing.Size(178, 22);
            this.CompanyEmail.TabIndex = 2;
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Company Email:";
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Company Name:";
            //
            // CompanyName
            //
            this.CompanyName.Location = new System.Drawing.Point(158, 24);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Size = new System.Drawing.Size(178, 22);
            this.CompanyName.TabIndex = 0;
            this.CompanyName.TextChanged += new System.EventHandler(this.CompanyName_TextChanged);
            //
            // RegisterSMEProfile
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegisterSMEProfile";
            this.Text = "RegisterSMEProfile";
            this.Load += new System.EventHandler(this.RegisterSMEProfile_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CompanyName;
        private System.Windows.Forms.TextBox CompanyEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RegisterSave;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ConfirmPass;
        private System.Windows.Forms.Label label4;
    }
}
