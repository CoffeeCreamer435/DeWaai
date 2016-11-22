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
        public static CursusPage cursus = new CursusPage();
        public static frmUsers users = new frmUsers();
        

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
