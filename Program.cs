using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N18DCCN109_BACKUP_RESTORE
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static String strDefaultPath = Environment.CurrentDirectory + @"\Backup\";
        [STAThread]
        static void Main()
        {
            if (!Directory.Exists(strDefaultPath))
            {
                Directory.CreateDirectory(strDefaultPath);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new loginForm());
        }
    }
}
