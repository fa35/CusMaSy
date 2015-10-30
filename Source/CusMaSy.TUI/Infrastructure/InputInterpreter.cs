using CusMaSy.Shared.Models.Interfaces;
using System;

namespace CusMaSy.TUI.Infrastructure
{
    internal class InputInterpreter
    {
        IFachkonzept _fachkonzept;
        AnlageWorker _anlageWorker;
        internal InputInterpreter(IFachkonzept fachkonzept)
        {
            _fachkonzept = fachkonzept;
            _anlageWorker = new AnlageWorker(fachkonzept);
        }

        internal void Read(string input)
        {
            switch (input)
            {
                case "anaz":
                    break;
                case "ansu":
                    break;
                case "anbe":
                    break;
                case "anle":
                    _anlageWorker.AnbieterAnlegen();
                    break;
                case "anlo":
                    break;
                case "anzu":
                    break;
                case "hilfe":
                    break;
                case "anme":
                    break;
                case "ende":
                    break;
                default:
                    Console.WriteLine(Environment.NewLine + "===> Eingabe konnte nicht geleselen werden !!!" + Environment.NewLine);
                    break;
            }
        }
    }
}


