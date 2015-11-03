using CusMaSy.Shared.Infrastructure;
using CusMaSy.Shared.Models;
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

            var anbieterNrString = ConsoleWriter.WriteInputStatement("Anbieternummer", true);
            while (string.IsNullOrWhiteSpace(anbieterNrString) && Validator.CheckStringIsLong(anbieterNrString) == false)
                anbieterNrString = ConsoleWriter.WriteInputStatement("Anbieternummer", false);

            if (anbieterNrString.ToLower().Equals("abbr"))
            {
                ConsoleWriter.WriteUserFeedback("Vorgang wurde abgeprochen", StatusFeedback.Info);
                return;
            }

            var anbieterNr = long.Parse(anbieterNrString);

            // theoretisch könnte es auch sein, das der anbieter nicht existiert -> sollte man noch prüfen
            _fachkonzept.RemoveAnbieter(anbieterNr);

            ConsoleWriter.WriteUserFeedback("Anbieter erfolgreich gelöscht!", StatusFeedback.Positiv);
        }

        internal void DeleteZuordnung()
        {
            ConsoleWriter.WriteHeadline("Zuordnung löschen");
            var anbieterNrString = ConsoleWriter.WriteInputStatement("Anbieternummer", true);
            while (string.IsNullOrWhiteSpace(anbieterNrString) && Validator.CheckStringIsLong(anbieterNrString) == false)
                anbieterNrString = ConsoleWriter.WriteInputStatement("Anbieternummer", false);

            if (anbieterNrString.ToLower().Equals("abbr"))
            {
                ConsoleWriter.WriteUserFeedback("Vorgang wurde abgeprochen", StatusFeedback.Info);
                return;
            }

            var anbieterNr = long.Parse(anbieterNrString);

            if (!Validator.CheckAnbieterNrExists(anbieterNr, _fachkonzept))
            {
                ConsoleWriter.WriteUserFeedback("Die Anbieternummer existiert nicht.", StatusFeedback.Info);
            }

            // mögliche zurodnungen

            var zuordnungen = _fachkonzept.GetAllZuordnungenByAnbietersNrs(new List<long> { anbieterNr });

            if (zuordnungen == null || !zuordnungen.Any())
            {
                ConsoleWriter.WriteUserFeedback("Dieser Anbieter hat keine Zuordnungen", StatusFeedback.Info);
                Menu.ShowMenu();
                return;
            }

            var anbieterNrsToAnbieterNamenDic = _fachkonzept.GetAnbieterNameByAnbieterNr(zuordnungen.Select(z => z.pf_ClientAnbieter_Nr).ToList());
            ConsoleWriter.WriteZurorndungen(zuordnungen, anbieterNrsToAnbieterNamenDic);

            Console.WriteLine(Environment.NewLine + "Auswahl:");

            var clientNrString = ConsoleWriter.WriteInputStatement("zuzuordnende Anbieternummer", true);
            while (string.IsNullOrWhiteSpace(clientNrString) && Validator.CheckStringIsLong(clientNrString) == false)
                clientNrString = ConsoleWriter.WriteInputStatement("zuzuordnende Anbieternummer", false);

            if (anbieterNrString.ToLower().Equals("abbr"))
            {
                ConsoleWriter.WriteUserFeedback("Vorgang wurde abgeprochen", StatusFeedback.Info);
                return;
            }

            try
            {
                var clientNr = long.Parse(clientNrString);

                // theoretisch könnte zurodnung nicht exisiestieren --> sollte man prüfen
                _fachkonzept.RemoveZuordnung(anbieterNr, clientNr);
                ConsoleWriter.WriteUserFeedback("Zuordnung erfolgreich gelöschen", StatusFeedback.Positiv);
            }
            catch (Exception ex)
            {
                ConsoleWriter.WriteUserFeedback("Konnte Zuordnung nicht löschen!", StatusFeedback.Negativ);
            }
        }
    }
}
