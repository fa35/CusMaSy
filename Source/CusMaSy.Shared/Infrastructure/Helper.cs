using System;
using System.Reflection;


namespace CusMaSy.Shared.Infrastructure
{
    public static class Helper
    {
        private static string GetVersion()
        {
            return Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        public static string GetTitle(string viewName)
        {
            return String.Format("{0} - {1}", viewName, GetVersion());
        }
    }
}
