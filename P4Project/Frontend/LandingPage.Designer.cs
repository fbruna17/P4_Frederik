namespace P4Project
{
    partial class LandingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingPage));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StudentRegisterBtn = new System.Windows.Forms.Button();
            this.StudentLoginBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SMERegisterBtn = new System.Windows.Forms.Button();
            this.SMELoginBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StudentRegisterBtn);
            this.groupBox1.Controls.Add(this.StudentLoginBtn);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 343);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Login";
            // 
            // StudentRegisterBtn
            // 
            this.StudentRegisterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentRegisterBtn.Location = new System.Drawing.Point(6, 260);
            this.StudentRegisterBtn.Name = "StudentRegisterBtn";
            this.StudentRegisterBtn.Size = new System.Drawing.Size(188, 29);
            this.StudentRegisterBtn.TabIndex = 3;
            this.StudentRegisterBtn.Text = "Register";
            this.StudentRegisterBtn.UseVisualStyleBackColor = true;
            this.StudentRegisterBtn.Click += new System.EventHandler(this.StudentRegisterBtn_Click);
            // 
            // StudentLoginBtn
            // 
            this.StudentLoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentLoginBtn.Location = new System.Drawing.Point(6, 216);
            this.StudentLoginBtn.Name = "StudentLoginBtn";
            this.StudentLoginBtn.Size = new System.Drawing.Size(188, 29);
            this.StudentLoginBtn.TabIndex = 2;
            this.StudentLoginBtn.Text = "Login";
            this.StudentLoginBtn.UseVisualStyleBackColor = true;
            this.StudentLoginBtn.Click += new System.EventHandler(this.StudentLoginBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(6, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(188, 173);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SMERegisterBtn);
            this.groupBox2.Controls.Add(this.SMELoginBtn);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(253, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 343);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SME Login";
            // 
            // SMERegisterBtn
            // 
            this.SMERegisterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMERegisterBtn.Location = new System.Drawing.Point(6, 260);
            this.SMERegisterBtn.Name = "SMERegisterBtn";
            this.SMERegisterBtn.Size = new System.Drawing.Size(188, 29);
            this.SMERegisterBtn.TabIndex = 6;
            this.SMERegisterBtn.Text = "Register ";
            this.SMERegisterBtn.UseVisualStyleBackColor = true;
            this.SMERegisterBtn.Click += new System.EventHandler(this.SMERegisterBtn_Click);
            // 
            // SMELoginBtn
            // 
            this.SMELoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMELoginBtn.Location = new System.Drawing.Point(6, 216);
            this.SMELoginBtn.Name = "SMELoginBtn";
            this.SMELoginBtn.Size = new System.Drawing.Size(188, 29);
            this.SMELoginBtn.TabIndex = 5;
            this.SMELoginBtn.Text = "Login";
            this.SMELoginBtn.UseVisualStyleBackColor = true;
            this.SMELoginBtn.Click += new System.EventHandler(this.SMELoginBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 173);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 366);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "LandingPage";
            this.Text = "LandingPage";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SMERegisterBtn;
        private System.Windows.Forms.Button SMELoginBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button StudentRegisterBtn;
        private System.Windows.Forms.Button StudentLoginBtn;
    }
}