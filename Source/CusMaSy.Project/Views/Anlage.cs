using System;
using System.Windows.Forms;
using CusMaSy.Project.Models.Interfaces;
using CusMaSy.Project.Infrastructure;
using CusMaSy.Project.Models;

namespace CusMaSy.Project.Views
{
    public partial class Anlage : Form
    {
        IFachkonzept _fachkonzept;

        public Anlage(IFachkonzept fachkonzept)
        {
            InitializeComponent();
            _fachkonzept = fachkonzept;
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            var anbieter = new Anbieter
            {
                Firma = txbFirma.Text,
                Branche = txbBranche.Text,
                Homepage = txbHomepage.Text,
                Plz = int.Parse(nudPlz.Value.ToString()),
                TelefonNr = txbTelefonnr.Text,
                Land = cmbLand.SelectedText,
                Ort = txbOrt.Text,
                Strasse = txbStrasse.Text,
                HausNr = txbHausnr.Text,
                MailAdresse = txbMailadresse.Text,
                SteuerNr = txbSteuernr.Text
            };

            _fachkonzept.ErstelleAnbieter(anbieter);
        }
    }
}
