using CusMaSy.Shared.Data;
using CusMaSy.Shared.Infrastructure;
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

            var a = new Anbieter();
            var ort = new Ort();

            var firma = ConsoleWriter.WriteInputStatement("Firma");
            while (string.IsNullOrWhiteSpace(firma))
                firma = ConsoleWriter.WriteInputStatement("Firma");
            a.Firma = firma;


            var steuerNr = ConsoleWriter.WriteInputStatement("Steuernummer");
            while (string.IsNullOrWhiteSpace(steuerNr))
                steuerNr = ConsoleWriter.WriteInputStatement("Steuernummer");
            a.Steuernummer = steuerNr;


            var branche = ConsoleWriter.WriteInputStatement("Branche");
            while (string.IsNullOrWhiteSpace(branche))
                branche = ConsoleWriter.WriteInputStatement("Branche");
            a.Branche = branche;


            var homepage = ConsoleWriter.WriteInputStatement("Homepage");
            while (string.IsNullOrWhiteSpace(homepage) || Validator.CheckHomepage(homepage) == false)
                homepage = ConsoleWriter.WriteInputStatement("Homepage");
            a.Homepage = homepage;


            var teleNr = ConsoleWriter.WriteInputStatement("Telefonnummer");
            while (string.IsNullOrWhiteSpace(teleNr))
                teleNr = ConsoleWriter.WriteInputStatement("Telefonnummer");
            a.Telefonnummer = teleNr;


            var mailAdr = ConsoleWriter.WriteInputStatement("Mailadresse");
            while (string.IsNullOrWhiteSpace(mailAdr) || Validator.CheckMailadresse(mailAdr) == false)
                mailAdr = ConsoleWriter.WriteInputStatement("Mailadresse");
            a.Mailadresse = mailAdr;


            var strasse = ConsoleWriter.WriteInputStatement("Strasse");
            while (string.IsNullOrWhiteSpace(strasse))
                strasse = ConsoleWriter.WriteInputStatement("Strasse");
            a.Strasse = strasse;


            var hausNr = ConsoleWriter.WriteInputStatement("Hausnummer");
            while (string.IsNullOrWhiteSpace(hausNr))
                hausNr = ConsoleWriter.WriteInputStatement("Hausnummer");
            a.Hausnummer = hausNr;


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
            a.f_AnbieterTyp_Nr = AnbieterTypConverter.ToAnbieterTypNr(anbieterTyp);

            // ort nr holen:
            a.f_Ort_Nr = _fachkonzept.GetOrtNr(ort);

            // anbieter speichern
            _fachkonzept.SaveAnbieter(a);

            Console.Clear();
            Console.WriteLine("Anbieter erfolgreich angelegt");
            Menu.ShowMenu();

        }


        internal void ZuordnungAnlegen()
        {
            ConsoleWriter.WriteHeadline("Zuordnung anlegen");

            var anbieterNrString = ConsoleWriter.WriteInputStatement("Anbieternummer");
            while (string.IsNullOrWhiteSpace(anbieterNrString) && Validator.CheckStringIsLong(anbieterNrString) == false)
                anbieterNrString = ConsoleWriter.WriteInputStatement("Anbieternummer");

            var anbieterNr = long.Parse(anbieterNrString);

            if (!Validator.CheckAnbieterNrExists(anbieterNr, _fachkonzept))
            {
                Console.WriteLine("Die Anbieternummer existiert nicht");
                Menu.ShowMenu();
                return;
            }

            var clientNrString = ConsoleWriter.WriteInputStatement("zuzuordnende Anbieternummer");
            while (string.IsNullOrWhiteSpace(clientNrString) && Validator.CheckStringIsLong(clientNrString) == false)
                clientNrString = ConsoleWriter.WriteInputStatement("zuzuordnende Anbieternummer");

            var clientNr = long.Parse(clientNrString);

            Console.Clear();

            // check if zuordnung exists
            if (!_fachkonzept.ExistsHostClientZuordnung(anbieterNr, clientNr))
            {
                _fachkonzept.SaveZuordnung(anbieterNr, clientNr);
                Console.WriteLine("Zuordnung erfolgreich angelegt");
            }
            else
            {
                Console.WriteLine("Zuordnung bestand bereits");
            }

            Menu.ShowMenu();
        }
    }
}
