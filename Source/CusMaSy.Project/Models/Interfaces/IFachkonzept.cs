
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


        /// <summary>
        /// Ladet Orte mit Parametern, falle alle Orte, falls keine Parameter reingeführt wurden
        /// </summary>
        Ort[] LadeOrte(long? plzNr = null, int? plz = null);

        long GetOrtNr(Ort ort);

        int GetAnbieterTypNrByBool(bool isKaufmann);
        void DeleteRelations(long anbieters, List<long> relations);
    }
}
