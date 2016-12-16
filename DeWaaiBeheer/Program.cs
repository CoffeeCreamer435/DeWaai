using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeWaaiBeheer
{
    static class Program
    {
        public static frmCoursesPage courses = new frmCoursesPage();
        public static frmMyAccount account = new frmMyAccount();
        public static frmUsersPage users = new frmUsersPage();
        public static frmInstructorsPage instructors = new frmInstructorsPage();
        public static frmNewCourse newCourse = new frmNewCourse();
        public static Inschrijvingen.InschrijvingenPage inschrijvingen = new Inschrijvingen.InschrijvingenPage();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new frmLogin());
        }
        
    }
}
