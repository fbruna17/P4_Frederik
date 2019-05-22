﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P4Project.Backend.Classes;
using P4Project.Backend.Recommendation;
using MySql.Data.MySqlClient;

namespace P4Project.Frontend
{
    public partial class Search : Form
    {
        private List<TaskSearched> taskResults { get; set; }
        private StudentLoggedIn ThisStudent { get; }

        private string Query;
        public Search(StudentLoggedIn thisStudent)
        {
            InitializeComponent();
            ThisStudent = thisStudent;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SQLControl SQL = new SQLControl();
            Query = SearchBox.Text;
            SearchResultGrid.Rows.Clear();

            // The results of all tasks are found:
            taskResults = SQL.SearchTasks(Query, CheckSearchType());
            // The commendation is initialized with the results and the Student:
            RecMaker recommender = new RecMaker(ThisStudent, taskResults);
            List<TaskRecommend> recTasks = recommender.RecommendTasks(true);

            foreach (TaskSearched task in taskResults)
            {
                List<TaskRecommend> tasks = recTasks.Where(t => t.ID == task.ID).ToList();
                if (tasks.Count > 0)
                {
                    TaskRecommend tTask = tasks[0];
                    task.GetSMEName();
                    SearchResultGrid.Rows.Add(task.Title, tTask.RecommendScore.ToString(), task.SMEName, task.ApplicationDeadline.ToShortDateString(), task.Startdate.ToShortDateString(), task.EstCompletionDate.ToShortDateString());
                }
            }
            SearchResultGrid.Visible = true;
        }

        private int CheckSearchType()
        {
            int i;
            if (rbtnTitle.Checked)
            {
                i = 1;
            }
            else if (rbtnCompanies.Checked)
            {
                i = 2;
            }
            else
            {
                i = 3;
            }
            return i;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ViewTask_Click(object sender, EventArgs e)
        {
            TaskDetailed thisTask;
            try
            {
                thisTask = GetTask();
                var tView = new TaskView(thisTask, ThisStudent);
                Close();
                tView.ShowDialog();

            }
            catch(MySqlException ex)
            {
                MessageBox.Show("There was an error in the database while trying to look up this task! Please try again later, or contact system administrators!\n" + ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("An unexpected error occured... Please Contact System Administrator! \n" + ex.Message);
            }
        }

        private TaskDetailed GetTask()
        {
            SQLControl sql = new SQLControl();
            string taskname = SearchResultGrid.SelectedCells[0].Value.ToString();
            TaskSearched tTask = taskResults.Single(t => t.Title == taskname);
            TaskDetailed thisTask = sql.FetchTaskDetailed(tTask.ID);
            if (int.TryParse(SearchResultGrid.SelectedCells[1].Value.ToString(), out int i))
            {
                thisTask.RecScore = i;
            }
            else throw new Exception();
            return thisTask;
        }
    }
}
