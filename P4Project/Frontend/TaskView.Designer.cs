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
            this.CompanyNameLabel = new System.Windows.Forms.Label();
            this.TaskDescriptionBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PracticalInfoBox = new System.Windows.Forms.GroupBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.RecSkills = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DateBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DescriptionBox.SuspendLayout();
            this.PracticalInfoBox.SuspendLayout();
            this.DateBox.SuspendLayout();
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
            this.DescriptionBox.Location = new System.Drawing.Point(92, 91);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(282, 347);
            this.DescriptionBox.TabIndex = 1;
            this.DescriptionBox.TabStop = false;
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
            // TaskDescriptionBox
            // 
            this.TaskDescriptionBox.Location = new System.Drawing.Point(10, 92);
            this.TaskDescriptionBox.Name = "TaskDescriptionBox";
            this.TaskDescriptionBox.ReadOnly = true;
            this.TaskDescriptionBox.Size = new System.Drawing.Size(266, 249);
            this.TaskDescriptionBox.TabIndex = 1;
            this.TaskDescriptionBox.Text = "";
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
            // PracticalInfoBox
            // 
            this.PracticalInfoBox.Controls.Add(this.DateBox);
            this.PracticalInfoBox.Controls.Add(this.label3);
            this.PracticalInfoBox.Controls.Add(this.RecSkills);
            this.PracticalInfoBox.Controls.Add(this.Label2);
            this.PracticalInfoBox.Location = new System.Drawing.Point(409, 91);
            this.PracticalInfoBox.Name = "PracticalInfoBox";
            this.PracticalInfoBox.Size = new System.Drawing.Size(353, 347);
            this.PracticalInfoBox.TabIndex = 2;
            this.PracticalInfoBox.TabStop = false;
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
            // RecSkills
            // 
            this.RecSkills.FormattingEnabled = true;
            this.RecSkills.ItemHeight = 16;
            this.RecSkills.Location = new System.Drawing.Point(7, 92);
            this.RecSkills.Name = "RecSkills";
            this.RecSkills.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.RecSkills.Size = new System.Drawing.Size(120, 84);
            this.RecSkills.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Required Skills:";
            // 
            // DateBox
            // 
            this.DateBox.Controls.Add(this.label4);
            this.DateBox.Location = new System.Drawing.Point(176, 52);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(162, 149);
            this.DateBox.TabIndex = 3;
            this.DateBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Deadlines:";
            // 
            // TaskView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PracticalInfoBox);
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
    }
}