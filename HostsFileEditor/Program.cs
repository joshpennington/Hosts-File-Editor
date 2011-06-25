using System;
using System.Windows.Forms;

using HostsFileEditor.Forms;

namespace HostsFileEditor
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(FormFactory.CreateMainForm());
        }
    }
}