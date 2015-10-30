using System;
using System.Windows.Forms;
using CusMaSy.Shared.Models.Interfaces;
using System.Collections.Generic;
using CusMaSy.Shared.Infrastructure;
using CusMaSy.Shared.Data;

namespace CusMaSy.GUI.Forms
{
    public partial class Anlage : Form
    {
        IFachkonzept _fachkonzept;
        List<string> _states;

        public Anlage(IFachkonzept fachkonzept)
        {
            InitializeComponent();
            _fachkonzept = fachkonzept;
            this.Text = Helper.GetTitle("Anbieter-Anlage");

            LoadStates();
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
                    Telefonnummer = txbTelefonnr.Text,
                    Strasse = txbStrasse.Text,
                    Hausnummer = txbHausnr.Text,
                    Mailadresse = txbMailadresse.Text,
                    Steuernummer = txbSteuernr.Text
                };

                var ort = new Ort
                {
                    PLZ = int.Parse(nudPlz.Value.ToString()),
                    Ort1 = txbOrt.Text,
                    Land = cmbLand.SelectedItem.ToString()
                };


                bool isKaufmann = rdbKaufmann.Checked ? true : false; // was wenn keiner von beiden ausgewählt ist?

                // todo: try save the provider catch exceptions, show an info to the user

                // ort anlegen und ortnr anbieter zuweisen
                var ortNr = _fachkonzept.GetOrtNr(ort);
                anbieter.f_Ort_Nr = ortNr;

                // anbietertyp anlege bzw. nr erhalten
                var typNr = _fachkonzept.GetAnbieterTypNrByBool(isKaufmann);
                anbieter.f_AnbieterTyp_Nr = typNr;

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

        void LoadStates()
        {
            // variante für fachkonzeptB impl. dann jeweils casten
            _states = (_fachkonzept as FachkonzeptA).GetAllStates();

            cmbLand.Items.Clear();

            foreach (var land in _states)
                cmbLand.Items.Add(land);
        }

        private void btnAddState_Click(object sender, EventArgs e)
        {
            new AddState(_fachkonzept).ShowDialog();
            LoadStates();
        }
    }
}
