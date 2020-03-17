using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace UserMaster
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //try
            //{
            //    MyGlobal.GlobalDataBase = args[0];
            //}
            //catch { MessageBox.Show("Invalid Connection", "Error Note", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); Environment.Exit(1); }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UserMaster());
        }
    }

    public static class MyGlobal
    {
        public static string GlobalAuthority = "";
        public static string GlobalUserID = "";
        public static string GlobalUserName = "";
        public static string GlobalEmployeeCode = "";
        public static string GlobalEmployeeName = "";
        public static string GlobalDataBase = "";
        public static string GlobalServer = "";
        public static string GlobalDataBaseUserID = "";
        public static string GlobalDataBasePassword = "";
    }
}
