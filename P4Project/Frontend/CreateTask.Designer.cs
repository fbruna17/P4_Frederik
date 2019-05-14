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
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.ReqSkillList = new System.Windows.Forms.ListView();
            this.AddSkillButton = new System.Windows.Forms.Button();
            this.lblTaskDesc = new System.Windows.Forms.Label();
            this.txtTaskDesc = new System.Windows.Forms.TextBox();
            this.RemoteCheck = new System.Windows.Forms.CheckBox();
            this.btnSubmitTask = new System.Windows.Forms.Button();
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
            this.lblHours.Location = new System.Drawing.Point(120, 109);
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
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 22);
            this.txtTitle.TabIndex = 4;
            this.txtTitle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(184, 72);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(100, 22);
            this.txtLocation.TabIndex = 5;
            this.txtLocation.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(184, 106);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(100, 22);
            this.txtHours.TabIndex = 6;
            // 
            // lblDeadline
            // 
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.Location = new System.Drawing.Point(599, 41);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(64, 17);
            this.lblDeadline.TabIndex = 8;
            this.lblDeadline.Text = "Deadline";
            // 
            // ReqSkillList
            // 
            this.ReqSkillList.Location = new System.Drawing.Point(184, 142);
            this.ReqSkillList.Name = "ReqSkillList";
            this.ReqSkillList.Size = new System.Drawing.Size(121, 97);
            this.ReqSkillList.TabIndex = 9;
            this.ReqSkillList.UseCompatibleStateImageBehavior = false;
            // 
            // AddSkillButton
            // 
            this.AddSkillButton.Location = new System.Drawing.Point(311, 216);
            this.AddSkillButton.Name = "AddSkillButton";
            this.AddSkillButton.Size = new System.Drawing.Size(49, 23);
            this.AddSkillButton.TabIndex = 10;
            this.AddSkillButton.Text = "Add";
            this.AddSkillButton.UseVisualStyleBackColor = true;
            // 
            // lblTaskDesc
            // 
            this.lblTaskDesc.AutoSize = true;
            this.lblTaskDesc.Location = new System.Drawing.Point(67, 289);
            this.lblTaskDesc.Name = "lblTaskDesc";
            this.lblTaskDesc.Size = new System.Drawing.Size(79, 17);
            this.lblTaskDesc.TabIndex = 11;
            this.lblTaskDesc.Text = "Description";
            // 
            // txtTaskDesc
            // 
            this.txtTaskDesc.Location = new System.Drawing.Point(70, 310);
            this.txtTaskDesc.Name = "txtTaskDesc";
            this.txtTaskDesc.Size = new System.Drawing.Size(290, 22);
            this.txtTaskDesc.TabIndex = 12;
            // 
            // RemoteCheck
            // 
            this.RemoteCheck.AutoSize = true;
            this.RemoteCheck.Location = new System.Drawing.Point(311, 75);
            this.RemoteCheck.Name = "RemoteCheck";
            this.RemoteCheck.Size = new System.Drawing.Size(112, 21);
            this.RemoteCheck.TabIndex = 13;
            this.RemoteCheck.Text = "Remote work";
            this.RemoteCheck.UseVisualStyleBackColor = true;
            // 
            // btnSubmitTask
            // 
            this.btnSubmitTask.Location = new System.Drawing.Point(647, 381);
            this.btnSubmitTask.Name = "btnSubmitTask";
            this.btnSubmitTask.Size = new System.Drawing.Size(141, 57);
            this.btnSubmitTask.TabIndex = 14;
            this.btnSubmitTask.Text = "Submit";
            this.btnSubmitTask.UseVisualStyleBackColor = true;
            this.btnSubmitTask.Click += new System.EventHandler(this.btnSubmitTask_Click);
            // 
            // CreateTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmitTask);
            this.Controls.Add(this.RemoteCheck);
            this.Controls.Add(this.txtTaskDesc);
            this.Controls.Add(this.lblTaskDesc);
            this.Controls.Add(this.AddSkillButton);
            this.Controls.Add(this.ReqSkillList);
            this.Controls.Add(this.lblDeadline);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblSkillReq);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblTitle);
            this.Name = "CreateTask";
            this.Text = "CreateTask";
            this.Load += new System.EventHandler(this.CreateTask_Load);
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
        private System.Windows.Forms.Label lblDeadline;
        private System.Windows.Forms.ListView ReqSkillList;
        private System.Windows.Forms.Button AddSkillButton;
        private System.Windows.Forms.Label lblTaskDesc;
        private System.Windows.Forms.TextBox txtTaskDesc;
        private System.Windows.Forms.CheckBox RemoteCheck;
        private System.Windows.Forms.Button btnSubmitTask;
    }
}