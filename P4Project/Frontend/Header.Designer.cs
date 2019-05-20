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
            this.HeaderSideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSidebarHome = new System.Windows.Forms.Button();
            this.btnSidebarTask = new System.Windows.Forms.Button();
            this.btnSidebarLogOut = new System.Windows.Forms.Button();
            this.HeaderPanel.SuspendLayout();
            this.HeaderSideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HeaderPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.HeaderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeaderPanel.Controls.Add(this.lblNameInHeader);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.HeaderPanel.Size = new System.Drawing.Size(1067, 44);
            this.HeaderPanel.TabIndex = 0;
            // 
            // lblNameInHeader
            // 
            this.lblNameInHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNameInHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameInHeader.Location = new System.Drawing.Point(13, 12);
            this.lblNameInHeader.Margin = new System.Windows.Forms.Padding(0);
            this.lblNameInHeader.Name = "lblNameInHeader";
            this.lblNameInHeader.Size = new System.Drawing.Size(1039, 18);
            this.lblNameInHeader.TabIndex = 0;
            this.lblNameInHeader.Text = "Name";
            this.lblNameInHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeaderSideBar
            // 
            this.HeaderSideBar.AutoSize = true;
            this.HeaderSideBar.BackColor = System.Drawing.Color.Gainsboro;
            this.HeaderSideBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeaderSideBar.Controls.Add(this.btnSidebarHome);
            this.HeaderSideBar.Controls.Add(this.btnSidebarTask);
            this.HeaderSideBar.Controls.Add(this.btnSidebarLogOut);
            this.HeaderSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.HeaderSideBar.Location = new System.Drawing.Point(0, 44);
            this.HeaderSideBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HeaderSideBar.Name = "HeaderSideBar";
            this.HeaderSideBar.Size = new System.Drawing.Size(134, 510);
            this.HeaderSideBar.TabIndex = 1;
            // 
            // btnSidebarHome
            // 
            this.btnSidebarHome.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSidebarHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSidebarHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSidebarHome.Location = new System.Drawing.Point(0, 1);
            this.btnSidebarHome.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.btnSidebarHome.Name = "btnSidebarHome";
            this.btnSidebarHome.Size = new System.Drawing.Size(132, 28);
            this.btnSidebarHome.TabIndex = 0;
            this.btnSidebarHome.Text = "Home";
            this.btnSidebarHome.UseVisualStyleBackColor = false;
            // 
            // btnSidebarTask
            // 
            this.btnSidebarTask.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSidebarTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSidebarTask.Location = new System.Drawing.Point(0, 30);
            this.btnSidebarTask.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.btnSidebarTask.Name = "btnSidebarTask";
            this.btnSidebarTask.Size = new System.Drawing.Size(132, 28);
            this.btnSidebarTask.TabIndex = 1;
            this.btnSidebarTask.Text = "Task";
            this.btnSidebarTask.UseVisualStyleBackColor = false;
            this.btnSidebarTask.Click += new System.EventHandler(this.btnSidebarTask_Click);
            // 
            // btnSidebarLogOut
            // 
            this.btnSidebarLogOut.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSidebarLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSidebarLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSidebarLogOut.Location = new System.Drawing.Point(0, 59);
            this.btnSidebarLogOut.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.btnSidebarLogOut.Name = "btnSidebarLogOut";
            this.btnSidebarLogOut.Size = new System.Drawing.Size(132, 28);
            this.btnSidebarLogOut.TabIndex = 2;
            this.btnSidebarLogOut.Text = "Log Out";
            this.btnSidebarLogOut.UseVisualStyleBackColor = false;
            // 
            // Header
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.HeaderSideBar);
            this.Controls.Add(this.HeaderPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Header";
            this.Text = "Header";
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderSideBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label lblNameInHeader;
        private System.Windows.Forms.FlowLayoutPanel HeaderSideBar;
        private System.Windows.Forms.Button btnSidebarHome;
        private System.Windows.Forms.Button btnSidebarTask;
        private System.Windows.Forms.Button btnSidebarLogOut;
    }
}