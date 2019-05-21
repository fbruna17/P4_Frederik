using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P4Project.Backend.Classes;

namespace P4Project.Frontend
{
    public partial class Search : Form
    {
        private string Query;
        public Search()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SQLControl SQL = new SQLControl();
            Query = SearchBox.Text;
            List<TaskSearched> TaskResults = new List<TaskSearched>();
            SearchResultGrid.Rows.Clear();

            TaskResults = SQL.SearchTasks(Query, CheckSearchType());

            foreach (TaskSearched t in TaskResults)
            {
                t.GetSMEName();
                SearchResultGrid.Rows.Add(t.MakeDataViewString());
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
    }
}
