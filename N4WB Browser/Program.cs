using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace N4WB_Browser
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Import settings
            settings.load();

            // Load UI
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(settings.CompatTextRendering);
            Application.Run(new gui.main());
        }
    }
}
