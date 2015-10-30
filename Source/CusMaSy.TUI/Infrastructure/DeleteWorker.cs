using CusMaSy.Shared.Infrastructure;
using CusMaSy.Shared.Models.Interfaces;
using System;

namespace CusMaSy.TUI.Infrastructure
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
        }

        internal void DeleteZuordnung()
        {
            ConsoleWriter.WriteHeadline("Zuordnung löschen");
            var anbieterNrString = ConsoleWriter.WriteInputStatement("Anbieternummer");
            while (string.IsNullOrWhiteSpace(anbieterNrString) && Validator.CheckStringIsLong(anbieterNrString) == false)
                anbieterNrString = ConsoleWriter.WriteInputStatement("Anbieternummer");

            var anbieterNr = long.Parse(anbieterNrString);

            var clientNrString = ConsoleWriter.WriteInputStatement("zuzuordnende Anbieternummer");
            while (string.IsNullOrWhiteSpace(clientNrString) && Validator.CheckStringIsLong(clientNrString) == false)
                clientNrString = ConsoleWriter.WriteInputStatement("zuzuordnende Anbieternummer");

            var clientNr = long.Parse(clientNrString);

            // theoretisch könnte zurodnung nicht exisiestieren --> sollte man prüfen
            _fachkonzept.RemoveZuordnung(anbieterNr, clientNr);
            Console.Clear();
            ConsoleWriter.WriteHeadline("Zuordnung erfolgreich gelöschen");
        }
    }
}
