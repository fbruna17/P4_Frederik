namespace P4Project.Frontend
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
            this.createTask = new System.Windows.Forms.Button();
            this.email = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // companyName
            // 
            this.companyName.Location = new System.Drawing.Point(253, 12);
            this.companyName.Multiline = true;
            this.companyName.Name = "companyName";
            this.companyName.ReadOnly = true;
            this.companyName.Size = new System.Drawing.Size(309, 32);
            this.companyName.TabIndex = 0;
            // 
            // createTask
            // 
            this.createTask.Location = new System.Drawing.Point(592, 91);
            this.createTask.Name = "createTask";
            this.createTask.Size = new System.Drawing.Size(115, 23);
            this.createTask.TabIndex = 2;
            this.createTask.Text = "Create Task";
            this.createTask.UseVisualStyleBackColor = true;
            this.createTask.Click += new System.EventHandler(this.createTask_Click);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(65, 91);
            this.email.Multiline = true;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Size = new System.Drawing.Size(100, 22);
            this.email.TabIndex = 1;
            // 
            // SMEProfileView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createTask);
            this.Controls.Add(this.email);
            this.Controls.Add(this.companyName);
            this.Name = "SMEProfileView";
            this.Text = "SMEProfileView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox companyName;
        private System.Windows.Forms.Button createTask;
        private System.Windows.Forms.TextBox email;
    }
}