

namespace CusMaSy.Project.Models.Interfaces
{
    public interface IFachkonzept
    {
        void ErstelleAnbieter(Anbieter anbieter);

        void ErstelleOrt(int plz, string ort);

        Anbieter LadeAnbieter(long anbieterNr);


    }
}
