﻿namespace P4Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateStudProfileV2));
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
            this.imageChooseBtn = new System.Windows.Forms.Button();
            this.imageUploadBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(338, 40);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 223);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // StudCrTitle
            // 
            this.StudCrTitle.AutoSize = true;
            this.StudCrTitle.Location = new System.Drawing.Point(233, 7);
            this.StudCrTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StudCrTitle.Name = "StudCrTitle";
            this.StudCrTitle.Size = new System.Drawing.Size(144, 13);
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
            this.groupBox1.Location = new System.Drawing.Point(14, 189);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(230, 149);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // basicSaveBut
            // 
            this.basicSaveBut.Location = new System.Drawing.Point(156, 130);
            this.basicSaveBut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.basicSaveBut.Name = "basicSaveBut";
            this.basicSaveBut.Size = new System.Drawing.Size(74, 19);
            this.basicSaveBut.TabIndex = 6;
            this.basicSaveBut.Text = "Save";
            this.basicSaveBut.UseVisualStyleBackColor = true;
            this.basicSaveBut.Click += new System.EventHandler(this.basicSaveBut_Click);
            // 
            // EmailText
            // 
            this.EmailText.Location = new System.Drawing.Point(8, 105);
            this.EmailText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(76, 20);
            this.EmailText.TabIndex = 5;
            // 
            // LastNameText
            // 
            this.LastNameText.Location = new System.Drawing.Point(140, 53);
            this.LastNameText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(76, 20);
            this.LastNameText.TabIndex = 4;
            // 
            // FirstNameText
            // 
            this.FirstNameText.Location = new System.Drawing.Point(8, 54);
            this.FirstNameText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FirstNameText.Name = "FirstNameText";
            this.FirstNameText.Size = new System.Drawing.Size(76, 20);
            this.FirstNameText.TabIndex = 3;
            // 
            // MailLabel
            // 
            this.MailLabel.AutoSize = true;
            this.MailLabel.Location = new System.Drawing.Point(5, 88);
            this.MailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MailLabel.Name = "MailLabel";
            this.MailLabel.Size = new System.Drawing.Size(35, 13);
            this.MailLabel.TabIndex = 2;
            this.MailLabel.Text = "Email:";
            // 
            // lNamelabel
            // 
            this.lNamelabel.AutoSize = true;
            this.lNamelabel.Location = new System.Drawing.Point(137, 37);
            this.lNamelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lNamelabel.Name = "lNamelabel";
            this.lNamelabel.Size = new System.Drawing.Size(61, 13);
            this.lNamelabel.TabIndex = 1;
            this.lNamelabel.Text = "Last Name:";
            // 
            // fNameLabel
            // 
            this.fNameLabel.AutoSize = true;
            this.fNameLabel.Location = new System.Drawing.Point(5, 37);
            this.fNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fNameLabel.Name = "fNameLabel";
            this.fNameLabel.Size = new System.Drawing.Size(60, 13);
            this.fNameLabel.TabIndex = 0;
            this.fNameLabel.Text = "First Name:";
            // 
            // imageChooseBtn
            // 
            this.imageChooseBtn.Location = new System.Drawing.Point(347, 277);
            this.imageChooseBtn.Name = "imageChooseBtn";
            this.imageChooseBtn.Size = new System.Drawing.Size(88, 23);
            this.imageChooseBtn.TabIndex = 4;
            this.imageChooseBtn.Text = "Choose Picture";
            this.imageChooseBtn.UseVisualStyleBackColor = true;
            this.imageChooseBtn.Click += new System.EventHandler(this.ImageChooseBtn_Click);
            // 
            // imageUploadBtn
            // 
            this.imageUploadBtn.Location = new System.Drawing.Point(441, 277);
            this.imageUploadBtn.Name = "imageUploadBtn";
            this.imageUploadBtn.Size = new System.Drawing.Size(88, 23);
            this.imageUploadBtn.TabIndex = 5;
            this.imageUploadBtn.Text = "Upload Picture";
            this.imageUploadBtn.UseVisualStyleBackColor = true;
            this.imageUploadBtn.Click += new System.EventHandler(this.ImageUploadBtn_Click);
            // 
            // CreateStudProfileV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.imageUploadBtn);
            this.Controls.Add(this.imageChooseBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StudCrTitle);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button imageChooseBtn;
        private System.Windows.Forms.Button imageUploadBtn;
    }
}