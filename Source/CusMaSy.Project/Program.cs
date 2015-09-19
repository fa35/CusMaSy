using System;
using CusMaSy.Project.Views;

namespace CusMaSy.Project
{
    static class Program
    {
        static void Main()
        {
            Console.Write("Running the GUI...\nPress Enter To Abort");

            if (true)
                new System.Threading.Thread(() => { System.Windows.Forms.Application.Run(new frmKunde()); }).Start();

            Console.ReadLine();


            System.Windows.Forms.Application.Exit();
        }



        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        //static void Main()
        //{
        //    Application.EnableVisualStyles();
        //    Application.SetCompatibleTextRenderingDefault(false);
        //    Application.Run(new Form1());
        //}
    }
}
