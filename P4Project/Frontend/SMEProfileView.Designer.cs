﻿namespace P4Project.Frontend
{
    partial class SMEProfileView
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
            this.companyName = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.createTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // companyName
            // 
            this.companyName.Location = new System.Drawing.Point(190, 10);
            this.companyName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.companyName.Multiline = true;
            this.companyName.Name = "companyName";
            this.companyName.ReadOnly = true;
            this.companyName.Size = new System.Drawing.Size(233, 27);
            this.companyName.TabIndex = 0;
            this.companyName.TextChanged += new System.EventHandler(this.CompanyName_TextChanged);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(49, 74);
            this.email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.email.Multiline = true;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Size = new System.Drawing.Size(76, 19);
            this.email.TabIndex = 1;
            // 
            // createTask
            // 
            this.createTask.Location = new System.Drawing.Point(444, 74);
            this.createTask.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createTask.Name = "createTask";
            this.createTask.Size = new System.Drawing.Size(86, 19);
            this.createTask.TabIndex = 2;
            this.createTask.Text = "Create Task";
            this.createTask.UseVisualStyleBackColor = true;
            this.createTask.Click += new System.EventHandler(this.createTask_Click);
            // 
            // SMEProfileView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.createTask);
            this.Controls.Add(this.email);
            this.Controls.Add(this.companyName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SMEProfileView";
            this.Text = "SMEProfileView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox companyName;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Button createTask;
    }
}