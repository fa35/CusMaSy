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
            if (anbieterTyp.ToLower().Equals("kaufmann"))
                return 1;
            if (anbieterTyp.ToLower().Equals("privatperson"))
                return 2;

            return 0;
        }
    }
}
