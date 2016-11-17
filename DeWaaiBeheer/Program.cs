using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeWaaiBeheer
{
    static class Program
    {
        public static frmLogin login = new frmLogin();
        public static frmHome home = new frmHome();
        public static frmMyAccount account = new frmMyAccount();
        public static frmCourses courses = new frmCourses();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(home);
        }
        
    }
}
