namespace P4Project.Frontend
{
    partial class SMELandingPage
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
            this.Create_New_Task = new System.Windows.Forms.Button();
            this.TaskOverViewGroup = new System.Windows.Forms.GroupBox();
            this.TaskView = new System.Windows.Forms.DataGridView();
            this.SeeAllTasks = new System.Windows.Forms.Button();
            this.SeeCompletedTasks = new System.Windows.Forms.Button();
            this.SeeOnGoingTasks = new System.Windows.Forms.Button();
            this.SeePrivateTasks = new System.Windows.Forms.Button();
            this.SeePublicTasks = new System.Windows.Forms.Button();
            this.ViewTask = new System.Windows.Forms.Button();
            this.SMENotificationBtn = new System.Windows.Forms.Button();
            this.TaskTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Applications = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApplicationDeadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssignedStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskOverViewGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TaskView)).BeginInit();
            this.SuspendLayout();
            // 
            // Create_New_Task
            // 
            this.Create_New_Task.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_New_Task.Location = new System.Drawing.Point(417, 391);
            this.Create_New_Task.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Create_New_Task.Name = "Create_New_Task";
            this.Create_New_Task.Size = new System.Drawing.Size(156, 46);
            this.Create_New_Task.TabIndex = 8;
            this.Create_New_Task.Text = "Create Task";
            this.Create_New_Task.UseVisualStyleBackColor = true;
            this.Create_New_Task.Click += new System.EventHandler(this.Create_New_Task_Click);
            // 
            // TaskOverViewGroup
            // 
            this.TaskOverViewGroup.Controls.Add(this.TaskView);
            this.TaskOverViewGroup.Controls.Add(this.SeeAllTasks);
            this.TaskOverViewGroup.Controls.Add(this.SeeCompletedTasks);
            this.TaskOverViewGroup.Controls.Add(this.SeeOnGoingTasks);
            this.TaskOverViewGroup.Controls.Add(this.SeePrivateTasks);
            this.TaskOverViewGroup.Controls.Add(this.SeePublicTasks);
            this.TaskOverViewGroup.Location = new System.Drawing.Point(15, 48);
            this.TaskOverViewGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TaskOverViewGroup.Name = "TaskOverViewGroup";
            this.TaskOverViewGroup.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TaskOverViewGroup.Size = new System.Drawing.Size(771, 331);
            this.TaskOverViewGroup.TabIndex = 2;
            this.TaskOverViewGroup.TabStop = false;
            this.TaskOverViewGroup.Text = "Task Overview:";
            // 
            // TaskView
            // 
            this.TaskView.AllowUserToAddRows = false;
            this.TaskView.AllowUserToDeleteRows = false;
            this.TaskView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.TaskView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TaskView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskTitle,
            this.Applications,
            this.ApplicationDeadline,
            this.AssignedStudent,
            this.StartDate,
            this.Deadline});
            this.TaskView.Location = new System.Drawing.Point(128, 25);
            this.TaskView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TaskView.MultiSelect = false;
            this.TaskView.Name = "TaskView";
            this.TaskView.ReadOnly = true;
            this.TaskView.RowTemplate.Height = 24;
            this.TaskView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TaskView.Size = new System.Drawing.Size(592, 286);
            this.TaskView.TabIndex = 9;
            // 
            // SeeAllTasks
            // 
            this.SeeAllTasks.Location = new System.Drawing.Point(7, 167);
            this.SeeAllTasks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeeAllTasks.Name = "SeeAllTasks";
            this.SeeAllTasks.Size = new System.Drawing.Size(93, 28);
            this.SeeAllTasks.TabIndex = 7;
            this.SeeAllTasks.Text = "All";
            this.SeeAllTasks.UseVisualStyleBackColor = true;
            this.SeeAllTasks.Click += new System.EventHandler(this.SeeAllTasks_Click);
            // 
            // SeeCompletedTasks
            // 
            this.SeeCompletedTasks.Location = new System.Drawing.Point(7, 134);
            this.SeeCompletedTasks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeeCompletedTasks.Name = "SeeCompletedTasks";
            this.SeeCompletedTasks.Size = new System.Drawing.Size(93, 28);
            this.SeeCompletedTasks.TabIndex = 6;
            this.SeeCompletedTasks.Text = "Completed";
            this.SeeCompletedTasks.UseVisualStyleBackColor = true;
            this.SeeCompletedTasks.Click += new System.EventHandler(this.SeeCompletedTasks_Click);
            // 
            // SeeOnGoingTasks
            // 
            this.SeeOnGoingTasks.Location = new System.Drawing.Point(7, 100);
            this.SeeOnGoingTasks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeeOnGoingTasks.Name = "SeeOnGoingTasks";
            this.SeeOnGoingTasks.Size = new System.Drawing.Size(93, 28);
            this.SeeOnGoingTasks.TabIndex = 5;
            this.SeeOnGoingTasks.Text = "Ongoing";
            this.SeeOnGoingTasks.UseVisualStyleBackColor = true;
            this.SeeOnGoingTasks.Click += new System.EventHandler(this.SeeOnGoingTasks_Click);
            // 
            // SeePrivateTasks
            // 
            this.SeePrivateTasks.Location = new System.Drawing.Point(7, 66);
            this.SeePrivateTasks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeePrivateTasks.Name = "SeePrivateTasks";
            this.SeePrivateTasks.Size = new System.Drawing.Size(93, 28);
            this.SeePrivateTasks.TabIndex = 4;
            this.SeePrivateTasks.Text = "Private";
            this.SeePrivateTasks.UseVisualStyleBackColor = true;
            this.SeePrivateTasks.Click += new System.EventHandler(this.SeePrivateTasks_Click);
            // 
            // SeePublicTasks
            // 
            this.SeePublicTasks.Location = new System.Drawing.Point(7, 31);
            this.SeePublicTasks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeePublicTasks.Name = "SeePublicTasks";
            this.SeePublicTasks.Size = new System.Drawing.Size(93, 28);
            this.SeePublicTasks.TabIndex = 3;
            this.SeePublicTasks.Text = "Public";
            this.SeePublicTasks.UseVisualStyleBackColor = true;
            this.SeePublicTasks.Click += new System.EventHandler(this.SeePublicTasks_Click);
            // 
            // ViewTask
            // 
            this.ViewTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewTask.Location = new System.Drawing.Point(579, 391);
            this.ViewTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ViewTask.Name = "ViewTask";
            this.ViewTask.Size = new System.Drawing.Size(156, 46);
            this.ViewTask.TabIndex = 10;
            this.ViewTask.Text = "View Task";
            this.ViewTask.UseVisualStyleBackColor = true;
            this.ViewTask.Click += new System.EventHandler(this.ViewTask_Click);
            // 
            // SMENotificationBtn
            // 
            this.SMENotificationBtn.Location = new System.Drawing.Point(613, 14);
            this.SMENotificationBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SMENotificationBtn.Name = "SMENotificationBtn";
            this.SMENotificationBtn.Size = new System.Drawing.Size(121, 28);
            this.SMENotificationBtn.TabIndex = 1;
            this.SMENotificationBtn.Text = "Notifications (0)";
            this.SMENotificationBtn.UseVisualStyleBackColor = true;
            this.SMENotificationBtn.Click += new System.EventHandler(this.SMENotificationBtn_Click);
            // 
            // TaskTitle
            // 
            this.TaskTitle.Frozen = true;
            this.TaskTitle.HeaderText = "Task Title";
            this.TaskTitle.Name = "TaskTitle";
            this.TaskTitle.ReadOnly = true;
            // 
            // Applications
            // 
            this.Applications.Frozen = true;
            this.Applications.HeaderText = "Applications";
            this.Applications.Name = "Applications";
            this.Applications.ReadOnly = true;
            this.Applications.Visible = false;
            // 
            // ApplicationDeadline
            // 
            this.ApplicationDeadline.Frozen = true;
            this.ApplicationDeadline.HeaderText = "Application Deadline";
            this.ApplicationDeadline.Name = "ApplicationDeadline";
            this.ApplicationDeadline.ReadOnly = true;
            this.ApplicationDeadline.Visible = false;
            // 
            // AssignedStudent
            // 
            this.AssignedStudent.Frozen = true;
            this.AssignedStudent.HeaderText = "Assigned Student";
            this.AssignedStudent.Name = "AssignedStudent";
            this.AssignedStudent.ReadOnly = true;
            this.AssignedStudent.Visible = false;
            // 
            // StartDate
            // 
            this.StartDate.Frozen = true;
            this.StartDate.HeaderText = "Start Date";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            // 
            // Deadline
            // 
            this.Deadline.Frozen = true;
            this.Deadline.HeaderText = "Deadline";
            this.Deadline.Name = "Deadline";
            this.Deadline.ReadOnly = true;
            this.Deadline.Visible = false;
            // 
            // SMELandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SMENotificationBtn);
            this.Controls.Add(this.Create_New_Task);
            this.Controls.Add(this.ViewTask);
            this.Controls.Add(this.TaskOverViewGroup);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SMELandingPage";
            this.Text = "SMELandingPage";
            this.TaskOverViewGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TaskView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Create_New_Task;
        private System.Windows.Forms.GroupBox TaskOverViewGroup;
        private System.Windows.Forms.DataGridView TaskView;
        private System.Windows.Forms.Button ViewTask;
        private System.Windows.Forms.Button SeeAllTasks;
        private System.Windows.Forms.Button SeeCompletedTasks;
        private System.Windows.Forms.Button SeeOnGoingTasks;
        private System.Windows.Forms.Button SeePrivateTasks;
        private System.Windows.Forms.Button SeePublicTasks;
        private System.Windows.Forms.Button SMENotificationBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Applications;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApplicationDeadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignedStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deadline;
    }
}