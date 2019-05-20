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
            this.ReqSkillList = new System.Windows.Forms.ListView();
            this.AddSkillButton = new System.Windows.Forms.Button();
            this.lblTaskDesc = new System.Windows.Forms.Label();
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
            this.PublicStateRadio = new System.Windows.Forms.RadioButton();
            this.PrivateStateRadio = new System.Windows.Forms.RadioButton();
            this.listLocation = new System.Windows.Forms.ComboBox();
            this.richTaskDesc = new System.Windows.Forms.RichTextBox();
            this.UpDownHours = new System.Windows.Forms.NumericUpDown();
            this.StateGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownHours)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(98, 33);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(78, 61);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(48, 13);
            this.lblLocation.TabIndex = 1;
            this.lblLocation.Text = "Location";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(90, 89);
            this.lblHours.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(35, 13);
            this.lblHours.TabIndex = 2;
            this.lblHours.Text = "Hours";
            // 
            // lblSkillReq
            // 
            this.lblSkillReq.AutoSize = true;
            this.lblSkillReq.Location = new System.Drawing.Point(48, 115);
            this.lblSkillReq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSkillReq.Name = "lblSkillReq";
            this.lblSkillReq.Size = new System.Drawing.Size(77, 13);
            this.lblSkillReq.TabIndex = 3;
            this.lblSkillReq.Text = "Required Skills";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(138, 31);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(92, 20);
            this.txtTitle.TabIndex = 4;
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
            // ReqSkillList
            // 
            this.ReqSkillList.Location = new System.Drawing.Point(138, 115);
            this.ReqSkillList.Margin = new System.Windows.Forms.Padding(2);
            this.ReqSkillList.Name = "ReqSkillList";
            this.ReqSkillList.Size = new System.Drawing.Size(92, 80);
            this.ReqSkillList.TabIndex = 9;
            this.ReqSkillList.UseCompatibleStateImageBehavior = false;
            // 
            // AddSkillButton
            // 
            this.AddSkillButton.Location = new System.Drawing.Point(233, 115);
            this.AddSkillButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddSkillButton.Name = "AddSkillButton";
            this.AddSkillButton.Size = new System.Drawing.Size(54, 19);
            this.AddSkillButton.TabIndex = 10;
            this.AddSkillButton.Text = "Add";
            this.AddSkillButton.UseVisualStyleBackColor = true;
            this.AddSkillButton.Click += new System.EventHandler(this.AddSkillButton_Click);
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
            this.btnSubmitTask.Location = new System.Drawing.Point(485, 310);
            this.btnSubmitTask.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmitTask.Name = "btnSubmitTask";
            this.btnSubmitTask.Size = new System.Drawing.Size(106, 46);
            this.btnSubmitTask.TabIndex = 14;
            this.btnSubmitTask.Text = "Continue";
            this.btnSubmitTask.UseVisualStyleBackColor = true;
            this.btnSubmitTask.Click += new System.EventHandler(this.btnSubmitTask_Click);
            // 
            // AddSkillReqList
            // 
            this.AddSkillReqList.FormattingEnabled = true;
            this.AddSkillReqList.Location = new System.Drawing.Point(292, 115);
            this.AddSkillReqList.Margin = new System.Windows.Forms.Padding(2);
            this.AddSkillReqList.Name = "AddSkillReqList";
            this.AddSkillReqList.Size = new System.Drawing.Size(97, 139);
            this.AddSkillReqList.TabIndex = 15;
            this.AddSkillReqList.Visible = false;
            // 
            // btnConfirmSkillAdd
            // 
            this.btnConfirmSkillAdd.Location = new System.Drawing.Point(332, 267);
            this.btnConfirmSkillAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmSkillAdd.Name = "btnConfirmSkillAdd";
            this.btnConfirmSkillAdd.Size = new System.Drawing.Size(56, 19);
            this.btnConfirmSkillAdd.TabIndex = 16;
            this.btnConfirmSkillAdd.Text = "Confirm";
            this.btnConfirmSkillAdd.UseVisualStyleBackColor = true;
            this.btnConfirmSkillAdd.Visible = false;
            this.btnConfirmSkillAdd.Click += new System.EventHandler(this.btnConfirmSkillAdd_Click);
            // 
            // ClearSkillsButton
            // 
            this.ClearSkillsButton.Location = new System.Drawing.Point(233, 139);
            this.ClearSkillsButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClearSkillsButton.Name = "ClearSkillsButton";
            this.ClearSkillsButton.Size = new System.Drawing.Size(54, 19);
            this.ClearSkillsButton.TabIndex = 17;
            this.ClearSkillsButton.Text = "Clear";
            this.ClearSkillsButton.UseVisualStyleBackColor = true;
            this.ClearSkillsButton.Click += new System.EventHandler(this.ClearSkillsButton_Click);
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
            this.ApplicationDeadlinePicker.Size = new System.Drawing.Size(151, 20);
            this.ApplicationDeadlinePicker.TabIndex = 20;
            // 
            // StartDeadlinePicker
            // 
            this.StartDeadlinePicker.Location = new System.Drawing.Point(436, 107);
            this.StartDeadlinePicker.Margin = new System.Windows.Forms.Padding(2);
            this.StartDeadlinePicker.Name = "StartDeadlinePicker";
            this.StartDeadlinePicker.Size = new System.Drawing.Size(151, 20);
            this.StartDeadlinePicker.TabIndex = 21;
            // 
            // CompDeadlinePicker
            // 
            this.CompDeadlinePicker.Location = new System.Drawing.Point(436, 161);
            this.CompDeadlinePicker.Margin = new System.Windows.Forms.Padding(2);
            this.CompDeadlinePicker.Name = "CompDeadlinePicker";
            this.CompDeadlinePicker.Size = new System.Drawing.Size(151, 20);
            this.CompDeadlinePicker.TabIndex = 22;
            // 
            // StateGroupBox
            // 
            this.StateGroupBox.Controls.Add(this.PublicStateRadio);
            this.StateGroupBox.Controls.Add(this.PrivateStateRadio);
            this.StateGroupBox.Location = new System.Drawing.Point(436, 199);
            this.StateGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.StateGroupBox.Name = "StateGroupBox";
            this.StateGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.StateGroupBox.Size = new System.Drawing.Size(74, 71);
            this.StateGroupBox.TabIndex = 23;
            this.StateGroupBox.TabStop = false;
            // 
            // PublicStateRadio
            // 
            this.PublicStateRadio.AutoSize = true;
            this.PublicStateRadio.Location = new System.Drawing.Point(5, 44);
            this.PublicStateRadio.Margin = new System.Windows.Forms.Padding(2);
            this.PublicStateRadio.Name = "PublicStateRadio";
            this.PublicStateRadio.Size = new System.Drawing.Size(54, 17);
            this.PublicStateRadio.TabIndex = 1;
            this.PublicStateRadio.Text = "Public";
            this.PublicStateRadio.UseVisualStyleBackColor = true;
            // 
            // PrivateStateRadio
            // 
            this.PrivateStateRadio.AutoSize = true;
            this.PrivateStateRadio.Checked = true;
            this.PrivateStateRadio.Location = new System.Drawing.Point(5, 18);
            this.PrivateStateRadio.Margin = new System.Windows.Forms.Padding(2);
            this.PrivateStateRadio.Name = "PrivateStateRadio";
            this.PrivateStateRadio.Size = new System.Drawing.Size(58, 17);
            this.PrivateStateRadio.TabIndex = 0;
            this.PrivateStateRadio.TabStop = true;
            this.PrivateStateRadio.Text = "Private";
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
            this.listLocation.Location = new System.Drawing.Point(138, 58);
            this.listLocation.Name = "listLocation";
            this.listLocation.Size = new System.Drawing.Size(92, 21);
            this.listLocation.TabIndex = 24;
            // 
            // richTaskDesc
            // 
            this.richTaskDesc.Location = new System.Drawing.Point(12, 252);
            this.richTaskDesc.Name = "richTaskDesc";
            this.richTaskDesc.Size = new System.Drawing.Size(218, 96);
            this.richTaskDesc.TabIndex = 25;
            this.richTaskDesc.Text = "";
            // 
            // UpDownHours
            // 
            this.UpDownHours.Location = new System.Drawing.Point(138, 90);
            this.UpDownHours.Name = "UpDownHours";
            this.UpDownHours.Size = new System.Drawing.Size(92, 20);
            this.UpDownHours.TabIndex = 26;
            // 
            // CreateTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.UpDownHours);
            this.Controls.Add(this.richTaskDesc);
            this.Controls.Add(this.listLocation);
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
            this.Controls.Add(this.lblTaskDesc);
            this.Controls.Add(this.AddSkillButton);
            this.Controls.Add(this.ReqSkillList);
            this.Controls.Add(this.lblAppDeadline);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblSkillReq);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreateTask";
            this.Text = "CreateTask";
            this.Load += new System.EventHandler(this.CreateTask_Load);
            this.StateGroupBox.ResumeLayout(false);
            this.StateGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownHours)).EndInit();
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
        private System.Windows.Forms.ListView ReqSkillList;
        private System.Windows.Forms.Button AddSkillButton;
        private System.Windows.Forms.Label lblTaskDesc;
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
        private System.Windows.Forms.ComboBox listLocation;
        private System.Windows.Forms.RichTextBox richTaskDesc;
        private System.Windows.Forms.NumericUpDown UpDownHours;
    }
}