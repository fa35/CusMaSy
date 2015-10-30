using CusMaSy.Shared.Infrastructure;

namespace CusMaSy.Project
{
    static class Program
    {
        static void Main()
        {
            new System.Threading.Thread(() =>
            {
                System.Windows.Forms.Application.Run(new CusMaSy.GUI.Forms.Hauptansicht(new FachkonzeptA()));
                // TUI.Program.Main(new[] { "FachkonzeptA" });
            }).Start();

            System.Windows.Forms.Application.Exit();
        }

    }
}
