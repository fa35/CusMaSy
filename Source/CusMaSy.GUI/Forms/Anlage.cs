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
            string message = "Anbieter konnte nicht angelegt werden.";
            try
            {
                // todo: Carlo, validate the values of the input field
                // if some values are null or wrong, the methode can't save the provider
                var arr = new string[] {txbFirma.Text, txbBranche.Text, txbHomepage.Text, txbTelefonnr.Text, txbStrasse.Text,
                    txbHausnr.Text, txbMailadresse.Text, txbSteuernr.Text};

                foreach (string text in arr)
                {
                    if (string.IsNullOrEmpty(text))
                    {
                        message = "Es müssen alle Felder ausgefüllt werden. Anbieter konnte nicht angelegt werden.";
                        throw new Exception();
                    }
                }

                if (!rdbKaufmann.Checked && !rdbPrivatperson.Checked)
                {
                    message = "Sie müssen Kaufmann oder Privatperson auswählen.";
                    throw new Exception();
                }

                if (!Validator.CheckHomepage(txbHomepage.Text))
                {
                    message = "Sie müssen Ihre Homepage richtig eingeben. z.B. www.example.de";
                    throw new Exception();
                }

                if (!Validator.CheckMailadresse(txbMailadresse.Text))
                {
                    message = "Sie müssen Ihre Mailadresse richtig eingeben. z.B. example@example.com";
                    throw new Exception();
                }

                if (!Validator.CheckPLZ(nudPlz.Value.ToString()))
                {
                    message = "Sie müssen Ihre Postleitzahl richtig eingeben. z.B. 14774";
                    throw new Exception();
                }

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

                bool isKaufmann = rdbKaufmann.Checked ? true : false;
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
                MessageBox.Show(message);
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
            _states = _fachkonzept.GetAllStates();

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
