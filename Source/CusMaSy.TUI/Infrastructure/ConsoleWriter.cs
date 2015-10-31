using System;

namespace CusMaSy.TUI.Infrastructure
{
    internal static class ConsoleWriter
    {
        internal static void WriteHeadline(string content)
        {
            Console.WriteLine(String.Format("\t{0}:{1}", content, Environment.NewLine));
        }

        internal static void WirteMenuPoint(string content, string input)
        {
            Console.WriteLine(String.Format("- {0} - Eingabe: {1}", content, input));
        }

        internal static string WriteInputStatement(string content)
        {
            Console.Write(String.Format("{0} eingeben: ", content));
            return Console.ReadLine();
        }
    }
}
