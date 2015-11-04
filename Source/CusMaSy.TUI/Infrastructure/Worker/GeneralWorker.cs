using CusMaSy.Shared.Data;
using CusMaSy.Shared.Infrastructure;
using CusMaSy.Shared.Models;
using CusMaSy.Shared.Models.Interfaces;
using CusMaSy.TUI.Infrastructure.Helper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CusMaSy.TUI.Infrastructure.Worker
{
    internal class GeneralWorker
    {
        IFachkonzept _fachkonzept;
        internal GeneralWorker(IFachkonzept fachkonzept)
        {
            _fachkonzept = fachkonzept;
        }

        internal void EditAnbieter()
        {
            ConsoleWriter.WriteHeadline("Anbieter bearbeiten");

            var anbieterString = ConsoleWriter.WriteInputStatement("Name oder Nr eingeben", true);
            while (string.IsNullOrWhiteSpace(anbieterString))
                anbieterString = ConsoleWriter.WriteInputStatement("Name oder Nr eingeben", false);

            if (anbieterString.ToLower().Equals("abbr"))
            {
                ConsoleWriter.WriteUserFeedback("Vorgang wurde abgeprochen", StatusFeedback.Info);
                return;
            }

            long anbieterNr = 0;
            long.TryParse(anbieterString, out anbieterNr);

            var anbieter = new Anbieter();

            try
            {
                if (anbieterNr > 0)
                    anbieter = _fachkonzept.FindAnbieterByNr(anbieterNr);
                else
                    anbieter = _fachkonzept.FindAnbieterByName(anbieterString);

                if (anbieter == null)
                    ConsoleWriter.WriteUserFeedback("Anbieter konnte nicht gefunden werden. Es ist keine Änderung der Details möglich.", StatusFeedback.Negativ);

                ShowAnbieterDetails(anbieter);
                ConsoleWriter.WriteHeadline("Veränderungen eingeben");
            }
            catch (Exception ex)
            {
                ConsoleWriter.WriteUserFeedback("Anbieter konnte nicht geladen werden", StatusFeedback.Negativ);
            }

            anbieter = ConsoleWriter.InputAnbieterDetails(anbieter, new Ort(), _fachkonzept);
            if (anbieter == null || anbieter.p_Anbieter_Nr < 1)
                return;

            try
            {
                _fachkonzept.UpdateAnbieter(anbieter);
                ConsoleWriter.WriteUserFeedback("Anbieter erfolgreich abgeändert", StatusFeedback.Positiv);
            }
            catch (Exception ex)
            {
                ConsoleWriter.WriteUserFeedback("Änderungen konnte nicht gespeichert werden", StatusFeedback.Negativ);
            }
        }

        internal void ShowAllAnbieters()
        {
            var anbieters = new List<Anbieter>();
            try
            {
                anbieters = _fachkonzept.GetAllAnbieter();
                ConsoleWriter.WriteHeadline("Alle Anbieter");

                foreach (var anbieter in anbieters)
                    Console.WriteLine(anbieter.p_Anbieter_Nr + " | " + anbieter.Firma);

                Menu.ShowMenu();
            }
            catch (Exception ex)
            {
                ConsoleWriter.WriteUserFeedback("Es ist ein Fehler beim laden der Anbieter aufgetreten", StatusFeedback.Negativ);
            }
        }

        internal void SearchAnbieter()
        {
            ConsoleWriter.WriteHeadline("Anbieter suchen");

            var anbieterString = ConsoleWriter.WriteInputStatement("Name oder Nr eingeben", true);
            while (string.IsNullOrWhiteSpace(anbieterString))
                anbieterString = ConsoleWriter.WriteInputStatement("Name oder Nr eingeben", false);

            if (anbieterString.ToLower().Equals("abbr"))
            {
                ConsoleWriter.WriteUserFeedback("Vorgang wurde abgeprochen", StatusFeedback.Info);
                return;
            }

            long anbieterNr = 0;
            long.TryParse(anbieterString, out anbieterNr);

            var anbieter = new Anbieter();

            try
            {
                if (anbieterNr > 0)
                    anbieter = _fachkonzept.FindAnbieterByNr(anbieterNr);
                else
                    anbieter = _fachkonzept.FindAnbieterByName(anbieterString);
            }
            catch (Exception ex)
            {
                ConsoleWriter.WriteUserFeedback("Es ist ein Fehler beim Finden des Anbieters aufgetreten", StatusFeedback.Negativ);
                return;
            }

            if (anbieter == null || string.IsNullOrWhiteSpace(anbieter.p_Anbieter_Nr.ToString()))
            {
                ConsoleWriter.WriteUserFeedback("Anbieter konnte nicht gefunden werden.", StatusFeedback.Info);
                return;
            }
            // theoretisch sollte man noch den ort laden
            ShowAnbieterDetails(anbieter);
            Menu.ShowMenu();
        }


        internal void ShowAnbieterDetails(Anbieter anbieter)
        {
            ConsoleWriter.WriteHeadline("Anbieterdetails");
            Console.WriteLine("Firma: " + anbieter.Firma);
            Console.WriteLine("Branche: " + anbieter.Branche);
            Console.WriteLine("Homepage: " + anbieter.Homepage);
            Console.WriteLine("Mailadresse: " + anbieter.Mailadresse);
            Console.WriteLine("Telefonnummer: " + anbieter.Telefonnummer);
            Console.WriteLine("AnbieterTyp: " + AnbieterTypConverter.ToAnbieterTyp(anbieter.f_AnbieterTyp_Nr));
            Console.WriteLine("Steuernummer: " + anbieter.Steuernummer);
            Console.WriteLine("Strasse: " + anbieter.Strasse);
            Console.WriteLine("Hausnummer: " + anbieter.Hausnummer);

            var orte = new List<Ort>();
            try
            {
                orte = _fachkonzept.GetOrte(new List<long> { anbieter.f_Ort_Nr });
            }
            catch (Exception ex)
            {
                ConsoleWriter.WriteUserFeedback("Es ist ein Fehler beim Laden des Ortes aufgetreten", StatusFeedback.Negativ);
            }

            if (!orte.Any())
                return;

            Console.WriteLine("PLZ: " + orte.First().PLZ);
            Console.WriteLine("Ort: " + orte.First().Ort1);
            Console.WriteLine("Land: " + orte.First().Land);

            // zuordnungen
            try
            {
                var relations = _fachkonzept.GetAllZuordnungenByAnbietersNrs(new List<long> { anbieter.p_Anbieter_Nr });

                if (relations == null || !relations.Any())
                    return;

                var anbieterNrsToAnbieterNamenDic = _fachkonzept.GetAnbieterNameByAnbieterNr(relations.Select(z => z.pf_ClientAnbieter_Nr).ToList());
                ConsoleWriter.WriteZurorndungen(relations, anbieterNrsToAnbieterNamenDic);
            }
            catch (Exception ex)
            {
                ConsoleWriter.WriteUserFeedback("Es ist ein Fehler beim Laden der Zuordnungen aufgetreten aufgetreten", StatusFeedback.Negativ);
            }
        }
    }
}
