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
            this.Match = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskSMEName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskAppDeadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbtnSkills = new System.Windows.Forms.RadioButton();
            this.rbtnCompanies = new System.Windows.Forms.RadioButton();
            this.rbtnTitle = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Back = new System.Windows.Forms.Button();
            this.ViewTask = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SearchResultGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(122, 49);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(244, 20);
            this.SearchBox.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(372, 49);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 20);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // SearchResultGrid
            // 
            this.SearchResultGrid.AllowUserToResizeColumns = false;
            this.SearchResultGrid.AllowUserToResizeRows = false;
            this.SearchResultGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SearchResultGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.SearchResultGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.SearchResultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchResultGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskTitle,
            this.Match,
            this.TaskSMEName,
            this.TaskAppDeadline,
            this.TaskStartDate,
            this.TaskEndDate});
            this.SearchResultGrid.Location = new System.Drawing.Point(44, 259);
            this.SearchResultGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchResultGrid.MultiSelect = false;
            this.SearchResultGrid.Name = "SearchResultGrid";
            this.SearchResultGrid.ReadOnly = true;
            this.SearchResultGrid.RowTemplate.Height = 24;
            this.SearchResultGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SearchResultGrid.Size = new System.Drawing.Size(719, 150);
            this.SearchResultGrid.TabIndex = 2;
            this.SearchResultGrid.Visible = false;
            // 
            // TaskTitle
            // 
            this.TaskTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TaskTitle.HeaderText = "Title";
            this.TaskTitle.Name = "TaskTitle";
            this.TaskTitle.ReadOnly = true;
            this.TaskTitle.Width = 180;
            // 
            // Match
            // 
            this.Match.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Match.HeaderText = "Match";
            this.Match.Name = "Match";
            this.Match.ReadOnly = true;
            this.Match.Width = 50;
            // 
            // TaskSMEName
            // 
            this.TaskSMEName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TaskSMEName.HeaderText = "Owner";
            this.TaskSMEName.Name = "TaskSMEName";
            this.TaskSMEName.ReadOnly = true;
            this.TaskSMEName.Width = 150;
            // 
            // TaskAppDeadline
            // 
            this.TaskAppDeadline.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TaskAppDeadline.HeaderText = "Application Deadline";
            this.TaskAppDeadline.Name = "TaskAppDeadline";
            this.TaskAppDeadline.ReadOnly = true;
            this.TaskAppDeadline.Width = 180;
            // 
            // TaskStartDate
            // 
            this.TaskStartDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TaskStartDate.HeaderText = "Start Date";
            this.TaskStartDate.Name = "TaskStartDate";
            this.TaskStartDate.ReadOnly = true;
            this.TaskStartDate.Width = 180;
            // 
            // TaskEndDate
            // 
            this.TaskEndDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TaskEndDate.HeaderText = "Est. Completion Date";
            this.TaskEndDate.Name = "TaskEndDate";
            this.TaskEndDate.ReadOnly = true;
            this.TaskEndDate.Width = 180;
            // 
            // rbtnSkills
            // 
            this.rbtnSkills.AutoSize = true;
            this.rbtnSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSkills.Location = new System.Drawing.Point(199, 37);
            this.rbtnSkills.Name = "rbtnSkills";
            this.rbtnSkills.Size = new System.Drawing.Size(95, 17);
            this.rbtnSkills.TabIndex = 3;
            this.rbtnSkills.Text = "Required Skills";
            this.rbtnSkills.UseVisualStyleBackColor = true;
            // 
            // rbtnCompanies
            // 
            this.rbtnCompanies.AutoSize = true;
            this.rbtnCompanies.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCompanies.Location = new System.Drawing.Point(72, 37);
            this.rbtnCompanies.Name = "rbtnCompanies";
            this.rbtnCompanies.Size = new System.Drawing.Size(100, 17);
            this.rbtnCompanies.TabIndex = 2;
            this.rbtnCompanies.Text = "Company Name";
            this.rbtnCompanies.UseVisualStyleBackColor = true;
            // 
            // rbtnTitle
            // 
            this.rbtnTitle.AutoSize = true;
            this.rbtnTitle.Checked = true;
            this.rbtnTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTitle.Location = new System.Drawing.Point(6, 37);
            this.rbtnTitle.Name = "rbtnTitle";
            this.rbtnTitle.Size = new System.Drawing.Size(45, 17);
            this.rbtnTitle.TabIndex = 1;
            this.rbtnTitle.TabStop = true;
            this.rbtnTitle.Text = "Title";
            this.rbtnTitle.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnSkills);
            this.groupBox1.Controls.Add(this.rbtnTitle);
            this.groupBox1.Controls.Add(this.rbtnCompanies);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(122, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 84);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search tasks based on:";
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(122, 184);
            this.Back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(90, 30);
            this.Back.TabIndex = 5;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // ViewTask
            // 
            this.ViewTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewTask.Location = new System.Drawing.Point(216, 184);
            this.ViewTask.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ViewTask.Name = "ViewTask";
            this.ViewTask.Size = new System.Drawing.Size(90, 30);
            this.ViewTask.TabIndex = 6;
            this.ViewTask.Text = "View Task";
            this.ViewTask.UseVisualStyleBackColor = true;
            this.ViewTask.Click += new System.EventHandler(this.ViewTask_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ViewTask);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SearchResultGrid);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.SearchBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Search";
            this.Text = "Search";
            ((System.ComponentModel.ISupportInitialize)(this.SearchResultGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView SearchResultGrid;
        private System.Windows.Forms.RadioButton rbtnSkills;
        private System.Windows.Forms.RadioButton rbtnCompanies;
        private System.Windows.Forms.RadioButton rbtnTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button ViewTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Match;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskSMEName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskAppDeadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskEndDate;
    }
}
