﻿namespace P4Project.Frontend
{
    partial class CreateTask
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblSkillReq = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.lblAppDeadline = new System.Windows.Forms.Label();
            this.ReqSkillList = new System.Windows.Forms.ListView();
            this.AddSkillButton = new System.Windows.Forms.Button();
            this.lblTaskDesc = new System.Windows.Forms.Label();
            this.txtTaskDesc = new System.Windows.Forms.TextBox();
            this.RemoteCheck = new System.Windows.Forms.CheckBox();
            this.btnSubmitTask = new System.Windows.Forms.Button();
            this.AddSkillReqList = new System.Windows.Forms.CheckedListBox();
            this.btnConfirmSkillAdd = new System.Windows.Forms.Button();
            this.ClearSkillsButton = new System.Windows.Forms.Button();
            this.lblStartDeadline = new System.Windows.Forms.Label();
            this.lblCompletionDate = new System.Windows.Forms.Label();
            this.ApplicationDeadlinePicker = new System.Windows.Forms.DateTimePicker();
            this.StartDeadlinePicker = new System.Windows.Forms.DateTimePicker();
            this.CompDeadlinePicker = new System.Windows.Forms.DateTimePicker();
            this.StateGroupBox = new System.Windows.Forms.GroupBox();
            this.PrivateStateRadio = new System.Windows.Forms.RadioButton();
            this.PublicStateRadio = new System.Windows.Forms.RadioButton();
            this.StateGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(131, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(35, 17);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(104, 75);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(62, 17);
            this.lblLocation.TabIndex = 1;
            this.lblLocation.Text = "Location";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(120, 110);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(46, 17);
            this.lblHours.TabIndex = 2;
            this.lblHours.Text = "Hours";
            // 
            // lblSkillReq
            // 
            this.lblSkillReq.AutoSize = true;
            this.lblSkillReq.Location = new System.Drawing.Point(64, 142);
            this.lblSkillReq.Name = "lblSkillReq";
            this.lblSkillReq.Size = new System.Drawing.Size(102, 17);
            this.lblSkillReq.TabIndex = 3;
            this.lblSkillReq.Text = "Required Skills";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(184, 38);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 22);
            this.txtTitle.TabIndex = 4;
            this.txtTitle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(184, 71);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(100, 22);
            this.txtLocation.TabIndex = 5;
            this.txtLocation.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(184, 106);
            this.txtHours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(100, 22);
            this.txtHours.TabIndex = 6;
            // 
            // lblAppDeadline
            // 
            this.lblAppDeadline.AutoSize = true;
            this.lblAppDeadline.Location = new System.Drawing.Point(579, 38);
            this.lblAppDeadline.Name = "lblAppDeadline";
            this.lblAppDeadline.Size = new System.Drawing.Size(141, 17);
            this.lblAppDeadline.TabIndex = 8;
            this.lblAppDeadline.Text = "Application Deadline:";
            // 
            // ReqSkillList
            // 
            this.ReqSkillList.Location = new System.Drawing.Point(184, 142);
            this.ReqSkillList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReqSkillList.Name = "ReqSkillList";
            this.ReqSkillList.Size = new System.Drawing.Size(121, 98);
            this.ReqSkillList.TabIndex = 9;
            this.ReqSkillList.UseCompatibleStateImageBehavior = false;
            // 
            // AddSkillButton
            // 
            this.AddSkillButton.Location = new System.Drawing.Point(311, 142);
            this.AddSkillButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddSkillButton.Name = "AddSkillButton";
            this.AddSkillButton.Size = new System.Drawing.Size(72, 23);
            this.AddSkillButton.TabIndex = 10;
            this.AddSkillButton.Text = "Add";
            this.AddSkillButton.UseVisualStyleBackColor = true;
            this.AddSkillButton.Click += new System.EventHandler(this.AddSkillButton_Click);
            // 
            // lblTaskDesc
            // 
            this.lblTaskDesc.AutoSize = true;
            this.lblTaskDesc.Location = new System.Drawing.Point(12, 290);
            this.lblTaskDesc.Name = "lblTaskDesc";
            this.lblTaskDesc.Size = new System.Drawing.Size(79, 17);
            this.lblTaskDesc.TabIndex = 11;
            this.lblTaskDesc.Text = "Description";
            // 
            // txtTaskDesc
            // 
            this.txtTaskDesc.Location = new System.Drawing.Point(15, 310);
            this.txtTaskDesc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTaskDesc.Name = "txtTaskDesc";
            this.txtTaskDesc.Size = new System.Drawing.Size(289, 22);
            this.txtTaskDesc.TabIndex = 12;
            // 
            // RemoteCheck
            // 
            this.RemoteCheck.AutoSize = true;
            this.RemoteCheck.Location = new System.Drawing.Point(311, 75);
            this.RemoteCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemoteCheck.Name = "RemoteCheck";
            this.RemoteCheck.Size = new System.Drawing.Size(112, 21);
            this.RemoteCheck.TabIndex = 13;
            this.RemoteCheck.Text = "Remote work";
            this.RemoteCheck.UseVisualStyleBackColor = true;
            // 
            // btnSubmitTask
            // 
            this.btnSubmitTask.Location = new System.Drawing.Point(647, 382);
            this.btnSubmitTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmitTask.Name = "btnSubmitTask";
            this.btnSubmitTask.Size = new System.Drawing.Size(141, 57);
            this.btnSubmitTask.TabIndex = 14;
            this.btnSubmitTask.Text = "Continue";
            this.btnSubmitTask.UseVisualStyleBackColor = true;
            this.btnSubmitTask.Click += new System.EventHandler(this.btnSubmitTask_Click);
            // 
            // AddSkillReqList
            // 
            this.AddSkillReqList.FormattingEnabled = true;
            this.AddSkillReqList.Location = new System.Drawing.Point(389, 142);
            this.AddSkillReqList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddSkillReqList.Name = "AddSkillReqList";
            this.AddSkillReqList.Size = new System.Drawing.Size(128, 174);
            this.AddSkillReqList.TabIndex = 15;
            this.AddSkillReqList.Visible = false;
            // 
            // btnConfirmSkillAdd
            // 
            this.btnConfirmSkillAdd.Location = new System.Drawing.Point(443, 329);
            this.btnConfirmSkillAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmSkillAdd.Name = "btnConfirmSkillAdd";
            this.btnConfirmSkillAdd.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmSkillAdd.TabIndex = 16;
            this.btnConfirmSkillAdd.Text = "Confirm";
            this.btnConfirmSkillAdd.UseVisualStyleBackColor = true;
            this.btnConfirmSkillAdd.Visible = false;
            this.btnConfirmSkillAdd.Click += new System.EventHandler(this.btnConfirmSkillAdd_Click);
            // 
            // ClearSkillsButton
            // 
            this.ClearSkillsButton.Location = new System.Drawing.Point(311, 171);
            this.ClearSkillsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClearSkillsButton.Name = "ClearSkillsButton";
            this.ClearSkillsButton.Size = new System.Drawing.Size(72, 23);
            this.ClearSkillsButton.TabIndex = 17;
            this.ClearSkillsButton.Text = "Clear";
            this.ClearSkillsButton.UseVisualStyleBackColor = true;
            this.ClearSkillsButton.Click += new System.EventHandler(this.ClearSkillsButton_Click);
            // 
            // lblStartDeadline
            // 
            this.lblStartDeadline.AutoSize = true;
            this.lblStartDeadline.Location = new System.Drawing.Point(579, 111);
            this.lblStartDeadline.Name = "lblStartDeadline";
            this.lblStartDeadline.Size = new System.Drawing.Size(102, 17);
            this.lblStartDeadline.TabIndex = 18;
            this.lblStartDeadline.Text = "Start Deadline:";
            // 
            // lblCompletionDate
            // 
            this.lblCompletionDate.AutoSize = true;
            this.lblCompletionDate.Location = new System.Drawing.Point(579, 177);
            this.lblCompletionDate.Name = "lblCompletionDate";
            this.lblCompletionDate.Size = new System.Drawing.Size(182, 17);
            this.lblCompletionDate.TabIndex = 19;
            this.lblCompletionDate.Text = "Estimated Completion Date:";
            // 
            // ApplicationDeadlinePicker
            // 
            this.ApplicationDeadlinePicker.Location = new System.Drawing.Point(581, 62);
            this.ApplicationDeadlinePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ApplicationDeadlinePicker.Name = "ApplicationDeadlinePicker";
            this.ApplicationDeadlinePicker.Size = new System.Drawing.Size(200, 22);
            this.ApplicationDeadlinePicker.TabIndex = 20;
            // 
            // StartDeadlinePicker
            // 
            this.StartDeadlinePicker.Location = new System.Drawing.Point(581, 132);
            this.StartDeadlinePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartDeadlinePicker.Name = "StartDeadlinePicker";
            this.StartDeadlinePicker.Size = new System.Drawing.Size(200, 22);
            this.StartDeadlinePicker.TabIndex = 21;
            // 
            // CompDeadlinePicker
            // 
            this.CompDeadlinePicker.Location = new System.Drawing.Point(581, 198);
            this.CompDeadlinePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CompDeadlinePicker.Name = "CompDeadlinePicker";
            this.CompDeadlinePicker.Size = new System.Drawing.Size(200, 22);
            this.CompDeadlinePicker.TabIndex = 22;
            // 
            // StateGroupBox
            // 
            this.StateGroupBox.Controls.Add(this.PublicStateRadio);
            this.StateGroupBox.Controls.Add(this.PrivateStateRadio);
            this.StateGroupBox.Location = new System.Drawing.Point(582, 245);
            this.StateGroupBox.Name = "StateGroupBox";
            this.StateGroupBox.Size = new System.Drawing.Size(99, 87);
            this.StateGroupBox.TabIndex = 23;
            this.StateGroupBox.TabStop = false;
            // 
            // PrivateStateRadio
            // 
            this.PrivateStateRadio.AutoSize = true;
            this.PrivateStateRadio.Checked = true;
            this.PrivateStateRadio.Location = new System.Drawing.Point(7, 22);
            this.PrivateStateRadio.Name = "PrivateStateRadio";
            this.PrivateStateRadio.Size = new System.Drawing.Size(73, 21);
            this.PrivateStateRadio.TabIndex = 0;
            this.PrivateStateRadio.TabStop = true;
            this.PrivateStateRadio.Text = "Private";
            this.PrivateStateRadio.UseVisualStyleBackColor = true;
            // 
            // PublicStateRadio
            // 
            this.PublicStateRadio.AutoSize = true;
            this.PublicStateRadio.Location = new System.Drawing.Point(7, 54);
            this.PublicStateRadio.Name = "PublicStateRadio";
            this.PublicStateRadio.Size = new System.Drawing.Size(67, 21);
            this.PublicStateRadio.TabIndex = 1;
            this.PublicStateRadio.Text = "Public";
            this.PublicStateRadio.UseVisualStyleBackColor = true;
            // 
            // CreateTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StateGroupBox);
            this.Controls.Add(this.CompDeadlinePicker);
            this.Controls.Add(this.StartDeadlinePicker);
            this.Controls.Add(this.ApplicationDeadlinePicker);
            this.Controls.Add(this.lblCompletionDate);
            this.Controls.Add(this.lblStartDeadline);
            this.Controls.Add(this.ClearSkillsButton);
            this.Controls.Add(this.btnConfirmSkillAdd);
            this.Controls.Add(this.AddSkillReqList);
            this.Controls.Add(this.btnSubmitTask);
            this.Controls.Add(this.RemoteCheck);
            this.Controls.Add(this.txtTaskDesc);
            this.Controls.Add(this.lblTaskDesc);
            this.Controls.Add(this.AddSkillButton);
            this.Controls.Add(this.ReqSkillList);
            this.Controls.Add(this.lblAppDeadline);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblSkillReq);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreateTask";
            this.Text = "CreateTask";
            this.Load += new System.EventHandler(this.CreateTask_Load);
            this.StateGroupBox.ResumeLayout(false);
            this.StateGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblSkillReq;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Label lblAppDeadline;
        private System.Windows.Forms.ListView ReqSkillList;
        private System.Windows.Forms.Button AddSkillButton;
        private System.Windows.Forms.Label lblTaskDesc;
        private System.Windows.Forms.TextBox txtTaskDesc;
        private System.Windows.Forms.CheckBox RemoteCheck;
        private System.Windows.Forms.Button btnSubmitTask;
        private System.Windows.Forms.CheckedListBox AddSkillReqList;
        private System.Windows.Forms.Button btnConfirmSkillAdd;
        private System.Windows.Forms.Button ClearSkillsButton;
        private System.Windows.Forms.Label lblStartDeadline;
        private System.Windows.Forms.Label lblCompletionDate;
        private System.Windows.Forms.DateTimePicker ApplicationDeadlinePicker;
        private System.Windows.Forms.DateTimePicker StartDeadlinePicker;
        private System.Windows.Forms.DateTimePicker CompDeadlinePicker;
        private System.Windows.Forms.GroupBox StateGroupBox;
        private System.Windows.Forms.RadioButton PublicStateRadio;
        private System.Windows.Forms.RadioButton PrivateStateRadio;
    }
}