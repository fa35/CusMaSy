using CusMaSy.Shared.Infrastructure;
using CusMaSy.Shared.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CusMaSy.GUI.Forms
{
    public partial class AddState : Form
    {
        IFachkonzept _fachkonzept;
        List<string> _existingStates;
        public AddState(IFachkonzept fachkonzept)
        {
            InitializeComponent();
            _fachkonzept = fachkonzept;
            this.Text = Helper.GetTitle("Land hinzufügen");

            try
            {
                _existingStates = _fachkonzept.GetAllStates();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Es sind Probleme mit der Datenbank-Verbindung aufgetaucht", "Fehlermeldung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddState_Click(object sender, EventArgs e)
        {
            var input = txbState.Text;

            if (Validator.CheckLand(input))
            {
                ShowFeedback("Nur Buchstaben!");
                return;
            }

            if (_existingStates.Contains(input))
            {
                ShowFeedback("Land bereits in Datenbank.");
                return;
            }

            try
            {
                _fachkonzept.SaveState(input);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beim Speichern ist ein Fehler aufgetreten", "Fehlermeldung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void ShowFeedback(string content)
        {
            lblWarning.Text = content;
            lblWarning.Visible = true;
        }

        private void txbState_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbState.Text))
                btnAddState.Enabled = false;
            else
                btnAddState.Enabled = true;
        }
    }
}
