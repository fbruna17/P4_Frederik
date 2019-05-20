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
        public Search()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SQLControl SQL = new SQLControl();

            string Query = SearchBox.Text;

            List<TaskSearched> TaskResults = SQL.SearchTasks(Query);

            foreach(TaskSearched t in TaskResults)
            {
                SearchResultGrid.Rows.Add(t.MakeDataViewString());
            }
        }
    }
}
