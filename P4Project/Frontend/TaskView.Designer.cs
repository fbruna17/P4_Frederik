namespace P4Project.Frontend
{
    partial class TaskView
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
            this.TaskNameLabel = new System.Windows.Forms.Label();
            this.DescriptionBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TaskDescriptionBox = new System.Windows.Forms.RichTextBox();
            this.CompanyNameLabel = new System.Windows.Forms.Label();
            this.PracticalInfoBox = new System.Windows.Forms.GroupBox();
            this.EditSkills = new System.Windows.Forms.Button();
            this.DateBox = new System.Windows.Forms.GroupBox();
            this.EstHours = new System.Windows.Forms.Label();
            this.CompletionDeadline = new System.Windows.Forms.Label();
            this.StartDate = new System.Windows.Forms.Label();
            this.ApplicationDeadline = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RecSkills = new System.Windows.Forms.ListBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.UnApply = new System.Windows.Forms.Button();
            this.Apply = new System.Windows.Forms.Button();
            this.EditTask = new System.Windows.Forms.Button();
            this.ViewApplicants = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.ApplicantBox = new System.Windows.Forms.GroupBox();
            this.CloseApplicantView = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.RemoveStudentApplicant = new System.Windows.Forms.Button();
            this.SeeStudentProfile = new System.Windows.Forms.Button();
            this.StudentApplicantsView = new System.Windows.Forms.DataGridView();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Education = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionBox.SuspendLayout();
            this.PracticalInfoBox.SuspendLayout();
            this.DateBox.SuspendLayout();
            this.ApplicantBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentApplicantsView)).BeginInit();
            this.SuspendLayout();
            // 
            // TaskNameLabel
            // 
            this.TaskNameLabel.AutoSize = true;
            this.TaskNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TaskNameLabel.Location = new System.Drawing.Point(32, 26);
            this.TaskNameLabel.Name = "TaskNameLabel";
            this.TaskNameLabel.Size = new System.Drawing.Size(186, 29);
            this.TaskNameLabel.TabIndex = 0;
            this.TaskNameLabel.Text = "Tasknamelabel";
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Controls.Add(this.label1);
            this.DescriptionBox.Controls.Add(this.TaskDescriptionBox);
            this.DescriptionBox.Controls.Add(this.CompanyNameLabel);
            this.DescriptionBox.Location = new System.Drawing.Point(37, 78);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(282, 347);
            this.DescriptionBox.TabIndex = 1;
            this.DescriptionBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Task Description:";
            // 
            // TaskDescriptionBox
            // 
            this.TaskDescriptionBox.Location = new System.Drawing.Point(10, 92);
            this.TaskDescriptionBox.Name = "TaskDescriptionBox";
            this.TaskDescriptionBox.ReadOnly = true;
            this.TaskDescriptionBox.Size = new System.Drawing.Size(266, 249);
            this.TaskDescriptionBox.TabIndex = 1;
            this.TaskDescriptionBox.Text = "";
            // 
            // CompanyNameLabel
            // 
            this.CompanyNameLabel.AutoSize = true;
            this.CompanyNameLabel.Location = new System.Drawing.Point(7, 22);
            this.CompanyNameLabel.Name = "CompanyNameLabel";
            this.CompanyNameLabel.Size = new System.Drawing.Size(132, 17);
            this.CompanyNameLabel.TabIndex = 0;
            this.CompanyNameLabel.Text = "Companynamelabel";
            // 
            // PracticalInfoBox
            // 
            this.PracticalInfoBox.Controls.Add(this.EditSkills);
            this.PracticalInfoBox.Controls.Add(this.DateBox);
            this.PracticalInfoBox.Controls.Add(this.label3);
            this.PracticalInfoBox.Controls.Add(this.RecSkills);
            this.PracticalInfoBox.Controls.Add(this.Label2);
            this.PracticalInfoBox.Location = new System.Drawing.Point(359, 26);
            this.PracticalInfoBox.Name = "PracticalInfoBox";
            this.PracticalInfoBox.Size = new System.Drawing.Size(400, 347);
            this.PracticalInfoBox.TabIndex = 2;
            this.PracticalInfoBox.TabStop = false;
            // 
            // EditSkills
            // 
            this.EditSkills.Location = new System.Drawing.Point(73, 198);
            this.EditSkills.Name = "EditSkills";
            this.EditSkills.Size = new System.Drawing.Size(82, 23);
            this.EditSkills.TabIndex = 4;
            this.EditSkills.Text = "Edit Skills";
            this.EditSkills.UseVisualStyleBackColor = true;
            this.EditSkills.Visible = false;
            // 
            // DateBox
            // 
            this.DateBox.Controls.Add(this.EstHours);
            this.DateBox.Controls.Add(this.CompletionDeadline);
            this.DateBox.Controls.Add(this.StartDate);
            this.DateBox.Controls.Add(this.ApplicationDeadline);
            this.DateBox.Controls.Add(this.label8);
            this.DateBox.Controls.Add(this.label7);
            this.DateBox.Controls.Add(this.label6);
            this.DateBox.Controls.Add(this.label5);
            this.DateBox.Controls.Add(this.label4);
            this.DateBox.Location = new System.Drawing.Point(161, 52);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(233, 140);
            this.DateBox.TabIndex = 3;
            this.DateBox.TabStop = false;
            // 
            // EstHours
            // 
            this.EstHours.AutoSize = true;
            this.EstHours.Location = new System.Drawing.Point(145, 117);
            this.EstHours.Name = "EstHours";
            this.EstHours.Size = new System.Drawing.Size(0, 17);
            this.EstHours.TabIndex = 8;
            // 
            // CompletionDeadline
            // 
            this.CompletionDeadline.AutoSize = true;
            this.CompletionDeadline.Location = new System.Drawing.Point(145, 92);
            this.CompletionDeadline.Name = "CompletionDeadline";
            this.CompletionDeadline.Size = new System.Drawing.Size(0, 17);
            this.CompletionDeadline.TabIndex = 7;
            // 
            // StartDate
            // 
            this.StartDate.AutoSize = true;
            this.StartDate.Location = new System.Drawing.Point(145, 66);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(0, 17);
            this.StartDate.TabIndex = 6;
            // 
            // ApplicationDeadline
            // 
            this.ApplicationDeadline.AutoSize = true;
            this.ApplicationDeadline.Location = new System.Drawing.Point(145, 40);
            this.ApplicationDeadline.Name = "ApplicationDeadline";
            this.ApplicationDeadline.Size = new System.Drawing.Size(0, 17);
            this.ApplicationDeadline.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Est. Hours Needed:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Completion Deadline:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Start Date:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Application Deadline:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(7, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Deadlines:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(-4, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Required Skills:";
            // 
            // RecSkills
            // 
            this.RecSkills.FormattingEnabled = true;
            this.RecSkills.ItemHeight = 16;
            this.RecSkills.Location = new System.Drawing.Point(0, 92);
            this.RecSkills.Name = "RecSkills";
            this.RecSkills.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.RecSkills.Size = new System.Drawing.Size(155, 100);
            this.RecSkills.TabIndex = 1;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(108, 18);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(140, 17);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Practical Information:";
            // 
            // UnApply
            // 
            this.UnApply.Location = new System.Drawing.Point(641, 390);
            this.UnApply.Name = "UnApply";
            this.UnApply.Size = new System.Drawing.Size(118, 35);
            this.UnApply.TabIndex = 7;
            this.UnApply.Text = "Un Apply";
            this.UnApply.UseVisualStyleBackColor = true;
            this.UnApply.Visible = false;
            this.UnApply.Click += new System.EventHandler(this.UnApply_Click);
            // 
            // Apply
            // 
            this.Apply.Location = new System.Drawing.Point(641, 390);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(118, 35);
            this.Apply.TabIndex = 6;
            this.Apply.Text = "Apply";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Visible = false;
            this.Apply.Click += new System.EventHandler(this.Apply_Click_1);
            // 
            // EditTask
            // 
            this.EditTask.Location = new System.Drawing.Point(641, 390);
            this.EditTask.Name = "EditTask";
            this.EditTask.Size = new System.Drawing.Size(118, 35);
            this.EditTask.TabIndex = 3;
            this.EditTask.Text = "Edit Task";
            this.EditTask.UseVisualStyleBackColor = true;
            this.EditTask.Visible = false;
            this.EditTask.Click += new System.EventHandler(this.EditTask_Click);
            // 
            // ViewApplicants
            // 
            this.ViewApplicants.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.ViewApplicants.Location = new System.Drawing.Point(492, 390);
            this.ViewApplicants.Name = "ViewApplicants";
            this.ViewApplicants.Size = new System.Drawing.Size(143, 35);
            this.ViewApplicants.TabIndex = 4;
            this.ViewApplicants.Text = "View Applicants";
            this.ViewApplicants.UseVisualStyleBackColor = true;
            this.ViewApplicants.Visible = false;
            this.ViewApplicants.Click += new System.EventHandler(this.ViewApplicants_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Back.Location = new System.Drawing.Point(517, 390);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(118, 35);
            this.Back.TabIndex = 8;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // ApplicantBox
            // 
            this.ApplicantBox.Controls.Add(this.CloseApplicantView);
            this.ApplicantBox.Controls.Add(this.label9);
            this.ApplicantBox.Controls.Add(this.RemoveStudentApplicant);
            this.ApplicantBox.Controls.Add(this.SeeStudentProfile);
            this.ApplicantBox.Controls.Add(this.StudentApplicantsView);
            this.ApplicantBox.Location = new System.Drawing.Point(788, 35);
            this.ApplicantBox.Name = "ApplicantBox";
            this.ApplicantBox.Size = new System.Drawing.Size(486, 267);
            this.ApplicantBox.TabIndex = 9;
            this.ApplicantBox.TabStop = false;
            this.ApplicantBox.Visible = false;
            // 
            // CloseApplicantView
            // 
            this.CloseApplicantView.Location = new System.Drawing.Point(126, 215);
            this.CloseApplicantView.Name = "CloseApplicantView";
            this.CloseApplicantView.Size = new System.Drawing.Size(106, 32);
            this.CloseApplicantView.TabIndex = 4;
            this.CloseApplicantView.Text = "Close";
            this.CloseApplicantView.UseVisualStyleBackColor = true;
            this.CloseApplicantView.Click += new System.EventHandler(this.CloseApplicantView_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(158, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Applicants:";
            // 
            // RemoveStudentApplicant
            // 
            this.RemoveStudentApplicant.Location = new System.Drawing.Point(238, 214);
            this.RemoveStudentApplicant.Name = "RemoveStudentApplicant";
            this.RemoveStudentApplicant.Size = new System.Drawing.Size(114, 33);
            this.RemoveStudentApplicant.TabIndex = 2;
            this.RemoveStudentApplicant.Text = "Reject";
            this.RemoveStudentApplicant.UseVisualStyleBackColor = true;
            this.RemoveStudentApplicant.Click += new System.EventHandler(this.RemoveStudentApplicant_Click);
            // 
            // SeeStudentProfile
            // 
            this.SeeStudentProfile.Location = new System.Drawing.Point(358, 214);
            this.SeeStudentProfile.Name = "SeeStudentProfile";
            this.SeeStudentProfile.Size = new System.Drawing.Size(109, 33);
            this.SeeStudentProfile.TabIndex = 1;
            this.SeeStudentProfile.Text = "See Profile";
            this.SeeStudentProfile.UseVisualStyleBackColor = true;
            this.SeeStudentProfile.Click += new System.EventHandler(this.SeeStudentProfile_Click);
            // 
            // StudentApplicantsView
            // 
            this.StudentApplicantsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentApplicantsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentName,
            this.Education,
            this.RecScore,
            this.StudentID});
            this.StudentApplicantsView.Location = new System.Drawing.Point(6, 45);
            this.StudentApplicantsView.Name = "StudentApplicantsView";
            this.StudentApplicantsView.RowTemplate.Height = 24;
            this.StudentApplicantsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentApplicantsView.Size = new System.Drawing.Size(474, 163);
            this.StudentApplicantsView.TabIndex = 0;
            // 
            // StudentName
            // 
            this.StudentName.Frozen = true;
            this.StudentName.HeaderText = "Name";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            this.StudentName.Width = 150;
            // 
            // Education
            // 
            this.Education.Frozen = true;
            this.Education.HeaderText = "Education";
            this.Education.Name = "Education";
            this.Education.ReadOnly = true;
            // 
            // RecScore
            // 
            this.RecScore.Frozen = true;
            this.RecScore.HeaderText = "Recommend Score";
            this.RecScore.Name = "RecScore";
            this.RecScore.ReadOnly = true;
            // 
            // StudentID
            // 
            this.StudentID.Frozen = true;
            this.StudentID.HeaderText = "StudentID";
            this.StudentID.Name = "StudentID";
            this.StudentID.ReadOnly = true;
            // 
            // TaskView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 450);
            this.Controls.Add(this.ApplicantBox);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.ViewApplicants);
            this.Controls.Add(this.EditTask);
            this.Controls.Add(this.UnApply);
            this.Controls.Add(this.PracticalInfoBox);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.TaskNameLabel);
            this.Name = "TaskView";
            this.Text = "TaskView";
            this.DescriptionBox.ResumeLayout(false);
            this.DescriptionBox.PerformLayout();
            this.PracticalInfoBox.ResumeLayout(false);
            this.PracticalInfoBox.PerformLayout();
            this.DateBox.ResumeLayout(false);
            this.DateBox.PerformLayout();
            this.ApplicantBox.ResumeLayout(false);
            this.ApplicantBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentApplicantsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TaskNameLabel;
        private System.Windows.Forms.GroupBox DescriptionBox;
        private System.Windows.Forms.Label CompanyNameLabel;
        private System.Windows.Forms.RichTextBox TaskDescriptionBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox PracticalInfoBox;
        private System.Windows.Forms.GroupBox DateBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox RecSkills;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button EditTask;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label EstHours;
        private System.Windows.Forms.Label CompletionDeadline;
        private System.Windows.Forms.Label StartDate;
        private System.Windows.Forms.Label ApplicationDeadline;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ViewApplicants;
        private System.Windows.Forms.Button EditSkills;
        private System.Windows.Forms.Button UnApply;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.GroupBox ApplicantBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button RemoveStudentApplicant;
        private System.Windows.Forms.Button SeeStudentProfile;
        private System.Windows.Forms.DataGridView StudentApplicantsView;
        private System.Windows.Forms.Button CloseApplicantView;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Education;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
    }
}