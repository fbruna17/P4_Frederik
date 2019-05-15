namespace P4Project.Frontend
{
    partial class TaskPreview
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
            this.lblTaskPreviewTitle = new System.Windows.Forms.Label();
            this.grp1 = new System.Windows.Forms.GroupBox();
            this.lblTaskViewDesc = new System.Windows.Forms.Label();
            this.txtTaskViewDescription = new System.Windows.Forms.RichTextBox();
            this.lblTaskPreviewSMEName = new System.Windows.Forms.Label();
            this.grpTaskPreviewPractical = new System.Windows.Forms.GroupBox();
            this.lblPracticalTitle = new System.Windows.Forms.Label();
            this.grp1.SuspendLayout();
            this.grpTaskPreviewPractical.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTaskPreviewTitle
            // 
            this.lblTaskPreviewTitle.AutoSize = true;
            this.lblTaskPreviewTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskPreviewTitle.Location = new System.Drawing.Point(108, 17);
            this.lblTaskPreviewTitle.Name = "lblTaskPreviewTitle";
            this.lblTaskPreviewTitle.Size = new System.Drawing.Size(66, 31);
            this.lblTaskPreviewTitle.TabIndex = 0;
            this.lblTaskPreviewTitle.Text = "Title";
            // 
            // grp1
            // 
            this.grp1.Controls.Add(this.lblTaskViewDesc);
            this.grp1.Controls.Add(this.txtTaskViewDescription);
            this.grp1.Controls.Add(this.lblTaskPreviewTitle);
            this.grp1.Location = new System.Drawing.Point(45, 71);
            this.grp1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp1.Name = "grp1";
            this.grp1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp1.Size = new System.Drawing.Size(283, 308);
            this.grp1.TabIndex = 0;
            this.grp1.TabStop = false;
            // 
            // lblTaskViewDesc
            // 
            this.lblTaskViewDesc.AutoSize = true;
            this.lblTaskViewDesc.Location = new System.Drawing.Point(7, 94);
            this.lblTaskViewDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaskViewDesc.Name = "lblTaskViewDesc";
            this.lblTaskViewDesc.Size = new System.Drawing.Size(83, 17);
            this.lblTaskViewDesc.TabIndex = 2;
            this.lblTaskViewDesc.Text = "Description:";
            // 
            // txtTaskViewDescription
            // 
            this.txtTaskViewDescription.Location = new System.Drawing.Point(5, 112);
            this.txtTaskViewDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTaskViewDescription.Name = "txtTaskViewDescription";
            this.txtTaskViewDescription.Size = new System.Drawing.Size(271, 190);
            this.txtTaskViewDescription.TabIndex = 1;
            this.txtTaskViewDescription.Text = "";
            // 
            // lblTaskPreviewSMEName
            // 
            this.lblTaskPreviewSMEName.AutoSize = true;
            this.lblTaskPreviewSMEName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskPreviewSMEName.Location = new System.Drawing.Point(251, 11);
            this.lblTaskPreviewSMEName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaskPreviewSMEName.Name = "lblTaskPreviewSMEName";
            this.lblTaskPreviewSMEName.Size = new System.Drawing.Size(263, 39);
            this.lblTaskPreviewSMEName.TabIndex = 2;
            this.lblTaskPreviewSMEName.Text = "Company Name";
            // 
            // grpTaskPreviewPractical
            // 
            this.grpTaskPreviewPractical.Controls.Add(this.lblPracticalTitle);
            this.grpTaskPreviewPractical.Location = new System.Drawing.Point(393, 71);
            this.grpTaskPreviewPractical.Name = "grpTaskPreviewPractical";
            this.grpTaskPreviewPractical.Size = new System.Drawing.Size(395, 308);
            this.grpTaskPreviewPractical.TabIndex = 3;
            this.grpTaskPreviewPractical.TabStop = false;
            // 
            // lblPracticalTitle
            // 
            this.lblPracticalTitle.AutoSize = true;
            this.lblPracticalTitle.Location = new System.Drawing.Point(188, 17);
            this.lblPracticalTitle.Name = "lblPracticalTitle";
            this.lblPracticalTitle.Size = new System.Drawing.Size(46, 17);
            this.lblPracticalTitle.TabIndex = 0;
            this.lblPracticalTitle.Text = "label1";
            // 
            // TaskPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpTaskPreviewPractical);
            this.Controls.Add(this.lblTaskPreviewSMEName);
            this.Controls.Add(this.grp1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TaskPreview";
            this.Text = "ViewTask";
            this.grp1.ResumeLayout(false);
            this.grp1.PerformLayout();
            this.grpTaskPreviewPractical.ResumeLayout(false);
            this.grpTaskPreviewPractical.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTaskPreviewTitle;
        private System.Windows.Forms.GroupBox grp1;
        private System.Windows.Forms.RichTextBox txtTaskViewDescription;
        private System.Windows.Forms.Label lblTaskViewDesc;
        private System.Windows.Forms.Label lblTaskPreviewSMEName;
        private System.Windows.Forms.GroupBox grpTaskPreviewPractical;
        private System.Windows.Forms.Label lblPracticalTitle;
    }
}