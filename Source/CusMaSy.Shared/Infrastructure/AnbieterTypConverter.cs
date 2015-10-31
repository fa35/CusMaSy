namespace CusMaSy.Shared.Infrastructure
{
    public static class AnbieterTypConverter
    {
        public static string ToAnbieterTyp(int anbieterTypNr)
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

        public static int ToAnbieterTypNr(string anbieterTyp)
        {
            if (anbieterTyp.Equals("Kaufmann"))
                return 1;
            if (anbieterTyp.Equals("Privatperson"))
                return 2;

            return 0;
        }
    }
}
