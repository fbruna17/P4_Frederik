namespace P4Project.Frontend
{
    partial class Search
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
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SearchResultGrid = new System.Windows.Forms.DataGridView();
            this.TaskTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskSMEName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskAppDeadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SearchResultGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(68, 40);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(177, 20);
            this.SearchBox.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(256, 40);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 19);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // SearchResultGrid
            // 
            this.SearchResultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchResultGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskTitle,
            this.TaskSMEName,
            this.TaskAppDeadline,
            this.TaskStartDate,
            this.TaskEndDate});
            this.SearchResultGrid.Location = new System.Drawing.Point(10, 113);
            this.SearchResultGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchResultGrid.Name = "SearchResultGrid";
            this.SearchResultGrid.ReadOnly = true;
            this.SearchResultGrid.RowTemplate.Height = 24;
            this.SearchResultGrid.Size = new System.Drawing.Size(561, 122);
            this.SearchResultGrid.TabIndex = 2;
            this.SearchResultGrid.Visible = false;
            // 
            // TaskTitle
            // 
            this.TaskTitle.HeaderText = "Title";
            this.TaskTitle.Name = "TaskTitle";
            this.TaskTitle.ReadOnly = true;
            // 
            // TaskSMEName
            // 
            this.TaskSMEName.HeaderText = "Owner";
            this.TaskSMEName.Name = "TaskSMEName";
            this.TaskSMEName.ReadOnly = true;
            // 
            // TaskAppDeadline
            // 
            this.TaskAppDeadline.HeaderText = "Application Deadline";
            this.TaskAppDeadline.Name = "TaskAppDeadline";
            this.TaskAppDeadline.ReadOnly = true;
            // 
            // TaskStartDate
            // 
            this.TaskStartDate.HeaderText = "Start Date";
            this.TaskStartDate.Name = "TaskStartDate";
            this.TaskStartDate.ReadOnly = true;
            // 
            // TaskEndDate
            // 
            this.TaskEndDate.HeaderText = "Est. Completion Date";
            this.TaskEndDate.Name = "TaskEndDate";
            this.TaskEndDate.ReadOnly = true;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.SearchResultGrid);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.SearchBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Search";
            this.Text = "Search";
            ((System.ComponentModel.ISupportInitialize)(this.SearchResultGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView SearchResultGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskSMEName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskAppDeadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskEndDate;
    }
}