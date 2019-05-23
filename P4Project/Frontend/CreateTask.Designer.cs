namespace P4Project.Frontend
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
            this.lblAppDeadline = new System.Windows.Forms.Label();
            this.lblTaskDesc = new System.Windows.Forms.Label();
            this.btnSubmitTask = new System.Windows.Forms.Button();
            this.lblStartDeadline = new System.Windows.Forms.Label();
            this.lblCompletionDate = new System.Windows.Forms.Label();
            this.ApplicationDeadlinePicker = new System.Windows.Forms.DateTimePicker();
            this.StartDeadlinePicker = new System.Windows.Forms.DateTimePicker();
            this.CompDeadlinePicker = new System.Windows.Forms.DateTimePicker();
            this.StateGroupBox = new System.Windows.Forms.GroupBox();
            this.PublicStateRadio = new System.Windows.Forms.RadioButton();
            this.PrivateStateRadio = new System.Windows.Forms.RadioButton();
            this.listLocation = new System.Windows.Forms.ComboBox();
            this.richTaskDesc = new System.Windows.Forms.RichTextBox();
            this.UpDownHours = new System.Windows.Forms.NumericUpDown();
            this.EditSkillsBox = new System.Windows.Forms.GroupBox();
            this.SkillDropDown = new System.Windows.Forms.ComboBox();
            this.RemoveSkill = new System.Windows.Forms.Button();
            this.AddSkill = new System.Windows.Forms.Button();
            this.SkillSetGrid = new System.Windows.Forms.DataGridView();
            this.SkillName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.StateGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownHours)).BeginInit();
            this.EditSkillsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SkillSetGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(35, 17);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(12, 70);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(62, 17);
            this.lblLocation.TabIndex = 1;
            this.lblLocation.Text = "Location";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(12, 106);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(46, 17);
            this.lblHours.TabIndex = 2;
            this.lblHours.Text = "Hours";
            // 
            // lblSkillReq
            // 
            this.lblSkillReq.AutoSize = true;
            this.lblSkillReq.Location = new System.Drawing.Point(12, 137);
            this.lblSkillReq.Name = "lblSkillReq";
            this.lblSkillReq.Size = new System.Drawing.Size(102, 17);
            this.lblSkillReq.TabIndex = 3;
            this.lblSkillReq.Text = "Required Skills";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(132, 33);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(173, 22);
            this.txtTitle.TabIndex = 1;
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
            // lblTaskDesc
            // 
            this.lblTaskDesc.AutoSize = true;
            this.lblTaskDesc.Location = new System.Drawing.Point(12, 290);
            this.lblTaskDesc.Name = "lblTaskDesc";
            this.lblTaskDesc.Size = new System.Drawing.Size(79, 17);
            this.lblTaskDesc.TabIndex = 11;
            this.lblTaskDesc.Text = "Description";
            // 
            // btnSubmitTask
            // 
            this.btnSubmitTask.Location = new System.Drawing.Point(700, 372);
            this.btnSubmitTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmitTask.Name = "btnSubmitTask";
            this.btnSubmitTask.Size = new System.Drawing.Size(141, 57);
            this.btnSubmitTask.TabIndex = 15;
            this.btnSubmitTask.Text = "Continue";
            this.btnSubmitTask.UseVisualStyleBackColor = true;
            this.btnSubmitTask.Click += new System.EventHandler(this.btnSubmitTask_Click);
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
            this.ApplicationDeadlinePicker.Size = new System.Drawing.Size(259, 22);
            this.ApplicationDeadlinePicker.TabIndex = 9;
            // 
            // StartDeadlinePicker
            // 
            this.StartDeadlinePicker.Location = new System.Drawing.Point(581, 132);
            this.StartDeadlinePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartDeadlinePicker.Name = "StartDeadlinePicker";
            this.StartDeadlinePicker.Size = new System.Drawing.Size(259, 22);
            this.StartDeadlinePicker.TabIndex = 10;
            // 
            // CompDeadlinePicker
            // 
            this.CompDeadlinePicker.Location = new System.Drawing.Point(581, 198);
            this.CompDeadlinePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CompDeadlinePicker.Name = "CompDeadlinePicker";
            this.CompDeadlinePicker.Size = new System.Drawing.Size(259, 22);
            this.CompDeadlinePicker.TabIndex = 11;
            // 
            // StateGroupBox
            // 
            this.StateGroupBox.Controls.Add(this.PublicStateRadio);
            this.StateGroupBox.Controls.Add(this.PrivateStateRadio);
            this.StateGroupBox.Location = new System.Drawing.Point(581, 246);
            this.StateGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StateGroupBox.Name = "StateGroupBox";
            this.StateGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StateGroupBox.Size = new System.Drawing.Size(260, 87);
            this.StateGroupBox.TabIndex = 12;
            this.StateGroupBox.TabStop = false;
            // 
            // PublicStateRadio
            // 
            this.PublicStateRadio.AutoSize = true;
            this.PublicStateRadio.Location = new System.Drawing.Point(7, 54);
            this.PublicStateRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PublicStateRadio.Name = "PublicStateRadio";
            this.PublicStateRadio.Size = new System.Drawing.Size(202, 21);
            this.PublicStateRadio.TabIndex = 14;
            this.PublicStateRadio.TabStop = true;
            this.PublicStateRadio.Text = "Public (Students can apply)";
            this.PublicStateRadio.UseVisualStyleBackColor = true;
            // 
            // PrivateStateRadio
            // 
            this.PrivateStateRadio.AutoSize = true;
            this.PrivateStateRadio.Checked = true;
            this.PrivateStateRadio.Location = new System.Drawing.Point(7, 22);
            this.PrivateStateRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PrivateStateRadio.Name = "PrivateStateRadio";
            this.PrivateStateRadio.Size = new System.Drawing.Size(242, 21);
            this.PrivateStateRadio.TabIndex = 13;
            this.PrivateStateRadio.TabStop = true;
            this.PrivateStateRadio.Text = "Private (Students can\'t see/apply)";
            this.PrivateStateRadio.UseVisualStyleBackColor = true;
            // 
            // listLocation
            // 
            this.listLocation.FormattingEnabled = true;
            this.listLocation.Items.AddRange(new object[] {
            "Aalborg",
            "Århus",
            "Copenhagen",
            "Esbjerg",
            "Odense",
            "Roskilde",
            "Remote Work"});
            this.listLocation.Location = new System.Drawing.Point(132, 66);
            this.listLocation.Margin = new System.Windows.Forms.Padding(4);
            this.listLocation.Name = "listLocation";
            this.listLocation.Size = new System.Drawing.Size(173, 24);
            this.listLocation.TabIndex = 2;
            // 
            // richTaskDesc
            // 
            this.richTaskDesc.Location = new System.Drawing.Point(16, 310);
            this.richTaskDesc.Margin = new System.Windows.Forms.Padding(4);
            this.richTaskDesc.Name = "richTaskDesc";
            this.richTaskDesc.Size = new System.Drawing.Size(289, 117);
            this.richTaskDesc.TabIndex = 4;
            this.richTaskDesc.Text = "";
            // 
            // UpDownHours
            // 
            this.UpDownHours.Location = new System.Drawing.Point(132, 106);
            this.UpDownHours.Margin = new System.Windows.Forms.Padding(4);
            this.UpDownHours.Name = "UpDownHours";
            this.UpDownHours.Size = new System.Drawing.Size(173, 22);
            this.UpDownHours.TabIndex = 3;
            // 
            // EditSkillsBox
            // 
            this.EditSkillsBox.Controls.Add(this.SkillDropDown);
            this.EditSkillsBox.Controls.Add(this.RemoveSkill);
            this.EditSkillsBox.Controls.Add(this.AddSkill);
            this.EditSkillsBox.Location = new System.Drawing.Point(332, 70);
            this.EditSkillsBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditSkillsBox.Name = "EditSkillsBox";
            this.EditSkillsBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditSkillsBox.Size = new System.Drawing.Size(219, 126);
            this.EditSkillsBox.TabIndex = 5;
            this.EditSkillsBox.TabStop = false;
            // 
            // SkillDropDown
            // 
            this.SkillDropDown.FormattingEnabled = true;
            this.SkillDropDown.Location = new System.Drawing.Point(25, 69);
            this.SkillDropDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SkillDropDown.Name = "SkillDropDown";
            this.SkillDropDown.Size = new System.Drawing.Size(167, 24);
            this.SkillDropDown.TabIndex = 6;
            // 
            // RemoveSkill
            // 
            this.RemoveSkill.Location = new System.Drawing.Point(5, 21);
            this.RemoveSkill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemoveSkill.Name = "RemoveSkill";
            this.RemoveSkill.Size = new System.Drawing.Size(99, 32);
            this.RemoveSkill.TabIndex = 8;
            this.RemoveSkill.Text = "Remove Skill";
            this.RemoveSkill.UseVisualStyleBackColor = true;
            this.RemoveSkill.Click += new System.EventHandler(this.RemoveSkill_Click);
            // 
            // AddSkill
            // 
            this.AddSkill.Location = new System.Drawing.Point(115, 21);
            this.AddSkill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddSkill.Name = "AddSkill";
            this.AddSkill.Size = new System.Drawing.Size(99, 32);
            this.AddSkill.TabIndex = 7;
            this.AddSkill.Text = "Add Skill";
            this.AddSkill.UseVisualStyleBackColor = true;
            this.AddSkill.Click += new System.EventHandler(this.AddSkill_Click);
            // 
            // SkillSetGrid
            // 
            this.SkillSetGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.SkillSetGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SkillSetGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SkillName});
            this.SkillSetGrid.Location = new System.Drawing.Point(132, 137);
            this.SkillSetGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SkillSetGrid.MultiSelect = false;
            this.SkillSetGrid.Name = "SkillSetGrid";
            this.SkillSetGrid.ReadOnly = true;
            this.SkillSetGrid.RowTemplate.Height = 24;
            this.SkillSetGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SkillSetGrid.Size = new System.Drawing.Size(173, 146);
            this.SkillSetGrid.TabIndex = 1;
            // 
            // SkillName
            // 
            this.SkillName.Frozen = true;
            this.SkillName.HeaderText = "Skill";
            this.SkillName.Name = "SkillName";
            this.SkillName.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Required Skills For This Task";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(522, 372);
            this.Back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(141, 57);
            this.Back.TabIndex = 30;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(340, 372);
            this.Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(141, 57);
            this.Delete.TabIndex = 31;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Visible = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // CreateTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 473);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SkillSetGrid);
            this.Controls.Add(this.EditSkillsBox);
            this.Controls.Add(this.UpDownHours);
            this.Controls.Add(this.richTaskDesc);
            this.Controls.Add(this.listLocation);
            this.Controls.Add(this.StateGroupBox);
            this.Controls.Add(this.CompDeadlinePicker);
            this.Controls.Add(this.StartDeadlinePicker);
            this.Controls.Add(this.ApplicationDeadlinePicker);
            this.Controls.Add(this.lblCompletionDate);
            this.Controls.Add(this.lblStartDeadline);
            this.Controls.Add(this.btnSubmitTask);
            this.Controls.Add(this.lblTaskDesc);
            this.Controls.Add(this.lblAppDeadline);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblSkillReq);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblLocation);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreateTask";
            this.Text = "CreateTask";
            this.StateGroupBox.ResumeLayout(false);
            this.StateGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownHours)).EndInit();
            this.EditSkillsBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SkillSetGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblSkillReq;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblAppDeadline;
        private System.Windows.Forms.Label lblTaskDesc;
        private System.Windows.Forms.Button btnSubmitTask;
        private System.Windows.Forms.Label lblStartDeadline;
        private System.Windows.Forms.Label lblCompletionDate;
        private System.Windows.Forms.DateTimePicker ApplicationDeadlinePicker;
        private System.Windows.Forms.DateTimePicker StartDeadlinePicker;
        private System.Windows.Forms.DateTimePicker CompDeadlinePicker;
        private System.Windows.Forms.GroupBox StateGroupBox;
        private System.Windows.Forms.RadioButton PublicStateRadio;
        private System.Windows.Forms.RadioButton PrivateStateRadio;
        private System.Windows.Forms.ComboBox listLocation;
        private System.Windows.Forms.RichTextBox richTaskDesc;
        private System.Windows.Forms.NumericUpDown UpDownHours;
        private System.Windows.Forms.GroupBox EditSkillsBox;
        private System.Windows.Forms.ComboBox SkillDropDown;
        private System.Windows.Forms.Button RemoveSkill;
        private System.Windows.Forms.Button AddSkill;
        private System.Windows.Forms.DataGridView SkillSetGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn SkillName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Delete;
    }
}