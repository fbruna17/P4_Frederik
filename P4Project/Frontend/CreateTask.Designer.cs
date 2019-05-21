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
            this.StateGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownHours)).BeginInit();
            this.EditSkillsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SkillSetGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(9, 27);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(9, 57);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(48, 13);
            this.lblLocation.TabIndex = 1;
            this.lblLocation.Text = "Location";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(9, 86);
            this.lblHours.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(35, 13);
            this.lblHours.TabIndex = 2;
            this.lblHours.Text = "Hours";
            // 
            // lblSkillReq
            // 
            this.lblSkillReq.AutoSize = true;
            this.lblSkillReq.Location = new System.Drawing.Point(9, 111);
            this.lblSkillReq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSkillReq.Name = "lblSkillReq";
            this.lblSkillReq.Size = new System.Drawing.Size(77, 13);
            this.lblSkillReq.TabIndex = 3;
            this.lblSkillReq.Text = "Required Skills";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(99, 27);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(131, 20);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblAppDeadline
            // 
            this.lblAppDeadline.AutoSize = true;
            this.lblAppDeadline.Location = new System.Drawing.Point(434, 31);
            this.lblAppDeadline.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAppDeadline.Name = "lblAppDeadline";
            this.lblAppDeadline.Size = new System.Drawing.Size(107, 13);
            this.lblAppDeadline.TabIndex = 8;
            this.lblAppDeadline.Text = "Application Deadline:";
            // 
            // lblTaskDesc
            // 
            this.lblTaskDesc.AutoSize = true;
            this.lblTaskDesc.Location = new System.Drawing.Point(9, 236);
            this.lblTaskDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTaskDesc.Name = "lblTaskDesc";
            this.lblTaskDesc.Size = new System.Drawing.Size(60, 13);
            this.lblTaskDesc.TabIndex = 11;
            this.lblTaskDesc.Text = "Description";
            // 
            // btnSubmitTask
            // 
            this.btnSubmitTask.Location = new System.Drawing.Point(525, 302);
            this.btnSubmitTask.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmitTask.Name = "btnSubmitTask";
            this.btnSubmitTask.Size = new System.Drawing.Size(106, 46);
            this.btnSubmitTask.TabIndex = 15;
            this.btnSubmitTask.Text = "Continue";
            this.btnSubmitTask.UseVisualStyleBackColor = true;
            this.btnSubmitTask.Click += new System.EventHandler(this.btnSubmitTask_Click);
            // 
            // lblStartDeadline
            // 
            this.lblStartDeadline.AutoSize = true;
            this.lblStartDeadline.Location = new System.Drawing.Point(434, 90);
            this.lblStartDeadline.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartDeadline.Name = "lblStartDeadline";
            this.lblStartDeadline.Size = new System.Drawing.Size(77, 13);
            this.lblStartDeadline.TabIndex = 18;
            this.lblStartDeadline.Text = "Start Deadline:";
            // 
            // lblCompletionDate
            // 
            this.lblCompletionDate.AutoSize = true;
            this.lblCompletionDate.Location = new System.Drawing.Point(434, 144);
            this.lblCompletionDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompletionDate.Name = "lblCompletionDate";
            this.lblCompletionDate.Size = new System.Drawing.Size(137, 13);
            this.lblCompletionDate.TabIndex = 19;
            this.lblCompletionDate.Text = "Estimated Completion Date:";
            // 
            // ApplicationDeadlinePicker
            // 
            this.ApplicationDeadlinePicker.Location = new System.Drawing.Point(436, 50);
            this.ApplicationDeadlinePicker.Margin = new System.Windows.Forms.Padding(2);
            this.ApplicationDeadlinePicker.Name = "ApplicationDeadlinePicker";
            this.ApplicationDeadlinePicker.Size = new System.Drawing.Size(195, 20);
            this.ApplicationDeadlinePicker.TabIndex = 9;
            // 
            // StartDeadlinePicker
            // 
            this.StartDeadlinePicker.Location = new System.Drawing.Point(436, 107);
            this.StartDeadlinePicker.Margin = new System.Windows.Forms.Padding(2);
            this.StartDeadlinePicker.Name = "StartDeadlinePicker";
            this.StartDeadlinePicker.Size = new System.Drawing.Size(195, 20);
            this.StartDeadlinePicker.TabIndex = 10;
            // 
            // CompDeadlinePicker
            // 
            this.CompDeadlinePicker.Location = new System.Drawing.Point(436, 161);
            this.CompDeadlinePicker.Margin = new System.Windows.Forms.Padding(2);
            this.CompDeadlinePicker.Name = "CompDeadlinePicker";
            this.CompDeadlinePicker.Size = new System.Drawing.Size(195, 20);
            this.CompDeadlinePicker.TabIndex = 11;
            // 
            // StateGroupBox
            // 
            this.StateGroupBox.Controls.Add(this.PublicStateRadio);
            this.StateGroupBox.Controls.Add(this.PrivateStateRadio);
            this.StateGroupBox.Location = new System.Drawing.Point(436, 200);
            this.StateGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.StateGroupBox.Name = "StateGroupBox";
            this.StateGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.StateGroupBox.Size = new System.Drawing.Size(195, 71);
            this.StateGroupBox.TabIndex = 12;
            this.StateGroupBox.TabStop = false;
            // 
            // PublicStateRadio
            // 
            this.PublicStateRadio.AutoSize = true;
            this.PublicStateRadio.Location = new System.Drawing.Point(5, 44);
            this.PublicStateRadio.Margin = new System.Windows.Forms.Padding(2);
            this.PublicStateRadio.Name = "PublicStateRadio";
            this.PublicStateRadio.Size = new System.Drawing.Size(154, 17);
            this.PublicStateRadio.TabIndex = 14;
            this.PublicStateRadio.TabStop = true;
            this.PublicStateRadio.Text = "Public (Students can apply)";
            this.PublicStateRadio.UseVisualStyleBackColor = true;
            // 
            // PrivateStateRadio
            // 
            this.PrivateStateRadio.AutoSize = true;
            this.PrivateStateRadio.Checked = true;
            this.PrivateStateRadio.Location = new System.Drawing.Point(5, 18);
            this.PrivateStateRadio.Margin = new System.Windows.Forms.Padding(2);
            this.PrivateStateRadio.Name = "PrivateStateRadio";
            this.PrivateStateRadio.Size = new System.Drawing.Size(185, 17);
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
            this.listLocation.Location = new System.Drawing.Point(99, 54);
            this.listLocation.Name = "listLocation";
            this.listLocation.Size = new System.Drawing.Size(131, 21);
            this.listLocation.TabIndex = 2;
            // 
            // richTaskDesc
            // 
            this.richTaskDesc.Location = new System.Drawing.Point(12, 252);
            this.richTaskDesc.Name = "richTaskDesc";
            this.richTaskDesc.Size = new System.Drawing.Size(218, 96);
            this.richTaskDesc.TabIndex = 4;
            this.richTaskDesc.Text = "";
            // 
            // UpDownHours
            // 
            this.UpDownHours.Location = new System.Drawing.Point(99, 86);
            this.UpDownHours.Name = "UpDownHours";
            this.UpDownHours.Size = new System.Drawing.Size(130, 20);
            this.UpDownHours.TabIndex = 3;
            // 
            // EditSkillsBox
            // 
            this.EditSkillsBox.Controls.Add(this.SkillDropDown);
            this.EditSkillsBox.Controls.Add(this.RemoveSkill);
            this.EditSkillsBox.Controls.Add(this.AddSkill);
            this.EditSkillsBox.Location = new System.Drawing.Point(249, 57);
            this.EditSkillsBox.Margin = new System.Windows.Forms.Padding(2);
            this.EditSkillsBox.Name = "EditSkillsBox";
            this.EditSkillsBox.Padding = new System.Windows.Forms.Padding(2);
            this.EditSkillsBox.Size = new System.Drawing.Size(164, 102);
            this.EditSkillsBox.TabIndex = 5;
            this.EditSkillsBox.TabStop = false;
            // 
            // SkillDropDown
            // 
            this.SkillDropDown.FormattingEnabled = true;
            this.SkillDropDown.Location = new System.Drawing.Point(19, 56);
            this.SkillDropDown.Margin = new System.Windows.Forms.Padding(2);
            this.SkillDropDown.Name = "SkillDropDown";
            this.SkillDropDown.Size = new System.Drawing.Size(126, 21);
            this.SkillDropDown.TabIndex = 6;
            // 
            // RemoveSkill
            // 
            this.RemoveSkill.Location = new System.Drawing.Point(4, 17);
            this.RemoveSkill.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveSkill.Name = "RemoveSkill";
            this.RemoveSkill.Size = new System.Drawing.Size(74, 26);
            this.RemoveSkill.TabIndex = 8;
            this.RemoveSkill.Text = "Remove Skill";
            this.RemoveSkill.UseVisualStyleBackColor = true;
            this.RemoveSkill.Click += new System.EventHandler(this.RemoveSkill_Click);
            // 
            // AddSkill
            // 
            this.AddSkill.Location = new System.Drawing.Point(86, 17);
            this.AddSkill.Margin = new System.Windows.Forms.Padding(2);
            this.AddSkill.Name = "AddSkill";
            this.AddSkill.Size = new System.Drawing.Size(74, 26);
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
            this.SkillSetGrid.Location = new System.Drawing.Point(99, 111);
            this.SkillSetGrid.Margin = new System.Windows.Forms.Padding(2);
            this.SkillSetGrid.MultiSelect = false;
            this.SkillSetGrid.Name = "SkillSetGrid";
            this.SkillSetGrid.ReadOnly = true;
            this.SkillSetGrid.RowTemplate.Height = 24;
            this.SkillSetGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SkillSetGrid.Size = new System.Drawing.Size(130, 119);
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
            this.label1.Location = new System.Drawing.Point(253, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Required Skills For This Task";
            // 
            // CreateTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 384);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreateTask";
            this.Text = "CreateTask";
            this.Load += new System.EventHandler(this.CreateTask_Load);
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
    }
}