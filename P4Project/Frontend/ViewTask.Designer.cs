namespace P4Project.Frontend
{
    partial class ViewTask
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
            this.TaskViewDescription = new System.Windows.Forms.RichTextBox();
            this.grpPractical = new System.Windows.Forms.GroupBox();
            this.grp1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(111, 49);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(53, 17);
            this.lblCompanyName.TabIndex = 0;
            this.lblCompanyName.Text = "reeeee";
            // 
            // grp1
            // 
            this.grp1.Controls.Add(this.TaskViewDescription);
            this.grp1.Controls.Add(this.lblCompanyName);
            this.grp1.Location = new System.Drawing.Point(46, 72);
            this.grp1.Name = "grp1";
            this.grp1.Size = new System.Drawing.Size(282, 344);
            this.grp1.TabIndex = 0;
            this.grp1.TabStop = false;
            // 
            // TaskViewDescription
            // 
            this.TaskViewDescription.Location = new System.Drawing.Point(6, 161);
            this.TaskViewDescription.Name = "TaskViewDescription";
            this.TaskViewDescription.Size = new System.Drawing.Size(270, 177);
            this.TaskViewDescription.TabIndex = 1;
            this.TaskViewDescription.Text = "";
            // 
            // grpPractical
            // 
            this.grpPractical.Location = new System.Drawing.Point(393, 72);
            this.grpPractical.Name = "grpPractical";
            this.grpPractical.Size = new System.Drawing.Size(395, 344);
            this.grpPractical.TabIndex = 1;
            this.grpPractical.TabStop = false;
            // 
            // ViewTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpPractical);
            this.Controls.Add(this.grp1);
            this.Name = "ViewTask";
            this.Text = "ViewTask";
            this.grp1.ResumeLayout(false);
            this.grp1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.GroupBox grp1;
        private System.Windows.Forms.RichTextBox TaskViewDescription;
        private System.Windows.Forms.GroupBox grpPractical;
    }
}