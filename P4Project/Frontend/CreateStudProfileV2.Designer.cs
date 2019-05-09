namespace P4Project
{
    partial class CreateStudProfileV2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StudCrTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.basicSaveBut = new System.Windows.Forms.Button();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.LastNameText = new System.Windows.Forms.TextBox();
            this.FirstNameText = new System.Windows.Forms.TextBox();
            this.MailLabel = new System.Windows.Forms.Label();
            this.lNamelabel = new System.Windows.Forms.Label();
            this.fNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(19, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 123);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // StudCrTitle
            // 
            this.StudCrTitle.AutoSize = true;
            this.StudCrTitle.Location = new System.Drawing.Point(311, 9);
            this.StudCrTitle.Name = "StudCrTitle";
            this.StudCrTitle.Size = new System.Drawing.Size(188, 17);
            this.StudCrTitle.TabIndex = 2;
            this.StudCrTitle.Text = "CREATE PROFILE (Student)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.basicSaveBut);
            this.groupBox1.Controls.Add(this.EmailText);
            this.groupBox1.Controls.Add(this.LastNameText);
            this.groupBox1.Controls.Add(this.FirstNameText);
            this.groupBox1.Controls.Add(this.MailLabel);
            this.groupBox1.Controls.Add(this.lNamelabel);
            this.groupBox1.Controls.Add(this.fNameLabel);
            this.groupBox1.Location = new System.Drawing.Point(19, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 183);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // basicSaveBut
            // 
            this.basicSaveBut.Location = new System.Drawing.Point(208, 160);
            this.basicSaveBut.Name = "basicSaveBut";
            this.basicSaveBut.Size = new System.Drawing.Size(98, 23);
            this.basicSaveBut.TabIndex = 6;
            this.basicSaveBut.Text = "Save";
            this.basicSaveBut.UseVisualStyleBackColor = true;
            this.basicSaveBut.Click += new System.EventHandler(this.basicSaveBut_Click);
            // 
            // EmailText
            // 
            this.EmailText.Location = new System.Drawing.Point(10, 129);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(100, 22);
            this.EmailText.TabIndex = 5;
            // 
            // LastNameText
            // 
            this.LastNameText.Location = new System.Drawing.Point(186, 65);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(100, 22);
            this.LastNameText.TabIndex = 4;
            // 
            // FirstNameText
            // 
            this.FirstNameText.Location = new System.Drawing.Point(10, 66);
            this.FirstNameText.Name = "FirstNameText";
            this.FirstNameText.Size = new System.Drawing.Size(100, 22);
            this.FirstNameText.TabIndex = 3;
            // 
            // MailLabel
            // 
            this.MailLabel.AutoSize = true;
            this.MailLabel.Location = new System.Drawing.Point(7, 108);
            this.MailLabel.Name = "MailLabel";
            this.MailLabel.Size = new System.Drawing.Size(46, 17);
            this.MailLabel.TabIndex = 2;
            this.MailLabel.Text = "Email:";
            // 
            // lNamelabel
            // 
            this.lNamelabel.AutoSize = true;
            this.lNamelabel.Location = new System.Drawing.Point(183, 45);
            this.lNamelabel.Name = "lNamelabel";
            this.lNamelabel.Size = new System.Drawing.Size(80, 17);
            this.lNamelabel.TabIndex = 1;
            this.lNamelabel.Text = "Last Name:";
            // 
            // fNameLabel
            // 
            this.fNameLabel.AutoSize = true;
            this.fNameLabel.Location = new System.Drawing.Point(7, 45);
            this.fNameLabel.Name = "fNameLabel";
            this.fNameLabel.Size = new System.Drawing.Size(80, 17);
            this.fNameLabel.TabIndex = 0;
            this.fNameLabel.Text = "First Name:";
            // 
            // CreateStudProfileV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StudCrTitle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CreateStudProfileV2";
            this.Text = "CreateStudProfile";
            this.Load += new System.EventHandler(this.CreateStudProfileV2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label StudCrTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button basicSaveBut;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.TextBox LastNameText;
        private System.Windows.Forms.TextBox FirstNameText;
        private System.Windows.Forms.Label MailLabel;
        private System.Windows.Forms.Label lNamelabel;
        private System.Windows.Forms.Label fNameLabel;
    }
}