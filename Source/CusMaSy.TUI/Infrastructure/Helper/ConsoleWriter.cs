using CusMaSy.Shared.Data;
using CusMaSy.Shared.Infrastructure;
using CusMaSy.Shared.Models;
using CusMaSy.Shared.Models.Interfaces;
using System;
using System.Collections.Generic;

namespace CusMaSy.TUI.Infrastructure.Helper
{
    internal static class ConsoleWriter
    {
        internal static void WriteHeadline(string content)
        {
            Console.WriteLine(String.Format("\t{0}:{1}", content, Environment.NewLine));
        }

        internal static void WirteMenuPoint(string content, string input)
        {
            Console.WriteLine(String.Format("- {0} - Eingabe: {1}", content, input));
        }

        internal static string WriteInputStatement(string content, bool isFirstTime)
        {
            if (isFirstTime)
                Console.Write(String.Format("{0} eingeben: ", content));
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(String.Format("{0} eingeben: ", content));
                Console.ForegroundColor = ConsoleColor.White;
            }

            return Console.ReadLine();
        }

        internal static void WriteZurorndungen(List<Anbieter_Zuordnung> zuordnungen, Dictionary<long, string> anbieterNrAnbieterNameDic)
        {
            Console.WriteLine(Environment.NewLine + "Zuordnungen" + Environment.NewLine);

            foreach (var zuordnung in zuordnungen)
            {
                var name = string.Empty;
                anbieterNrAnbieterNameDic.TryGetValue(zuordnung.pf_ClientAnbieter_Nr, out name);
                Console.WriteLine(zuordnung.pf_ClientAnbieter_Nr + " | " + name);
            }
        }

        internal static void WriteUserFeedback(string message, StatusFeedback status)
        {
            Console.Clear();

            switch (status)
            {
                case StatusFeedback.Info:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case StatusFeedback.Negativ:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case StatusFeedback.Positiv:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
            }

            Console.WriteLine(Environment.NewLine + message);
            Console.ForegroundColor = ConsoleColor.White;

            Menu.ShowMenu();
        }

