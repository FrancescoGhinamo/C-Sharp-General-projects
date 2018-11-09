using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LineCalculator.Frontend.MainForm
{
    /// <summary>
    /// Class to launch the program
    /// </summary>
    public static class Launcher
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LineFormGUI());
        }
    }
}
