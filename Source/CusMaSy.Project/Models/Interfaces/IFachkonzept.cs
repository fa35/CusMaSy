

namespace CusMaSy.Project.Models.Interfaces
{
    public interface IFachkonzept
    {
        void ErstelleAnbieter(Anbieter anbieter);

        void ErstelleOrt(int plz, string ort);

        Anbieter LadeAnbieter(long anbieterNr);

        Anbieter[] LadeAnbieter(string firma = null);

        Ort[] LadeOrte(int plz);

    }
}
