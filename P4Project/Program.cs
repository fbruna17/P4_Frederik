using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using P4Project.Backend.Classes;
using P4Project.Frontend;

namespace P4Project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
       //     SQLControl sql = new SQLControl();
       //     StudentDetailed stud = sql.FetchStudentDetailed(51);
       //     StudentLoggedIn student = new StudentLoggedIn("LTest", "12345678", stud);



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LandingPage());
        }
    }
}
