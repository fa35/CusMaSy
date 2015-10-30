using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CusMaSy.TUI.Infrastructure
{
    class Menu
    {
        internal static void ShowMenu()
        {
            Console.WriteLine("\t Anbieter-Menü:");
            Console.WriteLine("-1 Anbieter anzeigen - Eingabe: ana");
            Console.WriteLine("-2 Anbieter suchen - Eingabe: ans");
            Console.WriteLine("-3 Anbieterdetails bearbeiten - Eingabe: anbe");
            Console.WriteLine("-4 Anbieter anlegen - Eingabe: an1e");
            Console.WriteLine("-5 Anbieter löschen - Eingabe: anlo");
            Console.WriteLine("-6 Anbieter andere Anbieter zuordnen - Eingabe: anzu");
        }

        internal static void ShowHelp()
        {
            Console.WriteLine("\t Hilfe:");
            Console.WriteLine("-1 Anbieter-Menü anzeigen lassen: - Eingabe: anme");
            Console.WriteLine("-2 Anwendung beenden: - Eingabe: end");


        }
    }
}
