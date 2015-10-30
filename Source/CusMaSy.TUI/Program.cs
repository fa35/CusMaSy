using System;
using CusMaSy.TUI.Infrastructure;
using CusMaSy.Shared.Infrastructure;
using CusMaSy.Shared.Models.Interfaces;

namespace CusMaSy.TUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // fake: 
            args = new[] { "FachkonzeptA" };

            if (args == null || args.Length < 1)
            {
                NoFachkonzept();
                return;
            }

            IFachkonzept fachkonzept;

            switch (args[0])
            {
                case "FachkonzeptA":
                    fachkonzept = new FachkonzeptA();
                    break;
                case "FachkonzeptB":
                    fachkonzept = new FachkonzeptB();
                    break;
                default:
                    NoFachkonzept();
                    return;
            }

            while (true)
            {
                var interpreter = new InputInterpreter(fachkonzept);

                var title = Helper.GetTitle("CusMaSy-TUI");
                Console.WriteLine("***\t" + title + "\t***" + Environment.NewLine);

                Menu.ShowMenu();
                interpreter.Read(Console.ReadLine());
            }
        }

        private static void NoFachkonzept()
        {
            Console.WriteLine("==> Das Fachkonzept konnte nicht ausgewählt werden!!!");
            Console.WriteLine("Anwendung beenden mit Enter");
            Console.ReadKey();
        }
    }
}
