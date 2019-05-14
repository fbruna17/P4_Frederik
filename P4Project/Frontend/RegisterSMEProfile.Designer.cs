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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterSMEProfile));
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
            this.pictureBox1_SME = new System.Windows.Forms.PictureBox();
            this.chooseLogoBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SMEUsername = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_SME)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.SMEUsername);
            this.groupBox1.Controls.Add(this.ConfirmPass);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Password);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.RegisterSave);
            this.groupBox1.Controls.Add(this.CompanyEmail);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CompanyName);
            this.groupBox1.Location = new System.Drawing.Point(15, 103);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(393, 295);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Register";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ConfirmPass
            // 
            this.ConfirmPass.Location = new System.Drawing.Point(180, 185);
            this.ConfirmPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConfirmPass.Name = "ConfirmPass";
            this.ConfirmPass.PasswordChar = '*';
            this.ConfirmPass.Size = new System.Drawing.Size(177, 22);
            this.ConfirmPass.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Confirm Password";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(180, 152);
            this.Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(177, 22);
            this.Password.TabIndex = 5;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // RegisterSave
            // 
            this.RegisterSave.Location = new System.Drawing.Point(284, 264);
            this.RegisterSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegisterSave.Name = "RegisterSave";
            this.RegisterSave.Size = new System.Drawing.Size(75, 23);
            this.RegisterSave.TabIndex = 3;
            this.RegisterSave.Text = "Register";
            this.RegisterSave.UseVisualStyleBackColor = true;
            this.RegisterSave.Click += new System.EventHandler(this.RegisterSave_Click);
            // 
            // CompanyEmail
            // 
            this.CompanyEmail.Location = new System.Drawing.Point(180, 220);
            this.CompanyEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CompanyEmail.Name = "CompanyEmail";
            this.CompanyEmail.Size = new System.Drawing.Size(177, 22);
            this.CompanyEmail.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Company Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Company Name:";
            // 
            // CompanyName
            // 
            this.CompanyName.Location = new System.Drawing.Point(180, 80);
            this.CompanyName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Size = new System.Drawing.Size(177, 22);
            this.CompanyName.TabIndex = 0;
            this.CompanyName.TextChanged += new System.EventHandler(this.CompanyName_TextChanged);
            // 
            // pictureBox1_SME
            // 
            this.pictureBox1_SME.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1_SME.BackgroundImage")));
            this.pictureBox1_SME.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1_SME.Location = new System.Drawing.Point(481, 46);
            this.pictureBox1_SME.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1_SME.Name = "pictureBox1_SME";
            this.pictureBox1_SME.Size = new System.Drawing.Size(273, 289);
            this.pictureBox1_SME.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1_SME.TabIndex = 1;
            this.pictureBox1_SME.TabStop = false;
            this.pictureBox1_SME.Click += new System.EventHandler(this.PictureBox1_SME_Click);
            // 
            // chooseLogoBtn
            // 
            this.chooseLogoBtn.Location = new System.Drawing.Point(536, 354);
            this.chooseLogoBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chooseLogoBtn.Name = "chooseLogoBtn";
            this.chooseLogoBtn.Size = new System.Drawing.Size(179, 28);
            this.chooseLogoBtn.TabIndex = 2;
            this.chooseLogoBtn.Text = "Choose Logo File";
            this.chooseLogoBtn.UseVisualStyleBackColor = true;
            this.chooseLogoBtn.Click += new System.EventHandler(this.ChooseLogoBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Username:";
            // 
            // SMEUsername
            // 
            this.SMEUsername.Location = new System.Drawing.Point(180, 115);
            this.SMEUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SMEUsername.Name = "SMEUsername";
            this.SMEUsername.Size = new System.Drawing.Size(177, 22);
            this.SMEUsername.TabIndex = 8;
            // 
            // RegisterSMEProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chooseLogoBtn);
            this.Controls.Add(this.pictureBox1_SME);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegisterSMEProfile";
            this.Text = "RegisterSMEProfile";
            this.Load += new System.EventHandler(this.RegisterSMEProfile_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_SME)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1_SME;
        private System.Windows.Forms.Button chooseLogoBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SMEUsername;
    }
}
