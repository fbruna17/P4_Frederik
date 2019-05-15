namespace P4Project.Frontend
{
    partial class StudentProfileView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentProfileView));
            this.WelcomeText = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.StudentEmailLabel = new System.Windows.Forms.Label();
            this.StudentNameLabel = new System.Windows.Forms.Label();
            this.StudentPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.EducationLabel = new System.Windows.Forms.Label();
            this.StudentResumeLink = new System.Windows.Forms.LinkLabel();
            this.StudentResumeLabel = new System.Windows.Forms.Label();
            this.StudentEducationLabel = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StudentDescBox = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StudentEditProfileBtn = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StudSkillList = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentPictureBox)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // WelcomeText
            // 
            this.WelcomeText.Location = new System.Drawing.Point(309, 23);
            this.WelcomeText.Margin = new System.Windows.Forms.Padding(4);
            this.WelcomeText.Name = "WelcomeText";
            this.WelcomeText.Size = new System.Drawing.Size(372, 52);
            this.WelcomeText.TabIndex = 0;
            this.WelcomeText.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox1.Controls.Add(this.WelcomeText);
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1065, 123);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.EmailLabel);
            this.groupBox2.Controls.Add(this.NameLabel);
            this.groupBox2.Controls.Add(this.StudentEmailLabel);
            this.groupBox2.Controls.Add(this.StudentNameLabel);
            this.groupBox2.Controls.Add(this.StudentPictureBox);
            this.groupBox2.Location = new System.Drawing.Point(96, 132);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(419, 213);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(254, 100);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(0, 17);
            this.EmailLabel.TabIndex = 4;
            this.EmailLabel.Click += new System.EventHandler(this.EmailLabel_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(251, 57);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(0, 17);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Click += new System.EventHandler(this.NameLabel_Click);
            // 
            // StudentEmailLabel
            // 
            this.StudentEmailLabel.AutoSize = true;
            this.StudentEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentEmailLabel.Location = new System.Drawing.Point(180, 100);
            this.StudentEmailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StudentEmailLabel.Name = "StudentEmailLabel";
            this.StudentEmailLabel.Size = new System.Drawing.Size(68, 20);
            this.StudentEmailLabel.TabIndex = 2;
            this.StudentEmailLabel.Text = "Email: ";
            // 
            // StudentNameLabel
            // 
            this.StudentNameLabel.AutoSize = true;
            this.StudentNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentNameLabel.Location = new System.Drawing.Point(180, 57);
            this.StudentNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StudentNameLabel.Name = "StudentNameLabel";
            this.StudentNameLabel.Size = new System.Drawing.Size(63, 20);
            this.StudentNameLabel.TabIndex = 1;
            this.StudentNameLabel.Text = "Name:";
            // 
            // StudentPictureBox
            // 
            this.StudentPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StudentPictureBox.BackgroundImage")));
            this.StudentPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StudentPictureBox.Location = new System.Drawing.Point(8, 23);
            this.StudentPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.StudentPictureBox.Name = "StudentPictureBox";
            this.StudentPictureBox.Size = new System.Drawing.Size(159, 182);
            this.StudentPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StudentPictureBox.TabIndex = 0;
            this.StudentPictureBox.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.EducationLabel);
            this.groupBox3.Controls.Add(this.StudentResumeLink);
            this.groupBox3.Controls.Add(this.StudentResumeLabel);
            this.groupBox3.Controls.Add(this.StudentEducationLabel);
            this.groupBox3.Location = new System.Drawing.Point(523, 132);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(419, 213);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // EducationLabel
            // 
            this.EducationLabel.AutoSize = true;
            this.EducationLabel.Location = new System.Drawing.Point(170, 60);
            this.EducationLabel.Name = "EducationLabel";
            this.EducationLabel.Size = new System.Drawing.Size(0, 17);
            this.EducationLabel.TabIndex = 3;
            this.EducationLabel.Click += new System.EventHandler(this.Education_Click);
            // 
            // StudentResumeLink
            // 
            this.StudentResumeLink.AutoSize = true;
            this.StudentResumeLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentResumeLink.Location = new System.Drawing.Point(169, 100);
            this.StudentResumeLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StudentResumeLink.Name = "StudentResumeLink";
            this.StudentResumeLink.Size = new System.Drawing.Size(134, 20);
            this.StudentResumeLink.TabIndex = 2;
            this.StudentResumeLink.TabStop = true;
            this.StudentResumeLink.Text = "Download PDF";
            this.StudentResumeLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.StudentResumeLink_LinkClicked);
            // 
            // StudentResumeLabel
            // 
            this.StudentResumeLabel.AutoSize = true;
            this.StudentResumeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentResumeLabel.Location = new System.Drawing.Point(13, 100);
            this.StudentResumeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StudentResumeLabel.Name = "StudentResumeLabel";
            this.StudentResumeLabel.Size = new System.Drawing.Size(132, 20);
            this.StudentResumeLabel.TabIndex = 1;
            this.StudentResumeLabel.Text = "Resumé PDF: ";
            // 
            // StudentEducationLabel
            // 
            this.StudentEducationLabel.AutoSize = true;
            this.StudentEducationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentEducationLabel.Location = new System.Drawing.Point(13, 57);
            this.StudentEducationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StudentEducationLabel.Name = "StudentEducationLabel";
            this.StudentEducationLabel.Size = new System.Drawing.Size(104, 20);
            this.StudentEducationLabel.TabIndex = 0;
            this.StudentEducationLabel.Text = "Education: ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.StudentDescBox);
            this.groupBox4.Location = new System.Drawing.Point(96, 352);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(419, 220);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // StudentDescBox
            // 
            this.StudentDescBox.Location = new System.Drawing.Point(8, 58);
            this.StudentDescBox.Margin = new System.Windows.Forms.Padding(4);
            this.StudentDescBox.Name = "StudentDescBox";
            this.StudentDescBox.Size = new System.Drawing.Size(400, 154);
            this.StudentDescBox.TabIndex = 0;
            this.StudentDescBox.Text = "";
            this.StudentDescBox.TextChanged += new System.EventHandler(this.StudentDescBox_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.StudSkillList);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(524, 353);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(284, 438);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Skill Set";
            // 
            // StudentEditProfileBtn
            // 
            this.StudentEditProfileBtn.Location = new System.Drawing.Point(8, 27);
            this.StudentEditProfileBtn.Margin = new System.Windows.Forms.Padding(4);
            this.StudentEditProfileBtn.Name = "StudentEditProfileBtn";
            this.StudentEditProfileBtn.Size = new System.Drawing.Size(109, 28);
            this.StudentEditProfileBtn.TabIndex = 6;
            this.StudentEditProfileBtn.Text = "Edit Profile";
            this.StudentEditProfileBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.StudentEditProfileBtn);
            this.groupBox6.Location = new System.Drawing.Point(816, 353);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(125, 438);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Location = new System.Drawing.Point(96, 581);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(419, 210);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Former Tasks";
            // 
            // StudSkillList
            // 
            this.StudSkillList.Location = new System.Drawing.Point(8, 74);
            this.StudSkillList.Name = "StudSkillList";
            this.StudSkillList.Size = new System.Drawing.Size(269, 357);
            this.StudSkillList.TabIndex = 1;
            this.StudSkillList.UseCompatibleStateImageBehavior = false;
            this.StudSkillList.SelectedIndexChanged += new System.EventHandler(this.StudSkillList_SelectedIndexChanged);
            // 
            // StudentProfileView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 806);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentProfileView";
            this.Text = "StudentProfileView";
            this.Load += new System.EventHandler(this.StudentProfileView_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentPictureBox)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox WelcomeText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label StudentEmailLabel;
        private System.Windows.Forms.Label StudentNameLabel;
        private System.Windows.Forms.PictureBox StudentPictureBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.LinkLabel StudentResumeLink;
        private System.Windows.Forms.Label StudentResumeLabel;
        private System.Windows.Forms.Label StudentEducationLabel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox StudentDescBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StudentEditProfileBtn;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label EducationLabel;
        private System.Windows.Forms.ListView StudSkillList;
    }
}