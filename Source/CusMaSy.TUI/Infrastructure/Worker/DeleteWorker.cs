using CusMaSy.Shared.Infrastructure;
using CusMaSy.Shared.Models.Interfaces;
using CusMaSy.TUI.Infrastructure.Helper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CusMaSy.TUI.Infrastructure.Worker
{
    internal class DeleteWorker
    {
        IFachkonzept _fachkonzept;
        internal DeleteWorker(IFachkonzept fachkonzept)
        {
            _fachkonzept = fachkonzept;
        }

        internal void DeleteAnbieter()
        {
            ConsoleWriter.WriteHeadline("Anbieter löschen");

            var anbieterNrString = ConsoleWriter.WriteInputStatement("Anbieternummer");
            while (string.IsNullOrWhiteSpace(anbieterNrString) && Validator.CheckStringIsLong(anbieterNrString) == false)
                anbieterNrString = ConsoleWriter.WriteInputStatement("Anbieternummer");

            var anbieterNr = long.Parse(anbieterNrString);

            // theoretisch könnte es auch sein, das der anbieter nicht existiert -> sollte man noch prüfen
            _fachkonzept.RemoveAnbieter(anbieterNr);

            Console.Clear();
            Console.WriteLine("Anbieter erfolgreich gelöscht!");
            Menu.ShowMenu();
        }

        internal void DeleteZuordnung()
        {
            ConsoleWriter.WriteHeadline("Zuordnung löschen");
            var anbieterNrString = ConsoleWriter.WriteInputStatement("Anbieternummer");
            while (string.IsNullOrWhiteSpace(anbieterNrString) && Validator.CheckStringIsLong(anbieterNrString) == false)
                anbieterNrString = ConsoleWriter.WriteInputStatement("Anbieternummer");

            var anbieterNr = long.Parse(anbieterNrString);

            if (!Validator.CheckAnbieterNrExists(anbieterNr, _fachkonzept))
            {
                Console.WriteLine("Die Anbieternummer existiert nicht.");
                Menu.ShowMenu();
            }

            // mögliche zurodnungen

            var zuordnungen = _fachkonzept.GetAllZuordnungenByAnbietersNrs(new List<long> { anbieterNr });

            if (zuordnungen == null || !zuordnungen.Any())
            {
                Console.WriteLine("Dieser Anbieter hat keine Zuordnungen");
                Menu.ShowMenu();
                return;
            }

            var anbieterNrsToAnbieterNamenDic = _fachkonzept.GetAnbieterNameByAnbieterNr(zuordnungen.Select(z => z.pf_ClientAnbieter_Nr).ToList());
            ConsoleWriter.WriteZurorndungen(zuordnungen, anbieterNrsToAnbieterNamenDic);

            Console.WriteLine(Environment.NewLine + "Auswahl:");

            var clientNrString = ConsoleWriter.WriteInputStatement("zuzuordnende Anbieternummer");
            while (string.IsNullOrWhiteSpace(clientNrString) && Validator.CheckStringIsLong(clientNrString) == false)
                clientNrString = ConsoleWriter.WriteInputStatement("zuzuordnende Anbieternummer");

            try
            {
                var clientNr = long.Parse(clientNrString);

                // theoretisch könnte zurodnung nicht exisiestieren --> sollte man prüfen
                _fachkonzept.RemoveZuordnung(anbieterNr, clientNr);
                Console.Clear();
                ConsoleWriter.WriteHeadline("Zuordnung erfolgreich gelöschen");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Konnte Zuordnung nicht löschen!");
            }

            Menu.ShowMenu();

        }
    }
}