        internal static Anbieter InputAnbieterDetails(Anbieter anbieter, Ort ort, IFachkonzept _fachkonzept)
        {
            var firma = ConsoleWriter.WriteInputStatement("Firma", true);
            while (string.IsNullOrWhiteSpace(firma))
                firma = ConsoleWriter.WriteInputStatement("Firma", false);

            if (firma.ToLower().Equals("abbr"))
            {
                ConsoleWriter.WriteUserFeedback("Vorgang wurde abgeprochen", StatusFeedback.Info);
                return null;
            }
            anbieter.Firma = firma;

            var steuerNr = ConsoleWriter.WriteInputStatement("Steuernummer", true);
            while (string.IsNullOrWhiteSpace(steuerNr))
                steuerNr = ConsoleWriter.WriteInputStatement("Steuernummer", false);

            if (steuerNr.ToLower().Equals("abbr"))
            {
                ConsoleWriter.WriteUserFeedback("Vorgang wurde abgeprochen", StatusFeedback.Info);
                return null;
            }
            anbieter.Steuernummer = steuerNr;


            var branche = ConsoleWriter.WriteInputStatement("Branche", true);
            while (string.IsNullOrWhiteSpace(branche))
                branche = ConsoleWriter.WriteInputStatement("Branche", false);

            if (branche.ToLower().Equals("abbr"))
            {
                ConsoleWriter.WriteUserFeedback("Vorgang wurde abgeprochen", StatusFeedback.Info);
                return null;
            }
            anbieter.Branche = branche;


            var homepage = ConsoleWriter.WriteInputStatement("Homepage", true);
            while (string.IsNullOrWhiteSpace(homepage) || Validator.CheckHomepage(homepage) == false)
                homepage = ConsoleWriter.WriteInputStatement("Homepage", false);

            if (homepage.ToLower().Equals("abbr"))
            {
                ConsoleWriter.WriteUserFeedback("Vorgang wurde abgeprochen", StatusFeedback.Info);
                return null;
            }
            anbieter.Homepage = homepage;


            var teleNr = ConsoleWriter.WriteInputStatement("Telefonnummer", true);
            while (string.IsNullOrWhiteSpace(teleNr))
                teleNr = ConsoleWriter.WriteInputStatement("Telefonnummer", false);

            if (teleNr.ToLower().Equals("abbr"))
            {
                ConsoleWriter.WriteUserFeedback("Vorgang wurde abgeprochen", StatusFeedback.Info);
                return null;
            }
            anbieter.Telefonnummer = teleNr;


            var mailAdr = ConsoleWriter.WriteInputStatement("Mailadresse", true);
            while (string.IsNullOrWhiteSpace(mailAdr) || Validator.CheckMailadresse(mailAdr) == false)
                mailAdr = ConsoleWriter.WriteInputStatement("Mailadresse", false);

            if (mailAdr.ToLower().Equals("abbr"))
            {
                ConsoleWriter.WriteUserFeedback("Vorgang wurde abgeprochen", StatusFeedback.Info);
                return null;
            }
            anbieter.Mailadresse = mailAdr;

            var strasse = ConsoleWriter.WriteInputStatement("Strasse", true);
            while (string.IsNullOrWhiteSpace(strasse))
                strasse = ConsoleWriter.WriteInputStatement("Strasse", false);

            if (strasse.ToLower().Equals("abbr"))
            {
                ConsoleWriter.WriteUserFeedback("Vorgang wurde abgeprochen", StatusFeedback.Info);
                return null;
            }
            anbieter.Strasse = strasse;


            var hausNr = ConsoleWriter.WriteInputStatement("Hausnummer", true);
            while (string.IsNullOrWhiteSpace(hausNr))
                hausNr = ConsoleWriter.WriteInputStatement("Hausnummer", false);

            if (hausNr.ToLower().Equals("abbr"))
            {
                ConsoleWriter.WriteUserFeedback("Vorgang wurde abgeprochen", StatusFeedback.Info);
                return null;
            }
            anbieter.Hausnummer = hausNr;


            var plz = ConsoleWriter.WriteInputStatement("PLZ", true);
            while (string.IsNullOrWhiteSpace(plz) || Validator.CheckPLZ(plz) == false)
                plz = ConsoleWriter.WriteInputStatement("PLZ", false);

            if (plz.ToLower().Equals("abbr"))
            {
                ConsoleWriter.WriteUserFeedback("Vorgang wurde abgeprochen", StatusFeedback.Info);
                return null;
            }

            ort.PLZ = int.Parse(plz);


            var ortBez = ConsoleWriter.WriteInputStatement("Ort", true);
            while (string.IsNullOrWhiteSpace(ortBez))
                ortBez = ConsoleWriter.WriteInputStatement("Ort", false);

            if (ortBez.ToLower().Equals("abbr"))
            {
                ConsoleWriter.WriteUserFeedback("Vorgang wurde abgeprochen", StatusFeedback.Info);
                return null;
            }
            ort.Ort1 = ortBez;


            var land = ConsoleWriter.WriteInputStatement("Land", true);
            while (string.IsNullOrWhiteSpace(land))
                land = ConsoleWriter.WriteInputStatement("Land", false);

            if (land.ToLower().Equals("abbr"))
            {
                ConsoleWriter.WriteUserFeedback("Vorgang wurde abgeprochen", StatusFeedback.Info);
                return null;
            }
            ort.Land = land;

            var anbieterTyp = ConsoleWriter.WriteInputStatement("AnbieterTyp (Kaufmann/Privatperson)", true);

            while (string.IsNullOrWhiteSpace(anbieterTyp) || Validator.CheckAnbieterTyp(anbieterTyp) == false)
                anbieterTyp = ConsoleWriter.WriteInputStatement("AnbieterTyp (Kaufmann/Privatperson)", false);

            if (anbieterTyp.ToLower().Equals("abbr"))
            {
                ConsoleWriter.WriteUserFeedback("Vorgang wurde abgeprochen", StatusFeedback.Info);
                return null;
            }
            anbieter.f_AnbieterTyp_Nr = AnbieterTypConverter.ToAnbieterTypNr(anbieterTyp);

            // ort nr holen:
            anbieter.f_Ort_Nr = _fachkonzept.GetOrtNr(ort);

            return anbieter;
        }
    }
}
