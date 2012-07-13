using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Management;

namespace WMI_Monitor_Csharp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            int xPos = Screen.PrimaryScreen.WorkingArea.Width - 245;
            Application.Run(new FormShort(xPos, 0));
        }
    } 
}
