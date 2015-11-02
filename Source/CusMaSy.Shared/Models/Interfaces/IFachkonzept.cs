using CusMaSy.Shared.Data;
using System.Collections.Generic;

namespace CusMaSy.Shared.Models.Interfaces
{
    public interface IFachkonzept
    {
        /// <summary>
        /// Lade Anbieter mit Parametern, oder bei keinen Parametern -> lade alle Anbieter
        /// </summary>
        List<Anbieter> GetAllAnbieter();

        /// <summary>
        /// Speichert einen neuen Anbieter und setzt den Anbietertypen
        /// </summary>
        void SaveAnbieter(Anbieter anbieter);
        long GetOrtNr(Ort ort);
        int GetAnbieterTypNrByBool(bool isKaufmann);
        List<Ort> GetOrte(List<long> list);
        void RemoveAnbieter(long anbieterNr);
        void SaveState(string input);
        List<Anbieter_Zuordnung> GetAllZuordnungenByAnbietersNrs(List<long> anbietersNrs);

        void UpdateAnbieter(Anbieter anbieter);

        void SaveZuordnung(long hostNr, long clientNr);
        void RemoveZuordnung(long hostNr, long clientNr);
        bool ExistsHostClientZuordnung(long anbieterNr, long clientNr);
        Anbieter FindAnbieterByNr(long anbieterNr);
        Anbieter FindAnbieterByName(string anbieterName);
    }
}
