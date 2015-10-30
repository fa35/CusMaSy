using System;
using CusMaSy.GUI.Forms;
using CusMaSy.Shared.Infrastructure;

namespace CusMaSy.Project
{
    static class Program
    {
        static void Main()
        {
            Console.Write("Running the GUI...\nPress Enter To Abort");

            var fa = new FachkonzeptA();

            if (true)
                new System.Threading.Thread(() => { System.Windows.Forms.Application.Run(new Hauptansicht(fa)); }).Start();

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

        //private static void Do()
        //{
        //    Console.WriteLine("-- CusMaSy Ver. 1.1" + Environment.NewLine);

        //    Console.WriteLine("Menüpunkte");
        //    Console.WriteLine("\t 1. Anbieter ausgeben lassen");
        //    Console.WriteLine("\t 2. Anbieter anlegen");
        //    Console.WriteLine("\t 3. Anbieter zuordnen");
        //    Console.WriteLine("\t 4. Anwendung beenden");

        //    Console.WriteLine("--> Bitte Menüpunkt (Zahl) eingeben: 2");
        //    Console.WriteLine(Environment.NewLine + "Auswahl: Anbieter anlegen" + Environment.NewLine);
        //    Console.WriteLine("Firma: Mastor Gbr");
        //    Console.WriteLine("Homepage: ---");
        //    Console.WriteLine("Mailadresse: t.engels@mastor.de");
        //    Console.Write("Strasse: ");
        //    Console.ReadLine();

        //}
    }
}
