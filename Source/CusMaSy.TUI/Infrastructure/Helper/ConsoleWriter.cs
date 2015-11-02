using CusMaSy.Shared.Data;
using System;
using System.Collections.Generic;

namespace CusMaSy.TUI.Infrastructure.Helper
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

        internal static void WriteZurorndungen(List<Anbieter_Zuordnung> zuordnungen, Dictionary<long, string> anbieterNrAnbieterNameDic)
        {
            Console.WriteLine(Environment.NewLine + "Zuordnungen" + Environment.NewLine);

            foreach (var zuordnung in zuordnungen)
            {
                var name = string.Empty;
                anbieterNrAnbieterNameDic.TryGetValue(zuordnung.pf_ClientAnbieter_Nr, out name);
                Console.WriteLine(zuordnung.pf_ClientAnbieter_Nr + " | " + name);
            }
        }
    }
}
