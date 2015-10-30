using CusMaSy.GUI.Forms;
using CusMaSy.Shared.Infrastructure;
using System;
using System.Windows.Forms;

namespace CusMaSy.GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Hauptansicht(new FachkonzeptA()));
        }
    }
}
