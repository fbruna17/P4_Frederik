namespace P4Project.Frontend
{
    partial class Header
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
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.lblNameInHeader = new System.Windows.Forms.Label();
            this.HeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HeaderPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.HeaderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeaderPanel.Controls.Add(this.lblNameInHeader);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Padding = new System.Windows.Forms.Padding(10);
            this.HeaderPanel.Size = new System.Drawing.Size(800, 42);
            this.HeaderPanel.TabIndex = 0;
            // 
            // lblNameInHeader
            // 
            this.lblNameInHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNameInHeader.Location = new System.Drawing.Point(10, 10);
            this.lblNameInHeader.Name = "lblNameInHeader";
            this.lblNameInHeader.Size = new System.Drawing.Size(778, 20);
            this.lblNameInHeader.TabIndex = 0;
            this.lblNameInHeader.Text = "label1";
            this.lblNameInHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Header
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HeaderPanel);
            this.Name = "Header";
            this.Text = "Header";
            this.HeaderPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label lblNameInHeader;
    }
}