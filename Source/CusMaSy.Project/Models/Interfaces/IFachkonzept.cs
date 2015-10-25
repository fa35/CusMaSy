
namespace CusMaSy.Project.Models.Interfaces
{
    public interface IFachkonzept
    {

        /// <summary>
        /// Erzeugt neuen Anbieter
        /// </summary>
        Anbieter ErstelleAnbieter(string steuernr, string firma, string strasse, string hausnr, int plz, string ort, string land, string telefonnr, string mailadresse, string homepage, string branche);

        /// <summary>
        /// Erzeugt neuen Ort
        /// </summary>
        Ort ErstelleOrt(int plz, string ort);


        /// <summary>
        /// Lade Anbieter mit Parametern, oder bei keinen Parametern -> lade alle Anbieter
        /// </summary>
        Anbieter[] LadeAnbieter(long? anbieterNr = null, string firma = null);


        /// <summary>
        /// Ladet Orte mit Parametern, falle alle Orte, falls keine Parameter reingeführt wurden
        /// </summary>
        Ort[] LadeOrte(long? plzNr = null, int? plz = null);

    }
}
