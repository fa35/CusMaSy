namespace CusMaSy.Shared.Infrastructure
{
    public static class StringConverter
    {
        public static int ToInt(string content)
        {
            int number = 0;
            int.TryParse(content, out number);
            return number;
        }
    }
}
