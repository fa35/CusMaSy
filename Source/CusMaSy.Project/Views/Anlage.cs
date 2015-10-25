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
            // todo: Carlo, validate the values of the input field
            // if some values are null or wrong, the methode can't save the provider

            var firma = txbFirma.Text;
            var branche = txbBranche.Text;
            var homepage = txbHomepage.Text;
            var plz = int.Parse(nudPlz.Value.ToString());
            var telefonNr = txbTelefonnr.Text;
            var land = cmbLand.SelectedText;
            var ort = txbOrt.Text;
            var strasse = txbStrasse.Text;
            var hausNr = txbHausnr.Text;
            var mailAdresse = txbMailadresse.Text;
            var steuerNr = txbSteuernr.Text;

            // todo: try save the provider catch exceptions, show an info to the user
        }
    }
}
