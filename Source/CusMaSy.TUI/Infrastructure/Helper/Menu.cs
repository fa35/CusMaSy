﻿using System;

namespace CusMaSy.TUI.Infrastructure.Helper
{
    class Menu
    {
        internal static void ShowMenu()
        {
            Console.Write(Environment.NewLine);
            ConsoleWriter.WriteHeadline("Anbieter-Menü");
            ConsoleWriter.WirteMenuPoint("Anbieter anzeigen", "anaz");
            ConsoleWriter.WirteMenuPoint("Anbieter suchen", "ansu");
            ConsoleWriter.WirteMenuPoint("Anbieterdetails bearbeiten", "anbe");
            ConsoleWriter.WirteMenuPoint("Anbieter anlegen", "anle");
            ConsoleWriter.WirteMenuPoint("Anbieter löschen", "anlo");
            ConsoleWriter.WirteMenuPoint("Anbieter zuordnen", "anzu");
            ConsoleWriter.WirteMenuPoint("Zuordnung löschen", "zulo");
            ConsoleWriter.WirteMenuPoint("Anwendung beenden", "ende");
            ConsoleWriter.WirteMenuPoint("Hilfe anzeigen", "hilfe");
        }

        internal static void ShowHelp()
        {
            ConsoleWriter.WriteHeadline("Hilfe");
            ConsoleWriter.WirteMenuPoint("Anbieter-Menü anzeigen", "anme");
            ConsoleWriter.WirteMenuPoint("Anwendung beenden", "ende");
        }
    }
}