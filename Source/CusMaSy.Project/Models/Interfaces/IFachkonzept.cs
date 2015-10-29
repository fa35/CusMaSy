
using CusMaSy.Project.Data;
using System.Collections.Generic;

namespace CusMaSy.Project.Models.Interfaces
{
    public interface IFachkonzept
    {

        /// <summary>
        /// Lade Anbieter mit Parametern, oder bei keinen Parametern -> lade alle Anbieter
        /// </summary>
        Anbieter[] LadeAnbieter(long? anbieterNr = null, string firma = null);

        List<Anbieter> GetAllAnbieter();

        /// <summary>
        /// Speichert einen neuen Anbieter und setzt den Anbietertypen
        /// </summary>
        void SaveAnbieter(Anbieter anbieter);

        long GetOrtNr(Ort ort);

        int GetAnbieterTypNrByBool(bool isKaufmann);
        void DeleteRelations(long anbieters, List<long> relations);
        List<Ort> GetOrte(List<long> list);
        void RemoveAnbieter(string anbieterNr);
        void SaveState(string input);
        List<Anbieter_Zuordnung> GetAllZuordnungenByAnbieterNr(List<long> list);
        void SaveZuordnungen(long _hostNr, List<long> anbieterNrs);
    }
}
