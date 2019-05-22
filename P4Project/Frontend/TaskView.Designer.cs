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
            this.TaskState = new System.Windows.Forms.Label();
            this.RecScoreLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
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
            this.SubmitNew = new System.Windows.Forms.Button();
            this.UpdateTaskSubmit = new System.Windows.Forms.Button();
            this.EditAgain = new System.Windows.Forms.Button();
            this.ViewAssignedStudent = new System.Windows.Forms.Button();
            this.CompletBtn = new System.Windows.Forms.Button();
            this.DescriptionBox.SuspendLayout();
            this.PracticalInfoBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.DateBox.SuspendLayout();
            this.ApplicantBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentApplicantsView)).BeginInit();
            this.SuspendLayout();
            // 
            // TaskNameLabel
            // 
            this.TaskNameLabel.AutoSize = true;
            this.TaskNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TaskNameLabel.Location = new System.Drawing.Point(24, 21);
            this.TaskNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TaskNameLabel.Name = "TaskNameLabel";
            this.TaskNameLabel.Size = new System.Drawing.Size(146, 25);
            this.TaskNameLabel.TabIndex = 0;
            this.TaskNameLabel.Text = "Tasknamelabel";
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Controls.Add(this.label1);
            this.DescriptionBox.Controls.Add(this.TaskDescriptionBox);
            this.DescriptionBox.Controls.Add(this.CompanyNameLabel);
            this.DescriptionBox.Location = new System.Drawing.Point(28, 63);
            this.DescriptionBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DescriptionBox.Size = new System.Drawing.Size(212, 282);
            this.DescriptionBox.TabIndex = 1;
            this.DescriptionBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Task Description:";
            // 
            // TaskDescriptionBox
            // 
            this.TaskDescriptionBox.Location = new System.Drawing.Point(8, 75);
            this.TaskDescriptionBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TaskDescriptionBox.Name = "TaskDescriptionBox";
            this.TaskDescriptionBox.ReadOnly = true;
            this.TaskDescriptionBox.Size = new System.Drawing.Size(200, 203);
            this.TaskDescriptionBox.TabIndex = 1;
            this.TaskDescriptionBox.Text = "";
            // 
            // CompanyNameLabel
            // 
            this.CompanyNameLabel.AutoSize = true;
            this.CompanyNameLabel.Location = new System.Drawing.Point(5, 18);
            this.CompanyNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CompanyNameLabel.Name = "CompanyNameLabel";
            this.CompanyNameLabel.Size = new System.Drawing.Size(99, 13);
            this.CompanyNameLabel.TabIndex = 0;
            this.CompanyNameLabel.Text = "Companynamelabel";
            // 
            // PracticalInfoBox
            // 
            this.PracticalInfoBox.Controls.Add(this.TaskState);
            this.PracticalInfoBox.Controls.Add(this.RecScoreLabel);
            this.PracticalInfoBox.Controls.Add(this.groupBox1);
            this.PracticalInfoBox.Controls.Add(this.DateBox);
            this.PracticalInfoBox.Controls.Add(this.label3);
            this.PracticalInfoBox.Controls.Add(this.RecSkills);
            this.PracticalInfoBox.Controls.Add(this.Label2);
            this.PracticalInfoBox.Location = new System.Drawing.Point(269, 21);
            this.PracticalInfoBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PracticalInfoBox.Name = "PracticalInfoBox";
            this.PracticalInfoBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PracticalInfoBox.Size = new System.Drawing.Size(300, 282);
            this.PracticalInfoBox.TabIndex = 2;
            this.PracticalInfoBox.TabStop = false;
            // 
            // TaskState
            // 
            this.TaskState.AutoSize = true;
            this.TaskState.Location = new System.Drawing.Point(4, 203);
            this.TaskState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TaskState.Name = "TaskState";
            this.TaskState.Size = new System.Drawing.Size(62, 13);
            this.TaskState.TabIndex = 7;
            this.TaskState.Text = "Task State:";
            // 
            // RecScoreLabel
            // 
            this.RecScoreLabel.AutoSize = true;
            this.RecScoreLabel.Location = new System.Drawing.Point(16, 249);
            this.RecScoreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RecScoreLabel.Name = "RecScoreLabel";
            this.RecScoreLabel.Size = new System.Drawing.Size(0, 13);
            this.RecScoreLabel.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LocationLabel);
            this.groupBox1.Controls.Add(this.label100);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(119, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 67);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Location = new System.Drawing.Point(97, 28);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(0, 13);
            this.LocationLabel.TabIndex = 2;
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Location = new System.Drawing.Point(7, 28);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(83, 13);
            this.label100.TabIndex = 1;
            this.label100.Text = "Work Location: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "General:";
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
            this.DateBox.Location = new System.Drawing.Point(121, 117);
            this.DateBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DateBox.Name = "DateBox";
            this.DateBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DateBox.Size = new System.Drawing.Size(175, 114);
            this.DateBox.TabIndex = 3;
            this.DateBox.TabStop = false;
            // 
            // EstHours
            // 
            this.EstHours.AutoSize = true;
            this.EstHours.Location = new System.Drawing.Point(109, 95);
            this.EstHours.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EstHours.Name = "EstHours";
            this.EstHours.Size = new System.Drawing.Size(0, 13);
            this.EstHours.TabIndex = 8;
            // 
            // CompletionDeadline
            // 
            this.CompletionDeadline.AutoSize = true;
            this.CompletionDeadline.Location = new System.Drawing.Point(109, 75);
            this.CompletionDeadline.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CompletionDeadline.Name = "CompletionDeadline";
            this.CompletionDeadline.Size = new System.Drawing.Size(0, 13);
            this.CompletionDeadline.TabIndex = 7;
            // 
            // StartDate
            // 
            this.StartDate.AutoSize = true;
            this.StartDate.Location = new System.Drawing.Point(109, 54);
            this.StartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(0, 13);
            this.StartDate.TabIndex = 6;
            // 
            // ApplicationDeadline
            // 
            this.ApplicationDeadline.AutoSize = true;
            this.ApplicationDeadline.Location = new System.Drawing.Point(109, 32);
            this.ApplicationDeadline.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ApplicationDeadline.Name = "ApplicationDeadline";
            this.ApplicationDeadline.Size = new System.Drawing.Size(0, 13);
            this.ApplicationDeadline.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 95);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Est. Hours Needed:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 75);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Completion Deadline:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 54);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Start Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Application Deadline:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(5, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Deadlines:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(-3, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Required Skills:";
            // 
            // RecSkills
            // 
            this.RecSkills.FormattingEnabled = true;
            this.RecSkills.Location = new System.Drawing.Point(0, 75);
            this.RecSkills.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RecSkills.Name = "RecSkills";
            this.RecSkills.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.RecSkills.Size = new System.Drawing.Size(117, 82);
            this.RecSkills.TabIndex = 1;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(81, 15);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(106, 13);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Practical Information:";
            // 
            // UnApply
            // 
            this.UnApply.Location = new System.Drawing.Point(481, 317);
            this.UnApply.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UnApply.Name = "UnApply";
            this.UnApply.Size = new System.Drawing.Size(88, 28);
            this.UnApply.TabIndex = 7;
            this.UnApply.Text = "Un Apply";
            this.UnApply.UseVisualStyleBackColor = true;
            this.UnApply.Visible = false;
            this.UnApply.Click += new System.EventHandler(this.UnApply_Click);
            // 
            // Apply
            // 
            this.Apply.Location = new System.Drawing.Point(481, 317);
            this.Apply.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(88, 28);
            this.Apply.TabIndex = 6;
            this.Apply.Text = "Apply";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Visible = false;
            this.Apply.Click += new System.EventHandler(this.Apply_Click_1);
            // 
            // EditTask
            // 
            this.EditTask.Location = new System.Drawing.Point(481, 317);
            this.EditTask.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditTask.Name = "EditTask";
            this.EditTask.Size = new System.Drawing.Size(88, 28);
            this.EditTask.TabIndex = 3;
            this.EditTask.Text = "Edit Task";
            this.EditTask.UseVisualStyleBackColor = true;
            this.EditTask.Visible = false;
            this.EditTask.Click += new System.EventHandler(this.EditTask_Click);
            // 
            // ViewApplicants
            // 
            this.ViewApplicants.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.ViewApplicants.Location = new System.Drawing.Point(369, 317);
            this.ViewApplicants.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ViewApplicants.Name = "ViewApplicants";
            this.ViewApplicants.Size = new System.Drawing.Size(107, 28);
            this.ViewApplicants.TabIndex = 4;
            this.ViewApplicants.Text = "View Applicants";
            this.ViewApplicants.UseVisualStyleBackColor = true;
            this.ViewApplicants.Visible = false;
            this.ViewApplicants.Click += new System.EventHandler(this.ViewApplicants_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Back.Location = new System.Drawing.Point(388, 317);
            this.Back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(88, 28);
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
            this.ApplicantBox.Location = new System.Drawing.Point(194, 51);
            this.ApplicantBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ApplicantBox.Name = "ApplicantBox";
            this.ApplicantBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ApplicantBox.Size = new System.Drawing.Size(371, 217);
            this.ApplicantBox.TabIndex = 9;
            this.ApplicantBox.TabStop = false;
            this.ApplicantBox.Visible = false;
            // 
            // CloseApplicantView
            // 
            this.CloseApplicantView.Location = new System.Drawing.Point(94, 175);
            this.CloseApplicantView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CloseApplicantView.Name = "CloseApplicantView";
            this.CloseApplicantView.Size = new System.Drawing.Size(80, 26);
            this.CloseApplicantView.TabIndex = 4;
            this.CloseApplicantView.Text = "Close";
            this.CloseApplicantView.UseVisualStyleBackColor = true;
            this.CloseApplicantView.Click += new System.EventHandler(this.CloseApplicantView_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(118, 14);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Applicants:";
            // 
            // RemoveStudentApplicant
            // 
            this.RemoveStudentApplicant.Location = new System.Drawing.Point(178, 174);
            this.RemoveStudentApplicant.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RemoveStudentApplicant.Name = "RemoveStudentApplicant";
            this.RemoveStudentApplicant.Size = new System.Drawing.Size(86, 27);
            this.RemoveStudentApplicant.TabIndex = 2;
            this.RemoveStudentApplicant.Text = "Reject";
            this.RemoveStudentApplicant.UseVisualStyleBackColor = true;
            this.RemoveStudentApplicant.Click += new System.EventHandler(this.RemoveStudentApplicant_Click);
            // 
            // SeeStudentProfile
            // 
            this.SeeStudentProfile.Location = new System.Drawing.Point(268, 174);
            this.SeeStudentProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SeeStudentProfile.Name = "SeeStudentProfile";
            this.SeeStudentProfile.Size = new System.Drawing.Size(82, 27);
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
            this.StudentApplicantsView.Location = new System.Drawing.Point(4, 37);
            this.StudentApplicantsView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StudentApplicantsView.Name = "StudentApplicantsView";
            this.StudentApplicantsView.RowTemplate.Height = 24;
            this.StudentApplicantsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentApplicantsView.Size = new System.Drawing.Size(362, 132);
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
            this.StudentID.Visible = false;
            // 
            // SubmitNew
            // 
            this.SubmitNew.Location = new System.Drawing.Point(481, 317);
            this.SubmitNew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SubmitNew.Name = "SubmitNew";
            this.SubmitNew.Size = new System.Drawing.Size(88, 28);
            this.SubmitNew.TabIndex = 10;
            this.SubmitNew.Text = "Submit";
            this.SubmitNew.UseVisualStyleBackColor = true;
            this.SubmitNew.Visible = false;
            this.SubmitNew.Click += new System.EventHandler(this.SubmitNew_Click);
            // 
            // UpdateTaskSubmit
            // 
            this.UpdateTaskSubmit.Location = new System.Drawing.Point(481, 317);
            this.UpdateTaskSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UpdateTaskSubmit.Name = "UpdateTaskSubmit";
            this.UpdateTaskSubmit.Size = new System.Drawing.Size(88, 28);
            this.UpdateTaskSubmit.TabIndex = 11;
            this.UpdateTaskSubmit.Text = "Submit";
            this.UpdateTaskSubmit.UseVisualStyleBackColor = true;
            this.UpdateTaskSubmit.Visible = false;
            this.UpdateTaskSubmit.Click += new System.EventHandler(this.UpdateTaskSubmit_Click);
            // 
            // EditAgain
            // 
            this.EditAgain.Location = new System.Drawing.Point(388, 317);
            this.EditAgain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditAgain.Name = "EditAgain";
            this.EditAgain.Size = new System.Drawing.Size(88, 28);
            this.EditAgain.TabIndex = 12;
            this.EditAgain.Text = "Edit";
            this.EditAgain.UseVisualStyleBackColor = true;
            this.EditAgain.Visible = false;
            this.EditAgain.Click += new System.EventHandler(this.EditAgain_Click);
            // 
            // ViewAssignedStudent
            // 
            this.ViewAssignedStudent.Location = new System.Drawing.Point(369, 317);
            this.ViewAssignedStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ViewAssignedStudent.Name = "ViewAssignedStudent";
            this.ViewAssignedStudent.Size = new System.Drawing.Size(106, 28);
            this.ViewAssignedStudent.TabIndex = 13;
            this.ViewAssignedStudent.Text = "View Assigned";
            this.ViewAssignedStudent.UseVisualStyleBackColor = true;
            this.ViewAssignedStudent.Visible = false;
            this.ViewAssignedStudent.Click += new System.EventHandler(this.ViewAssignedStudent_Click);
            // 
            // CompletBtn
            // 
            this.CompletBtn.Location = new System.Drawing.Point(482, 317);
            this.CompletBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CompletBtn.Name = "CompletBtn";
            this.CompletBtn.Size = new System.Drawing.Size(88, 28);
            this.CompletBtn.TabIndex = 14;
            this.CompletBtn.Text = "Complete";
            this.CompletBtn.UseVisualStyleBackColor = true;
            this.CompletBtn.Visible = false;
            this.CompletBtn.Click += new System.EventHandler(this.CompletBtn_Click);
            // 
            // TaskView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 366);
            this.Controls.Add(this.CompletBtn);
            this.Controls.Add(this.ViewAssignedStudent);
            this.Controls.Add(this.EditAgain);
            this.Controls.Add(this.UpdateTaskSubmit);
            this.Controls.Add(this.ApplicantBox);
            this.Controls.Add(this.SubmitNew);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.ViewApplicants);
            this.Controls.Add(this.EditTask);
            this.Controls.Add(this.UnApply);
            this.Controls.Add(this.PracticalInfoBox);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.TaskNameLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TaskView";
            this.Text = "TaskView";
            this.DescriptionBox.ResumeLayout(false);
            this.DescriptionBox.PerformLayout();
            this.PracticalInfoBox.ResumeLayout(false);
            this.PracticalInfoBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button UnApply;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.GroupBox ApplicantBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button RemoveStudentApplicant;
        private System.Windows.Forms.Button SeeStudentProfile;
        private System.Windows.Forms.DataGridView StudentApplicantsView;
        private System.Windows.Forms.Button CloseApplicantView;
        private System.Windows.Forms.Button SubmitNew;
        private System.Windows.Forms.Button UpdateTaskSubmit;
        private System.Windows.Forms.Button EditAgain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.Button ViewAssignedStudent;
        private System.Windows.Forms.Button CompletBtn;
        private System.Windows.Forms.Label RecScoreLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Education;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.Label TaskState;
    }
}