using System;
using System.Windows.Forms;
using CusMaSy.Project.Models.Interfaces;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // todo: Carlo, validate the values of the input field
                // if some values are null or wrong, the methode can't save the provider

                var anbieter = new Anbieter
                {
                    Firma = txbFirma.Text,
                    Branche = txbBranche.Text,
                    Homepage = txbHomepage.Text,
                    TelefonNr = txbTelefonnr.Text,
                    Strasse = txbStrasse.Text,
                    HausNr = txbHausnr.Text,
                    MailAdresse = txbMailadresse.Text,
                    SteuerNr = txbSteuernr.Text
                };

                var ort = new Ort
                {
                    Plz = int.Parse(nudPlz.Value.ToString()),
                    OrtName = txbOrt.Text,
                    Land = cmbLand.SelectedText
                };


                bool isKaufmann = rdbKaufmann.Checked ? true : false; // was wenn keiner von beiden ausgewählt ist?

                // todo: try save the provider catch exceptions, show an info to the user

                // ort anlegen und ortnr anbieter zuweisen
                var ortNr = _fachkonzept.GetOrtNr(ort);
                anbieter.OrtNr = ortNr;

                // anbietertyp anlege bzw. nr erhalten
                var typNr = _fachkonzept.GetAnbieterTypNrByBool(isKaufmann);
                anbieter.AnbieterTypNr = typNr;

                // anbieter speichern
                _fachkonzept.SaveAnbieter(anbieter);

                MessageBox.Show("Anbieter angelegt", "Anlage erfolgreich!");
                CloseForm();
            }
            catch (Exception ex)
            {
                // logger einbauen und loggen
                MessageBox.Show("Anbieter konnte nicht angelegt werden" + Environment.NewLine + ex.Message, "Anlage fehlerhaft");
            }
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        void CloseForm()
        {
            this.Close();
        }
    }
}
