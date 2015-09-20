

namespace CusMaSy.Project.Models.Interfaces
{
    public interface IFachkonzept
    {
        bool ErstelleAnbieter(Anbieter anbieter);

        Anbieter LadeAnbieter(long anbieterNr);
    }
}
