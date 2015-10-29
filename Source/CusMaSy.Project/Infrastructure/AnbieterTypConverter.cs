namespace CusMaSy.Project.Infrastructure
{
    internal static class AnbieterTypConverter
    {
        internal static string ToAnbieterTyp(int anbieterTypNr)
        {
            switch (anbieterTypNr)
            {
                case 1:
                    return "Kaufmann";
                case 2:
                    return "Privatperson";
                default:
                    return "Unbekannt";
            }
        }
    }
}
