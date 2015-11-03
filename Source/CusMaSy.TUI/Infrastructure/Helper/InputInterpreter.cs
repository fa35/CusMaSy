using CusMaSy.Shared.Models;
using CusMaSy.Shared.Models.Interfaces;
using CusMaSy.TUI.Infrastructure.Worker;
using System;
using System.Threading;

namespace CusMaSy.TUI.Infrastructure.Helper
{
    internal class InputInterpreter
    {
        IFachkonzept _fachkonzept;
        AddWorker _addWorker;
        DeleteWorker _deleteWorker;
        GeneralWorker _generalWorker;
        internal InputInterpreter(IFachkonzept fachkonzept)
        {
            _fachkonzept = fachkonzept;
            _addWorker = new AddWorker(fachkonzept);
            _deleteWorker = new DeleteWorker(fachkonzept);
            _generalWorker = new GeneralWorker(fachkonzept);
        }

        internal void Read(string input)
        {
            Console.Clear();

            switch (input)
            {
                case "anaz":
                    _generalWorker.ShowAllAnbieters();
                    break;
                case "ansu":
                    _generalWorker.SearchAnbieter();
                    break;
                case "anbe":
                    _generalWorker.EditAnbieter();
                    break;
                case "anle":
                    _addWorker.AnbieterAnlegen();
                    break;
                case "anlo":
                    _deleteWorker.DeleteAnbieter();
                    break;
                case "anzu":
                    _addWorker.ZuordnungAnlegen();
                    break;
                case "zulo":
                    _deleteWorker.DeleteZuordnung();
                    break;
                case "anme":
                    Menu.ShowMenu();
                    break;
                case "ende":
                    Thread.CurrentThread.Abort(); // narg
                    break;
                default:
                    ConsoleWriter.WriteUserFeedback("Eingabe konnte nicht geleselen werden !!!", StatusFeedback.Negativ);
                    break;
            }
        }
    }
}


