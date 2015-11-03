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

            var anbieterString = ConsoleWriter.WriteInputStatement("Name oder Nr eingeben");
            while (string.IsNullOrWhiteSpace(anbieterString))
                anbieterString = ConsoleWriter.WriteInputStatement("Name oder Nr eingeben");

            long anbieterNr = 0;
            long.TryParse(anbieterString, out anbieterNr);

            var anbieter = new Anbieter();

            if (anbieterNr > 0)
                anbieter = _fachkonzept.FindAnbieterByNr(anbieterNr);
            else
                anbieter = _fachkonzept.FindAnbieterByName(anbieterString);

            if (anbieter == null)
                ConsoleWriter.WriteUserFeedback("Anbieter konnte nicht gefunden werden. Es ist keine Änderung der Details möglich.", StatusFeedback.Negativ);

            ShowAnbieterDetails(anbieter);

            ConsoleWriter.WriteHeadline("Veränderungen eingeben");

            var ort = new Ort();

            var firma = ConsoleWriter.WriteInputStatement("Firma");
            while (string.IsNullOrWhiteSpace(firma))
                firma = ConsoleWriter.WriteInputStatement("Firma");
            anbieter.Firma = firma;


            var steuerNr = ConsoleWriter.WriteInputStatement("Steuernummer");
            while (string.IsNullOrWhiteSpace(steuerNr))
                steuerNr = ConsoleWriter.WriteInputStatement("Steuernummer");
            anbieter.Steuernummer = steuerNr;


            var branche = ConsoleWriter.WriteInputStatement("Branche");
            while (string.IsNullOrWhiteSpace(branche))
                branche = ConsoleWriter.WriteInputStatement("Branche");
            anbieter.Branche = branche;


            var homepage = ConsoleWriter.WriteInputStatement("Homepage");
            while (string.IsNullOrWhiteSpace(homepage) || Validator.CheckHomepage(homepage) == false)
                homepage = ConsoleWriter.WriteInputStatement("Homepage");
            anbieter.Homepage = homepage;


            var teleNr = ConsoleWriter.WriteInputStatement("Telefonnummer");
            while (string.IsNullOrWhiteSpace(teleNr))
                teleNr = ConsoleWriter.WriteInputStatement("Telefonnummer");
            anbieter.Telefonnummer = teleNr;


            var mailAdr = ConsoleWriter.WriteInputStatement("Mailadresse");
            while (string.IsNullOrWhiteSpace(mailAdr) || Validator.CheckMailadresse(mailAdr) == false)
                mailAdr = ConsoleWriter.WriteInputStatement("Mailadresse");
            anbieter.Mailadresse = mailAdr;


            var strasse = ConsoleWriter.WriteInputStatement("Strasse");
            while (string.IsNullOrWhiteSpace(strasse))
                strasse = ConsoleWriter.WriteInputStatement("Strasse");
            anbieter.Strasse = strasse;


            var hausNr = ConsoleWriter.WriteInputStatement("Hausnummer");
            while (string.IsNullOrWhiteSpace(hausNr))
                hausNr = ConsoleWriter.WriteInputStatement("Hausnummer");
            anbieter.Hausnummer = hausNr;


            var plz = ConsoleWriter.WriteInputStatement("PLZ");
            while (string.IsNullOrWhiteSpace(plz) || Validator.CheckPLZ(plz) == false)
                plz = ConsoleWriter.WriteInputStatement("PLZ");
            ort.PLZ = int.Parse(plz);


            var ortBez = ConsoleWriter.WriteInputStatement("Ort");
            while (string.IsNullOrWhiteSpace(ortBez))
                ortBez = ConsoleWriter.WriteInputStatement("Ort");
            ort.Ort1 = ortBez;

            var land = ConsoleWriter.WriteInputStatement("Land");
            while (string.IsNullOrWhiteSpace(land))
                land = ConsoleWriter.WriteInputStatement("Land");
            ort.Land = land;

            var anbieterTyp = ConsoleWriter.WriteInputStatement("AnbieterTyp (Kaufmann/Privatperson)");

            while (string.IsNullOrWhiteSpace(anbieterTyp) || Validator.CheckAnbieterTyp(anbieterTyp) == false)
                anbieterTyp = ConsoleWriter.WriteInputStatement("AnbieterTyp (Kaufmann/Privatperson)");
            anbieter.f_AnbieterTyp_Nr = AnbieterTypConverter.ToAnbieterTypNr(anbieterTyp);

            // ort nr holen:
            anbieter.f_Ort_Nr = _fachkonzept.GetOrtNr(ort);

            // anbieter speichern
            _fachkonzept.UpdateAnbieter(anbieter);

            ConsoleWriter.WriteUserFeedback("Anbieter erfolgreich abgeändert", StatusFeedback.Positiv);
        }

        internal void ShowAllAnbieters()
        {
            var anbieters = _fachkonzept.GetAllAnbieter();

            ConsoleWriter.WriteHeadline("Alle Anbieter");

            foreach (var anbieter in anbieters)
            {
                Console.WriteLine(anbieter.p_Anbieter_Nr + " | " + anbieter.Firma);
            }

            Menu.ShowMenu();
        }

        internal void SearchAnbieter()
        {
            ConsoleWriter.WriteHeadline("Anbieter suchen");

            var anbieterString = ConsoleWriter.WriteInputStatement("Name oder Nr eingeben");
            while (string.IsNullOrWhiteSpace(anbieterString))
                anbieterString = ConsoleWriter.WriteInputStatement("Name oder Nr eingeben");

            long anbieterNr = 0;
            long.TryParse(anbieterString, out anbieterNr);

            var anbieter = new Anbieter();

            if (anbieterNr > 0)
                anbieter = _fachkonzept.FindAnbieterByNr(anbieterNr);
            else
                anbieter = _fachkonzept.FindAnbieterByName(anbieterString);

            if (anbieter == null)
                ConsoleWriter.WriteUserFeedback("Anbieter konnte nicht gefunden werden.", StatusFeedback.Info);

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

            var orte = _fachkonzept.GetOrte(new List<long> { anbieter.f_Ort_Nr });

            if (!orte.Any())
                return;

            Console.WriteLine("PLZ: " + orte.First().PLZ);
            Console.WriteLine("Ort: " + orte.First().Ort1);
            Console.WriteLine("Land: " + orte.First().Land);

            // zuordnungen

            var relations = _fachkonzept.GetAllZuordnungenByAnbietersNrs(new List<long> { anbieter.p_Anbieter_Nr });

            if (relations == null || !relations.Any())
                return;

            var anbieterNrsToAnbieterNamenDic = _fachkonzept.GetAnbieterNameByAnbieterNr(relations.Select(z => z.pf_ClientAnbieter_Nr).ToList());
            ConsoleWriter.WriteZurorndungen(relations, anbieterNrsToAnbieterNamenDic);
        }
    }
}
