using CusMaSy.Shared.Data;
using CusMaSy.Shared.Infrastructure;
using CusMaSy.Shared.Models;
using CusMaSy.Shared.Models.Interfaces;
using CusMaSy.TUI.Infrastructure.Helper;
using System;

namespace CusMaSy.TUI.Infrastructure.Worker
{
    internal class AddWorker
    {
        IFachkonzept _fachkonzept;

        internal AddWorker(IFachkonzept fachkonzept)
        {
            _fachkonzept = fachkonzept;
        }

        internal void AnbieterAnlegen()
        {
            ConsoleWriter.WriteHeadline("Anbieter anlegen");
            var anbieter = new Anbieter();
            anbieter = ConsoleWriter.InputAnbieterDetails(anbieter, new Ort(), _fachkonzept);
            if (anbieter == null)
                return;

            try
            {
                _fachkonzept.SaveAnbieter(anbieter);
                ConsoleWriter.WriteUserFeedback("Anbieter '" + anbieter.Firma + "' erfolgreich angelegt!", StatusFeedback.Positiv);
            }
            catch (Exception ex)
            {
                ConsoleWriter.WriteUserFeedback("Es ist ein Fehler beim Speichern des Anbieters aufgetreten", StatusFeedback.Negativ);
            }
        }


        internal void ZuordnungAnlegen()
        {
            ConsoleWriter.WriteHeadline("Zuordnung anlegen");
            var anbieterNrString = ConsoleWriter.WriteInputStatement("Anbieternummer", true);
            while (string.IsNullOrWhiteSpace(anbieterNrString) && Validator.CheckStringIsLong(anbieterNrString) == false)
                anbieterNrString = ConsoleWriter.WriteInputStatement("Anbieternummer", false);

            if (anbieterNrString.ToLower().Equals("abbr"))
            {
                ConsoleWriter.WriteUserFeedback("Vorgang wurde abgeprochen", StatusFeedback.Info);
                return;
            }
            var anbieterNr = long.Parse(anbieterNrString);

            try
            {
                if (!Validator.CheckAnbieterNrExists(anbieterNr, _fachkonzept))
                {
                    ConsoleWriter.WriteUserFeedback("Anbieternummer '" + anbieterNr + "' existiert nicht!", StatusFeedback.Info);
                    return;
                }

                var clientNrString = ConsoleWriter.WriteInputStatement("zuzuordnende Anbieternummer", true);
                while (string.IsNullOrWhiteSpace(clientNrString) && Validator.CheckStringIsLong(clientNrString) == false)
                    clientNrString = ConsoleWriter.WriteInputStatement("zuzuordnende Anbieternummer", false);

                if (clientNrString.ToLower().Equals("abbr"))
                {
                    ConsoleWriter.WriteUserFeedback("Vorgang wurde abgeprochen", StatusFeedback.Info);
                    return;
                }

                var clientNr = long.Parse(clientNrString);
                Console.Clear();

                // check if zuordnung exists
                if (_fachkonzept.ExistsHostClientZuordnung(anbieterNr, clientNr))
                    ConsoleWriter.WriteUserFeedback("Zuordnung bestand bereits!", StatusFeedback.Info);

                _fachkonzept.SaveZuordnung(anbieterNr, clientNr);
                ConsoleWriter.WriteUserFeedback("Zuordnung erfolgreich angelegt!", StatusFeedback.Positiv);
            }
            catch (Exception ex)
            {
                ConsoleWriter.WriteUserFeedback("Es ist ein Fehler beim Speichern der Zuordnung aufgetreten!", StatusFeedback.Negativ);
            }
        }
    }
}
