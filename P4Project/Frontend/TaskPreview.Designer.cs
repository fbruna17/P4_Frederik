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
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.grp1 = new System.Windows.Forms.GroupBox();
            this.lblTaskViewDesc = new System.Windows.Forms.Label();
            this.txtTaskViewDescription = new System.Windows.Forms.RichTextBox();
            this.lblTaskPreviewSMEName = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(31, 15);
            this.lblCompanyName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(146, 26);
            this.lblCompanyName.TabIndex = 0;
            this.lblCompanyName.Text = "No title added";
            // 
            // grp1
            // 
            this.grp1.Controls.Add(this.lblTaskViewDesc);
            this.grp1.Controls.Add(this.txtTaskViewDescription);
            this.grp1.Controls.Add(this.lblCompanyName);
            this.grp1.Location = new System.Drawing.Point(34, 58);
            this.grp1.Margin = new System.Windows.Forms.Padding(2);
            this.grp1.Name = "grp1";
            this.grp1.Padding = new System.Windows.Forms.Padding(2);
            this.grp1.Size = new System.Drawing.Size(212, 250);
            this.grp1.TabIndex = 0;
            this.grp1.TabStop = false;
            // 
            // lblTaskViewDesc
            // 
            this.lblTaskViewDesc.AutoSize = true;
            this.lblTaskViewDesc.Location = new System.Drawing.Point(5, 76);
            this.lblTaskViewDesc.Name = "lblTaskViewDesc";
            this.lblTaskViewDesc.Size = new System.Drawing.Size(63, 13);
            this.lblTaskViewDesc.TabIndex = 2;
            this.lblTaskViewDesc.Text = "Description:";
            // 
            // txtTaskViewDescription
            // 
            this.txtTaskViewDescription.Location = new System.Drawing.Point(4, 91);
            this.txtTaskViewDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtTaskViewDescription.Name = "txtTaskViewDescription";
            this.txtTaskViewDescription.Size = new System.Drawing.Size(204, 155);
            this.txtTaskViewDescription.TabIndex = 1;
            this.txtTaskViewDescription.Text = "";
            // 
            // lblTaskPreviewSMEName
            // 
            this.lblTaskPreviewSMEName.AutoSize = true;
            this.lblTaskPreviewSMEName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskPreviewSMEName.Location = new System.Drawing.Point(188, 9);
            this.lblTaskPreviewSMEName.Name = "lblTaskPreviewSMEName";
            this.lblTaskPreviewSMEName.Size = new System.Drawing.Size(209, 31);
            this.lblTaskPreviewSMEName.TabIndex = 2;
            this.lblTaskPreviewSMEName.Text = "Company Name";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(286, 58);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitContainer1.Size = new System.Drawing.Size(302, 246);
            this.splitContainer1.SplitterDistance = 45;
            this.splitContainer1.TabIndex = 3;
            // 
            // TaskPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.lblTaskPreviewSMEName);
            this.Controls.Add(this.grp1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TaskPreview";
            this.Text = "ViewTask";
            this.grp1.ResumeLayout(false);
            this.grp1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.GroupBox grp1;
        private System.Windows.Forms.RichTextBox txtTaskViewDescription;
        private System.Windows.Forms.Label lblTaskViewDesc;
        private System.Windows.Forms.Label lblTaskPreviewSMEName;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}